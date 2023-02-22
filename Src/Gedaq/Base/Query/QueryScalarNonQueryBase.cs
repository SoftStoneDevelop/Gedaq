using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base.Query
{
    internal abstract class QueryScalarNonQueryBase
    {
        protected abstract QueryCommonBase QueryCommon { get; }

        public void ScalarGenerate(QueryBase source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommon.ThrowExceptionIfOutCannotExist(source);
                ScalarMethodAsync(source, builder);
            }
        }

        public void NonQueryGenerate(QueryBase source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommon.ThrowExceptionIfOutCannotExist(source);
                NonQueryMethodAsync(source, builder);
            }
        }

        protected virtual void NonQueryMethod(QueryBase source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(source, QueryCommon.DefaultSourceType(), QueryCommon.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder);
            MethodBody(source, true, QueryCommon.DefaultSourceTypeParametr(), MethodType.Sync, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBase source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(source, QueryCommon.DefaultSourceType(), QueryCommon.DefaultSourceTypeParametr(), builder);
            AsyncEndMethodParametrs(builder);
            MethodBody(source, true, QueryCommon.DefaultSourceTypeParametr(), MethodType.Async, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethod(QueryBase source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(source, QueryCommon.DefaultSourceType(), QueryCommon.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder);
            MethodBody(source, true, "connection", MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBase source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(source, QueryCommon.DefaultSourceType(), QueryCommon.DefaultSourceTypeParametr(), builder);
            AsyncEndMethodParametrs(builder);
            MethodBody(source, true, QueryCommon.DefaultSourceTypeParametr(), MethodType.Async, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected void StartNonQueryMethod(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static System.Int32 NonQuery{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async Task<System.Int32> NonQuery{source.MethodName}Async(
");
            }
        }

        protected void StartScalarMethod(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static {QueryCommon.GetScalarTypeName(source)} Scalar{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async Task<{QueryCommon.GetScalarTypeName(source)}> Scalar{source.MethodName}Async(
");
            }
        }

        protected void QueryMethodParametrs(
            QueryBase source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder
            )
        {
            builder.Append($@"
            this {sourceTypeName} {sourceParametrName}
");
            if (source.HaveParametrs())
            {
                var index = -1;
                foreach (var parametr in source.BaseParametrs())
                {
                    ++index;
                    if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                    {
                        builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");
                    }

                    QueryCommon.WriteOutParametrs(parametr, builder);
                }
            }
        }

        protected void EndMethodParametrs(StringBuilder builder)
        {
            builder.Append($@",
            int? timeout = null
        )
        {{
");
        }

        protected void AsyncEndMethodParametrs(StringBuilder builder)
        {
            builder.Append($@",
            int? timeout = null,
            CancellationToken cancellationToken = default
        )
        {{
");
        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
        }

        protected void MethodBody(
            QueryBase source,
            bool needCheckOpen,
            string sourceParametrName,
            MethodType methodType,
            QueryType queryType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeOrCloseAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            if (needCheckOpen)
            {
                builder.Append($@"
            bool needClose = {sourceParametrName}.State == ConnectionState.Closed;
            if(needClose)
            {{
                {await}{sourceParametrName}.Open{async};
            }}
");
            }
            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync({sourceParametrName}, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Command({sourceParametrName}, false, timeout)"
                ;
            builder.Append($@"
            {QueryCommon.CommandType()} command = null;
            try
            {{
                command = {createCommand};
");
            if (source.HaveParametrs())
            {
                QueryCommon.WriteSetParametrs(source, builder);
            }

            if (queryType == QueryType.Scalar)
            {
                builder.Append($@"
                var result = ({QueryCommon.GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
");
            }
            else
            {
                builder.Append($@"
                var result = {await}command.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs())
            {
                QueryCommon.SetOutAndReturnParametrs(source, builder);
            }

            builder.Append($@"
                return result;
            }}
            finally
            {{
");

            if (needCheckOpen)
            {
                builder.Append($@"
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}
");
            }
            builder.Append($@"
                if(command != null)
                {{
                    command.Parameters.Clear();
                    {await}command.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }
    }
}
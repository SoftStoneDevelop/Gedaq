using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
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

        protected abstract ProviderInfo ProviderInfo { get; }

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
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(), 
                builder,
                true
                );
            EndMethodParametrs(builder, MethodType.Sync);
            MethodBody(
                source, 
                true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Sync, 
                QueryType.NonQuery, 
                builder
                );
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBase source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(), 
                builder,
                false
                );
            EndMethodParametrs(builder, MethodType.Async);
            MethodBody(
                source, 
                true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Async, 
                QueryType.NonQuery, 
                builder
                );
            EndMethod(builder);
        }

        protected virtual void ScalarMethod(QueryBase source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(),
                builder,
                true
                );
            EndMethodParametrs(builder, MethodType.Sync);
            MethodBody(source, true, "connection", MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBase source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(),
                builder,
                false
                );
            EndMethodParametrs(builder, MethodType.Async);
            MethodBody(
                source, 
                true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Async, 
                QueryType.Scalar, 
                builder
                );
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
            StringBuilder builder,
            bool useInAndOut
            )
        {
            builder.Append($@"
            this {sourceTypeName} {sourceParametrName}
");
            QueryCommon.AddParametrs(source, builder, useInAndOut);
            QueryCommon.AddFormatParametrs(source, builder);
        }

        protected void EndMethodParametrs(StringBuilder builder, MethodType methodType)
        {
            builder.Append($@",
            int? timeout = null
");
            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null
");
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default
");
            }

            builder.Append($@"
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

            builder.Append($@"
            {ProviderInfo.CommandType()} command = null;
            try
            {{
                command =
");
            QueryCommon.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;
                command.Set{source.MethodName}Parametrs(
");
            QueryCommon.WriteSetParametrs(source, builder, ProviderInfo);
            builder.Append($@"
                    );
");

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
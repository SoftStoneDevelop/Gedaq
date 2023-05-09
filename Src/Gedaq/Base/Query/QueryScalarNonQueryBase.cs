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
        protected abstract ProviderInfo ProviderInfo { get; }

        public void ScalarGenerate(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                ScalarMethodAsync(source, builder);
            }
        }

        public void NonQueryGenerate(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                NonQueryMethodAsync(source, builder);
            }
        }

        protected virtual void NonQueryMethod(QueryBaseCommand source, StringBuilder builder)
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

        protected virtual void NonQueryMethodAsync(QueryBaseCommand source, StringBuilder builder)
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

        protected virtual void ScalarMethod(QueryBaseCommand source, StringBuilder builder)
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

        protected virtual void ScalarMethodAsync(QueryBaseCommand source, StringBuilder builder)
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
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static {QueryCommonBase.GetScalarTypeName(source, ProviderInfo)} Scalar{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async Task<{QueryCommonBase.GetScalarTypeName(source, ProviderInfo)}> Scalar{source.MethodName}Async(
");
            }
        }

        protected void QueryMethodParametrs(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder,
            bool useInAndOut
            )
        {
            builder.Append($@"
            {source.ContainTypeName.ThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}
");
            QueryCommonBase.AddParametrs(source, builder, useInAndOut);
            QueryCommonBase.AddFormatParametrs(source, builder);
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
            QueryBaseCommand source,
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
            QueryCommonBase.CreateCommand(source, sourceParametrName, methodType, builder);

            if(source.ContainTypeName.IsStatic())
            {
                builder.Append($@"
                ;
                command.Set{source.MethodName}Parametrs(
");
            }
            else
            {
                builder.Append($@"
                ;
                Set{source.MethodName}Parametrs(
                    command
");
            }
            QueryCommonBase.WriteSetParametrs(source, builder, ProviderInfo);
            builder.Append($@"
                    );
");

            if (queryType == QueryType.Scalar)
            {
                builder.Append($@"
                var result = ({QueryCommonBase.GetScalarTypeName(source, ProviderInfo)}){await}command.ExecuteScalar{async};
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
                QueryCommonBase.SetOutAndReturnParametrs(source, builder, ProviderInfo);
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
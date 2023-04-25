using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class QueryBatchScalarNoQueryBase
    {
        protected abstract BatchCommonBase BatchCommon { get; }

        protected abstract ProviderInfo ProviderInfo { get; }

        public void GenerateScalar(QueryBatch source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ScalarMethodAsync(source, builder);
            }
        }

        public void GenerateNonQuery(QueryBatch source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                NonQueryMethodAsync(source, builder);
            }
        }

        protected virtual void ScalarMethod(QueryBatch source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Sync);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBatch source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Async);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethod(QueryBatch source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Sync);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBatch source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Async);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected void StartScalarMethod(
            QueryBatch source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        public static {BatchCommon.GetScalarTypeName(source)} Scalar{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"
        public static async Task<{BatchCommon.GetScalarTypeName(source)}> Scalar{source.MethodName}Async(
");
            }
        }

        protected void StartNonQueryMethod(
            QueryBatch source,
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

        protected void StartMethodParametrs(
            QueryBatch source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder
            )
        {
            builder.Append($@"
            this {sourceTypeName} {sourceParametrName}
");

            BatchCommon.WriteMethodParametrs(source, builder);
        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
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

        protected void ScalarMethodBody(
            QueryBatch source,
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
            {ProviderInfo.BatchType()} batch = null;
            try
            {{
                batch =
");
            BatchCommon.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;
");
            BatchCommon.WriteSetParametrs(source, builder, ProviderInfo);

            if (queryType == QueryType.Scalar)
            {
                builder.Append($@"
                //var result = {await}batch.ExecuteScalar<{BatchCommon.GetScalarTypeName(source)}>{async};
                var result = ({BatchCommon.GetScalarTypeName(source)}){await}batch.ExecuteScalar{async};
");
            }
            else
            {
                builder.Append($@"
                var result = ({BatchCommon.GetScalarTypeName(source)}){await}batch.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs)
            {
                BatchCommon.SetOutAndReturnParametrs(source, builder);
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
                if(batch != null)
                {{
                    batch.BatchCommands.Clear();
                    {await}batch.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }
    }
}

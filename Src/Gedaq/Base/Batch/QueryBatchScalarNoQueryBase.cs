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
        protected abstract ProviderInfo ProviderInfo { get; }

        public void GenerateScalar(QueryBatchCommand source, StringBuilder builder)
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

        public void GenerateNonQuery(QueryBatchCommand source, StringBuilder builder)
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

        protected virtual void ScalarMethod(QueryBatchCommand source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Sync);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Async);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethod(QueryBatchCommand source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Sync);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Async);
            ScalarMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected void StartScalarMethod(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            BatchCommonBase.GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} {typeName} {(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async Task<{typeName}> {(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}Async(
");
            }
        }

        protected void StartNonQueryMethod(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} System.Int32 {(((int)source.QueryType).IsPowerOfTwo() ? "" : "NonQuery")}{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async Task<System.Int32> {(((int)source.QueryType).IsPowerOfTwo() ? "" : "NonQuery")}{source.MethodName}Async(
");
            }
        }

        protected void StartMethodParametrs(
            QueryBatchCommand source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder
            )
        {
            builder.Append($@"
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}
");

            BatchCommonBase.WriteMethodParametrs(source, builder);
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
            QueryBatchCommand source,
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
            BatchCommonBase.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;
");
            BatchCommonBase.WriteSetParametrs(source, builder, ProviderInfo);

            BatchCommonBase.GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
            if (queryType == QueryType.Scalar)
            {
                if (isRowAffected || (!typeSymbol.IsNullableType() && !typeSymbol.IsReferenceType))
                {
                    builder.Append($@"
            {typeName} result = ({typeName}){await}batch.ExecuteScalar{async};
");
                }
                else
                {
                    builder.Append($@"
            var scalarResult = {await}batch.ExecuteScalar{async};
            {typeName} result;
            if(scalarResult == null || scalarResult == DBNull.Value)
            {{
                result = null;
            }}
            else
            {{
                result = ({typeName})scalarResult;
            }}
");
                }
            }
            else
            {
                builder.Append($@"
                var result = ({typeName}){await}batch.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs)
            {
                BatchCommonBase.SetOutAndReturnParametrs(source, builder, ProviderInfo);
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

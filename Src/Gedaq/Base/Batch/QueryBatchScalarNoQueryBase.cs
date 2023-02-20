using Gedaq.Base.Model;
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
        protected abstract BatchCommonGenerator BatchCommon { get; }

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
            StartMethodParametrs(source, "DbConnection", "connection", builder);
            EndMethodParametrs(builder);
            ScalarMethodBody(source, true, "connection", MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBatch source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, "DbConnection", "connection", builder);
            AsyncEndMethodParametrs(builder);
            ScalarMethodBody(source, true, "connection", MethodType.Async, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethod(QueryBatch source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, "DbConnection", "connection", builder);
            EndMethodParametrs(builder);
            ScalarMethodBody(source, true, "connection", MethodType.Sync, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBatch source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, "DbConnection", "connection", builder);
            AsyncEndMethodParametrs(builder);
            ScalarMethodBody(source, true, "connection", MethodType.Async, QueryType.NonQuery, builder);
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
            if (source.HaveParametrs)
            {
                foreach (var item in source.QueryBases())
                {
                    if (!item.query.HaveParametrs())
                    {
                        continue;
                    }

                    foreach (var parametr in item.query.BaseParametrs())
                    {
                        builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{item.number}
");
                        //todo OUT parametrs
                    }
                }
            }
        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
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
            var createBatch =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}BatchAsync({sourceParametrName}, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Batch({sourceParametrName}, false, timeout)"
                ;
            builder.Append($@"
            {BatchCommon.BatchType()} batch = null;
            try
            {{
                batch = {createBatch};
");
            if (source.HaveParametrs)
            {
                BatchCommon.WriteSetParametrs(source, builder);
            }

            if (queryType == QueryType.Scalar)
            {
                builder.Append($@"
                //return {await}batch.ExecuteScalar<{BatchCommon.GetScalarTypeName(source)}>{async};
                return ({BatchCommon.GetScalarTypeName(source)}){await}batch.ExecuteScalar{async};
");
            }
            else
            {
                builder.Append($@"
                return ({BatchCommon.GetScalarTypeName(source)}){await}batch.ExecuteNonQuery{async};
");
            }

            builder.Append($@"
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

using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Linq;
using System.Text;

namespace Gedaq.Base
{
    internal abstract class QueryBatchReadBase
    {
        protected abstract BatchCommonGenerator BatchCommon { get; }

        public void Generate(QueryBatch source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ReadMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source, builder);
            }
        }

        protected virtual void ReadMethod(QueryBatch source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, "DbConnection", "connection", builder);
            EndMethodParametrs(builder);
            ReadMethodBody(source, true, "connection", MethodType.Sync, builder);
            EndMethod(builder);
        }

        protected virtual void ReadAsyncMethod(QueryBatch source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, "DbConnection", "connection", builder);
            AsyncEndMethodParametrs(builder);
            ReadMethodBody(source, true, "connection", MethodType.Async, builder);
            EndMethod(builder);
        }

        protected void StartReadMethod(
            QueryBatch source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static IEnumerable<IEnumerable<{type}>> {source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async IAsyncEnumerable<IAsyncEnumerable<{type}>> {source.MethodName}Async(
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
                    }
                }
            }
        }

        protected void ReadMethodBody(
            QueryBatch source,
            bool needCheckOpen,
            string sourceParametrName,
            MethodType methodType,
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
            {BatchCommon.ReaderType()} reader = null;
            try
            {{
                batch = {createBatch};
");
            if (source.HaveParametrs)
            {
                BatchCommon.WriteSetParametrs(source, builder);
            }

            builder.Append($@"
                reader = {await}batch.ExecuteReader{async};
");
            int index = -1;
            foreach (var item in source.QueryBases())
            {
                ++index;
                builder.Append($@"
                yield return reader.BatchItem{index}{(methodType == MethodType.Async ? "Async(cancellationToken)" : "()")};
                {await}reader.NextResult{async};
");
            }

            builder.Append($@"
                {await}reader.Dispose{disposeOrCloseAsync};
                reader = null;
            }}
            finally
            {{
                if (reader != null)
                {{
                    if (!reader.IsClosed)
                    {{
                        try 
                        {{
                            batch.Cancel();
                        }}
                        catch {{ /* ignore */ }}
                    }}
                
                    {await}reader.Dispose{disposeOrCloseAsync};
                }}
");
            if (needCheckOpen)
            {
                builder.Append($@"
                if (needClose)
                {{
                    {await}{sourceParametrName}.Close{disposeOrCloseAsync};
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
            [EnumeratorCancellation] CancellationToken cancellationToken = default
        )
        {{
");
        }
    }
}
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Linq;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class QueryBatchReadBase
    {
        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(QueryBatchCommand source, StringBuilder builder)
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

        protected virtual void ReadMethod(QueryBatchCommand source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Sync, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Sync);
            ReadMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, builder);
            EndMethod(builder);
        }

        protected virtual void ReadAsyncMethod(QueryBatchCommand source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Async, builder);
            StartMethodParametrs(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), builder);
            EndMethodParametrs(builder, MethodType.Async);
            ReadMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, builder);
            EndMethod(builder);
        }

        protected void StartReadMethod(
            QueryBatchCommand source,
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
            QueryBatchCommand source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder
            )
        {
            builder.Append($@"
            this {sourceTypeName} {sourceParametrName}
");
            BatchCommonBase.WriteMethodParametrs(source, builder);
        }

        protected void ReadMethodBody(
            QueryBatchCommand source,
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

            builder.Append($@"
            {ProviderInfo.BatchType()} batch = null;
            {ProviderInfo.ReaderType()} reader = null;
            try
            {{
                batch = 
");
            BatchCommonBase.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;
");

            BatchCommonBase.WriteSetParametrs(source, builder, ProviderInfo);

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

        protected void EndMethodParametrs(StringBuilder builder, MethodType methodType)
        {
            builder.Append($@",
            int? timeout = null
");
            if(ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null
");
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            [EnumeratorCancellation] CancellationToken cancellationToken = default
");
            }

            builder.Append($@"
        )
        {{
");
        }
    }
}
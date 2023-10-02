using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Linq;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class QueryBatchReadBase
    {
        private readonly BatchCommandBase _commandGenerator;

        public QueryBatchReadBase(BatchCommandBase commandGenerator)
        {
            _commandGenerator = commandGenerator;
        }

        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ReadMethod(source, builder, interfaceGenerator);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source, builder, interfaceGenerator);
            }
        }

        protected virtual void ReadMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ReadMethodInner(
                source,
                MethodType.Sync,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        protected virtual void ReadAsyncMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ReadMethodInner(
                source,
                MethodType.Async,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        public string ReadMethodName(
            QueryBatchCommand source,
            MethodType methodType
            )
        {
            if(methodType == MethodType.Sync)
            {
                return $"{source.MethodName}";
            }
            else
            {
                return $"{source.MethodName}Async";
            }
        }

        protected void ReadMethodInner(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool needCheckOpen,
            InterfaceGenerator interfaceGenerator
            )
        {
            ReadMethodDefinition(
                source,
                methodType,
                builder,
                sourceTypeName,
                sourceParametrName
                );
            if (source.AsPartInterface)
            {
                ReadMethodDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    sourceTypeName,
                    sourceParametrName,
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            ReadMethodBody(
                source,
                needCheckOpen: needCheckOpen,
                sourceParametrName,
                methodType,
                builder
                );
        }

        private void ReadMethodDefinition(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool forInterface = false
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().QueryBase.MapTypeName.GetFullTypeName(true) : "object";
            var returnType = methodType == MethodType.Sync ? $"IEnumerable<IEnumerable<{type}>>" : $"IAsyncEnumerable<IAsyncEnumerable<{type}>>";
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async "
                ;

            builder.Append($@"        
        {accessModifier} {staticModifier} {asyncKeyword}{returnType} {ReadMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            _commandGenerator.AddMethodParametrs(source, builder);

            builder.Append($@",
            int? timeout = null");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null");
            }

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation = forInterface ? string.Empty : "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default");

            }

            builder.Append($@"
            )");
        }

        private void ReadMethodBody(
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
            builder.Append($@"
        {{");

            if (needCheckOpen)
            {
                builder.Append($@"
            bool needClose = {sourceParametrName}.State == ConnectionState.Closed;
            if(needClose)
            {{
                {await}{sourceParametrName}.Open{async};
            }}");

            }

            builder.Append($@"
            {ProviderInfo.BatchType()} batch = null;
            {ProviderInfo.ReaderType()} reader = null;
            try
            {{
                batch = ");

            _commandGenerator.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;");

            _commandGenerator.WriteSetParametrs(source, builder, ProviderInfo);

            builder.Append($@"
                reader = {await}batch.ExecuteReader{async};");

            foreach (var item in source.QueryBases())
            {
                builder.Append($@"
                yield return {_commandGenerator.BatchItemMethodName(item, methodType)}{(methodType == MethodType.Async ? "(reader, cancellationToken)" : "(reader)")};
                {await}reader.NextResult{async};");

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
                }}");

            if (needCheckOpen)
            {
                builder.Append($@"
                if (needClose)
                {{
                    {await}{sourceParametrName}.Close{disposeOrCloseAsync};
                }}");

            }
            builder.Append($@"
                if(batch != null)
                {{
                    batch.BatchCommands.Clear();
                    {await}batch.Dispose{disposeOrCloseAsync};
                }}
            }}
        }}
");
        }
    }
}
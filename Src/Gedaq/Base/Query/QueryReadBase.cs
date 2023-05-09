using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsBatch;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Text;

namespace Gedaq.Base.Query
{
    internal abstract class QueryReadBase
    {
        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(QueryBaseCommand source, StringBuilder builder)
        {
            QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ReadMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source, builder);
            }
        }

        protected virtual void ReadMethod(QueryBaseCommand source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(
                source,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr()
                );
            EndMethodParametrs(builder, MethodType.Sync);
            ReadMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, builder);
            EndMethod(builder);
        }

        protected virtual void ReadAsyncMethod(QueryBaseCommand source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(
                source,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr()
                );
            EndMethodParametrs(builder, MethodType.Async);
            ReadMethodBody(source, true, ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, builder);
            EndMethod(builder);
        }

        protected void StartReadMethod(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> {source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> {source.MethodName}Async(
");
            }
        }

        protected void QueryMethodParametrs(
            QueryBaseCommand source,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName
            )
        {
            builder.Append($@"
            {sourceTypeName} {sourceParametrName}
");

            QueryCommonBase.AddParametrs(source, builder, false);
            QueryCommonBase.AddFormatParametrs(source, builder);
        }

        protected static void EndMethod(StringBuilder builder)
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
            [EnumeratorCancellation] CancellationToken cancellationToken = default
");
            }

            builder.Append($@"
        )
        {{
");
        }

        protected void ReadMethodBody(
            QueryBaseCommand source,
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
            {ProviderInfo.CommandType()} command = null;
            {ProviderInfo.ReaderType()} reader = null;
            try
            {{
                command =
");
            QueryCommonBase.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;
                Set{source.MethodName}Parametrs(
                    command
");
            QueryCommonBase.WriteSetParametrs(source, builder, ProviderInfo);
            builder.Append($@"
                    );
");

            builder.Append($@"
                reader = {await}command.ExecuteReader{async};
");

            builder.Append($@"
                while ({await}reader.Read{async})
                {{
");
            MappingHelper.YieldItem(source, builder, ProviderInfo);
            builder.Append($@"
                }}

                while ({await}reader.NextResult{async})
                {{
                }}

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
                            command.Cancel();
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
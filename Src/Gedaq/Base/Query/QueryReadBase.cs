using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsBatch;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Text;

namespace Gedaq.Base.Query
{
    internal abstract class QueryReadBase
    {
        protected abstract QueryCommonBase QueryCommon { get; }

        public void Generate(QueryBase source, StringBuilder builder)
        {
            QueryCommon.ThrowExceptionIfOutCannotExist(source);
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ReadMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source, builder);
            }
        }

        protected virtual void ReadMethod(QueryBase source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(
                source,
                builder,
                QueryCommon.DefaultSourceType(),
                QueryCommon.DefaultSourceTypeParametr()
                );
            EndMethodParametrs(builder, MethodType.Sync);
            ReadMethodBody(source, true, QueryCommon.DefaultSourceTypeParametr(), MethodType.Sync, builder);
            EndMethod(builder);
        }

        protected virtual void ReadAsyncMethod(QueryBase source, StringBuilder builder)
        {
            StartReadMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(
                source,
                builder,
                QueryCommon.DefaultSourceType(),
                QueryCommon.DefaultSourceTypeParametr()
                );
            EndMethodParametrs(builder, MethodType.Async);
            ReadMethodBody(source, true, QueryCommon.DefaultSourceTypeParametr(), MethodType.Async, builder);
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

        protected static void QueryMethodParametrs(
            QueryBase source,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName
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
                }
            }
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
            if (QueryCommon.CanSetTransaction)
            {
                builder.Append($@",
            {QueryCommon.TransactionType()} transaction = null
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
            QueryBase source,
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
            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync({sourceParametrName}, false, cancellationToken)" :
                $"Create{source.MethodName}Command({sourceParametrName}, false)"
                ;
            builder.Append($@"
            {QueryCommon.CommandType()} command = null;
            {QueryCommon.ReaderType()} reader = null;
            try
            {{
                command = {createCommand};
");
            QueryCommon.WriteSetParametrs(source, builder);

            builder.Append($@"
                reader = {await}command.ExecuteReader{async};
");

            builder.Append($@"
                while ({await}reader.Read{async})
                {{
");
            QueryCommon.YieldItem(source, builder);
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

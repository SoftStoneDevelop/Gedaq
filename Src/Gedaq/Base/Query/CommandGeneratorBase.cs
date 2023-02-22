using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Gedaq.Base.Query
{
    internal abstract class CommandGeneratorBase
    {
        protected abstract QueryCommonBase QueryCommon { get; }

        public void Generate(QueryBase source, StringBuilder builder)
        {
            GenrateCommand(source, builder);
            ExecuteCommandMethods(source, builder);
            SetParametrsMethod(source, builder);
        }

        protected virtual void GenrateCommand(QueryBase source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateCommandMethod(source, QueryCommon.DefaultSourceType(), QueryCommon.DefaultSourceTypeParametr(), MethodType.Sync, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateCommandMethod(source, QueryCommon.DefaultSourceType(), QueryCommon.DefaultSourceTypeParametr(), MethodType.Async, builder);
            }
        }

        protected abstract void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder);

        protected void CreateCommandMethod(
            QueryBase source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  {(methodType == MethodType.Async ? $"async Task<{QueryCommon.CommandType()}>" : QueryCommon.CommandType())} Create{source.MethodName}Command{(methodType == MethodType.Async ? "Async" : "")}(
            this {sourceTypeName} {sourceParametrName},
            bool prepare = false
");
            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default
");
            }

            builder.Append($@",
            int? timeout = null
        )
        {{
            var command = {sourceParametrName}.CreateCommand();
            command.CommandText = @""
{source.Query}
"";
            if(timeout.HasValue)
            {{
                command.CommandTimeout = timeout.Value;
            }}
");

            if (source.HaveParametrs())
            {
                var index = -1;
                foreach (var parametr in source.BaseParametrs())
                {
                    ++index;
                    CreateParametr(parametr, index, builder);
                }
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@"
            if(prepare)
            {{
                try
                {{
                    await command.PrepareAsync(cancellationToken).ConfigureAwait(false);
                }}
                catch
                {{  
                    await command.DisposeAsync().ConfigureAwait(false);
                    throw;
                }}
            }}
");
            }
            else
            {
                builder.Append($@"
            if(prepare)
            {{
                try
                {{
                    command.Prepare();
                }}
                catch
                {{
                    command.Dispose();
                    throw;
                }}
            }}
");
            }

            builder.Append($@"
            return command;
        }}
");

        }

        protected void ExecuteCommandMethods(QueryBase source, StringBuilder builder)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                QueryCommon.ThrowExceptionIfOutCannotExist(source);
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    StartExecuteCommand(source, MethodType.Sync, builder);
                    ExecuteCommand(source, MethodType.Sync, builder);
                    EndMethod(builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    StartExecuteCommand(source, MethodType.Async, builder);
                    ExecuteCommand(source, MethodType.Async, builder);
                    EndMethod(builder);
                }
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    StartExecuteScalarCommand(source, MethodType.Sync, builder);
                    ExecuteScalarCommand(source, MethodType.Sync, builder);
                    EndMethod(builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    QueryCommon.ThrowExceptionIfOutCannotExist(source);
                    StartExecuteScalarCommand(source, MethodType.Async, builder);
                    ExecuteScalarCommand(source, MethodType.Async, builder);
                    EndMethod(builder);
                }
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery) && source.BaseParametrs().Any(a => a.HaveDirection))
            {
                //TODO
            }
        }

        protected void StartExecuteCommand(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        public static IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}Command(this {QueryCommon.CommandType()} command)
        {{
");
            }
            else
            {
                builder.Append($@"
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}CommandAsync(
            this {QueryCommon.CommandType()} command,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }


        }

        protected void ExecuteCommand(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
            {QueryCommon.ReaderType()} reader = null;
            try
            {{
");
            builder.Append($@"
                reader = {await}command.ExecuteReader{async};
                while ({await}reader.Read{async})
                {{
");
            QueryCommon.YieldItem(source, builder);
            builder.Append($@"
                }}

                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
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
                
                    {await}reader.Dispose{disposeAsync};
                }}
            }}
");
        }

        protected void StartExecuteScalarCommand(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static {QueryCommon.GetScalarTypeName(source)} Scalar{source.MethodName}Command(
            this {QueryCommon.CommandType()} command
");
                if (source.HaveParametrs())
                {
                    foreach (var parametr in source.BaseParametrs())
                    {
                        QueryCommon.WriteOutParametrs(parametr, builder);
                    }
                }
                builder.Append($@"
        )
        {{
");
            }
            else
            {
                builder.Append($@"        
        public static async Task<{QueryCommon.GetScalarTypeName(source)}> Scalar{source.MethodName}CommandAsync(
            this {QueryCommon.CommandType()} command,
            CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        protected void ExecuteScalarCommand(QueryBase source, MethodType methodType, StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            builder.Append($@"
            var result = ({QueryCommon.GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
");
            if (source.HaveParametrs())
            {
                QueryCommon.SetOutAndReturnParametrs(source, builder);
            }

            builder.Append($@"
            return result;
");
        }

        protected void SetParametrsMethod(
            QueryBase source,
            StringBuilder builder
            )
        {
            if (!source.HaveParametrs())
            {
                return;
            }

            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            this {QueryCommon.CommandType()} command
");
            foreach (var parametr in source.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    builder.Append($@",
            in {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}
");
                }
            }

            builder.Append($@"
        )
        {{
");
            int index = -1;
            foreach (var parametr in source.BaseParametrs())
            {
                ++index;
                if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                {
                    continue;
                }

                if (parametr.Type.IsNullableType())
                {
                    builder.Append($@"
            if({parametr.VariableName()}.HasValue)
            {{
                {QueryCommon.GetParametrValue(parametr, index, "command")} = {parametr.VariableName()}.Value;
            }}
            else
            {{
                {QueryCommon.GetParametrValue(parametr, index, "command")} = DBNull.Value;
            }}
");
                }
                else
                {
                    builder.Append($@"
                {QueryCommon.GetParametrValue(parametr, index, "command")} = {parametr.VariableName()};
");
                }
            }

            builder.Append($@"
        }}
");

        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
        }
    }
}
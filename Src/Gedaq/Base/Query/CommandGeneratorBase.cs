using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsBatch;
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
        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(QueryBaseCommand source, StringBuilder builder)
        {
            GenrateCommand(source, builder);
            ExecuteCommandMethods(source, builder);
            SetParametrsMethod(source, builder);
        }

        protected virtual void GenrateCommand(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateCommandMethod(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateCommandMethod(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, builder);
            }
        }

        protected abstract void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder);

        protected void CreateCommandMethod(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} {(methodType == MethodType.Async ? $"async Task<{ProviderInfo.CommandType()}>" : ProviderInfo.CommandType())} Create{source.MethodName}Command{(methodType == MethodType.Async ? "Async" : "")}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}
");
            QueryCommonBase.AddFormatParametrs(source, builder);
            builder.Append($@",
            bool prepare = false
");

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default
");
            }

            builder.Append($@"
        )
        {{
            var command = {sourceParametrName}.CreateCommand();
");
            SetQuery(source, builder);
            SetParametrs(source, builder);

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

        private void SetQuery(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            if (source.HaveFromatParametrs())
            {
                builder.Append($@"
            command.CommandText = string.Format(@""
{source.Query}
""
");
                int index = 0;
                foreach (var item in source.FormatParametrs)
                {
                    builder.Append($@",
{(item.HaveName ? item.Name : $"format{index++.ToString()}")}
");
                }
                builder.Append($@"
)
;
");
            }
            else
            {
                builder.Append($@"
            command.CommandText = @""
{source.Query}
"";
");
            }
        }

        private void SetParametrs(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveParametrs())
            {
                return;
            }

            var index = -1;
            foreach (var parametr in source.BaseParametrs())
            {
                ++index;
                CreateParametr(parametr, index, builder);
            }
        }

        protected void ExecuteCommandMethods(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
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
                    QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                    StartExecuteScalarCommand(source, MethodType.Async, builder);
                    ExecuteScalarCommand(source, MethodType.Async, builder);
                    EndMethod(builder);
                }
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery) && source.HaveParametrs() && source.BaseParametrs().Any(a => a.HaveDirection))
            {
                //TODO parametrs(out types) pass into method as class
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
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}Command({source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command)
        {{
");
            }
            else
            {
                builder.Append($@"
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}CommandAsync(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }


        }

        protected void ExecuteCommand(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
            {ProviderInfo.ReaderType()} reader = null;
            try
            {{
");
            builder.Append($@"
                reader = {await}command.ExecuteReader{async};
                while ({await}reader.Read{async})
                {{
");
            MappingHelper.YieldItem(source, builder, ProviderInfo);
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
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            QueryCommonBase.GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} {typeName} {(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}Command(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command
");
                QueryCommonBase.AddParametrs(source, builder, true);
                builder.Append($@"
        )
        {{
");
            }
            else
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async Task<{typeName}> {(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}CommandAsync(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command
");
                QueryCommonBase.AddParametrs(source, builder, false);
                builder.Append($@",
            CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        protected void ExecuteScalarCommand(QueryBaseCommand source, MethodType methodType, StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            QueryCommonBase.GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
            if (isRowAffected || (!typeSymbol.IsNullableType() && !typeSymbol.IsReferenceType))
            {
                builder.Append($@"
            {typeName} result = ({typeName}){await}command.ExecuteScalar{async};
");
            }
            else
            {
                builder.Append($@"
            var scalarResult = {await}command.ExecuteScalar{async};
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

            if (source.HaveParametrs())
            {
                QueryCommonBase.SetOutAndReturnParametrs(source, builder, ProviderInfo);
            }

            builder.Append($@"
            return result;
");
        }

        protected void SetParametrsMethod(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} void Set{source.MethodName}Parametrs(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command
");
            QueryCommonBase.AddParametrs(source, builder, false);

            builder.Append($@",
            int? timeout = null

            ");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null
");
            }

            builder.Append($@"
        )
        {{

            if(timeout.HasValue)
            {{
                command.CommandTimeout = timeout.Value;
            }}
");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@"
            if(transaction != null)
            {{
                command.Transaction = transaction;
            }}
");
            }

            if(source.HaveParametrs())
            {
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
                {ProviderInfo.GetParametrValue(parametr, index, "command")} = {parametr.VariableName()}.Value;
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, index, "command")} = {ProviderInfo.GetNullValue(parametr)};
            }}
");
                    }
                    else
                    {
                        if(parametr.Type.IsReferenceType)
                        {
                            builder.Append($@"
            if({parametr.VariableName()} == null)
            {{
                {ProviderInfo.GetParametrValue(parametr, index, "command")} = {ProviderInfo.GetNullValue(parametr)};
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, index, "command")} = {parametr.VariableName()};
            }}
");
                        }
                        else
                        {
                            builder.Append($@"
                {ProviderInfo.GetParametrValue(parametr, index, "command")} = {parametr.VariableName()};
");
                        }
                    }
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
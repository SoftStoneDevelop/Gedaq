using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
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

        public string CreateCommandMethodName(
            QueryBaseCommand source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                return $"Create{source.MethodName}Command";
            }
            else
            {
                return $"Create{source.MethodName}CommandAsync";
            }
        }

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
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} {(methodType == MethodType.Async ? $"async {source.MethodInfo.AsyncResultType.ToResultType()}<{ProviderInfo.CommandType()}>" : ProviderInfo.CommandType())} {CreateCommandMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}
");
            AddFormatParametrs(source, builder);
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
                foreach (var item in source.FormatParametrs)
                {
                    builder.Append($@",
{item.Name}
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

        public string ExecuteCommandMethodName(
            QueryBaseCommand source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                return $"Execute{source.MethodName}Command";
            }
            else
            {
                return $"Execute{source.MethodName}CommandAsync";
            }
        }

        protected void StartExecuteCommand(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> {ExecuteCommandMethodName(source, methodType)}({source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command)
        {{
");
            }
            else
            {
                builder.Append($@"
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> {ExecuteCommandMethodName(source, methodType)}(
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

        public string ExecuteScalarCommandMethodName(
            QueryBaseCommand source,
            MethodType methodType
            )
        {
            if(methodType == MethodType.Sync)
            {
                return $"{(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}Command";
            }
            else
            {
                return $"{(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}CommandAsync";
            }
        }

        protected void StartExecuteScalarCommand(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} {typeName} {ExecuteScalarCommandMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command
");
                AddParametrs(source, builder, true);
                builder.Append($@"
        )
        {{
");
            }
            else
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async {source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}> {ExecuteScalarCommandMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command
");
                AddParametrs(source, builder, false);
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
            GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
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
                SetOutAndReturnParametrs(source, builder, ProviderInfo);
            }

            builder.Append($@"
            return result;
");
        }

        public string SetParametrsMethodName(QueryBaseCommand source)
        {
            return $"Set{source.MethodName}Parametrs";
        }

        protected void SetParametrsMethod(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} void {SetParametrsMethodName(source)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command
");
            AddParametrs(source, builder, false);

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

        public void CreateCommand(
            QueryBaseCommand source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                await {CreateCommandMethodName(source, methodType)}({sourceParametrName}
");
            }
            else
            {
                builder.Append($@"
                {CreateCommandMethodName(source, methodType)}({sourceParametrName}
");
            }

            SetFormatParametrs(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                , false, cancellationToken)
");
            }
            else
            {
                builder.Append($@"
                , false)
");
            }
        }

        private void SetFormatParametrs(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveFromatParametrs())
            {
                return;
            }

            foreach (var format in source.FormatParametrs)
            {
                builder.Append($@",
                {format.Name}
");
            }
        }

        public void AddFormatParametrs(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveFromatParametrs())
            {
                return;
            }

            foreach (var format in source.FormatParametrs)
            {
                builder.Append($@",
        System.String {format.Name}
");
            }
        }

        public void AddParametrs(
            QueryBaseCommand source,
            StringBuilder builder,
            bool writeOutParametrs
            )
        {
            if (!source.HaveParametrs())
            {
                return;
            }

            foreach (var parametr in source.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
                        ");
                }

                if (writeOutParametrs)
                {
                    CommandParametrsHelper.WriteOutParametrs(parametr, builder);
                }
            }
        }

        public void WriteSetParametrs(QueryBaseCommand source, StringBuilder builder, ProviderInfo providerInfo)
        {
            var isStatic = source.ContainTypeName.GCIsStatic();
            var afterFirst = false;
            if (source.HaveParametrs())
            {
                foreach (var parametr in source.BaseParametrs())
                {
                    if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                    {
                        continue;
                    }

                    if (!isStatic || afterFirst)
                    {
                        builder.Append($@",");
                    }

                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");
                    afterFirst |= true;
                }
            }

            builder.Append($@"{(!isStatic || afterFirst ? "," : "")}
                    timeout
");
            if (providerInfo.CanSetTransaction)
            {
                builder.Append($@",
                    transaction
");
            }
        }

        public void SetOutAndReturnParametrs(QueryBaseCommand source, StringBuilder builder, ProviderInfo providerInfo)
        {
            var index = -1;
            foreach (var parametr in source.BaseParametrs())
            {
                ++index;
                if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                {
                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = ({parametr.Type.GetFullTypeName(true)}){providerInfo.GetParametrValue(parametr, index, "command")};
");
                }
            }
        }

        public void GetScalarType(QueryBaseCommand source, ProviderInfo providerInfo, out ITypeSymbol type, out bool isRowsAffected, out string typeName)
        {
            if (source.Aliases.IsRowsAffected)
            {
                if (source.QueryType != Enums.QueryType.NonQuery)
                {
                    throw new Exception("Use NonQuery for update/delete/inser command");
                }

                isRowsAffected = true;
                type = null;
                typeName = "System.Int32";
                return;
            }

            isRowsAffected = false;
            if (providerInfo.IsKnownProviderType(source.MapTypeName) || providerInfo.IsSpecialHandlerType(source.MapTypeName))
            {
                type = source.MapTypeName;
                typeName = type.GetFullTypeName(replaceNullable: true);
                return;
            }

            var firstField = source.Aliases.AllFieldsOrderByPosition().First();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var typeProp);
            type = typeProp;
            typeName = type.GetFullTypeName(replaceNullable: true);
            return;
        }
    }
}
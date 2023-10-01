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

        protected abstract void CreateParametr(BaseParametr baseParametr, StringBuilder builder);

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

        public void CreateCommandMethodDefinition(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;
            var returnType = methodType == MethodType.Async ? $"{source.MethodInfo.AsyncResultType.ToResultType()}<{ProviderInfo.CommandType()}>" : ProviderInfo.CommandType();

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword} {returnType} {CreateCommandMethodName(source, methodType)}(
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
");
        }

        protected void CreateCommandMethod(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            CreateCommandMethodDefinition(
                source, 
                sourceTypeName, 
                sourceParametrName, 
                methodType, 
                builder
                );

            builder.Append($@"
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

            foreach (var parametr in source.BaseParametrs())
            {
                CreateParametr(parametr, builder);
            }
        }

        protected void ExecuteCommandMethods(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteCommandDefinition(source, MethodType.Sync, builder);
                    ExecuteCommandBody(source, MethodType.Sync, builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    ExecuteCommandDefinition(source, MethodType.Async, builder);
                    ExecuteCommandBody(source, MethodType.Async, builder);
                }
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteScalarCommandDefinition(source, MethodType.Sync, builder);
                    ExecuteScalarCommandBody(source, MethodType.Sync, builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                    ExecuteScalarCommandDefinition(source, MethodType.Async, builder);
                    ExecuteScalarCommandBody(source, MethodType.Async, builder);
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

        public void ExecuteCommandDefinition(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var methodName = ExecuteCommandMethodName(source, methodType);
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;

            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var returnType = methodType == MethodType.Async ? $"IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}>" : $"IEnumerable<{source.MapTypeName.GetFullTypeName(true)}>";
            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword} {returnType} {methodName}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command");

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation = forInterface ? string.Empty : "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default
");
            }

            builder.Append($@"
            )");
        }

        protected void ExecuteCommandBody(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
        {{
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

        public void ExecuteScalarCommandDefinition(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var returnType = methodType == MethodType.Sync ? typeName : $"{source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}>";

            builder.Append($@"        
        {accessModifier} {staticModifier} {asyncKeyword} {returnType} {ExecuteScalarCommandMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command");
            AddParametrs(source, builder, methodType == MethodType.Sync);

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@"
            )
");
        }

        protected void ExecuteScalarCommandBody(QueryBaseCommand source, MethodType methodType, StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
            builder.Append($@"
        {{
");

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
        }}
");
        }

        public string SetParametrsMethodName(QueryBaseCommand source)
        {
            return $"Set{source.MethodName}Parametrs";
        }

        public void SetParametrsMethodDefinition(
            QueryBaseCommand source,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;

            builder.Append($@"
        {accessModifier} {staticModifier} void {SetParametrsMethodName(source)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command");

            AddParametrs(source, builder, false);

            builder.Append($@",
            int? timeout = null");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null");
            }

            builder.Append($@"
            )");
        }

        protected void SetParametrsMethod(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            SetParametrsMethodDefinition(source, builder);
            builder.Append($@"
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
                foreach (var parametr in source.BaseParametrs())
                {
                    if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                    {
                        continue;
                    }

                    if (parametr.Type.IsNullableType())
                    {
                        builder.Append($@"
            if({parametr.VariableName()}.HasValue)
            {{
                {ProviderInfo.GetParametrValue(parametr, "command")} = {parametr.VariableName()}.Value;
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, "command")} = {ProviderInfo.GetNullValue(parametr)};
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
                {ProviderInfo.GetParametrValue(parametr, "command")} = {ProviderInfo.GetNullValue(parametr)};
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, "command")} = {parametr.VariableName()};
            }}
");
                        }
                        else
                        {
                            builder.Append($@"
                {ProviderInfo.GetParametrValue(parametr, "command")} = {parametr.VariableName()};
");
                        }
                    }
                }
            }

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
        System.String {format.Name}");

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
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}");

                }

                if (writeOutParametrs)
                {
                    CommandParametrsHelper.AddOutParametrs(parametr, builder);
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
            foreach (var parametr in source.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                {
                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = ({parametr.Type.GetFullTypeName(true)}){providerInfo.GetParametrValue(parametr, "command")};
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
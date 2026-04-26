using Gedaq.Base.Model;
using Gedaq.Constants;
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

        public void Generate(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            GenrateCommand(source, builder, interfaceGenerator);
            ExecuteCommandMethods(source, builder, interfaceGenerator);
            SetParametrsMethod(source, builder, interfaceGenerator);
        }

        protected virtual void GenrateCommand(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateCommandMethod(
                    source, 
                    ProviderInfo.DefaultSourceType(), 
                    ProviderInfo.DefaultSourceTypeParametr(), 
                    MethodType.Sync, 
                    builder,
                    interfaceGenerator);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateCommandMethod(
                    source, 
                    ProviderInfo.DefaultSourceType(), 
                    ProviderInfo.DefaultSourceTypeParametr(), 
                    MethodType.Async, 
                    builder,
                    interfaceGenerator);
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

        private void CreateCommandMethodDefinition(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false)
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async "
                ;
            var returnType = methodType == MethodType.Async ? $"{source.MethodInfo.AsyncResultType.ToResultType()}<{ProviderInfo.CommandType()}>" : ProviderInfo.CommandType();

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{returnType} {CreateCommandMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            AddDynamicQuery(source, builder);
            AddFormatParametrs(source, builder);
            AddDynamicParametrs(source, builder);
            builder.Append($@",
            bool prepare = false");

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@"
        )");

        }

        protected void CreateCommandMethod(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            CreateCommandMethodDefinition(
                source, 
                sourceTypeName, 
                sourceParametrName, 
                methodType, 
                builder);

            if(source.AsPartInterface)
            {
                CreateCommandMethodDefinition(
                    source,
                    sourceTypeName,
                    sourceParametrName,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true);
                interfaceGenerator.AddMethodDefinition();
            }

            builder.Append($@"
        {{
            var command = {sourceParametrName}.CreateCommand();");

            SetQuery(source, builder);
            SetParametrsWhenCreateCommand(source, builder);

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
            }}");

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
            }}");

            }

            builder.Append($@"
            return command;
        }}
");

        }

        private void SetQuery(
            QueryBaseCommand source,
            StringBuilder builder)
        {
            if (source.HaveFromatParametrs())
            {
                builder.Append($@"
            command.CommandText = string.Format(@""
{source.Query}
""
");
                foreach (var stringFormat in source.FormatParametrs)
                {
                    builder.Append($@",
{stringFormat.Name}");
                }
                builder.Append($@"
)
;");
            }
            else if (source.IsDynamicQuery())
            {
                builder.Append($@"
            command.CommandText = {MethodParametersConstants.DynamicQueryParametr};");
            }
            else
            {
                builder.Append($@"
            command.CommandText = @""
{source.Query}
""
;");
            }
        }

        private void SetParametrsWhenCreateCommand(
            QueryBaseCommand source,
            StringBuilder builder)
        {
            if (source.HaveParametrs())
            {
                foreach (var parametr in source.BaseParametrs())
                {
                    CreateParametr(parametr, builder);
                }
            }

            if (source.HaveDynamicParametrs())
            {
                builder.Append($@"
            command.Parameters.AddRange({source.BaseDynamicParametrs().VariableName()});");
            }
        }

        protected void ExecuteCommandMethods(
            QueryBaseCommand source, 
            StringBuilder builder, 
            InterfaceGenerator interfaceGenerator)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteCommandDefinition(source, MethodType.Sync, builder);
                    if(source.AsPartInterface)
                    {
                        ExecuteCommandDefinition(
                            source, 
                            MethodType.Sync, 
                            interfaceGenerator.DefinitionBuilder(), 
                            forInterface: true);
                        interfaceGenerator.AddMethodDefinition();
                    }
                    ExecuteCommandBody(source, MethodType.Sync, builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    ExecuteCommandDefinition(source, MethodType.Async, builder);
                    if (source.AsPartInterface)
                    {
                        ExecuteCommandDefinition(
                            source, 
                            MethodType.Async, 
                            interfaceGenerator.DefinitionBuilder(),
                            forInterface: true);
                        interfaceGenerator.AddMethodDefinition();
                    }
                    ExecuteCommandBody(source, MethodType.Async, builder);
                }
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteScalarCommandDefinition(source, MethodType.Sync, builder);
                    if (source.AsPartInterface)
                    {
                        ExecuteScalarCommandDefinition(
                            source, 
                            MethodType.Sync, 
                            interfaceGenerator.DefinitionBuilder(), 
                            forInterface: true
                            );
                        interfaceGenerator.AddMethodDefinition();
                    }
                    ExecuteScalarCommandBody(source, MethodType.Sync, builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                    ExecuteScalarCommandDefinition(source, MethodType.Async, builder);
                    if (source.AsPartInterface)
                    {
                        ExecuteScalarCommandDefinition(
                            source, 
                            MethodType.Async, 
                            interfaceGenerator.DefinitionBuilder(),
                            forInterface: true
                            );
                        interfaceGenerator.AddMethodDefinition();
                    }
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
            MethodType methodType)
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
            bool forInterface = false)
        {
            string ExecuteCommandReturnType()
            {
                if (source.IsCollectionDelegateMap)
                {
                    return methodType == MethodType.Async ?
                        "Task" :
                        "void";
                }

                var mapInfo = source.MapTypeInfos[0];
                switch (source.ReturnType)
                {
                    case ReturnType.Enumerable:
                    {
                        return methodType == MethodType.Async ?
                            $"IAsyncEnumerable<{mapInfo.ItemTypeName}>" : 
                            $"IEnumerable<{mapInfo.ItemTypeName}>";
                    }

                    case ReturnType.List:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<System.Collections.Generic.List<{mapInfo.ItemTypeName}>>" :
                            $"System.Collections.Generic.List<{mapInfo.ItemTypeName}>";
                    }

                    case ReturnType.Single:
                    case ReturnType.SingleOrDefault:
                    case ReturnType.First:
                    case ReturnType.FirstOrDefault:
                    default:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<{mapInfo.ItemTypeName}>" :
                            $"{mapInfo.ItemTypeName}";
                    }
                }
            }

            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var methodName = ExecuteCommandMethodName(source, methodType);
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{ExecuteCommandReturnType()} {methodName}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command");

            if (source.IsCollectionDelegateMap)
            {
                builder.Append($@",
            {source.MapDelegateParametrType()} {source.MapDelegateParametrName}");
            }

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation =
                    forInterface || source.ReturnType != ReturnType.Enumerable || source.IsCollectionDelegateMap ?
                    string.Empty
                    : "[EnumeratorCancellation] ";
                builder.Append($@",
            {enumeratorCancellation}CancellationToken cancellationToken = default");
            }

            builder.Append($@")");
        }

        protected void ExecuteCommandBody(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
        {{
            {ProviderInfo.ReaderType()} reader = null;
            try
            {{");

            ExecuteReader(source, methodType, builder);

            builder.Append($@"
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

        public void ExecuteReader(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
                reader = {await}command.ExecuteReader{async};");

            if (source.IsCollectionDelegateMap)
            {
                builder.Append($@"
                while ({await}reader.Read{async})
                {{");

                foreach (var mapInfo in source.MapTypeInfos)
                {
                    builder.Append($@"
                    {mapInfo.ItemTypeName} {mapInfo.MapItemName};
                    {{");
                    MappingHelper.MapItem(mapInfo.MapType, source, builder, ProviderInfo, mapInfo.MapItemName);
                    builder.Append($@"
                    }}");
                }

                builder.Append($@"
                    {source.MapDelegateParametrName}(");
                for (int i = 0; i < source.MapTypeInfos.Length; i++)
                {
                    var mapInfo = source.MapTypeInfos[i];
                    if (i != 0)
                    {
                        builder.Append(",");
                    }

                    builder.Append($@"{mapInfo.MapItemName}");
                }
                builder.Append(");");

                builder.Append($@"
                }}

                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;");
            }
            else
            {
                var mapInfo = source.MapTypeInfos[0];
                var mapType = mapInfo.MapType;
                switch (source.ReturnType)
                {
                    case ReturnType.Enumerable:
                    {
                            builder.Append($@"
                while ({await}reader.Read{async})
                {{
                    {mapInfo.ItemTypeName} {mapInfo.MapItemName};");

                            MappingHelper.MapItem(mapType, source, builder, ProviderInfo, mapInfo.MapItemName);

                            builder.Append($@"
                    yield return {mapInfo.MapItemName};
                }}

                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;");

                            break;
                    }

                    case ReturnType.List:
                    {
                            builder.Append($@"
                var resultList = new System.Collections.Generic.List<{mapInfo.ItemTypeName}>();
                while ({await}reader.Read{async})
                {{
                    {mapInfo.ItemTypeName} {mapInfo.MapItemName};");

                            MappingHelper.MapItem(mapType, source, builder, ProviderInfo, mapInfo.MapItemName);

                            builder.Append($@"
                    resultList.Add({mapInfo.MapItemName});
                }}

                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;

                return resultList;");

                            break;
                    }

                    case ReturnType.Single:
                    {
                            builder.Append($@"
                {mapInfo.ItemTypeName} mapInfo.MapItemName = default;
                var notContainAny = !{await}reader.Read{async};
                if(!notContainAny)
                {{");

                            MappingHelper.MapItem(mapType, source, builder, ProviderInfo, mapInfo.MapItemName);

                            builder.Append($@"
                }}

                var haveMoreThanOne = {await}reader.Read{async};
                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;

                if(notContainAny)
                {{
                    throw new InvalidOperationException(""The sequence does not contain any elements"");
                }}

                if(haveMoreThanOne)
                {{
                    throw new InvalidOperationException(""The sequence have more than one element"");
                }}

                return {mapInfo.MapItemName};");

                            break;
                    }

                    case ReturnType.SingleOrDefault:
                    {
                            builder.Append($@"
                {mapInfo.ItemTypeName} {mapInfo.MapItemName} = default;
                if({await}reader.Read{async})
                {{");

                            MappingHelper.MapItem(mapType, source, builder, ProviderInfo, mapInfo.MapItemName);

                            builder.Append($@"
                }}

                var haveMoreThanOne = {await}reader.Read{async};
                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;

                if(haveMoreThanOne)
                {{
                    throw new InvalidOperationException(""The sequence have more than one element"");
                }}

                return {mapInfo.MapItemName};");
                            break;
                    }

                    case ReturnType.First:
                    {
                            builder.Append($@"
                {mapInfo.ItemTypeName} {mapInfo.MapItemName} = default;
                var notContainAny = !{await}reader.Read{async};
                if(!notContainAny)
                {{");

                            MappingHelper.MapItem(mapType, source, builder, ProviderInfo, mapInfo.MapItemName);

                            builder.Append($@"
                }}

                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;

                if(notContainAny)
                {{
                    throw new InvalidOperationException(""The sequence does not contain any elements"");
                }}

                return {mapInfo.MapItemName};");

                            break;
                    }

                    case ReturnType.FirstOrDefault:
                    {
                            builder.Append($@"
                {mapInfo.ItemTypeName} {mapInfo.MapItemName} = default;
                if({await}reader.Read{async})
                {{");

                            MappingHelper.MapItem(mapType,source, builder, ProviderInfo, mapInfo.MapItemName);

                            builder.Append($@"
                }}

                while ({await}reader.NextResult{async})
                {{
                }}
                {await}reader.Dispose{disposeAsync};
                reader = null;

                return {mapInfo.MapItemName};");
                            break;
                    }
                }
            }
        }

        public string ExecuteScalarCommandMethodName(
            QueryBaseCommand source,
            MethodType methodType)
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
            bool forInterface = false)
        {
            GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var returnType = methodType == MethodType.Sync ? typeName : $"{source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}>";

            builder.Append($@"        
        {accessModifier} {staticModifier} {asyncKeyword}{returnType} {ExecuteScalarCommandMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.CommandType()} command");
            AddParametrs(source, builder, methodType == MethodType.Sync);
            AddDynamicParametrs(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@")
");
        }

        protected void ExecuteScalarCommandBody(QueryBaseCommand source, MethodType methodType, StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
            builder.Append($@"
        {{");

            if (isRowAffected || (!typeSymbol.IsNullableType() && !typeSymbol.IsReferenceType))
            {
                builder.Append($@"
            {typeName} result = ({typeName}){await}command.ExecuteScalar{async};");

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
            }}");

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
            bool forInterface = false)
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

            builder.Append($@")");
        }

        protected void SetParametrsMethod(
            QueryBaseCommand source,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            SetParametrsMethodDefinition(source, builder);
            if(source.AsPartInterface)
            {
                SetParametrsMethodDefinition(
                    source, 
                    interfaceGenerator.DefinitionBuilder(), 
                    forInterface: true);
                interfaceGenerator.AddMethodDefinition();
            }

            builder.Append($@"
        {{

            if(timeout.HasValue)
            {{
                command.CommandTimeout = timeout.Value;
            }}");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@"
            if(transaction != null)
            {{
                command.Transaction = transaction;
            }}");

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
            }}");

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
            }}");

                        }
                        else
                        {
                            builder.Append($@"
                {ProviderInfo.GetParametrValue(parametr, "command")} = {parametr.VariableName()};");

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
            StringBuilder builder)
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                await {CreateCommandMethodName(source, methodType)}({sourceParametrName}");

            }
            else
            {
                builder.Append($@"
                {CreateCommandMethodName(source, methodType)}({sourceParametrName}");

            }

            if (source.IsDynamicQuery())
            {
                builder.Append($@", {MethodParametersConstants.DynamicQueryParametr}");
            }

            if (source.HaveDynamicParametrs())
            {
                builder.Append($@", {source.BaseDynamicParametrs().VariableName()}");
            }

            SetFormatParametrs(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@", false, cancellationToken)");
            }
            else
            {
                builder.Append($@", false)");
            }
        }

        private void SetFormatParametrs(
            QueryBaseCommand source,
            StringBuilder builder)
        {
            if (!source.HaveFromatParametrs())
            {
                return;
            }

            foreach (var format in source.FormatParametrs)
            {
                builder.Append($@",
                {format.Name}");
            }
        }

        public void AddFormatParametrs(
            QueryBaseCommand source,
            StringBuilder builder)
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
            bool writeOutParametrs)
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

        public void AddDynamicParametrs(
            QueryBaseCommand source,
            StringBuilder builder)
        {
            if (!source.HaveDynamicParametrs())
            {
                return;
            }

            builder.Append($@",
            {ProviderInfo.GetParametrType()}[] {source.BaseDynamicParametrs().VariableName()}");
        }

        public void AddDynamicQuery(
            QueryBaseCommand source,
            StringBuilder builder)
        {
            if (!source.IsDynamicQuery())
            {
                return;
            }

            builder.Append($@", string {MethodParametersConstants.DynamicQueryParametr}");
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
                    {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}");
                    afterFirst |= true;
                }
            }

            builder.Append($@"{(!isStatic || afterFirst ? "," : "")}
                    timeout");

            if (providerInfo.CanSetTransaction)
            {
                builder.Append($@",
                    transaction");
            }
        }

        public void SetOutAndReturnParametrs(QueryBaseCommand source, StringBuilder builder, ProviderInfo providerInfo)
        {
            foreach (var parametr in source.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = ({parametr.Type.GetFullTypeName(true)}){providerInfo.GetParametrValue(parametr, "command")};");
                }
            }
        }

        public void GetScalarType(
            QueryBaseCommand source,
            ProviderInfo providerInfo,
            out ITypeSymbol type,
            out bool isRowsAffected,
            out string typeName)
        {
            if (source.IsRowsAffected)
            {
                if (source.QueryType != Enums.QueryType.NonQuery)
                {
                    throw new Exception("Use NonQuery for update/delete/insert command");
                }

                isRowsAffected = true;
                type = null;
                typeName = "System.Int32";
                return;
            }

            var mapType = source.MapTypeInfos[0].MapType;
            isRowsAffected = false;
            if (providerInfo.IsKnownProviderType(mapType) || providerInfo.IsSpecialHandlerType(mapType))
            {
                type = mapType;
                typeName = type.GetFullTypeName(replaceNullable: true);
                return;
            }

            var firstField = source.MapTypeInfos[0].Aliases.AllFieldsOrderByPosition().First();
            mapType.GetPropertyOrFieldName(firstField.Name, out _, out var typeProp);
            type = typeProp;
            typeName = type.GetFullTypeName(replaceNullable: true);
        }
    }
}
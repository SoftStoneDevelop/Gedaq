using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Linq;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class BatchCommandBase
    {
        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator,
            SourceProductionContext context)
        {
            CreateBatchItems(source, builder);
            CreateBatchMethods(source, builder, interfaceGenerator);
            ExecuteBatchMethods(source, builder, interfaceGenerator, context);
        }

        private void CreateBatchItems(
            QueryBatchCommand source, 
            StringBuilder builder)
        {
            if(!source.QueryType.HasFlag(QueryType.Read))
            {
                return;
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchItem(source, MethodType.Async, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchItem(source, MethodType.Sync, builder);
            }
        }

        protected virtual void CreateBatchMethods(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchMethodInner(
                    source, 
                    ProviderInfo.DefaultSourceType(), 
                    ProviderInfo.DefaultSourceTypeParametr(), 
                    MethodType.Sync, 
                    builder,
                    interfaceGenerator);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchMethodInner(
                    source,
                    ProviderInfo.DefaultSourceType(),
                    ProviderInfo.DefaultSourceTypeParametr(),
                    MethodType.Async,
                    builder,
                    interfaceGenerator);
            }

            SetParametrsMethodInner(source, builder, interfaceGenerator);
        }

        protected void ExecuteBatchMethods(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator,
            SourceProductionContext context)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                BatchCommonBase.CheckOutCannotExist(source, context);
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteBatchInner(
                        source, 
                        MethodType.Sync, 
                        builder, 
                        interfaceGenerator);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    ExecuteBatchInner(
                        source,
                        MethodType.Async,
                        builder,
                        interfaceGenerator);
                }
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteScalarBatchInner(
                        source, 
                        MethodType.Sync, 
                        builder, 
                        interfaceGenerator);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    BatchCommonBase.CheckOutCannotExist(source, context);
                    ExecuteScalarBatchInner(
                        source,
                        MethodType.Async,
                        builder,
                        interfaceGenerator);
                }
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery) && 
                source.HaveParametrs && 
                source.BatchPartBases().Any(a => a.QueryBase.HaveParametrs() && a.QueryBase.BaseParametrs().Any(an => an.HaveDirection)))
            {
                //TODO
            }
        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
        }

        private void CreateBatchItem(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder)
        {
            var async = methodType == MethodType.Sync ? "()" : "Async(cancellationToken).ConfigureAwait(false)";
            var await = methodType == MethodType.Sync ? "" : "await ";
            string ExecuteReturnType()
            {
                if (source.IsCollectionDelegateMap)
                {
                    return methodType == MethodType.Async ?
                        "Task" :
                        "void";
                }

                switch (source.ReturnType)
                {
                    case ReturnType.List:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<System.Collections.Generic.List<{ItemTypeName(source)}>>" :
                            $"System.Collections.Generic.List<{ItemTypeName(source)}>";
                    }

                    default:
                    case ReturnType.Enumerable:
                    {
                        return methodType == MethodType.Async ?
                            $"IAsyncEnumerable<{ItemTypeName(source)}>" :
                            $"IEnumerable<{ItemTypeName(source)}>";
                    }
                }
            }

            foreach (var batchPartBase in source.BatchPartBases())
            {
                var queryBase = batchPartBase.QueryBase;
                var asyncDeclar = methodType == MethodType.Async ? "async " : "";
                builder.Append($@"
        private static {asyncDeclar}{ExecuteReturnType()} {BatchItemMethodName(source, batchPartBase, methodType)}({ProviderInfo.ReaderType()} reader");

                if (source.IsCollectionDelegateMap)
                {
                    builder.Append($@",
            {queryBase.MapDelegateParametrType()} {queryBase.MapDelegateParametrName}");
                }

                if (methodType == MethodType.Async)
                {
                    var cancelAttribute =
                        source.ReturnType == ReturnType.Enumerable || source.IsCollectionDelegateMap ?
                        string.Empty :
                        "[EnumeratorCancellation] ";

                    builder.Append($@", {cancelAttribute}CancellationToken cancellationToken = default");
                }

                builder.Append($@")
        {{");
                if (source.IsCollectionDelegateMap)
                {
                    builder.Append($@"
            while({await}reader.Read{async})
            {{");
                    foreach (var mapInfo in queryBase.MapTypeInfos)
                    {
                        builder.Append($@"
                {mapInfo.ItemTypeName} {mapInfo.MapItemName};
                {{");
                        MappingHelper.MapItem(mapInfo.MapType, queryBase, builder, ProviderInfo, mapInfo.MapItemName, CastTypeExpr(source));
                        builder.Append($@"
                }}");
                    }

                    builder.Append($@"
                    {queryBase.MapDelegateParametrName}(");
                    for (int i = 0; i < queryBase.MapTypeInfos.Length; i++)
                    {
                        var mapInfo = queryBase.MapTypeInfos[i];
                        if (i != 0)
                        {
                            builder.Append(",");
                        }

                        builder.Append($@"{mapInfo.MapItemName}");
                    }
                    builder.Append(");");

                    builder.Append($@"
            }}");
                }
                else
                {
                    var mapInfo = queryBase.MapTypeInfos[0];
                    var mapType = mapInfo.MapType;
                    if (source.ReturnType == ReturnType.Enumerable)
                    {
                        builder.Append($@"
            while({await}reader.Read{async})
            {{
                {ItemTypeName(source)} {mapInfo.MapItemName};");
                        MappingHelper.MapItem(mapType, queryBase, builder, ProviderInfo, mapInfo.MapItemName, CastTypeExpr(source));
                        builder.Append($@"
                yield return {mapInfo.MapItemName};
            }}");
                    }
                    else
                    {
                        builder.Append($@"
            var batchItems = new System.Collections.Generic.List<{ItemTypeName(source)}>({source.BatchPartBases().Count()});
            while({await}reader.Read{async})
            {{
                {ItemTypeName(source)} {mapInfo.MapItemName};");
                        MappingHelper.MapItem(mapType, queryBase, builder, ProviderInfo, mapInfo.MapItemName, CastTypeExpr(source));
                        builder.Append($@"
                batchItems.Add({mapInfo.MapItemName});
            }}
            
            return batchItems;");
                    }
                }

                builder.Append($@"
        }}
");
            }
        }

        public string BatchItemMethodName(
            QueryBatchCommand source,
            BatchPartBase batchPart,
            MethodType methodType)
        {
            if (methodType == MethodType.Sync)
            {
                return $"{source.MethodName}BatchItem{batchPart.Index}";
            }
            else
            {
                return $"{source.MethodName}BatchItem{batchPart.Index}Async";
            }
        }

        protected abstract void CreateParametr(BaseParametr parametr, StringBuilder builder);

        public string CreateBatchMethodName(
            QueryBatchCommand source,
            MethodType methodType)
        {
            if (methodType == MethodType.Sync)
            {
                return $"Create{source.MethodName}Batch";
            }
            else
            {
                return $"Create{source.MethodName}BatchAsync";
            }
        }

        public void CreateBatchMethodInner(
            QueryBatchCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            CreateBatchMethodDefinition(
                    source,
                    sourceTypeName,
                    sourceParametrName,
                    methodType,
                    builder);

            if (source.AsPartInterface)
            {
                CreateBatchMethodDefinition(
                    source,
                    sourceTypeName,
                    sourceParametrName,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true);
                interfaceGenerator.AddMethodDefinition();
            }

            CreateBatchMethodBody(
                source,
                sourceParametrName,
                methodType, 
                builder);
        }

        public void CreateBatchMethodDefinition(
            QueryBatchCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false)
        {
            var returnType = methodType == MethodType.Async ?
                $"{source.MethodInfo.AsyncResultType.ToResultType()}<{ProviderInfo.BatchType()}>" :
                ProviderInfo.BatchType();

            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            builder.Append($@"
        {accessModifier} {source.MethodStaticModifier} {asyncKeyword}{returnType} {CreateBatchMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            AddFormatParametrs(source, builder);
            AddDynamicParametrs(source, builder);
            AddDynamicQueries(source, builder);

            builder.Append($@",
            bool prepare = false");

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");

            }

            builder.Append($@")");
        }

        protected void CreateBatchMethodBody(
            QueryBatchCommand source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder)
        {
            builder.Append($@"
        {{
            var batch = {sourceParametrName}.CreateBatch();");

            foreach (var item in source.BatchPartBases())
            {
                CreateBatchCommand(item, builder);
                builder.Append($@"
            batch.BatchCommands.Add(command);");
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@"
            if(prepare)
            {{
                try
                {{
                    await batch.PrepareAsync(cancellationToken).ConfigureAwait(false);
                }}
                catch
                {{  
                    await batch.DisposeAsync().ConfigureAwait(false);
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
                    batch.Prepare();
                }}
                catch
                {{
                    batch.Dispose();
                    throw;
                }}
            }}");
            }

            builder.Append($@"
            return batch;
        }}
");

        }

        private void CreateBatchCommand(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (item.Index == 0)
            {
                builder.Append($@"
            var command = batch.CreateBatchCommand();");
            }
            else
            {
                builder.Append($@"
            command = batch.CreateBatchCommand();");
            }

            SetQuery(item, builder);
            CreateCommandParametrs(item, builder);
        }

        private void CreateCommandParametrs(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (!item.QueryBase.HaveParametrs() && !item.QueryBase.HaveDynamicParametrs())
            {
                return;
            }

            builder.Append($@"
            {{");

            if (item.QueryBase.HaveDynamicParametrs())
            {
                builder.Append($@"
            command.Parameters.AddRange({item.DynamicParametersParametrName()});");
            }

            foreach (var parametr in item.QueryBase.BaseParametrs())
            {
                CreateParametr(parametr, builder);
            }

            builder.Append($@"
            }}");
        }

        private void SetQuery(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (item.QueryBase.HaveFromatParametrs())
            {
                builder.Append($@"
            command.CommandText = string.Format(@""
{item.QueryBase.Query}
""");
                foreach (var format in item.QueryBase.FormatParametrs)
                {
                    builder.Append($@",
{item.FormatName(format)}");
                }

                builder.Append($@");");
            }
            else if (item.QueryBase.IsDynamicQuery())
            {
                builder.Append($@"
            command.CommandText = {item.DynamicQueryParametrName()};");
            }
            else
            {
                builder.Append($@"
            command.CommandText = @""
{item.QueryBase.Query}
"";");
            }
        }

        private void AddFormatParametrs(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            if (!source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.BatchPartBases())
            {
                if(!item.QueryBase.HaveFromatParametrs())
                {
                    continue;
                }

                foreach (var format in item.QueryBase.FormatParametrs)
                {
                    builder.Append($@",
        System.String {item.FormatName(format)}");
                }
            }
        }

        private void AddDynamicParametrs(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            foreach (var item in source.BatchPartBases())
            {
                if (item.QueryBase.HaveDynamicParametrs())
                {
                    builder.Append($@",
        {ProviderInfo.GetParametrType()}[] {item.DynamicParametersParametrName()}");
                }
            }
        }

        private void AddDynamicQueries(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            foreach (var item in source.BatchPartBases())
            {
                if (item.QueryBase.IsDynamicQuery())
                {
                    builder.Append($@",
            System.String {item.DynamicQueryParametrName()}");
                }
            }
        }

        public string SetParametrsMethodName(
            QueryBatchCommand source)
        {
            return $"Set{source.MethodName}Parametrs";
        }

        protected void SetParametrsMethodInner(
            QueryBatchCommand source,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            SetParametrsMethodDefinition(source, builder);
            if (source.AsPartInterface)
            {
                SetParametrsMethodDefinition(
                    source,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true);
                interfaceGenerator.AddMethodDefinition();
            }
            SetParametrsMethodBody(source, builder);
        }

        protected void SetParametrsMethodDefinition(
            QueryBatchCommand source,
            StringBuilder builder,
            bool forInterface = false)
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;

            builder.Append($@"
        {accessModifier} {staticModifier} void {SetParametrsMethodName(source)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.BatchType()} batch");

            if (source.HaveParametrs)
            {
                foreach (var batchCommand in source.BatchPartBases())
                {
                    if (!batchCommand.QueryBase.HaveParametrs())
                    {
                        continue;
                    }

                    foreach (var parametr in batchCommand.QueryBase.BaseParametrs())
                    {
                        if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                        {
                            builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {batchCommand.VariableName(parametr)}");
                        }
                    }
                }
            }

            builder.Append($@",
            int? timeout = null");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null");

            }

            builder.Append($@")");
        }

        protected void SetParametrsMethodBody(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            builder.Append($@"
        {{
            if(timeout.HasValue)
            {{
                batch.Timeout = timeout.Value;
            }}");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@"
            if(transaction != null)
            {{
                batch.Transaction = transaction;
            }}");

            }

            SetBatchCommandParametrsValue(source, builder);

            builder.Append($@"
        }}
");

        }

        private void SetBatchCommandParametrsValue(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            if(!source.HaveParametrs)
            {
                return;
            }

            var commandBatchDefine = false;
            foreach (var batchCommand in source.BatchPartBases())
            {
                if (!batchCommand.QueryBase.HaveParametrs())
                {
                    continue;
                }

                var commandSet = false;

                foreach (var parametr in batchCommand.QueryBase.BaseParametrs())
                {
                    if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                    {
                        continue;
                    }

                    if (commandBatchDefine && !commandSet)
                    {
                        builder.Append($@"
            batchCommand = batch.BatchCommands[{batchCommand.Index}];");

                        commandSet = true;
                    }

                    if (!commandBatchDefine)
                    {
                        builder.Append($@"
            var batchCommand = batch.BatchCommands[{batchCommand.Index}];");

                        commandBatchDefine = true;
                        commandSet = true;
                    }

                    if (parametr.Type.IsNullableType())
                    {
                        builder.Append($@"
            if({batchCommand.VariableName(parametr)}.HasValue)
            {{
                {ProviderInfo.GetParametrValue(parametr, "batchCommand")} = {batchCommand.VariableName(parametr)}.Value;
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, "batchCommand")} = {ProviderInfo.GetNullValue(parametr)};
            }}");

                    }
                    else
                    {
                        if (parametr.Type.IsReferenceType)
                        {
                            builder.Append($@"
            if({batchCommand.VariableName(parametr)} == null)
            {{
                {ProviderInfo.GetParametrValue(parametr, "batchCommand")} = {ProviderInfo.GetNullValue(parametr)};
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, "batchCommand")} = {batchCommand.VariableName(parametr)};
            }}");

                        }
                        else
                        {
                            builder.Append($@"
            {ProviderInfo.GetParametrValue(parametr, "batchCommand")} = {batchCommand.VariableName(parametr)};");

                        }
                    }
                }
            }
        }

        public string ExecuteBatchMethodName(
            QueryBatchCommand source,
            MethodType methodType)
        {
            if (methodType == MethodType.Sync)
            {
                return $"Execute{source.MethodName}Batch";
            }
            else
            {
                return $"Execute{source.MethodName}BatchAsync";
            }
        }

        public void ExecuteBatchInner(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator)
        {
            ExecuteBatchDefinition(source, methodType, builder);
            if (source.AsPartInterface)
            {
                ExecuteBatchDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true);
                interfaceGenerator.AddMethodDefinition();
            }
            ExecuteBatchBody(source, methodType, builder);
        }

        public void ExecuteBatchDefinition(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false)
        {
            string ExecuteReturnType()
            {
                if (source.IsCollectionDelegateMap)
                {
                    return methodType == MethodType.Async ?
                        "Task" :
                        "void";
                }

                switch (source.ReturnType)
                {
                    case ReturnType.Enumerable:
                    {
                        return methodType == MethodType.Async ?
                            $"IAsyncEnumerable<IAsyncEnumerable<{ItemTypeName(source)}>>" :
                            $"IEnumerable<IEnumerable<{ItemTypeName(source)}>>";
                    }

                    case ReturnType.List:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<System.Collections.Generic.List<System.Collections.Generic.List<{ItemTypeName(source)}>>>" :
                            $"System.Collections.Generic.List<System.Collections.Generic.List<{ItemTypeName(source)}>>";
                    }

                    case ReturnType.Single:
                    case ReturnType.SingleOrDefault:
                    case ReturnType.First:
                    case ReturnType.FirstOrDefault:
                    default:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<{ItemTypeName(source)}>" :
                            $"{ItemTypeName(source)}";
                    }
                }
            }

            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{ExecuteReturnType()} {ExecuteBatchMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.BatchType()} batch");

            if (source.IsCollectionDelegateMap)
            {
                foreach (var batchParBase in source.BatchPartBases())
                {
                    builder.Append($@",
            {batchParBase.QueryBase.MapDelegateParametrType()} {batchParBase.QueryBase.MapDelegateParametrName}");
                }
            }

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation =
                    forInterface || source.ReturnType != ReturnType.Enumerable || source.IsCollectionDelegateMap ?
                    string.Empty :
                    "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default");
            }

            builder.Append($@")");
        }

        public string ItemTypeName(QueryBatchCommand source)
        {
            return source.AllSameTypes ? source.BatchPartBases().First().QueryBase.MapTypeInfos[0].ItemTypeName : "object";
        }

        private string CastTypeExpr(QueryBatchCommand source)
        {
            return source.AllSameTypes ? string.Empty : $"({ItemTypeName(source)})";
        }

        protected void ExecuteBatchBody(
            QueryBatchCommand source,
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

            ExecuteReadBody(source, methodType, builder);

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
                            batch.Cancel();
                        }}
                        catch {{ /* ignore */ }}
                    }}
                
                    {await}reader.Dispose{disposeAsync};
                }}
            }}
        }}
");
        }

        public void ExecuteReadBody(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";
            string GetEnumerator(BatchPartBase item)
            {
                if(methodType == MethodType.Async)
                {
                    return $"{BatchItemMethodName(source, item, methodType)}(reader, cancellationToken).GetAsyncEnumerator(cancellationToken)";
                }
                else
                {
                    return $"{BatchItemMethodName(source, item, methodType)}(reader).GetEnumerator()";
                }
            }

            string EnumeratorMoveNext()
            {
                if (methodType == MethodType.Async)
                {
                    return $"await enumerator.MoveNextAsync(cancellationToken)";
                }
                else
                {
                    return $"enumerator.MoveNext()";
                }
            }

            builder.Append($@"
                reader = {await}batch.ExecuteReader{async};");

            if (source.IsCollectionDelegateMap)
            {
                foreach (var batchPart in source.BatchPartBases())
                {
                    builder.Append($@"
                {await}{BatchItemMethodName(source, batchPart, methodType)}(reader");

                    builder.Append($@", {batchPart.MapDelegateParametrNameInBatch()}");

                    if (methodType == MethodType.Async)
                    {
                        builder.Append($@", cancellationToken");
                    }

                    builder.Append($@");");
                }
            }
            else
            {
                switch (source.ReturnType)
                {
                    case ReturnType.Enumerable:
                    {
                        foreach (var item in source.BatchPartBases())
                        {
                            builder.Append($@"
                yield return {BatchItemMethodName(source, item, methodType)}{(methodType == MethodType.Async ? "(reader, cancellationToken)" : "(reader)")};
                {await}reader.NextResult{async};");
                        }

                        builder.Append($@"
                while ({await}reader.NextResult{async})
                {{
                }}

                {await}reader.Dispose{disposeAsync};
                reader = null;");

                        break;
                    }

                    case ReturnType.List:
                    {
                        var type = ItemTypeName(source);
                        builder.Append($@"
                var batchResult = new System.Collections.Generic.List<System.Collections.Generic.List<{type}>>({source.BatchPartBases().Count()});");

                        foreach (var item in source.BatchPartBases())
                        {
                            builder.Append($@"
                batchResult.Add({await}{BatchItemMethodName(source, item, methodType)}{(methodType == MethodType.Async ? "(reader, cancellationToken)" : "(reader)")});
                {await}reader.NextResult{async};");
                        }

                        builder.Append($@"
                while ({await}reader.NextResult{async})
                {{
                }}

                {await}reader.Dispose{disposeAsync};
                reader = null;

                return batchResult;");

                        break;
                    }

                    case ReturnType.Single:
                    {
                        builder.Append($@"
                var notContainAny = true;
                var haveMoreThanOne = false;
                {ItemTypeName(source)} item = default;");
                        foreach (var item in source.BatchPartBases())
                        {
                            builder.Append($@"
                if(!haveMoreThanOne)
                {{
                    var enumerator = {GetEnumerator(item)};
                    var haveItem = {EnumeratorMoveNext()};
                    if(notContainAny)
                    {{
                        if(haveItem)
                        {{
                            item = enumerator.Current;
                            notContainAny = false;
                        }}
                    }}
                    else if(haveItem)
                    {{
                        haveMoreThanOne = true;
                    }}
                    
                    {await}reader.NextResult{async};
                }}");

                        }

                        builder.Append($@"
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

                return item;");

                        break;
                    }

                    case ReturnType.SingleOrDefault:
                    {
                        builder.Append($@"
                var notContainAny = true;
                var haveMoreThanOne = false;
                {ItemTypeName(source)} item = default;");
                        foreach (var item in source.BatchPartBases())
                        {
                            builder.Append($@"
                if(!haveMoreThanOne)
                {{
                    var enumerator = {GetEnumerator(item)};
                    var haveItem = {EnumeratorMoveNext()};
                    if(notContainAny)
                    {{
                        if(haveItem)
                        {{
                            item = enumerator.Current;
                            notContainAny = false;
                        }}
                    }}
                    else if(haveItem)
                    {{
                        haveMoreThanOne = true;
                    }}
                    
                    {await}reader.NextResult{async};
                }}");

                        }

                        builder.Append($@"
                while ({await}reader.NextResult{async})
                {{
                }}

                {await}reader.Dispose{disposeAsync};
                reader = null;

                if(haveMoreThanOne)
                {{
                    throw new InvalidOperationException(""The sequence have more than one element"");
                }}

                return item;");

                        break;
                    }

                    case ReturnType.First:
                    {
                        builder.Append($@"
                var notContainAny = true;
                {ItemTypeName(source)} item = default;");
                        foreach (var item in source.BatchPartBases())
                        {
                            builder.Append($@"
                if(notContainAny)
                {{
                    var enumerator = {GetEnumerator(item)};
                    var haveItem = {EnumeratorMoveNext()};
                    if(haveItem)
                    {{
                        item = enumerator.Current;
                        notContainAny = false;
                    }}
                    
                    {await}reader.NextResult{async};
                }}");

                        }

                        builder.Append($@"
                while ({await}reader.NextResult{async})
                {{
                }}

                {await}reader.Dispose{disposeAsync};
                reader = null;
                
                if(notContainAny)
                {{
                    throw new InvalidOperationException(""The sequence does not contain any elements"");
                }}

                return item;");

                        break;
                    }

                    case ReturnType.FirstOrDefault:
                    {
                        builder.Append($@"
                var notContainAny = true;
                {ItemTypeName(source)} item = default;");
                        foreach (var item in source.BatchPartBases())
                        {
                            builder.Append($@"
                if(notContainAny)
                {{
                    var enumerator = {GetEnumerator(item)};
                    var haveItem = {EnumeratorMoveNext()};
                    if(haveItem)
                    {{
                        item = enumerator.Current;
                        notContainAny = false;
                    }}
                    
                    {await}reader.NextResult{async};
                }}");

                        }

                        builder.Append($@"
                while ({await}reader.NextResult{async})
                {{
                }}

                {await}reader.Dispose{disposeAsync};
                reader = null;

                return item;");

                        break;
                    }
                }
            }  
        }

        public string ExecuteScalarBatchMethodName(
            QueryBatchCommand source,
            MethodType methodType)
        {
            if (methodType == MethodType.Sync)
            {
                return $"Execute{(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}Batch";
            }
            else
            {
                return $"Execute{(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}BatchAsync";
            }
        }

        private void ExecuteScalarBatchInner(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ExecuteScalarBatchDefinition(source, methodType, builder);
            if (source.AsPartInterface)
            {
                ExecuteScalarBatchDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            ExecuteScalarBatchBody(source, methodType, builder);
        }

        private void ExecuteScalarBatchDefinition(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false)
        {
            GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            var returnType = methodType == MethodType.Async ? $"{source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}>" : typeName;
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{returnType} {ExecuteScalarBatchMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.BatchType()} batch");
            AddMethodParametrs(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@")");
        }

        protected void ExecuteScalarBatchBody(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";
            GetScalarType(source, ProviderInfo, out var type, out var isRowAffected, out var typeName);
            builder.Append($@"
        {{");
            if (isRowAffected || (!type.IsNullableType() && !type.IsReferenceType))
            {
                builder.Append($@"
            {typeName} result = ({typeName}){await}batch.ExecuteScalar{async};");

            }
            else
            {
                builder.Append($@"
            var scalarResult = {await}batch.ExecuteScalar{async};
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

            if(source.HaveParametrs)
            {
                foreach (var item in source.BatchPartBases())
                {
                    if (!item.QueryBase.HaveParametrs())
                    {
                        continue;
                    }

                    SetOutAndReturnParametrs(source, builder, ProviderInfo);
                }
            }

            builder.Append($@"
            return result;
        }}
");
        }

        public void SetOutAndReturnParametrs(
            QueryBatchCommand batch,
            StringBuilder builder,
            ProviderInfo providerInfo)
        {
            foreach (var item in batch.BatchPartBases())
            {
                if (!item.QueryBase.HaveParametrs())
                {
                    continue;
                }

                foreach (var parametr in item.QueryBase.BaseParametrs())
                {
                    if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                    {
                        builder.Append($@"
                    {item.VariableName(parametr, BaseParametr.VariablePostfix(parametr.Direction))} = ({parametr.Type.GetFullTypeName(true)}){providerInfo.GetParametrValue(parametr, $"batch.BatchCommands[{item.Index}]")};");
                    }
                }
            }
        }

        public void WriteSetParametrs(
            QueryBatchCommand batch,
            StringBuilder builder,
            ProviderInfo providerInfo)
        {
            var isStatic = batch.ContainTypeName.GCIsStatic();
            if (isStatic)
            {
                builder.Append($@"
                batch.{SetParametrsMethodName(batch)}(");
            }
            else
            {
                builder.Append($@"
                {SetParametrsMethodName(batch)}(
                    batch");
            }

            var haveSuccessIteration = false;
            if (batch.HaveParametrs)
            {
                foreach (var item in batch.BatchPartBases())
                {
                    if (!item.QueryBase.HaveParametrs())
                    {
                        continue;
                    }

                    if (!isStatic || haveSuccessIteration)
                    {
                        builder.Append($@",");
                    }

                    var afterFirst = false;
                    foreach (var parametr in item.QueryBase.BaseParametrs())
                    {
                        if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                        {
                            continue;
                        }

                        if (afterFirst)
                        {
                            builder.Append($@",");
                        }

                        builder.Append($@"
                    {item.VariableName(parametr)}");

                        afterFirst |= true;
                    }

                    haveSuccessIteration |= true;
                }
            }

            builder.Append($@"{(!isStatic || haveSuccessIteration ? "," : "")}
                    timeout");

            if (providerInfo.CanSetTransaction)
            {
                builder.Append($@",
                    transaction");
            }

            builder.Append($@");");
        }

        public void CreateCommand(
            QueryBatchCommand source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder)
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                await {CreateBatchMethodName(source, methodType)}({sourceParametrName}");
            }
            else
            {
                builder.Append($@"
                {CreateBatchMethodName(source, methodType)}({sourceParametrName}");
            }

            PassFormatParametrs(source, builder);
            PassDynamicParametrs(source, builder);
            PassDynamicQueries(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@", false, cancellationToken)");
            }
            else
            {
                builder.Append($@", false)");
            }
        }

        private void PassFormatParametrs(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            if (!source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.BatchPartBases())
            {
                if (!item.QueryBase.HaveFromatParametrs())
                {
                    continue;
                }

                foreach (var format in item.QueryBase.FormatParametrs)
                {
                    builder.Append($@",
                {item.FormatName(format)}");

                }
            }
        }

        private void PassDynamicParametrs(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            if (!source.HaveDynamicParametrs)
            {
                return;
            }

            foreach (var item in source.BatchPartBases())
            {
                if (!item.QueryBase.HaveDynamicParametrs())
                {
                    continue;
                }

                builder.Append($@",
                {item.DynamicParametersParametrName()}");
            }
        }

        private void PassDynamicQueries(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            foreach (var item in source.BatchPartBases())
            {
                if (!item.QueryBase.IsDynamicQuery())
                {
                    continue;
                }

                builder.Append($@",
                {item.DynamicQueryParametrName()}");
            }
        }

        public void AddMethodParametrs(
            QueryBatchCommand source,
            StringBuilder builder)
        {
            if (!source.HaveParametrs && !source.HaveFormatParametrs && !source.HaveDynamicParametrs)
            {
                return;
            }

            foreach (var item in source.BatchPartBases())
            {
                AddParametrs(item, builder);
                AddFormatParametrs(item, builder);
                AddDynamicParametrs(item, builder);
                AddDynamicQuery(item, builder);
            }
        }

        private void AddParametrs(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (!item.QueryBase.HaveParametrs())
            {
                return;
            }

            foreach (var parametr in item.QueryBase.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}Batch{item.Number}");
                }

                CommandParametrsHelper.AddOutParametrs(parametr, builder, $"Batch{item.Number}");
            }
        }

        private void AddFormatParametrs(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (!item.QueryBase.HaveFromatParametrs())
            {
                return;
            }

            foreach (var format in item.QueryBase.FormatParametrs)
            {
                builder.Append($@",
            System.String {item.FormatName(format)}");
            }
        }

        public void AddDynamicParametrs(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (!item.QueryBase.HaveDynamicParametrs())
            {
                return;
            }

            builder.Append($@",
            {ProviderInfo.GetParametrType()}[] {item.DynamicParametersParametrName()}");
        }

        public void AddDynamicQuery(
            BatchPartBase item,
            StringBuilder builder)
        {
            if (!item.QueryBase.IsDynamicQuery())
            {
                return;
            }

            builder.Append($@",
            System.String {item.DynamicQueryParametrName()}");
        }

        public void GetScalarType(
            QueryBatchCommand source,
            ProviderInfo providerInfo,
            out ITypeSymbol type,
            out bool isRowAffected,
            out string typeName)
        {
            var first = source.BatchPartBases().First().QueryBase;
            if (first.IsRowsAffected)
            {
                if (source.QueryType != Enums.QueryType.NonQuery)
                {
                    throw new Exception("Use NonQuery for update/delete/inser command");
                }

                isRowAffected = true;
                type = null;
                typeName = "System.Int32";
                return;
            }

            isRowAffected = false;
            if (providerInfo.IsKnownProviderType(first.MapTypeInfos[0].MapType) || providerInfo.IsSpecialHandlerType(first.MapTypeInfos[0].MapType))
            {
                type = first.MapTypeInfos[0].MapType;
                typeName = type.GetFullTypeName(replaceNullable: true);
                return;
            }

            var firstField = first.MapTypeInfos[0].Aliases.AllFieldsOrderByPosition().First();
            first.MapTypeInfos[0].MapType.GetPropertyOrFieldName(firstField.Name, out _, out var typeProp);
            type = typeProp;
            typeName = type.GetFullTypeName(replaceNullable: true);
        }
    }
};
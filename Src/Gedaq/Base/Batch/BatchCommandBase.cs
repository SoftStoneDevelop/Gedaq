﻿using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
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
            InterfaceGenerator interfaceGenerator
            )
        {
            CreateBatchItems(source, builder);
            CreateBatchMethods(source, builder, interfaceGenerator);
            ExecuteBatchMethods(source, builder, interfaceGenerator);
        }

        private void CreateBatchItems(
            QueryBatchCommand source, 
            StringBuilder builder
            )
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
            InterfaceGenerator interfaceGenerator
            )
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchMethodInner(
                    source, 
                    ProviderInfo.DefaultSourceType(), 
                    ProviderInfo.DefaultSourceTypeParametr(), 
                    MethodType.Sync, 
                    builder,
                    interfaceGenerator
                    );
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchMethodInner(
                    source,
                    ProviderInfo.DefaultSourceType(),
                    ProviderInfo.DefaultSourceTypeParametr(),
                    MethodType.Async,
                    builder,
                    interfaceGenerator
                    );
            }

            SetParametrsMethodInner(source, builder, interfaceGenerator);
        }

        protected void ExecuteBatchMethods(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                BatchCommonBase.ThrowExceptionIfOutCannotExist(source);
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ExecuteBatchInner(
                        source, 
                        MethodType.Sync, 
                        builder, 
                        interfaceGenerator
                        );
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    ExecuteBatchInner(
                        source,
                        MethodType.Async,
                        builder,
                        interfaceGenerator
                        );
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
                        interfaceGenerator
                        );
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    BatchCommonBase.ThrowExceptionIfOutCannotExist(source);
                    ExecuteScalarBatchInner(
                        source,
                        MethodType.Async,
                        builder,
                        interfaceGenerator
                        );
                }
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery) && 
                source.HaveParametrs && 
                source.QueryBases().Any(a => a.QueryBase.HaveParametrs() && a.QueryBase.BaseParametrs().Any(an => an.HaveDirection))
                )
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
            StringBuilder builder
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().QueryBase.MapTypeName.GetFullTypeName(true) : "object";
            var async = methodType == MethodType.Sync ? "()" : "Async(cancellationToken).ConfigureAwait(false)";
            var await = methodType == MethodType.Sync ? "" : "await ";

            foreach (var item in source.QueryBases())
            {
                if (methodType == MethodType.Sync)
                {
                    builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static IEnumerable<{type}> {BatchItemMethodName(source, item, methodType)}({ProviderInfo.ReaderType()} reader)
        {{");
                }
                else
                {
                    builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static async IAsyncEnumerable<{type}> {BatchItemMethodName(source,item, methodType)}(
            {ProviderInfo.ReaderType()} reader,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{");
                }

                builder.Append($@"
            while({await}reader.Read{async})
            {{
                {ItemTypeName(source)} item;");
                MappingHelper.MapItem(item.QueryBase, builder, ProviderInfo, "item", CastTypeExpr(source));
                builder.Append($@"
                yield return item;
            }}
        }}
");
            }
        }

        public string BatchItemMethodName(
            QueryBatchCommand source,
            BatchPartBase batchPart,
            MethodType methodType
            )
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

        protected virtual void CreateFakeCommand(string sourceParametrName, StringBuilder builder)
        {

        }

        protected virtual void DisposeFakeCommand(MethodType methodType, StringBuilder builder)
        {

        }

        public string CreateBatchMethodName(
            QueryBatchCommand source,
            MethodType methodType
            )
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
            InterfaceGenerator interfaceGenerator
            )
        {
            CreateBatchMethodDefinition(
                    source,
                    sourceTypeName,
                    sourceParametrName,
                    methodType,
                    builder
                    );
            if (source.AsPartInterface)
            {
                CreateBatchMethodDefinition(
                    source,
                    sourceTypeName,
                    sourceParametrName,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }

            CreateBatchMethodBody(
                source,
                sourceParametrName,
                methodType, 
                builder
                );
        }

        public void CreateBatchMethodDefinition(
            QueryBatchCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            var returnType = methodType == MethodType.Async ? $"{source.MethodInfo.AsyncResultType.ToResultType()}<{ProviderInfo.BatchType()}>" : ProviderInfo.BatchType();
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async "
                ;

            builder.Append($@"
        {accessModifier} {source.MethodStaticModifier} {asyncKeyword}{returnType} {CreateBatchMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            AddFormatParametrs(source, builder);
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

        protected void CreateBatchMethodBody(
            QueryBatchCommand source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            builder.Append($@"
        {{
            var batch = {sourceParametrName}.CreateBatch();");

            CreateFakeCommand(sourceParametrName, builder);
            foreach (var item in source.QueryBases())
            {
                CreateBatchCommand(item, builder);
                builder.Append($@"
            batch.BatchCommands.Add(command);");
            }

            DisposeFakeCommand(methodType, builder);
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
            StringBuilder builder
            )
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
            SetCommandParametrs(item, builder);
        }

        private void SetCommandParametrs(
            BatchPartBase item,
            StringBuilder builder
            )
        {
            if (!item.QueryBase.HaveParametrs())
            {
                return;
            }

            builder.Append($@"
            {{");

            foreach (var parametr in item.QueryBase.BaseParametrs())
            {
                CreateParametr(parametr, builder);
            }

            builder.Append($@"
            }}");
        }

        private void SetQuery(
            BatchPartBase item,
            StringBuilder builder
            )
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

                builder.Append($@"
)
;");
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
            StringBuilder builder
            )
        {
            if (!source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.QueryBases())
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

        public string SetParametrsMethodName(
            QueryBatchCommand source
            )
        {
            return $"Set{source.MethodName}Parametrs";
        }

        protected void SetParametrsMethodInner(
            QueryBatchCommand source,
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            SetParametrsMethodDefinition(source, builder);
            if (source.AsPartInterface)
            {
                SetParametrsMethodDefinition(
                    source,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            SetParametrsMethodBody(source, builder);
        }

        protected void SetParametrsMethodDefinition(
            QueryBatchCommand source,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;

            builder.Append($@"
        {accessModifier} {staticModifier} void {SetParametrsMethodName(source)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.BatchType()} batch");

            if (source.HaveParametrs)
            {
                foreach (var batchCommand in source.QueryBases())
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

            builder.Append($@"
            )");
        }

        protected void SetParametrsMethodBody(
            QueryBatchCommand source,
            StringBuilder builder
            )
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
            StringBuilder builder
            )
        {
            if(!source.HaveParametrs)
            {
                return;
            }

            var commandBatchDefine = false;
            foreach (var batchCommand in source.QueryBases())
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
            MethodType methodType
            )
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
            InterfaceGenerator interfaceGenerator
            )
        {
            ExecuteBatchDefinition(source, methodType, builder);
            if (source.AsPartInterface)
            {
                ExecuteBatchDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            ExecuteBatchBody(source, methodType, builder);
        }

        public void ExecuteBatchDefinition(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            string ExecuteReturnType()
            {
                var type = ItemTypeName(source);
                switch (source.ReturnType)
                {
                    case ReturnType.Enumerable:
                    {
                        return methodType == MethodType.Async ?
                            $"IAsyncEnumerable<IAsyncEnumerable<{type}>>" :
                            $"IEnumerable<IEnumerable<{type}>>"
                            ;
                    }
                    case ReturnType.Single:
                    case ReturnType.SingleOrDefault:
                    case ReturnType.First:
                    case ReturnType.FirstOrDefault:
                    default:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<{type}>" :
                            $"{type}"
                            ;
                    }
                }
            }

            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async "
                ;

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{ExecuteReturnType()} {ExecuteBatchMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.BatchType()} batch");

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation = forInterface ? string.Empty : "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default");
            }

            builder.Append($@"
            )");
        }

        public string ItemTypeName(QueryBatchCommand source)
        {
            return source.AllSameTypes ? source.QueryBases().First().QueryBase.MapTypeName.GetFullTypeName(true) : "object";
        }

        private string CastTypeExpr(QueryBatchCommand source)
        {
            return source.AllSameTypes ? string.Empty : $"({ItemTypeName(source)})";
        }

        protected void ExecuteBatchBody(
            QueryBatchCommand source,
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
            StringBuilder builder
            )
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

            switch (source.ReturnType) 
            {
                case ReturnType.Enumerable:
                {
                    foreach (var item in source.QueryBases())
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

                case ReturnType.Single:
                {
                    builder.Append($@"
                var notContainAny = true;
                var haveMoreThanOne = false;
                {ItemTypeName(source)} item = default;");
                    foreach (var item in source.QueryBases())
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
                    foreach (var item in source.QueryBases())
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
                    foreach (var item in source.QueryBases())
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
                    foreach (var item in source.QueryBases())
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

        public string ExecuteScalarBatchMethodName(
            QueryBatchCommand source,
            MethodType methodType
            )
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
            bool forInterface = false
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().QueryBase.MapTypeName.GetFullTypeName(true) : "object";
            GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            var returnType = methodType == MethodType.Async ? $"{source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}>" : typeName;
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async "
                ;

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{returnType} {ExecuteScalarBatchMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{ProviderInfo.BatchType()} batch");
            AddMethodParametrs(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@"
            )");
        }

        protected void ExecuteScalarBatchBody(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder
            )
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
                foreach (var item in source.QueryBases())
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
            ProviderInfo providerInfo
            )
        {
            foreach (var item in batch.QueryBases())
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

        public void WriteSetParametrs(QueryBatchCommand batch, StringBuilder builder, ProviderInfo providerInfo)
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
                foreach (var item in batch.QueryBases())
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

            builder.Append($@"
                    );");
        }

        public void CreateCommand(
            QueryBatchCommand source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
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

            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                , false, cancellationToken)");
            }
            else
            {
                builder.Append($@"
                , false)");
            }
        }

        private void PassFormatParametrs(
            QueryBatchCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.QueryBases())
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

        public void AddMethodParametrs(
            QueryBatchCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveParametrs && !source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.QueryBases())
            {
                AddParametrs(item, builder);
                AddFormatParametrs(item, builder);
            }
        }

        private void AddParametrs(
            BatchPartBase item,
            StringBuilder builder
            )
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
            StringBuilder builder
            )
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

        public void GetScalarType(
            QueryBatchCommand source,
            ProviderInfo providerInfo,
            out ITypeSymbol type,
            out bool isRowAffected,
            out string typeName
            )
        {
            var first = source.QueryBases().First().QueryBase;
            if (first.Aliases.IsRowsAffected)
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
            if (providerInfo.IsKnownProviderType(first.MapTypeName) || providerInfo.IsSpecialHandlerType(first.MapTypeName))
            {
                type = first.MapTypeName;
                typeName = type.GetFullTypeName(replaceNullable: true);
                return;
            }

            var firstField = first.Aliases.AllFieldsOrderByPosition().First();
            first.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var typeProp);
            type = typeProp;
            typeName = type.GetFullTypeName(replaceNullable: true);
            return;
        }
    }
};
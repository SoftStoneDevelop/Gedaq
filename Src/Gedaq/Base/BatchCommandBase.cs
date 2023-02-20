﻿using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Linq;
using System.Text;

namespace Gedaq.Base
{
    internal abstract class BatchCommandBase
    {
        protected abstract BatchCommonGenerator BatchCommon { get; }

        public void Generate(QueryBatch source, StringBuilder builder)
        {
            CreateBatchItems(source, builder);
            CreateBatchMethods(source, builder);
            ExecuteBatchMethods(source, builder);
        }

        private void CreateBatchItems(QueryBatch source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchItem(source, MethodType.Async, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchItem(source, MethodType.Sync, builder);
            }
        }

        protected virtual void CreateBatchMethods(QueryBatch source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchMethod(source, "DbConnection", "connection", MethodType.Sync, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchMethod(source, "Dbconnection", "connection", MethodType.Async, builder);
            }

            SetParametrsMethod(source, builder);
        }

        protected void ExecuteBatchMethods(QueryBatch source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                StartExecuteBatch(source, MethodType.Sync, builder);
                ExecuteBatch(source, MethodType.Sync, builder);
                EndMethod(builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                StartExecuteBatch(source, MethodType.Async, builder);
                ExecuteBatch(source, MethodType.Async, builder);
                EndMethod(builder);
            }
        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
        }

        private void CreateBatchItem(
            QueryBatch source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().query.MapTypeName.GetFullTypeName(true) : "object";
            var async = methodType == MethodType.Sync ? "()" : "Async(cancellationToken).ConfigureAwait(false)";
            var await = methodType == MethodType.Sync ? "" : "await ";

            int index = -1;
            foreach (var item in source.QueryBases())
            {
                ++index;
                if (methodType == MethodType.Sync)
                {
                    builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static IEnumerable<{type}> BatchItem{index}(this {BatchCommon.ReaderType()} reader)
        {{
");
                }
                else
                {
                    builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static async IAsyncEnumerable<{type}> BatchItem{index}Async(
            this {BatchCommon.ReaderType()} reader,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
                }

                builder.Append($@"
            while({await}reader.Read{async})
            {{
");
                BatchCommon.YieldItem(item.query, builder, source.AllSameTypes ? "" : "(object)");
                builder.Append($@"
            }}
        }}
");
            }
        }

        protected abstract void CreateParametr(BaseParametr parametr, int index, StringBuilder builder);

        protected virtual void CreateFakeCommand(string sourceParametrName, StringBuilder builder)
        {

        }

        protected virtual void DisposeFakeCommand(MethodType methodType, StringBuilder builder)
        {

        }

        protected void CreateBatchMethod(
            QueryBatch source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  {(methodType == MethodType.Async ? $"async Task<{BatchCommon.BatchType()}>" : BatchCommon.BatchType())} Create{source.MethodName}Batch{(methodType == MethodType.Async ? "Async" : "")}(
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
            var batch = {sourceParametrName}.CreateBatch();

");
            CreateFakeCommand(sourceParametrName, builder);
            builder.Append($@"
            if(timeout.HasValue)
            {{
                batch.Timeout = timeout.Value;
            }}
");
            int index = -1;
            foreach (var item in source.QueryBases())
            {
                ++index;
                if (index == 0)
                {
                    builder.Append($@"
            var command = batch.CreateBatchCommand();
");
                }
                else
                {
                    builder.Append($@"
            command = batch.CreateBatchCommand();
");
                }

                builder.Append($@"
            command.CommandText = @""
{item.query.Query}
"";
");
                if (item.query.HaveParametrs())
                {
                    builder.Append($@"
            {{
");
                    int indexP = -1;
                    foreach (var parametr in item.query.BaseParametrs())
                    {
                        ++indexP;
                        CreateParametr(parametr, indexP, builder);
                    }

                    builder.Append($@"
            }}
");
                }

                builder.Append($@"
            batch.BatchCommands.Add(command);
");
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
                    batch.Prepare();
                }}
                catch
                {{
                    batch.Dispose();
                    throw;
                }}
            }}
");
            }

            builder.Append($@"
            return batch;
        }}
");

        }

        protected void SetParametrsMethod(
            QueryBatch source,
            StringBuilder builder
            )
        {
            if (!source.HaveParametrs)
            {
                return;
            }

            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            this {BatchCommon.BatchType()} batch
");
            foreach (var batchCommand in source.QueryBases())
            {
                if (!batchCommand.query.HaveParametrs())
                {
                    continue;
                }

                foreach (var parametr in batchCommand.query.BaseParametrs())
                {
                    builder.Append($@",
            in {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{batchCommand.number}
");
                }
            }

            builder.Append($@"
        )
        {{
");
            int indexBatch = -1;
            foreach (var batchCommand in source.QueryBases())
            {
                ++indexBatch;
                if (!batchCommand.query.HaveParametrs())
                {
                    continue;
                }

                if (indexBatch == 0)
                {
                    builder.Append($@"
            var batchCommand = batch.BatchCommands[{indexBatch}];
");
                }
                else
                {
                    builder.Append($@"
            batchCommand = batch.BatchCommands[{indexBatch}];
");
                }

                var indexP = -1;
                foreach (var parametr in batchCommand.query.BaseParametrs())
                {
                    ++indexP;
                    if (parametr.Type.IsNullableType())
                    {
                        builder.Append($@"
            if({parametr.VariableName()}Batch{batchCommand.number}.HasValue)
            {{
                {BatchCommon.GetParametrValue(parametr, indexP, "batchCommand")} = {parametr.VariableName()}Batch{batchCommand.number}.Value;
            }}
            else
            {{
                {BatchCommon.GetParametrValue(parametr, indexP, "batchCommand")} = DBNull.Value;
            }}
");
                    }
                    else
                    {
                        builder.Append($@"
            {BatchCommon.GetParametrValue(parametr, indexP, "batchCommand")} = {parametr.VariableName()}Batch{batchCommand.number};
");
                    }
                }
            }

            builder.Append($@"
        }}
");

        }

        private void StartExecuteBatch(
            QueryBatch source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        public static IEnumerable<IEnumerable<{type}>> Execute{source.MethodName}Batch(this {BatchCommon.BatchType()} batch)
        {{
");
            }
            else
            {
                builder.Append($@"
        public static async IAsyncEnumerable<IAsyncEnumerable<{type}>> Execute{source.MethodName}BatchAsync(
            this {BatchCommon.BatchType()} batch,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        protected void ExecuteBatch(
            QueryBatch source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
            {BatchCommon.ReaderType()} reader = null;
            try
            {{
");
            builder.Append($@"
                reader = {await}batch.ExecuteReader{async};
");
            int index = -1;
            foreach (var item in source.QueryBases())
            {
                ++index;
                builder.Append($@"
                yield return reader.BatchItem{index}{(methodType == MethodType.Async ? "Async(cancellationToken)" : "()")};
                {await}reader.NextResult{async};
");
            }
            
            builder.Append($@"
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
                            batch.Cancel();
                        }}
                        catch {{ /* ignore */ }}
                    }}
                
                    {await}reader.Dispose{disposeAsync};
                }}
            }}
");
        }
    }
}
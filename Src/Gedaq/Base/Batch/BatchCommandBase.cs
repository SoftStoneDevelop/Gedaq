using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class BatchCommandBase
    {
        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(QueryBatchCommand source, StringBuilder builder)
        {
            CreateBatchItems(source, builder);
            CreateBatchMethods(source, builder);
            ExecuteBatchMethods(source, builder);
        }

        private void CreateBatchItems(QueryBatchCommand source, StringBuilder builder)
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

        protected virtual void CreateBatchMethods(QueryBatchCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchMethod(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), MethodType.Sync, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchMethod(source, ProviderInfo.DefaultSourceType(), ProviderInfo.DefaultSourceTypeParametr(), MethodType.Async, builder);
            }

            SetParametrsMethod(source, builder);
        }

        protected void ExecuteBatchMethods(QueryBatchCommand source, StringBuilder builder)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                BatchCommonBase.ThrowExceptionIfOutCannotExist(source);
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

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    StartExecuteScalarBatch(source, MethodType.Sync, builder);
                    ExecuteScalarBatch(source, MethodType.Sync, builder);
                    EndMethod(builder);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    BatchCommonBase.ThrowExceptionIfOutCannotExist(source);
                    StartExecuteScalarBatch(source, MethodType.Async, builder);
                    ExecuteScalarBatch(source, MethodType.Async, builder);
                    EndMethod(builder);
                }
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery) && 
                source.HaveParametrs && 
                source.QueryBases().Any(a => a.query.HaveParametrs() && a.query.BaseParametrs().Any(an => an .HaveDirection))
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
        private static IEnumerable<{type}> BatchItem{index}({ProviderInfo.ReaderType()} reader)
        {{
");
                }
                else
                {
                    builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static async IAsyncEnumerable<{type}> BatchItem{index}Async(
            {ProviderInfo.ReaderType()} reader,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
                }

                builder.Append($@"
            while({await}reader.Read{async})
            {{
");
                MappingHelper.YieldItem(item.query, builder, ProviderInfo, source.AllSameTypes ? "" : "(object)");
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
            QueryBatchCommand source,
            string sourceTypeName,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  {(methodType == MethodType.Async ? $"async Task<{ProviderInfo.BatchType()}>" : ProviderInfo.BatchType())} Create{source.MethodName}Batch{(methodType == MethodType.Async ? "Async" : "")}(
            {sourceTypeName} {sourceParametrName}
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
            var batch = {sourceParametrName}.CreateBatch();

");
            CreateFakeCommand(sourceParametrName, builder);
            int index = -1;
            foreach (var item in source.QueryBases())
            {
                ++index;
                CreateBatchCommand(index, item, builder);
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

        private void CreateBatchCommand(
            int index,
            (int number, QueryBaseCommand query) item,
            StringBuilder builder
            )
        {
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

            SetQuery(item, builder);
            SetCommandParametrs(item, builder);
        }

        private void SetCommandParametrs(
            (int number, QueryBaseCommand query) item,
            StringBuilder builder
            )
        {
            if (!item.query.HaveParametrs())
            {
                return;
            }

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

        private void SetQuery(
            (int number, QueryBaseCommand query) item,
            StringBuilder builder
            )
        {
            if (item.query.HaveFromatParametrs())
            {
                builder.Append($@"
            command.CommandText = string.Format(@""
{item.query.Query}
""
");
                int index = 0;
                foreach (var format in item.query.FormatParametrs)
                {
                    builder.Append($@",
{(format.HaveName ? $"{format.Name}Batch{item.number}" : $"format{index++.ToString()}Batch{item.number}")}
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
{item.query.Query}
"";
");
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
                if(!item.query.HaveFromatParametrs())
                {
                    continue;
                }

                int index = 0;
                foreach (var format in item.query.FormatParametrs)
                {
                    builder.Append($@",
        System.String {(format.HaveName ? $"{format.Name}Batch{item.number.ToString()}" : $"format{index++.ToString()}Batch{item.number.ToString()}")}
");
                }
            }
        }

        protected void SetParametrsMethod(
            QueryBatchCommand source,
            StringBuilder builder
            )
        {
            builder.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            {ProviderInfo.BatchType()} batch
");
            if(source.HaveParametrs)
            {
                foreach (var batchCommand in source.QueryBases())
                {
                    if (!batchCommand.query.HaveParametrs())
                    {
                        continue;
                    }

                    foreach (var parametr in batchCommand.query.BaseParametrs())
                    {
                        if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                        {
                            builder.Append($@",
            in {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{batchCommand.number}
");
                        }
                    }
                }
            }

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
                batch.Timeout = timeout.Value;
            }}
");
            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@"
            if(transaction != null)
            {{
                batch.Transaction = transaction;
            }}
");
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

            int indexBatch = -1;
            var commandBatchDefine = false;
            foreach (var batchCommand in source.QueryBases())
            {
                ++indexBatch;
                if (!batchCommand.query.HaveParametrs())
                {
                    continue;
                }

                var indexP = -1;
                var commandSet = false;

                foreach (var parametr in batchCommand.query.BaseParametrs())
                {
                    ++indexP;
                    if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                    {
                        continue;
                    }

                    if (commandBatchDefine && !commandSet)
                    {
                        builder.Append($@"
            batchCommand = batch.BatchCommands[{indexBatch}];
");
                        commandSet = true;
                    }

                    if (!commandBatchDefine)
                    {
                        builder.Append($@"
            var batchCommand = batch.BatchCommands[{indexBatch}];
");
                        commandBatchDefine = true;
                        commandSet = true;
                    }

                    if (parametr.Type.IsNullableType())
                    {
                        builder.Append($@"
            if({parametr.VariableName()}Batch{batchCommand.number}.HasValue)
            {{
                {ProviderInfo.GetParametrValue(parametr, indexP, "batchCommand")} = {parametr.VariableName()}Batch{batchCommand.number}.Value;
            }}
            else
            {{
                {ProviderInfo.GetParametrValue(parametr, indexP, "batchCommand")} = DBNull.Value;
            }}
");
                    }
                    else
                    {
                        builder.Append($@"
            {ProviderInfo.GetParametrValue(parametr, indexP, "batchCommand")} = {parametr.VariableName()}Batch{batchCommand.number};
");
                    }
                }
            }
        }

        private void StartExecuteBatch(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        public static IEnumerable<IEnumerable<{type}>> Execute{source.MethodName}Batch({ProviderInfo.BatchType()} batch)
        {{
");
            }
            else
            {
                builder.Append($@"
        public static async IAsyncEnumerable<IAsyncEnumerable<{type}>> Execute{source.MethodName}BatchAsync(
            {ProviderInfo.BatchType()} batch,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        protected void ExecuteBatch(
            QueryBatchCommand source,
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
                reader = {await}batch.ExecuteReader{async};
");
            int index = -1;
            foreach (var item in source.QueryBases())
            {
                ++index;
                builder.Append($@"
                yield return BatchItem{index}{(methodType == MethodType.Async ? "Async(reader, cancellationToken)" : "(reader)")};
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

        private void StartExecuteScalarBatch(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var type = source.AllSameTypes ? source.QueryBases().First().query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"
        public static {BatchCommonBase.GetScalarTypeName(source, ProviderInfo)} Scalar{source.MethodName}Batch(
            {ProviderInfo.BatchType()} batch
");
                BatchCommonBase.WriteMethodParametrs(source, builder);

                builder.Append($@"
        )
        {{
");
            }
            else
            {
                builder.Append($@"
        public static async Task<{BatchCommonBase.GetScalarTypeName(source, ProviderInfo)}> Scalar{source.MethodName}BatchAsync(
            {ProviderInfo.BatchType()} batch,
            CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        protected void ExecuteScalarBatch(
            QueryBatchCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            builder.Append($@"
            var result = ({BatchCommonBase.GetScalarTypeName(source, ProviderInfo)}){await}batch.ExecuteScalar{async};
");
            if(source.HaveParametrs)
            {
                int index = -1;
                foreach (var item in source.QueryBases())
                {
                    ++index;
                    if (!item.query.HaveParametrs())
                    {
                        continue;
                    }

                    BatchCommonBase.SetOutAndReturnParametrs(source, builder, ProviderInfo);
                }
            }

            builder.Append($@"
            return result;
");
        }
    }
};
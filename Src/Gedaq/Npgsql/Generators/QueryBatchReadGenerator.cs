using Gedaq.DbConnection.Generators;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Gedaq.Npgsql.Generators
{
    internal class QueryBatchReadGenerator : QueryBaseGenerator
    {
        public void GenerateMethod(QueryBatchNpgsql source)
        {
            Reset();
            Start(source);

            ReadMethods(source);
            CreateBatchItems(source);
            CreateBatchMethods(source);
            ExecuteBatchMethods(source);

            End();
        }

        private void Start(
            QueryBatchNpgsql source
            )
        {
            _methodCode.Append($@"
using Npgsql;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}NpgsqlExtension
    {{
");
        }

        private void ReadMethods(QueryBatchNpgsql source)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ReadMethod(source);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    ReadAsyncMethod(source);
                }
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                throw new NotImplementedException();
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                throw new NotImplementedException();
            }
        }

        private void ReadMethod(QueryBatchNpgsql source)
        {
            if(source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Sync);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethodParametrs();
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync);
                EndMethod();
            }

            if(source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                EndMethodParametrs();
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync);
                EndMethod();
            }
        }

        private void ReadAsyncMethod(QueryBatchNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Async);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                AsyncEndMethodParametrs();
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Async);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                AsyncEndMethodParametrs();
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async);
                EndMethod();
            }
        }

        private void ExecuteBatchMethods(QueryBatchNpgsql source)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                StartExecuteBatch(source, MethodType.Sync);
                ExecuteBatch(source, MethodType.Sync);
                EndMethod();
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                StartExecuteBatch(source, MethodType.Async);
                ExecuteBatch(source, MethodType.Async);
                EndMethod();
            }
        }

        private void CreateBatchMethods(QueryBatchNpgsql source)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync);
                }

                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync);
                }
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async);
                }

                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async);
                }
            }

            SetParametrsMethod(source);
        }

        private void StartReadMethod(
            QueryBatchNpgsql source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ? source.Queries[0].query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"        
        public static IEnumerable<IEnumerable<{type}>> {source.MethodName}(
");
            }
            else
            {
                _methodCode.Append($@"        
        public static async IAsyncEnumerable<IAsyncEnumerable<{type}>> {source.MethodName}Async(
");
            }
        }

        private void StartMethodParametrs(
            QueryBatchNpgsql source,
            NpgsqlSourceType sourceType
            )
        {
            _methodCode.Append($@"
            this {sourceType.ToTypeName()} {sourceType.ToParametrName()}
");
            if(source.HaveParametrs)
            {
                for (int j = 0; j < source.Queries.Count; j++)
                {
                    var item = source.Queries[j];
                    if(!item.query.HaveParametrs())
                    {
                        continue;
                    }

                    for (int i = 0; i < item.query.Parametrs.Length; i++)
                    {
                        var parametr = item.query.Parametrs[i];
                        _methodCode.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{item.number}
");
                    }
                }
            }
        }

        private void EndMethodParametrs()
        {
            _methodCode.Append($@",
            int? timeout = null
        )
        {{
");
        }

        private void AsyncEndMethodParametrs()
        {
            _methodCode.Append($@",
            int? timeout = null,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
        )
        {{
");
        }

        private void StartExecuteBatch(
            QueryBatchNpgsql source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ?  source.Queries[0].query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"
        public static IEnumerable<IEnumerable<{type}>> Execute{source.MethodName}Batch(this NpgsqlBatch batch)
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        public static async IAsyncEnumerable<IAsyncEnumerable<{type}>> Execute{source.MethodName}BatchAsync(
            this NpgsqlBatch batch,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        private void ExecuteBatch(QueryBatchNpgsql source, MethodType methodType)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            _methodCode.Append($@"
            NpgsqlDataReader reader = null;
            try
            {{
");
            _methodCode.Append($@"
                reader = {await}batch.ExecuteReader{async};
");
            for (int j = 0; j < source.Queries.Count; j++)
            {
                _methodCode.Append($@"
                yield return reader.BatchItem{j}{(methodType == MethodType.Async ? "Async(cancellationToken)" : "()")};
                {await}reader.NextResult{async};
");
            }
            _methodCode.Append($@"
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

        private void ReadMethodBody(
            QueryBatchNpgsql source,
            Enums.NpgsqlSourceType sourceType,
            MethodType methodType
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeOrCloseAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            if (sourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
            bool needClose = {sourceType.ToParametrName()}.State == ConnectionState.Closed;
            if(needClose)
            {{
                {await}{sourceType.ToParametrName()}.Open{async};
            }}
");
            }
            var createBatch =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}BatchAsync({sourceType.ToParametrName()}, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Batch({sourceType.ToParametrName()}, false, timeout)"
                ;
            _methodCode.Append($@"
            NpgsqlBatch batch = null;
            NpgsqlDataReader reader = null;
            try
            {{
                batch = {createBatch};
");
            if(source.HaveParametrs)
            {
                _methodCode.Append($@"
                batch.Set{source.MethodName}Parametrs(
");
                var haveSuccessIteration = false;
                for (int j = 0; j < source.Queries.Count; j++)
                {
                    var item = source.Queries[j];
                    if (!item.query.HaveParametrs())
                    {
                        continue;
                    }

                    if (haveSuccessIteration)
                    {
                        _methodCode.Append($@",");
                    }

                    for (int i = 0; i < item.query.Parametrs.Length; i++)
                    {
                        var parametr = item.query.Parametrs[i];
                        _methodCode.Append($@"
                    in {parametr.VariableName()}Batch{item.number}
");
                        if (i != item.query.Parametrs.Length - 1)
                        {
                            _methodCode.Append($@",");
                        }
                    }

                    haveSuccessIteration |= true;
                }
                _methodCode.Append($@"
                    );");
            }
            _methodCode.Append($@"
                reader = {await}batch.ExecuteReader{async};
");
            for (int j = 0; j < source.Queries.Count; j++)
            {
                _methodCode.Append($@"
                yield return reader.BatchItem{j}{(methodType == MethodType.Async ? "Async(cancellationToken)" : "()")};
                {await}reader.NextResult{async};
");
            }

            _methodCode.Append($@"
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
                            batch.Cancel();
                        }}
                        catch {{ /* ignore */ }}
                    }}
                
                    {await}reader.Dispose{disposeOrCloseAsync};
                }}
");
            if (sourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}
");
            }
            _methodCode.Append($@"
                if(batch != null)
                {{
                    batch.BatchCommands.Clear();
                    {await}batch.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }

        private void CreateBatchMethod(
            QueryBatchNpgsql source,
            Enums.NpgsqlSourceType sourceType,
            MethodType methodType
            )
        {
            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  {(methodType == MethodType.Async ? "async Task<NpgsqlBatch>" : "NpgsqlBatch")} Create{source.MethodName}Batch{(methodType == MethodType.Async ? "Async" : "")}(
            this {sourceType.ToTypeName()} {sourceType.ToParametrName()},
            bool prepare = false
");
            if(methodType == MethodType.Async)
            {
                _methodCode.Append($@",
            CancellationToken cancellationToken = default
");
            }

            _methodCode.Append($@",
            int? timeout = null
        )
        {{
            var batch = {sourceType.ToParametrName()}.CreateBatch();
            if(timeout.HasValue)
            {{
                batch.Timeout = timeout.Value;
            }}
");
            for (int i = 0; i < source.Queries.Count; i++)
            {
                var item = source.Queries[i];
                if(i == 0)
                {
                    _methodCode.Append($@"
            var command = batch.CreateBatchCommand();
");
                }
                else
                {
                    _methodCode.Append($@"
            command = batch.CreateBatchCommand();
");
                }

                _methodCode.Append($@"
            command.CommandText = @""
{item.query.Query}
"";
");
                if (item.query.HaveParametrs())
                {
                    _methodCode.Append($@"
            {{
");
                    for (int j = 0; j < item.query.Parametrs.Length; j++)
                    {
                        var parametr = item.query.Parametrs[j];
                        if (parametr.Type.IsNullableType())
                        {
                            _methodCode.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter();
");
                        }
                        else
                        {
                            _methodCode.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
                        }

                        if (parametr.HaveNpgSqlDbType)
                        {
                            _methodCode.Append($@"
                parametr{parametr.Position}.NpgsqlDbType = ({MapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType};
");
                        }

                        if (parametr.HaveName)
                        {
                            _methodCode.Append($@"
                parametr{parametr.Position}.ParameterName = ""{parametr.Name}"";
");
                        }

                        if (parametr.HaveSize)
                        {
                            _methodCode.Append($@"
                parametr{parametr.Position}.Size = {parametr.Size};
");
                        }

                        if (parametr.Nullable)
                        {
                            _methodCode.Append($@"
                parametr{parametr.Position}.IsNullable = true;
");
                        }

                        if (parametr.Direction != System.Data.ParameterDirection.Input)
                        {
                            _methodCode.Append($@"
                parametr{parametr.Position}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
                        }

                        _methodCode.Append($@"
                command.Parameters.Add(parametr{parametr.Position});
");
                    }
                    _methodCode.Append($@"
            }}
");
                }

                _methodCode.Append($@"
            batch.BatchCommands.Add(command);
");
            }

            if (methodType == MethodType.Async)
            {
                _methodCode.Append($@"
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
                _methodCode.Append($@"
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

            _methodCode.Append($@"
            return batch;
        }}
");

        }

        private void SetParametrsMethod(
            QueryBatchNpgsql source
            )
        {
            if(!source.HaveParametrs)
            {
                return;
            }

            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            this NpgsqlBatch batch
");
            for (int j = 0; j < source.Queries.Count; j++)
            {
                var batchCommand = source.Queries[j];
                if(!batchCommand.query.HaveParametrs())
                {
                    continue;
                }

                for (int i = 0; i < batchCommand.query.Parametrs.Length; i++)
                {
                    var parametr = batchCommand.query.Parametrs[i];
                    _methodCode.Append($@",
            in {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{batchCommand.number}
");
                }
            }
            _methodCode.Append($@"
        )
        {{
");
            for (int j = 0; j < source.Queries.Count; j++)
            {
                var batchCommand = source.Queries[j];
                if (!batchCommand.query.HaveParametrs())
                {
                    continue;
                }

                if(j == 0)
                {
                    _methodCode.Append($@"
            var batchCommand = batch.BatchCommands[{j}];
");
                }
                else
                {
                    _methodCode.Append($@"
            batchCommand = batch.BatchCommands[{j}];
");
                }

                for (int i = 0; i < batchCommand.query.Parametrs.Length; i++)
                {
                    var parametr = batchCommand.query.Parametrs[i];
                    if (parametr.Type.IsNullableType())
                    {
                        _methodCode.Append($@"
            if({parametr.VariableName()}Batch{batchCommand.number}.HasValue)
            {{
                ((NpgsqlParameter)batchCommand.Parameters[{i}]).Value = {parametr.VariableName()}Batch{batchCommand.number}.Value;
            }}
            else
            {{
                ((NpgsqlParameter)batchCommand.Parameters[{i}]).Value = DBNull.Value;
            }}
");
                    }
                    else
                    {
                        _methodCode.Append($@"
            ((NpgsqlParameter<{parametr.Type.GetFullTypeName()}>)batchCommand.Parameters[{i}]).TypedValue = {parametr.VariableName()}Batch{batchCommand.number};
");
                    }

                }
            }

            _methodCode.Append($@"
        }}
");

        }

        private void CreateBatchItems(QueryBatchNpgsql source)
        {
            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchItem(source, MethodType.Async);
            }

            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchItem(source, MethodType.Sync);
            }
        }

        private void CreateBatchItem(
            QueryBatchNpgsql source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ? source.Queries[0].query.MapTypeName.GetFullTypeName(true) : "object";
            var async = methodType == MethodType.Sync ? "()" : "Async(cancellationToken).ConfigureAwait(false)";
            var await = methodType == MethodType.Sync ? "" : "await ";

            for (int j = 0; j < source.Queries.Count; j++)
            {
                var item = source.Queries[j];
                if(methodType == MethodType.Sync)
                {
                    _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static IEnumerable<{type}> BatchItem{j}(this NpgsqlDataReader reader)
        {{
");
                }
                else
                {
                    _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static async IAsyncEnumerable<{type}> BatchItem{j}Async(
            this NpgsqlDataReader reader,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
                }

                _methodCode.Append($@"
            while({await}reader.Read{async})
            {{
");
                YieldItem(item.query, source.AllSameTypes ? "" : "(object)");
                _methodCode.Append($@"
            }}
        }}
");
            }
        }

        private void YieldItem(
            QueryReadNpgsql source,
            string castTypeExpr
            )
        {
            if (MapTypeHelper.IsKnownProviderType(source.MapTypeName))
            {
                _methodCode.Append($@"
                    yield return {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if(source.MapTypeName.IsNullableType())
            {
                _methodCode.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        yield return {castTypeExpr}({source.MapTypeName.GetFullTypeName(true)})null;
                    }}
                    else
                    {{
                        yield return {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>(0);
                    }}
");
            }
            else if (source.MapTypeName.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    yield return {castTypeExpr}reader.GetValue(0);
");
            }
            else if (source.MapTypeName is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    var item = new object[reader.FieldCount];
                    reader.GetValues(item);
                    yield return {castTypeExpr}item;
");
            }
            else
            {
                ComplicateItem(source.Aliases, source.MapTypeName, source.MethodType);
                _methodCode.Append($@" 
                    yield return {castTypeExpr}item;
");
            }
        }
    }
}
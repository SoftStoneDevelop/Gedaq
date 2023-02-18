using Gedaq.DbConnection.Generators;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
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

namespace Gedaq.DbConnection.Generators
{
    internal class QueryBatchGenerator : QueryBaseGenerator
    {
        public void GenerateMethod(DbQueryBatch source)
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
            DbQueryBatch source
            )
        {
            _methodCode.Append($@"
using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}DbConnectionExtension
    {{
");
        }

        private void ReadMethods(DbQueryBatch source)
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
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    ScalarMethod(source);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    ScalarMethodAsync(source);
                }
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    NonQueryMethod(source);
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    NonQueryMethodAsync(source);
                }
            }
        }

        private void ReadMethod(DbQueryBatch source)
        {
            StartReadMethod(source, MethodType.Sync);
            StartMethodParametrs(source);
            EndMethodParametrs();
            ReadMethodBody(source, MethodType.Sync);
            EndMethod();
        }

        private void ReadAsyncMethod(DbQueryBatch source)
        {
            StartReadMethod(source, MethodType.Async);
            StartMethodParametrs(source);
            AsyncEndMethodParametrs(true);
            ReadMethodBody(source, MethodType.Async);
            EndMethod();
        }

        private void ScalarMethod(DbQueryBatch source)
        {
            StartScalarMethod(source, MethodType.Sync);
            StartMethodParametrs(source);
            EndMethodParametrs();
            ScalarMethodBody(source, MethodType.Sync, QueryType.Scalar);
            EndMethod();
        }

        private void ScalarMethodAsync(DbQueryBatch source)
        {
            StartScalarMethod(source, MethodType.Async);
            StartMethodParametrs(source);
            AsyncEndMethodParametrs(false);
            ScalarMethodBody(source, MethodType.Async, QueryType.Scalar);
            EndMethod();
        }

        private void NonQueryMethod(DbQueryBatch source)
        {
            StartScalarMethod(source, MethodType.Sync);
            StartMethodParametrs(source);
            EndMethodParametrs();
            ScalarMethodBody(source, MethodType.Sync, QueryType.NonQuery);
            EndMethod();
        }

        private void NonQueryMethodAsync(DbQueryBatch source)
        {
            StartScalarMethod(source, MethodType.Async);
            StartMethodParametrs(source);
            AsyncEndMethodParametrs(false);
            ScalarMethodBody(source, MethodType.Async, QueryType.NonQuery);
            EndMethod();
        }

        private void ExecuteBatchMethods(DbQueryBatch source)
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

        private void CreateBatchMethods(DbQueryBatch source)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateBatchMethod(source, MethodType.Sync);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateBatchMethod(source, MethodType.Async);
            }

            SetParametrsMethod(source);
        }

        private void StartReadMethod(
            DbQueryBatch source,
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

        private void StartScalarMethod(
            DbQueryBatch source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"
        public static {GetScalarTypeName(source)} Scalar{source.MethodName}(
");
            }
            else
            {
                _methodCode.Append($@"
        public static async Task<{GetScalarTypeName(source)}> Scalar{source.MethodName}Async(
");
            }
        }

        private string GetScalarTypeName(DbQueryBatch source)
        {
            var first = source.Queries[0].query;
            if (first.Aliases.IsRowsAffected)
            {
                return "System.Int32";
            }

            if (MapTypeHelper.IsKnownProviderType(first.MapTypeName))
            {
                return first.MapTypeName.GetFullTypeName();
            }

            var firstField = first.Aliases.GetFirstFieldInQuery();
            first.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }

        private void StartMethodParametrs(
            DbQueryBatch source
            )
        {
            _methodCode.Append($@"
            this DbConnection connection
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

        private void AsyncEndMethodParametrs(bool enumerator)
        {
            _methodCode.Append($@",
            int? timeout = null,
            {(enumerator ? "[EnumeratorCancellation] " : "")}CancellationToken cancellationToken = default
        )
        {{
");
        }

        private void StartExecuteBatch(
            DbQueryBatch source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ?  source.Queries[0].query.MapTypeName.GetFullTypeName(true) : "object";
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"
        public static IEnumerable<IEnumerable<{type}>> Execute{source.MethodName}Batch(this DbBatch batch)
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        public static async IAsyncEnumerable<IAsyncEnumerable<{type}>> Execute{source.MethodName}BatchAsync(
            this DbBatch batch,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        private void ExecuteBatch(DbQueryBatch source, MethodType methodType)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            _methodCode.Append($@"
            DbDataReader reader = null;
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
            DbQueryBatch source,
            MethodType methodType
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeOrCloseAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            _methodCode.Append($@"
            bool needClose = connection.State == ConnectionState.Closed;
            if(needClose)
            {{
                {await}connection.Open{async};
            }}
");
            var createBatch =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}BatchAsync(connection, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Batch(connection, false, timeout)"
                ;
            _methodCode.Append($@"
            DbBatch batch = null;
            DbDataReader reader = null;
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

                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}

                if(batch != null)
                {{
                    batch.BatchCommands.Clear();
                    {await}batch.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }

        private void ScalarMethodBody(
            DbQueryBatch source,
            MethodType methodType,
            QueryType queryType
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeOrCloseAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            _methodCode.Append($@"
            bool needClose = connection.State == ConnectionState.Closed;
            if(needClose)
            {{
                {await}connection.Open{async};
            }}
");
            var createBatch =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}BatchAsync(connection, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Batch(connection, false, timeout)"
                ;
            _methodCode.Append($@"
            DbBatch batch = null;
            try
            {{
                batch = {createBatch};
");
            if (source.HaveParametrs)
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

            if(queryType == QueryType.Scalar)
            {
                _methodCode.Append($@"
                return ({GetScalarTypeName(source)}){await}batch.ExecuteScalar{async};
");
            }
            else
            {
                _methodCode.Append($@"
                return ({GetScalarTypeName(source)}){await}batch.ExecuteNonQuery{async};
");
            }

            _methodCode.Append($@"
            }}
            finally
            {{
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}

                if(batch != null)
                {{
                    batch.BatchCommands.Clear();
                    {await}batch.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }

        private void CreateBatchMethod(
            DbQueryBatch source,
            MethodType methodType
            )
        {
            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  {(methodType == MethodType.Async ? "async Task<DbBatch>" : "DbBatch")} Create{source.MethodName}Batch{(methodType == MethodType.Async ? "Async" : "")}(
            this DbConnection connection,
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
            var batch = connection.CreateBatch();
            var fakeCommand = connection.CreateCommand();
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
                        _methodCode.Append($@"
                var parametr{j} = fakeCommand.CreateParameter();
");

                        if (parametr.HaveDbType)
                        {
                            _methodCode.Append($@"
                parametr{j}.DbType = (System.Data.DbType){parametr.DbType};
");
                        }

                        if (parametr.HaveName)
                        {
                            _methodCode.Append($@"
                parametr{j}.ParameterName = ""{parametr.Name}"";
");
                        }

                        if (parametr.HaveSize)
                        {
                            _methodCode.Append($@"
                parametr{j}.Size = {parametr.Size};
");
                        }

                        if (parametr.Nullable)
                        {
                            _methodCode.Append($@"
                parametr{j}.IsNullable = true;
");
                        }

                        if (parametr.Direction != System.Data.ParameterDirection.Input)
                        {
                            _methodCode.Append($@"
                parametr{j}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
                        }

                        _methodCode.Append($@"
                command.Parameters.Add(parametr{j});
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
            await fakeCommand.DisposeAsync(cancellationToken).ConfigureAwait(false);
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
            fakeCommand.Dispose();
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
            DbQueryBatch source
            )
        {
            if(!source.HaveParametrs)
            {
                return;
            }

            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            this DbBatch batch
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
                batchCommand.Parameters[{i}].Value = {parametr.VariableName()}Batch{batchCommand.number}.Value;
            }}
            else
            {{
                batchCommand.Parameters[{i}].Value = DBNull.Value;
            }}
");
                    }
                    else
                    {
                        _methodCode.Append($@"
            batchCommand.Parameters[{i}].Value = {parametr.VariableName()}Batch{batchCommand.number};
");
                    }

                }
            }

            _methodCode.Append($@"
        }}
");

        }

        private void CreateBatchItems(DbQueryBatch source)
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
            DbQueryBatch source,
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
        private static IEnumerable<{type}> BatchItem{j}(this DbDataReader reader)
        {{
");
                }
                else
                {
                    _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static async IAsyncEnumerable<{type}> BatchItem{j}Async(
            this DbDataReader reader,
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
            DbQuery source,
            string castTypeExpr
            )
        {
            if (DbMapTypeHelper.IsKnownProviderType(source.MapTypeName))
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
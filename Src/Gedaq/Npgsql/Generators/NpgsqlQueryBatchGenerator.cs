using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Npgsql.Generators
{
    internal class NpgsqlQueryBatchGenerator : QueryBaseGenerator
    {
        NpgsqlQueryBatchRead _batchRead = new NpgsqlQueryBatchRead();
        NpgsqlQueryBatchScalarNoQuery _batchScalarNoQuery = new NpgsqlQueryBatchScalarNoQuery();

        public void GenerateMethod(QueryBatchNpgsql source)
        {
            Reset();
            Start(source);

            if (source.QueryType.HasFlag(QueryType.Read))
            {
                _batchRead.Generate(source, _methodCode);
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                _batchScalarNoQuery.GenerateScalar(source, _methodCode);
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                _batchScalarNoQuery.GenerateNonQuery(source, _methodCode);
            }

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

        private string GetScalarTypeName(QueryBatchNpgsql source)
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
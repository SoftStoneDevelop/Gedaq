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
    internal class QueryBatchReadGenerator
    {
        private StringBuilder _methodCode = new StringBuilder();

        public string GetCode()
        {
            var code = _methodCode.ToString();
            return code;
        }

        public void Reset()
        {
            _methodCode.Clear();
        }

        public void GenerateMethod(QueryBatchReadNpgsql source)
        {
            Reset();
            Start(source);

            CreateBatchItems(source);
            ReadMethods(source);
            BatchMethods(source);

            End();
        }

        private void Start(
            QueryBatchReadNpgsql source
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
    public static class {source.MethodName}Class
    {{
");
        }

        private void End()
        {
            _methodCode.Append($@"
    }}
}}
");
        }

        private void ReadMethods(QueryBatchReadNpgsql source)
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

        private void ReadMethod(QueryBatchReadNpgsql source)
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

        private void ReadAsyncMethod(QueryBatchReadNpgsql source)
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

        private void BatchMethods(QueryBatchReadNpgsql source)
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

                StartExecuteBatch(source, MethodType.Sync);
                ExecuteBatch(source, MethodType.Sync);
                EndMethod();
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

                StartExecuteBatch(source, MethodType.Async);
                ExecuteBatch(source, MethodType.Async);
                EndMethod();
            }

            SetParametrsMethod(source);
        }

        private void StartReadMethod(
            QueryBatchReadNpgsql source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ? source.Queries[0].MapTypeName.GetFullTypeName(true) : "object";
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
            QueryBatchReadNpgsql source,
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
                    if(!item.HaveParametrs())
                    {
                        continue;
                    }

                    for (int i = 0; i < item.Parametrs.Length; i++)
                    {
                        var parametr = item.Parametrs[i];
                        _methodCode.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{item.BatchNumber}
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
            QueryBatchReadNpgsql source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ?  source.Queries[0].MapTypeName.GetFullTypeName(true) : "object";
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

        private void ExecuteBatch(QueryBatchReadNpgsql source, MethodType methodType)
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
            QueryBatchReadNpgsql source,
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
                    if (!item.HaveParametrs())
                    {
                        continue;
                    }

                    if (haveSuccessIteration)
                    {
                        _methodCode.Append($@",");
                    }

                    for (int i = 0; i < item.Parametrs.Length; i++)
                    {
                        var parametr = item.Parametrs[i];
                        _methodCode.Append($@"
                    in {parametr.VariableName()}Batch{item.BatchNumber}
");
                        if (i != item.Parametrs.Length - 1)
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

        private void EndMethod()
        {
            _methodCode.Append($@"
        }}
");
        }

        private void CreateBatchMethod(
            QueryBatchReadNpgsql source,
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
            if (source.Timeout.HasValue)
            {
                _methodCode.Append($@"
            else
            {{
                batch.Timeout = {source.Timeout};
            }}
");
            }
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
{item.Query}
"";
");
                if (item.HaveParametrs())
                {
                    _methodCode.Append($@"
            {{
");
                    for (int j = 0; j < item.Parametrs.Length; j++)
                    {
                        var parametr = item.Parametrs[j];
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

                        if (parametr.HaveDbType)
                        {
                            _methodCode.Append($@"
                parametr{parametr.Position}.NpgsqlDbType = ({TypeHelper.NpgsqlDbTypeName}){parametr.DbType};
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
            QueryBatchReadNpgsql source
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
                if(!batchCommand.HaveParametrs())
                {
                    continue;
                }

                for (int i = 0; i < batchCommand.Parametrs.Length; i++)
                {
                    var parametr = batchCommand.Parametrs[i];
                    _methodCode.Append($@",
            in {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}Batch{batchCommand.BatchNumber}
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
                if (!batchCommand.HaveParametrs())
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

                for (int i = 0; i < batchCommand.Parametrs.Length; i++)
                {
                    var parametr = batchCommand.Parametrs[i];
                    if (parametr.Type.IsNullableType())
                    {
                        _methodCode.Append($@"
            if({parametr.VariableName()}Batch{batchCommand.BatchNumber}.HasValue)
            {{
                ((NpgsqlParameter)batchCommand.Parameters[{i}]).Value = {parametr.VariableName()}Batch{batchCommand.BatchNumber}.Value;
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
            ((NpgsqlParameter<{parametr.Type.GetFullTypeName()}>)batchCommand.Parameters[{i}]).TypedValue = {parametr.VariableName()}Batch{batchCommand.BatchNumber};
");
                    }

                }
            }

            _methodCode.Append($@"
        }}
");

        }

        private void CreateBatchItems(QueryBatchReadNpgsql source)
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
            QueryBatchReadNpgsql source,
            MethodType methodType
            )
        {
            var type = source.AllSameTypes ? source.Queries[0].MapTypeName.GetFullTypeName(true) : "object";
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
                YieldItem(item, source.AllSameTypes ? "" : "(object)");
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
            if (source.MapTypeName.IsPrimitive())
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

        private class ItemPair
        {
            public ItemPair(
                Aliases aliases,
                ITypeSymbol mapTypeName,
                string itemName
                )
            {
                Aliases = aliases;
                MapTypeName = mapTypeName;
                ItemName = itemName;
            }

            public ItemPair(
                Aliases aliases,
                ITypeSymbol mapTypeName,
                string itemName,
                string propertyName
                )
                : this(aliases, mapTypeName, itemName)
            {
                PropertyName = propertyName;
            }

            public Aliases Aliases { get; private set; }
            public ITypeSymbol MapTypeName { get; private set; }
            public string PropertyName { get; private set; }
            public string ItemName { get; private set; }

            public ItemPair Parent { get; set; }
            public int Tabs { get; set; }
        }

        private void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType
            )
        {
            var aliases = new Stack<ItemPair>();
            aliases.Push(new ItemPair(rootAliase, rootMapTypeName, "item"));

            var itemId = 0;
            int tabs = -1;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (pair.Parent != null)
                {
                    var linkField = pair.Aliases.GetLinkField();
                    _methodCode.Append($@"
                    {Tabs(pair.Tabs)}if(!{(methodType == MethodType.Async ? "await " : "")}reader.IsDBNull{(methodType == MethodType.Async ? "Async" : "")}({linkField.Position}))
                    {Tabs(pair.Tabs)}{{
                        {Tabs(pair.Tabs)}var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}
                        {Tabs(pair.Tabs)}{{
");
                    for (int i = 0; i < pair.Aliases.Fields.Count; i++)
                    {
                        var field = pair.Aliases.Fields[i];
                        pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                        _methodCode.Append($@"
                            {Tabs(pair.Tabs)}{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                    }
                    _methodCode.Append($@" 
                        {Tabs(pair.Tabs)}}};
");
                    if (pair.Aliases.InnerEntities.Count == 0)
                    {
                        var current = pair;
                        while (current.Parent != null)
                        {
                            _methodCode.Append($@"
                        {Tabs(current.Tabs)}{current.Parent.ItemName}.{current.PropertyName} = {current.ItemName};
                    {Tabs(current.Tabs)}}}
");
                            current = current.Parent;
                        }

                        continue;
                    }
                }
                else//is root
                {
                    _methodCode.Append($@"
                    var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}
                    {{
");
                    for (int i = 0; i < pair.Aliases.Fields.Count; i++)
                    {
                        var field = pair.Aliases.Fields[i];
                        pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                        _methodCode.Append($@"
                        {propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                    }
                    _methodCode.Append($@" 
                    }};
");
                }

                if (pair.Aliases.InnerEntities.Count != 0)
                {
                    ++tabs;
                    for (var i = 0; i < pair.Aliases.InnerEntities.Count; i++)
                    {
                        var alias = pair.Aliases.InnerEntities[i];
                        pair.MapTypeName.GetPropertyOrFieldName(alias.EntityName, out var propertyName, out var pairType);
                        var newPair = new ItemPair(alias, pairType, $"item{++itemId}", propertyName);
                        newPair.Parent = pair;
                        newPair.Tabs = tabs;
                        aliases.Push(newPair);
                    }
                }
            }
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }
    }
}
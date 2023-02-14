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
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Gedaq.Npgsql.Generators
{
    internal class QueryReadGenerator
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

        public void GenerateMethod(QueryReadNpgsql source)
        {
            Reset();
            Start(source);

            if(source.MethodType.HasFlag(MethodType.Sync))
            {
                ReadMethod(source);
                CommandMethods(source);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source);
                CommandAsyncMethods(source);
            }

            End();
        }

        private void Start(
            QueryReadNpgsql source
            )
        {
            _methodCode.Append($@"
using Npgsql;
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

        private void ReadMethod(QueryReadNpgsql source)
        {
            if(source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethodParametrs();
                SyncBody(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethod();
            }

            if(source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                EndMethodParametrs();
                SyncBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                EndMethod();
            }
        }

        private void ReadAsyncMethod(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadAsyncMethod(source);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                AsyncEndMethodParametrs();
                AsyncBody(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadAsyncMethod(source);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                AsyncEndMethodParametrs();
                AsyncBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                EndMethod();
            }
        }

        private void CommandMethods(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync);
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync);
            }
        }

        private void CommandAsyncMethods(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async);
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async);
            }
        }

        private void StartReadMethod(
            QueryReadNpgsql source
            )
        {
            _methodCode.Append($@"        
        public static IEnumerable<{source.MapTypeName.GetFullTypeName()}> {source.MethodName}(
");
        }

        private void StartReadAsyncMethod(
            QueryReadNpgsql source
            )
        {
            _methodCode.Append($@"        
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName()}> {source.MethodName}Async(
");
        }

        private void StartMethodParametrs(
            QueryReadNpgsql source,
            NpgsqlSourceType sourceType
            )
        {
            _methodCode.Append($@"
            this {sourceType.ToTypeName()} {sourceType.ToParametrName()}
");
            if(source.HaveParametrTypes())
            {
                for (int i = 0; i < source.ParametrTypes.Length; i++)
                {
                    ITypeSymbol type = source.ParametrTypes[i];
                    if(source.HaveParametrNames())
                    {
                        string name = source.ParametrNames[i].ToLowerInvariant();
                        _methodCode.Append($@",
            {type.GetFullTypeName()} {name}
");
                    }
                    else
                    {
                        _methodCode.Append($@",
            {type.GetFullTypeName()} mParametr{i}
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

        private void SyncBody(
            QueryReadNpgsql source,
            Enums.NpgsqlSourceType sourceType
            )
        {
            if (sourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
            bool needClose = {source.SourceType.ToParametrName()}.State == ConnectionState.Closed;
            if(needClose)
            {{
                {source.SourceType.ToParametrName()}.Open();
            }}
");
            }

            _methodCode.Append($@"
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;
            try
            {{
                command = {source.SourceType.ToParametrName()}.CreateCommand();
                if(timeout != null)
                {{
                    command.CommandTimeout = (int)timeout;
                }}
                command.CommandText = @""
{source.Query}
"";
");
            SetCommandParametrs(source);
            _methodCode.Append($@"
                reader = command.ExecuteReader();
                while (reader.Read())
                {{
");
            YieldItem(source);
            _methodCode.Append($@"
                }}

                reader.Dispose();
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
                
                    reader.Dispose();
                }}
");
            if (sourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
                if (needClose)
                {{
                    connection.Close();
                }}
");
            }
            _methodCode.Append($@"
                command?.Parameters.Clear();
                command?.Dispose();
            }}
");
        }

        private void AsyncBody(
            QueryReadNpgsql source,
            Enums.NpgsqlSourceType sourceType
            )
        {
            if (sourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
            bool needClose = {source.SourceType.ToParametrName()}.State == ConnectionState.Closed;
            if(needClose)
            {{
                await {source.SourceType.ToParametrName()}.OpenAsync(cancellationToken).ConfigureAwait(false);
            }}
");
            }

            _methodCode.Append($@"
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;
            try
            {{
                command = {source.SourceType.ToParametrName()}.CreateCommand();
                if(timeout != null)
                {{
                    command.CommandTimeout = (int)timeout;
                }}
                command.CommandText = @""
{source.Query}
"";
");
            SetCommandParametrs(source);
            _methodCode.Append($@"
                reader = await command.ExecuteReaderAsync(cancellationToken).ConfigureAwait(false);
                while (await reader.ReadAsync(cancellationToken).ConfigureAwait(false))
                {{
");
            YieldItem(source);
            _methodCode.Append($@"
                }}

                await reader.DisposeAsync().ConfigureAwait(false);
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
                
                    await reader.DisposeAsync().ConfigureAwait(false);
                }}
");
            if (sourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
                if (needClose)
                {{
                    await connection.CloseAsync().ConfigureAwait(false);
                }}
");
            }
            _methodCode.Append($@"
                if(command != null)
                {{
                    command.Parameters.Clear();
                    await command.DisposeAsync().ConfigureAwait(false);
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

        #region CreateCommand

        private void CreateCommandMethod(
            QueryReadNpgsql source,
            Enums.NpgsqlSourceType sourceType,
            MethodType methodType
            )
        {
            _methodCode.Append($@"
    public static  {(methodType == MethodType.Async ? "async Task<NpgsqlCommand>" : "NpgsqlCommand")} Create{source.MethodName}Command{(methodType == MethodType.Async ? "Async" : "")}(
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
        var command = {source.SourceType.ToParametrName()}.CreateCommand();
        if(timeout != null)
        {{
            command.CommandTimeout = (int)timeout;
        }}
");
            if (source.HaveParametrTypes())
            {
                for (int i = 0; i < source.ParametrTypes.Length; i++)
                {
                    _methodCode.Append($@"
        var parametr{i} = new NpgsqlParameter<{source.ParametrTypes[i].GetFullTypeName()}>();
");
                    if (source.HaveParametrDbTypes())
                    {
                        _methodCode.Append($@"
        parametr{i}.NpgsqlDbType = ({TypeHelper.NpgsqlDbTypeName}){source.ParametrDbTypes[i]};
");
                    }
                    if (source.HaveParametrNames())
                    {
                        _methodCode.Append($@"
        parametr{i}.ParameterName = ""{source.ParametrNames[i]}"";
");
                    }
                    _methodCode.Append($@"
        command.Parameters.Add(parametr{i});
");
                }
            }

            if(methodType == MethodType.Async)
            {
                _methodCode.Append($@"
        await command.PrepareAsync(cancellationToken).ConfigureAwait(false);
");
            }
            else
            {
                _methodCode.Append($@"
        command.Prepare();
");
            }

            _methodCode.Append($@"
        return command;
    }}
");

        }

        #endregion

        private void SetCommandParametrs(QueryReadNpgsql source)
        {
            if(!source.HaveParametrTypes())
            {
                return;
            }

            for (int i = 0; i< source.ParametrTypes.Length; i++)
            {
                _methodCode.Append($@"
                var parametr{i} = new NpgsqlParameter<{source.ParametrTypes[i].GetFullTypeName()}>();
");
                if(source.HaveParametrDbTypes())
                {
                    _methodCode.Append($@"
                parametr{i}.NpgsqlDbType = ({TypeHelper.NpgsqlDbTypeName}){source.ParametrDbTypes[i]};
");
                }
                if(source.HaveParametrNames())
                {
                    _methodCode.Append($@"
                parametr{i}.ParameterName = ""{source.ParametrNames[i]}"";
                parametr{i}.TypedValue = {source.ParametrNames[i].ToLowerInvariant()};
");
                }
                else
                {
                    _methodCode.Append($@"
                parametr{i}.TypedValue = mParametr{i};
");
                }
                _methodCode.Append($@"
                command.Parameters.Add(parametr{i});
");
            }
        }

        private void YieldItem(
            QueryReadNpgsql source
            )
        {
            if (source.MapTypeName.IsPrimitive())
            {
                _methodCode.Append($@"
                    yield return reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if (source.MapTypeName.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    yield return reader.GetValue(0);
");
            }
            else if (source.MapTypeName is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    var item = new object[reader.FieldCount];
                    reader.GetValues(item);
                    yield return item;
");
            }
            else
            {
                ComplicateItem(source.Aliases, source.MapTypeName, source.MethodType);
                _methodCode.Append($@" 
                    yield return item;
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
                    {Tabs(tabs)}if(!{(methodType == MethodType.Async ? "await " : "")}reader.IsDBNull{(methodType == MethodType.Async ? "Async" : "")}({linkField.Position}))
                    {Tabs(tabs)}{{
                        var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}
                        {Tabs(tabs)}{{
");
                    for (int i = 0; i < pair.Aliases.Fields.Count; i++)
                    {
                        var field = pair.Aliases.Fields[i];
                        pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                        _methodCode.Append($@"
                            {Tabs(tabs)}{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                    }
                    _methodCode.Append($@" 
                        {Tabs(tabs)}}};
");
                    if (pair.Aliases.InnerEntities.Count == 0)
                    {
                        if (pair.Parent != null)
                        {
                            _methodCode.Append($@"
                        {Tabs(tabs)}{pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(tabs)}}}
");
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
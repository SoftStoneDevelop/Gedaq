﻿using Gedaq.Enums;
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
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source);
            }

            CommandMethods(source);

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

        private void ReadAsyncMethod(QueryReadNpgsql source)
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

        private void CommandMethods(QueryReadNpgsql source)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync);
                }

                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync);
                }

                StartExecuteCommand(source, MethodType.Sync);
                ExecuteCommand(source, MethodType.Sync);
                EndMethod();
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async);
                }

                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateCommandMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async);
                }

                StartExecuteCommand(source, MethodType.Async);
                ExecuteCommand(source, MethodType.Async);
                EndMethod();
            }

            SetParametrsMethod(source);
        }

        private void StartReadMethod(
            QueryReadNpgsql source,
            MethodType methodType
            )
        {
            if(methodType == MethodType.Sync)
            {
                _methodCode.Append($@"        
        public static IEnumerable<{source.MapTypeName.GetFullTypeName()}> {source.MethodName}(
");
            }
            else
            {
                _methodCode.Append($@"        
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName()}> {source.MethodName}Async(
");
            }
        }

        private void StartMethodParametrs(
            QueryReadNpgsql source,
            NpgsqlSourceType sourceType
            )
        {
            _methodCode.Append($@"
            this {sourceType.ToTypeName()} {sourceType.ToParametrName()}
");
            if(source.HaveParametrs())
            {
                for (int i = 0; i < source.Parametrs.Length; i++)
                {
                    var parametr = source.Parametrs[i];
                    _methodCode.Append($@",
            {parametr.Type.GetFullTypeName()} {parametr.VariableName()}
");
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

        private void StartExecuteCommand(
            QueryReadNpgsql source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"
        public static IEnumerable<{source.MapTypeName.GetFullTypeName()}> Execute{source.MethodName}Command(this NpgsqlCommand command)
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName()}> Execute{source.MethodName}CommandAsync(
            this NpgsqlCommand command,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        private void ExecuteCommand(QueryReadNpgsql source, MethodType methodType)
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
                reader = {await}command.ExecuteReader{async};
                while ({await}reader.Read{async})
                {{
");
            YieldItem(source);
            _methodCode.Append($@"
                }}

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
                            command.Cancel();
                        }}
                        catch {{ /* ignore */ }}
                    }}
                
                    {await}reader.Dispose{disposeAsync};
                }}
            }}
");
        }



        private void ReadMethodBody(
            QueryReadNpgsql source,
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
            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync({sourceType.ToParametrName()}, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Command({sourceType.ToParametrName()}, false, timeout)"
                ;
            _methodCode.Append($@"
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;
            try
            {{
                command = {createCommand};
");
            if(source.HaveParametrs())
            {
                _methodCode.Append($@"
                command.Set{source.MethodName}Parametrs(
");
                for (int i = 0; i < source.Parametrs.Length; i++)
                {
                    var parametr = source.Parametrs[i];
                    _methodCode.Append($@"
                    in {parametr.VariableName()}
");

                    if (i == source.Parametrs.Length - 1)
                    {
                        _methodCode.Append($@"
                    );
");
                    }
                    else
                    {
                        _methodCode.Append($@",");
                    }
                }
            }
            _methodCode.Append($@"
                reader = {await}command.ExecuteReader{async};
                while ({await}reader.Read{async})
                {{
");
            YieldItem(source);
            _methodCode.Append($@"
                }}

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
                            command.Cancel();
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
                if(command != null)
                {{
                    command.Parameters.Clear();
                    {await}command.Dispose{disposeOrCloseAsync};
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

        private void CreateCommandMethod(
            QueryReadNpgsql source,
            Enums.NpgsqlSourceType sourceType,
            MethodType methodType
            )
        {
            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
            var command = {sourceType.ToParametrName()}.CreateCommand();
            command.CommandText = @""
{source.Query}
"";
            if(timeout.HasValue)
            {{
                command.CommandTimeout = timeout.Value;
            }}
");
            if (source.HaveParametrs())
            {
                for (int i = 0; i < source.Parametrs.Length; i++)
                {
                    var parametr = source.Parametrs[i];
                    _methodCode.Append($@"
            var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
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
                    _methodCode.Append($@"
            command.Parameters.Add(parametr{parametr.Position});
");
                }
            }

            if (methodType == MethodType.Async)
            {
                _methodCode.Append($@"
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
                        command.Prepare();
                    }}
                    catch
                    {{
                        command.Dispose();
                        throw;
                    }}
                }}
");
            }

            _methodCode.Append($@"
            return command;
        }}
");

        }

        private void SetParametrsMethod(
            QueryReadNpgsql source
            )
        {
            if(!source.HaveParametrs())
            {
                return;
            }

            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            this NpgsqlCommand command
");
            for (int i = 0; i < source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                _methodCode.Append($@",
            in {parametr.Type.GetFullTypeName()} {parametr.VariableName()}
");
            }

            _methodCode.Append($@"
        )
        {{
");
            for (int i = 0; i < source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                _methodCode.Append($@"
            ((NpgsqlParameter<{parametr.Type.GetFullTypeName()}>)command.Parameters[{i}]).TypedValue = {parametr.VariableName()};
");

            }

            _methodCode.Append($@"
        }}
");

        }

        private void SetCommandParametrs(QueryReadNpgsql source)
        {
            if(!source.HaveParametrs())
            {
                return;
            }

            for (int i = 0; i< source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                _methodCode.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
                if(parametr.HaveDbType)
                {
                    _methodCode.Append($@"
                parametr{parametr.Position}.NpgsqlDbType = ({TypeHelper.NpgsqlDbTypeName}){parametr.DbType};
");
                }
                if(parametr.HaveName)
                {
                    _methodCode.Append($@"
                parametr{parametr.Position}.ParameterName = ""{parametr.Name}"";
");
                }
                _methodCode.Append($@"
                parametr{parametr.Position}.TypedValue = {parametr.VariableName()};
                command.Parameters.Add(parametr{parametr.Position});
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
                        var c = _methodCode.ToString();
                        while (current.Parent != null)
                        {
                            c = _methodCode.ToString();
                            _methodCode.Append($@"
                        {Tabs(current.Tabs)}{current.Parent.ItemName}.{current.PropertyName} = {current.ItemName};
                    {Tabs(current.Tabs)}}}
");
                            current = current.Parent;
                            c = _methodCode.ToString();
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
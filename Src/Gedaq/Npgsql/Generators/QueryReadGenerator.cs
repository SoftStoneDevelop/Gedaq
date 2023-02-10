using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            MethodParametrs(source);
            GenerateBody(source);
            End();
        }

        private void Start(
            QueryReadNpgsql source
            )
        {
            var async = source.MethodType == Enums.MethodType.Sync ? "" : "Async";
            var awaitOperator = source.MethodType == Enums.MethodType.Sync ? "" : "await";
            _methodCode.Append($@"
using Npgsql;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}ClassFrom{source.SourceType.ToString()}{async}
    {{
        
        public static {async.ToLowerInvariant()} I{async}Enumerable<{source.MapTypeName.GetFullTypeName()}> {source.MethodName}{async}(
");
        }

        private void End(
            )
        {
            _methodCode.Append($@"
        }}
    }}
}}
");
        }

        private void MethodParametrs(
            QueryReadNpgsql source
            )
        {
            _methodCode.Append($@"
            this {source.SourceType.ToTypeName()} {source.SourceType.ToParametrName()}
");
            //foreach parametrs - add parametrs
            _methodCode.Append($@"
        )
        {{
");
        }

        private void GenerateBody(
            QueryReadNpgsql source
            )
        {
            if (source.MethodType == Enums.MethodType.Sync)
            {
                SyncBody(source);
            }
            else
            {
                AsyncBody(source);
            }
        }

        #region Sync

        private void SyncBody(
            QueryReadNpgsql source
            )
        {
            if (source.SourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
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
                command.CommandText = @""
{source.Query}
"";
                reader = command.ExecuteReader();
                while (reader.Read())
                {{
");
            SyncYieldItem(source);
            _methodCode.Append($@"
                }}

                while (reader.NextResult()) 
                {{
                    //ignore
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
            if(source.SourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
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

        private void SyncYieldItem(
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
                _methodCode.Append($@"
                    var item = new {source.MapTypeName.GetFullTypeName()}
                    {{
");
                for (int i = 0; i < source.Aliases.FieldNames.Count; i++)
                {
                    string alias = source.Aliases.FieldNames[i];
                    source.MapTypeName.GetPropertyOrFieldName(alias, out var propertyName, out var propertyType);
                    _methodCode.Append($@"
                        {propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({i}),
");
                }

                _methodCode.Append($@" 
                    }};
                
                    yield return item;
");
            }
        }

        #endregion

        #region Async

        private void AsyncBody(
            QueryReadNpgsql source
            )
        {
            if (source.SourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
            {
                _methodCode.Append($@"
            bool needClose = {source.SourceType.ToParametrName()}.State == ConnectionState.Closed;
            if(needClose)
            {{
                await {source.SourceType.ToParametrName()}.OpenAsync().ConfigureAwait(false);
            }}
");
            }

            _methodCode.Append($@"
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;
            try
            {{
                command = {source.SourceType.ToParametrName()}.CreateCommand();
                command.CommandText = @""
{source.Query}
"";
                reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
                while (await reader.ReadAsync().ConfigureAwait(false))
                {{
");
            SyncYieldItem(source);
            _methodCode.Append($@"
                }}

                while (await reader.NextResultAsync().ConfigureAwait(false)) 
                {{
                    //ignore
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
            if (source.SourceType == Enums.NpgsqlSourceType.NpgsqlConnection)
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
                    await command.DisposeAsync();
                }}
            }}
");
        }

        #endregion
    }
}
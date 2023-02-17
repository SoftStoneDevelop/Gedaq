using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.DbConnection.Generators
{
    internal class DbConnectionQueryGenerator : QueryBaseGenerator
    {
        public void Generate(DbQuery source)
        {
            Reset();
            Start(source);

            ExecuteMethods(source);

            CreateCommandMethods(source);
            ExecuteCommandMethods(source);
            SetParametrsMethod(source);

            End();
        }

        private void Start(
            DbQuery source
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

        private void ExecuteMethods(DbQuery source)
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

        private void ScalarMethod(DbQuery source)
        {
            StartScalarMethod(source, MethodType.Sync);
            QueryMethodParametrs(source);
            EndMethodParametrs();
            ScalarMethodBody(source, MethodType.Sync);
            EndMethod();
        }

        private void ScalarMethodAsync(DbQuery source)
        {
            StartScalarMethod(source, MethodType.Async);
            QueryMethodParametrs(source);
            AsyncEndMethodParametrs(false);
            ScalarMethodBody(source, MethodType.Async);
            EndMethod();
        }

        private void NonQueryMethod(DbQuery source)
        {
            StartNonQueryMethod(source, MethodType.Sync);
            QueryMethodParametrs(source);
            EndMethodParametrs();
            NonQueryMethodBody(source, MethodType.Sync);
            EndMethod();
        }

        private void NonQueryMethodAsync(DbQuery source)
        {
            StartNonQueryMethod(source, MethodType.Async);
            QueryMethodParametrs(source);
            AsyncEndMethodParametrs(false);
            NonQueryMethodBody(source, MethodType.Async);
            EndMethod();
        }

        private void ReadMethod(DbQuery source)
        {
            StartReadMethod(source, MethodType.Sync);
            QueryMethodParametrs(source);
            EndMethodParametrs();
            ReadMethodBody(source, MethodType.Sync);
            EndMethod();
        }

        private void ReadAsyncMethod(DbQuery source)
        {
            StartReadMethod(source, MethodType.Async);
            QueryMethodParametrs(source);
            AsyncEndMethodParametrs(true);
            ReadMethodBody(source, MethodType.Async);
            EndMethod();
        }

        private void ExecuteCommandMethods(DbQuery source)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    StartExecuteCommand(source, MethodType.Sync);
                    ExecuteCommand(source, MethodType.Sync);
                    EndMethod();
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    StartExecuteCommand(source, MethodType.Async);
                    ExecuteCommand(source, MethodType.Async);
                    EndMethod();
                }
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                if (source.MethodType.HasFlag(MethodType.Sync))
                {
                    StartExecuteScalarCommand(source, MethodType.Sync);
                    ExecuteScalarCommand(source, MethodType.Sync);
                    EndMethod();
                }

                if (source.MethodType.HasFlag(MethodType.Async))
                {
                    StartExecuteScalarCommand(source, MethodType.Async);
                    ExecuteScalarCommand(source, MethodType.Async);
                    EndMethod();
                }
            }
        }

        private void CreateCommandMethods(DbQuery source)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                CreateCommandMethod(source, MethodType.Sync);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                CreateCommandMethod(source, MethodType.Async);
            }
        }

        private void StartReadMethod(
            DbQuery source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"        
        public static IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> {source.MethodName}(
");
            }
            else
            {
                _methodCode.Append($@"        
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> {source.MethodName}Async(
");
            }
        }

        private string GetScalarTypeName(DbQuery source)
        {
            if (source.Aliases.IsRowsAffected)
            {
                return "System.Int32";
            }

            if (source.MapTypeName.IsKnownProviderType())
            {
                return source.MapTypeName.GetFullTypeName();
            }

            var firstField = source.Aliases.GetFirstFieldInQuery();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }

        private void StartScalarMethod(
            DbQuery source,
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

        private void StartNonQueryMethod(
            DbQuery source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"        
        public static System.Int32 NonQuery{source.MethodName}(
");
            }
            else
            {
                _methodCode.Append($@"        
        public static async Task<System.Int32> NonQuery{source.MethodName}Async(
");
            }
        }

        private void QueryMethodParametrs(DbQuery source)
        {
            _methodCode.Append($@"
            this DbConnection connection
");
            if (source.HaveParametrs())
            {
                for (int i = 0; i < source.Parametrs.Length; i++)
                {
                    var parametr = source.Parametrs[i];
                    _methodCode.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}
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

        private void AsyncEndMethodParametrs(bool enumerator)
        {
            _methodCode.Append($@",
            int? timeout = null,
            {(enumerator ? "[EnumeratorCancellation] " : "")}CancellationToken cancellationToken = default
        )
        {{
");
        }

        private void StartExecuteCommand(
            DbQuery source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"
        public static IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}Command(this DbCommand command)
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}CommandAsync(
            this DbCommand command,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        private void StartExecuteScalarCommand(
            DbQuery source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"        
        public static {GetScalarTypeName(source)} Scalar{source.MethodName}Command(this DbCommand command)
        {{
");
            }
            else
            {
                _methodCode.Append($@"        
        public static async Task<{GetScalarTypeName(source)}> Scalar{source.MethodName}CommandAsync(
            this DbCommand command,
            CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        private void ExecuteScalarCommand(DbQuery source, MethodType methodType)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            _methodCode.Append($@"
            return ({GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
");
        }

        private void ExecuteCommand(DbQuery source, MethodType methodType)
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
                reader = {await}command.ExecuteReader{async};
                while ({await}reader.Read{async})
                {{
");
            YieldItem(source);
            _methodCode.Append($@"
                }}

                while ({await}reader.NextResult{async})
                {{
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

        private void ScalarMethodBody(
            DbQuery source,
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

            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync(connection, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Command(connection, false, timeout)"
                ;

            _methodCode.Append($@"
            DbCommand command = null;
            try
            {{
                command = {createCommand};
");
            if (source.HaveParametrs())
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
                return ({GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
            }}
            finally
            {{
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}

                if(command != null)
                {{
                    command.Parameters.Clear();
                    {await}command.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }

        private void NonQueryMethodBody(
            DbQuery source,
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

            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync(connection, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Command(connection, false, timeout)"
                ;

            _methodCode.Append($@"
            DbCommand command = null;
            try
            {{
                command = {createCommand};
");
            if (source.HaveParametrs())
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
                return {await}command.ExecuteNonQuery{async};
            }}
            finally
            {{
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}

                if(command != null)
                {{
                    command.Parameters.Clear();
                    {await}command.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }

        private void ReadMethodBody(
            DbQuery source,
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

            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync(connection, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Command(connection, false, timeout)"
                ;

            _methodCode.Append($@"
            DbCommand command = null;
            DbDataReader reader = null;
            try
            {{
                command = {createCommand};
");
            if (source.HaveParametrs())
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

                while ({await}reader.NextResult{async})
                {{
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
                
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}

                if(command != null)
                {{
                    command.Parameters.Clear();
                    {await}command.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }

        private void CreateCommandMethod(
            DbQuery source,
            MethodType methodType
            )
        {
            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  {(methodType == MethodType.Async ? "async Task<DbCommand>" : "DbCommand")} Create{source.MethodName}Command{(methodType == MethodType.Async ? "Async" : "")}(
            this DbConnection connection,
            bool prepare = false
");
            if (methodType == MethodType.Async)
            {
                _methodCode.Append($@",
            CancellationToken cancellationToken = default
");
            }

            _methodCode.Append($@",
            int? timeout = null
        )
        {{
            var command = connection.CreateCommand();
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
            var parametr{i} = command.CreateParameter();
");

                    if (parametr.HaveDbType)
                    {
                        _methodCode.Append($@"
            parametr{i}.DbType = (System.Data.DbType){parametr.DbType};
");
                    }

                    if (parametr.HaveName)
                    {
                        _methodCode.Append($@"
            parametr{i}.ParameterName = ""{parametr.Name}"";
");
                    }

                    if (parametr.HaveSize)
                    {
                        _methodCode.Append($@"
            parametr{i}.Size = {parametr.Size};
");
                    }

                    if (parametr.Nullable)
                    {
                        _methodCode.Append($@"
            parametr{i}.IsNullable = true;
");
                    }

                    if (parametr.Direction != System.Data.ParameterDirection.Input)
                    {
                        _methodCode.Append($@"
            parametr{i}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
                    }

                    _methodCode.Append($@"
            command.Parameters.Add(parametr{i});
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
            DbQuery source
            )
        {
            if (!source.HaveParametrs())
            {
                return;
            }

            _methodCode.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static  void Set{source.MethodName}Parametrs(
            this DbCommand command
");
            for (int i = 0; i < source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                _methodCode.Append($@",
            in {parametr.Type.GetFullTypeName(true)} {parametr.VariableName()}
");
            }

            _methodCode.Append($@"
        )
        {{
");
            for (int i = 0; i < source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                if (parametr.Type.IsNullableType())
                {
                    _methodCode.Append($@"
            if({parametr.VariableName()}.HasValue)
            {{
                (command.Parameters[{i}]).Value = {parametr.VariableName()}.Value;
            }}
            else
            {{
                (command.Parameters[{i}]).Value = DBNull.Value;
            }}
");
                }
                else
                {
                    _methodCode.Append($@"
            (command.Parameters[{i}]).Value = {parametr.VariableName()};
");
                }

            }

            _methodCode.Append($@"
        }}
");

        }

        private void YieldItem(
            DbQuery source
            )
        {
            if (source.MapTypeName.IsKnownProviderType())
            {
                _methodCode.Append($@"
                    yield return reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if (source.MapTypeName.IsNullableType())
            {
                _methodCode.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        yield return ({source.MapTypeName.GetFullTypeName(true)})null;
                    }}
                    else
                    {{
                        yield return reader.GetFieldValue<{source.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>(0);
                    }}
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
    }
}
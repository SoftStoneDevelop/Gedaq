using Gedaq.DbConnection.Generators;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Linq;
using System.Reflection.Metadata;

namespace Gedaq.Npgsql.Generators
{
    internal class QueryGenerator : QueryBaseGenerator
    {
        public void GenerateMethod(QueryReadNpgsql source)
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
            QueryReadNpgsql source
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

        private void ExecuteMethods(QueryReadNpgsql source)
        {
            if (source.QueryType.HasFlag(QueryType.Read))
            {
                ThrowExceptionIfOutCannotExist(source);
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
                    ThrowExceptionIfOutCannotExist(source);
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
                    ThrowExceptionIfOutCannotExist(source);
                    NonQueryMethodAsync(source);
                }
            }
        }

        private void ScalarMethod(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethodParametrs();
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync, QueryType.Scalar);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                EndMethodParametrs();
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync, QueryType.Scalar);
                EndMethod();
            }
        }

        private void ScalarMethodAsync(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Async);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                AsyncEndMethodParametrs(false);
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async, QueryType.Scalar);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                AsyncEndMethodParametrs(false);
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async, QueryType.Scalar);
                EndMethod();
            }
        }

        private void NonQueryMethod(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Sync);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethodParametrs();
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync, QueryType.NonQuery);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                EndMethodParametrs();
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync, QueryType.NonQuery);
                EndMethod();
            }
        }

        private void NonQueryMethodAsync(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                AsyncEndMethodParametrs(false);
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async, QueryType.NonQuery);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                AsyncEndMethodParametrs(false);
                NonQueryMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async, QueryType.NonQuery);
                EndMethod();
            }
        }

        private void ReadMethod(QueryReadNpgsql source)
        {
            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Sync);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                EndMethodParametrs();
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Sync);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
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
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection);
                AsyncEndMethodParametrs(true);
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlConnection, MethodType.Async);
                EndMethod();
            }

            if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Async);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource);
                AsyncEndMethodParametrs(true);
                ReadMethodBody(source, Enums.NpgsqlSourceType.NpgsqlDataSource, MethodType.Async);
                EndMethod();
            }
        }

        private void ExecuteCommandMethods(QueryReadNpgsql source)
        {
            if(source.QueryType.HasFlag(QueryType.Read))
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

            if (source.QueryType.HasFlag(QueryType.NonQuery) && source.Parametrs.Any(a => a.Direction != System.Data.ParameterDirection.Input))
            {
                //TODO
            }
        }

        private void CreateCommandMethods(QueryReadNpgsql source)
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
            }
        }

        private void StartReadMethod(
            QueryReadNpgsql source,
            MethodType methodType
            )
        {
            if(methodType == MethodType.Sync)
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

        private string GetScalarTypeName(QueryReadNpgsql source)
        {
            if(source.Aliases.IsRowsAffected)
            {
                return "System.Int32";
            }

            if (MapTypeHelper.IsKnownProviderType(source.MapTypeName))
            {
                return source.MapTypeName.GetFullTypeName();
            }

            var firstField = source.Aliases.GetFirstFieldInQuery();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }

        private void StartScalarMethod(
            QueryReadNpgsql source,
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
            QueryReadNpgsql source,
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

        private void QueryMethodParametrs(
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
                    if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                    {
                        _methodCode.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");
                    }

                    WriteOutParametrs(parametr);
                }
            }
        }

        private void WriteOutParametrs(NpgsqlParametr parametr)
        {
            if (parametr.Direction == System.Data.ParameterDirection.InputOutput || parametr.Direction == System.Data.ParameterDirection.Output)
            {
                _methodCode.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Output))}
");
                return;
            }

            if (parametr.Direction == System.Data.ParameterDirection.ReturnValue)
            {
                _methodCode.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.ReturnValue))}
");
                return;
            }
        }

        private void ThrowExceptionIfOutCannotExist(QueryReadNpgsql source)
        {
            if (source.Parametrs.Any(an => an.Direction != System.Data.ParameterDirection.Input))
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
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
            QueryReadNpgsql source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"
        public static IEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}Command(this NpgsqlCommand command)
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        public static async IAsyncEnumerable<{source.MapTypeName.GetFullTypeName(true)}> Execute{source.MethodName}CommandAsync(
            this NpgsqlCommand command,
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }


        }

        private void StartExecuteScalarCommand(
            QueryReadNpgsql source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                _methodCode.Append($@"        
        public static {GetScalarTypeName(source)} Scalar{source.MethodName}Command(
            this NpgsqlCommand command
");
                if(source.HaveParametrs())
                {
                    for (int i = 0; i < source.Parametrs.Length; i++)
                    {
                        var parametr = source.Parametrs[i];
                        WriteOutParametrs(parametr);
                    }
                }
                _methodCode.Append($@"
        )
        {{
");
            }
            else
            {
                _methodCode.Append($@"        
        public static async Task<{GetScalarTypeName(source)}> Scalar{source.MethodName}CommandAsync(
            this NpgsqlCommand command,
            CancellationToken cancellationToken = default
            )
        {{
");
            }
        }

        private void ExecuteScalarCommand(QueryReadNpgsql source, MethodType methodType)
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            _methodCode.Append($@"
            var result = ({GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
");
            if (source.HaveParametrs())
            {
                SetOutAndReturnParametrs(source);
            }

            _methodCode.Append($@"
            return result;
");
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

        private void NonQueryMethodBody(
            QueryReadNpgsql source,
            Enums.NpgsqlSourceType sourceType,
            MethodType methodType,
            QueryType queryType
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
            try
            {{
                command = {createCommand};
");
            if (source.HaveParametrs())
            {
                WriteSetParametrs(source);
            }

            if(queryType == QueryType.Scalar)
            {
                _methodCode.Append($@"
                var result = ({GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
");
            }
            else
            {
                _methodCode.Append($@"
                var result = {await}command.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs())
            {
                SetOutAndReturnParametrs(source);
            }

            _methodCode.Append($@"
                return result;
            }}
            finally
            {{
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

        private void SetOutAndReturnParametrs(QueryReadNpgsql source)
        {
            for (int i = 0; i < source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                {
                    _methodCode.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = {GetParametrValue(parametr, i, "command")};
");
                }


            }
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
                WriteSetParametrs(source);
            }
            _methodCode.Append($@"
                reader = {await}command.ExecuteReader{async};
");
            if(source.HaveParametrs())
            {
                SetOutAndReturnParametrs(source);
            }

            _methodCode.Append($@"
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

        private void WriteSetParametrs(QueryReadNpgsql source)
        {
            _methodCode.Append($@"
                command.Set{source.MethodName}Parametrs(
");
            for (int i = 0; i < source.Parametrs.Length; i++)
            {
                var parametr = source.Parametrs[i];
                if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                {
                    continue;
                }

                _methodCode.Append($@"
                    in {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
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

                    if(parametr.Type.IsNullableType())
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
                if(parametr.Type.IsNullableType())
                {
                    _methodCode.Append($@"
            if({parametr.VariableName()}.HasValue)
            {{
                {GetParametrValue(parametr,i, "command")} = {parametr.VariableName()}.Value;
            }}
            else
            {{
                {GetParametrValue(parametr, i, "command")} = DBNull.Value;
            }}
");
                }
                else
                {
                    _methodCode.Append($@"
                {GetParametrValue(parametr, i, "command")} = {parametr.VariableName()};
");
                }

            }

            _methodCode.Append($@"
        }}
");

        }

        protected string GetParametrValue(NpgsqlParametr parametr, int index, string source)
        {
            if (parametr.Type.IsNullableType())
            {
                return $"((NpgsqlParameter){source}.Parameters[{index}]).Value";
            }
            else
            {
                return $"((NpgsqlParameter<{parametr.Type.GetFullTypeName()}>){source}.Parameters[{index}]).TypedValue";
            }
        }

        private void YieldItem(
            QueryReadNpgsql source
            )
        {
            if (MapTypeHelper.IsKnownProviderType(source.MapTypeName))
            {
                _methodCode.Append($@"
                    yield return reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if(source.MapTypeName.IsNullableType())
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
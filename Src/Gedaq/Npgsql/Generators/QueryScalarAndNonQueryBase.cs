﻿using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal abstract class QueryScalarAndNonQueryBase : QueryCommonGenerator
    {
        protected virtual string CommandType()
        {
            return "DbCommand";
        }

        public void ScalarGenerate(QueryBase source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                NpgsqlQueryCommon.ThrowExceptionIfOutCannotExist(source);
                ScalarMethodAsync(source, builder);
            }
        }

        public void NonQueryGenerate(QueryBase source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                NpgsqlQueryCommon.ThrowExceptionIfOutCannotExist(source);
                NonQueryMethodAsync(source, builder);
            }
        }

        protected virtual void NonQueryMethod(QueryBase source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(source, "DbConnection", "connection", builder);
            EndMethodParametrs(builder);
            MethodBody(source, true, "connection", MethodType.Sync, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBase source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(source, "DbConnection", "connection", builder);
            AsyncEndMethodParametrs(builder);
            MethodBody(source, true, "connection", MethodType.Async, QueryType.NonQuery, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethod(QueryBase source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(source, "DbConnection", "connection", builder);
            EndMethodParametrs(builder);
            MethodBody(source, true, "connection", MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBase source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(source, "DbConnection", "connection", builder);
            AsyncEndMethodParametrs(builder);
            MethodBody(source, true, "connection", MethodType.Async, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected void StartNonQueryMethod(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static System.Int32 NonQuery{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async Task<System.Int32> NonQuery{source.MethodName}Async(
");
            }
        }

        protected void StartScalarMethod(
            QueryBase source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        public static {NpgsqlQueryCommon.GetScalarTypeName(source)} Scalar{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        public static async Task<{NpgsqlQueryCommon.GetScalarTypeName(source)}> Scalar{source.MethodName}Async(
");
            }
        }

        protected void QueryMethodParametrs(
            QueryBase source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder
            )
        {
            builder.Append($@"
            this {sourceTypeName} {sourceParametrName}
");
            if (source.HaveParametrs())
            {
                var index = -1;
                foreach (var parametr in source.BaseParametrs())
                {
                    ++index;
                    if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                    {
                        builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");
                    }

                    NpgsqlQueryCommon.WriteOutParametrs(parametr, builder);
                }
            }
        }

        protected void EndMethodParametrs(StringBuilder builder)
        {
            builder.Append($@",
            int? timeout = null
        )
        {{
");
        }

        protected void AsyncEndMethodParametrs(StringBuilder builder)
        {
            builder.Append($@",
            int? timeout = null,
            CancellationToken cancellationToken = default
        )
        {{
");
        }

        protected void EndMethod(StringBuilder builder)
        {
            builder.Append($@"
        }}
");
        }

        protected void MethodBody(
            QueryBase source,
            bool needCheckOpen,
            string sourceParametrName,
            MethodType methodType,
            QueryType queryType,
            StringBuilder builder
            )
        {
            var await = methodType == MethodType.Async ? "await " : "";
            var async = methodType == MethodType.Async ? "Async(cancellationToken).ConfigureAwait(false)" : "()";
            var disposeOrCloseAsync = methodType == MethodType.Async ? "Async().ConfigureAwait(false)" : "()";

            if (needCheckOpen)
            {
                builder.Append($@"
            bool needClose = {sourceParametrName}.State == ConnectionState.Closed;
            if(needClose)
            {{
                {await}{sourceParametrName}.Open{async};
            }}
");
            }
            var createCommand =
                methodType == MethodType.Async ?
                $"await Create{source.MethodName}CommandAsync({sourceParametrName}, false, cancellationToken, timeout)" :
                $"Create{source.MethodName}Command({sourceParametrName}, false, timeout)"
                ;
            builder.Append($@"
            {CommandType()} command = null;
            try
            {{
                command = {createCommand};
");
            if (source.HaveParametrs())
            {
                NpgsqlQueryCommon.WriteSetParametrs(source, builder);
            }

            if (queryType == QueryType.Scalar)
            {
                builder.Append($@"
                var result = ({NpgsqlQueryCommon.GetScalarTypeName(source)}){await}command.ExecuteScalar{async};
");
            }
            else
            {
                builder.Append($@"
                var result = {await}command.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs())
            {
                NpgsqlQueryCommon.SetOutAndReturnParametrs(source, builder, this);
            }

            builder.Append($@"
                return result;
            }}
            finally
            {{
");

            if (needCheckOpen)
            {
                builder.Append($@"
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}
");
            }
            builder.Append($@"
                if(command != null)
                {{
                    command.Parameters.Clear();
                    {await}command.Dispose{disposeOrCloseAsync};
                }}
            }}
");
        }
    }
}
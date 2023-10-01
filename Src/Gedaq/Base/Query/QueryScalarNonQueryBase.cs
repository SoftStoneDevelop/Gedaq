using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System;
using System.Text;

namespace Gedaq.Base.Query
{
    internal abstract class QueryScalarNonQueryBase
    {
        private readonly CommandGeneratorBase _commandGenerator;

        public QueryScalarNonQueryBase(CommandGeneratorBase commandGenerator)
        {
            _commandGenerator = commandGenerator;
        }

        protected abstract ProviderInfo ProviderInfo { get; }

        public void ScalarGenerate(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                ScalarMethodAsync(source, builder);
            }
        }

        public void NonQueryGenerate(QueryBaseCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                NonQueryMethodAsync(source, builder);
            }
        }

        protected virtual void NonQueryMethod(QueryBaseCommand source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(), 
                builder,
                true
                );
            EndMethodParametrs(builder, MethodType.Sync);
            MethodBody(
                source, 
                true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Sync, 
                QueryType.NonQuery, 
                builder
                );
            EndMethod(builder);
        }

        protected virtual void NonQueryMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            StartNonQueryMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(), 
                builder,
                false
                );
            EndMethodParametrs(builder, MethodType.Async);
            MethodBody(
                source, 
                true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Async, 
                QueryType.NonQuery, 
                builder
                );
            EndMethod(builder);
        }

        protected virtual void ScalarMethod(QueryBaseCommand source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Sync, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(),
                builder,
                true
                );
            EndMethodParametrs(builder, MethodType.Sync);
            MethodBody(source, true, "connection", MethodType.Sync, QueryType.Scalar, builder);
            EndMethod(builder);
        }

        protected virtual void ScalarMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            StartScalarMethod(source, MethodType.Async, builder);
            QueryMethodParametrs(
                source, 
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(),
                builder,
                false
                );
            EndMethodParametrs(builder, MethodType.Async);
            MethodBody(
                source, 
                true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Async, 
                QueryType.Scalar, 
                builder
                );
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
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} System.Int32 {(((int)source.QueryType).IsPowerOfTwo() ? "" : "NonQuery")}{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async {source.MethodInfo.AsyncResultType.ToResultType()}<System.Int32> {(((int)source.QueryType).IsPowerOfTwo() ? "" : "NonQuery")}{source.MethodName}Async(
");
            }
        }

        protected void StartScalarMethod(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder
            )
        {
            _commandGenerator.GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            if (methodType == MethodType.Sync)
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} {typeName} {(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}(
");
            }
            else
            {
                builder.Append($@"        
        {source.AccessModifier.ToLowerInvariant()} {source.MethodStaticModifier} async {source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}> {(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}Async(
");
            }
        }

        protected void QueryMethodParametrs(
            QueryBaseCommand source,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder,
            bool useInAndOut
            )
        {
            builder.Append($@"
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}
");
            _commandGenerator.AddParametrs(source, builder, useInAndOut);
            _commandGenerator.AddFormatParametrs(source, builder);
        }

        protected void EndMethodParametrs(StringBuilder builder, MethodType methodType)
        {
            builder.Append($@",
            int? timeout = null
");
            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null
");
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default
");
            }

            builder.Append($@"
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
            QueryBaseCommand source,
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

            builder.Append($@"
            {ProviderInfo.CommandType()} command = null;
            try
            {{
                command =
");
            _commandGenerator.CreateCommand(source, sourceParametrName, methodType, builder);

            if(source.ContainTypeName.GCIsStatic())
            {
                builder.Append($@"
                ;
                command.{_commandGenerator.SetParametrsMethodName(source)}(
");
            }
            else
            {
                builder.Append($@"
                ;
                {_commandGenerator.SetParametrsMethodName(source)}(
                    command
");
            }
            _commandGenerator.WriteSetParametrs(source, builder, ProviderInfo);
            builder.Append($@"
                    );
");
            _commandGenerator.GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
            if (queryType == QueryType.Scalar)
            {
                if (isRowAffected || (!typeSymbol.IsNullableType() && !typeSymbol.IsReferenceType))
                {
                    builder.Append($@"
            {typeName} result = ({typeName}){await}command.ExecuteScalar{async};
");
                }
                else
                {
                    builder.Append($@"
            var scalarResult = {await}command.ExecuteScalar{async};
            {typeName} result;
            if(scalarResult == null || scalarResult == DBNull.Value)
            {{
                result = null;
            }}
            else
            {{
                result = ({typeName})scalarResult;
            }}
");
                }
            }
            else
            {
                builder.Append($@"
                var result = ({typeName}){await}command.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs())
            {
                _commandGenerator.SetOutAndReturnParametrs(source, builder, ProviderInfo);
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
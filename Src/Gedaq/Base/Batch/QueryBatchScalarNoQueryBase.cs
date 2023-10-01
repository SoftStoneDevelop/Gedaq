using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using System;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class QueryBatchScalarNoQueryBase
    {
        private readonly BatchCommandBase _commandGenerator;

        public QueryBatchScalarNoQueryBase(BatchCommandBase commandGenerator)
        {
            _commandGenerator = commandGenerator;
        }

        protected abstract ProviderInfo ProviderInfo { get; }

        public void GenerateScalar(QueryBatchCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ScalarMethodAsync(source, builder);
            }
        }

        public void GenerateNonQuery(QueryBatchCommand source, StringBuilder builder)
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                NonQueryMethodAsync(source, builder);
            }
        }

        protected virtual void ScalarMethod(QueryBatchCommand source, StringBuilder builder)
        {
            ScalarMethodDefinition(
                source, 
                MethodType.Sync,
                ProviderInfo.DefaultSourceType(), 
                ProviderInfo.DefaultSourceTypeParametr(),
                builder
                );
            MethodBody(
                source,
                needCheckOpen: true, 
                ProviderInfo.DefaultSourceTypeParametr(), 
                MethodType.Sync, 
                QueryType.Scalar, 
                builder
                );
        }

        protected virtual void ScalarMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            ScalarMethodDefinition(
                source,
                MethodType.Async,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                builder
                );
            MethodBody(
                source,
                needCheckOpen: true,
                ProviderInfo.DefaultSourceTypeParametr(),
                MethodType.Async,
                QueryType.Scalar,
                builder
                );
        }

        protected virtual void NonQueryMethod(QueryBatchCommand source, StringBuilder builder)
        {
            NonQueryMethodDefinition(
                source,
                MethodType.Sync,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                builder
                );
            MethodBody(
                source,
                needCheckOpen: true,
                ProviderInfo.DefaultSourceTypeParametr(),
                MethodType.Sync,
                QueryType.NonQuery,
                builder
                );
        }

        protected virtual void NonQueryMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            NonQueryMethodDefinition(
                source,
                MethodType.Async,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                builder
                );
            MethodBody(
                source,
                needCheckOpen: true,
                ProviderInfo.DefaultSourceTypeParametr(),
                MethodType.Async,
                QueryType.NonQuery,
                builder
                );
        }

        public string ScalarMethodName(
            QueryBatchCommand source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                return $"{(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}";
            }
            else
            {
                return $"{(((int)source.QueryType).IsPowerOfTwo() ? "" : "Scalar")}{source.MethodName}Async";
            }
        }

        public void ScalarMethodDefinition(
            QueryBatchCommand source,
            MethodType methodType,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            _commandGenerator.GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            var returnType = methodType == MethodType.Sync ? $"{source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}>" : typeName;
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword} {typeName} {ScalarMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            _commandGenerator.AddMethodParametrs(source, builder);

            builder.Append($@",
            int? timeout = null");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null");
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@"
        )
");
        }

        public string NonQueryMethodName(
            QueryBatchCommand source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                return $"{(((int)source.QueryType).IsPowerOfTwo() ? "" : "NonQuery")}{source.MethodName}";
            }
            else
            {
                return $"{(((int)source.QueryType).IsPowerOfTwo() ? "" : "NonQuery")}{source.MethodName}Async";
            }
        }

        public void NonQueryMethodDefinition(
            QueryBatchCommand source,
            MethodType methodType,
            string sourceTypeName,
            string sourceParametrName,
            StringBuilder builder,
            bool forInterface = false
            )
        {
            var returnType = methodType == MethodType.Sync ? $"System.Int32" : $"{source.MethodInfo.AsyncResultType.ToResultType()}<System.Int32>";
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;

            builder.Append($@"        
        {accessModifier} {staticModifier} {asyncKeyword} {returnType} {NonQueryMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            _commandGenerator.AddMethodParametrs(source, builder);

            builder.Append($@",
            int? timeout = null");

            if (ProviderInfo.CanSetTransaction)
            {
                builder.Append($@",
            {ProviderInfo.TransactionType()} transaction = null");
            }

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");
            }

            builder.Append($@"
        )
");
        }

        protected void MethodBody(
            QueryBatchCommand source,
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
            builder.Append($@"
        {{");

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
            {ProviderInfo.BatchType()} batch = null;
            try
            {{
                batch =
");
            _commandGenerator.CreateCommand(source, sourceParametrName, methodType, builder);

            builder.Append($@"
                ;
");
            _commandGenerator.WriteSetParametrs(source, builder, ProviderInfo);

            _commandGenerator.GetScalarType(source, ProviderInfo, out var typeSymbol, out var isRowAffected, out var typeName);
            if (queryType == QueryType.Scalar)
            {
                if (isRowAffected || (!typeSymbol.IsNullableType() && !typeSymbol.IsReferenceType))
                {
                    builder.Append($@"
            {typeName} result = ({typeName}){await}batch.ExecuteScalar{async};
");
                }
                else
                {
                    builder.Append($@"
            var scalarResult = {await}batch.ExecuteScalar{async};
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
                var result = ({typeName}){await}batch.ExecuteNonQuery{async};
");
            }

            if (source.HaveParametrs)
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
                if(batch != null)
                {{
                    batch.BatchCommands.Clear();
                    {await}batch.Dispose{disposeOrCloseAsync};
                }}
            }}
        }}
");
        }
    }
}

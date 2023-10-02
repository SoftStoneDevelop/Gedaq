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

        public void ScalarGenerate(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ScalarMethod(source, builder, interfaceGenerator);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                ScalarMethodAsync(source, builder, interfaceGenerator);
            }
        }

        public void NonQueryGenerate(
            QueryBaseCommand source, 
            StringBuilder builder, 
            InterfaceGenerator interfaceGenerator
            )
        {
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                NonQueryMethod(source, builder, interfaceGenerator);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
                NonQueryMethodAsync(source, builder, interfaceGenerator);
            }
        }

        protected virtual void NonQueryMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            NonQueryMethodInner(
                source,
                MethodType.Sync,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                useInAndOut: true,
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        protected virtual void NonQueryMethodAsync(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            NonQueryMethodInner(
                source, 
                MethodType.Async, 
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                useInAndOut: false,
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        protected virtual void ScalarMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ScalarMethodInner(
                source,
                MethodType.Sync,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                useInAndOut: true,
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        protected virtual void ScalarMethodAsync(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ScalarMethodInner(
                source, 
                MethodType.Async, 
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                useInAndOut: false,
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        public string NonQueryMethodName(
            QueryBase source,
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

        public void NonQueryMethodInner(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool useInAndOut,
            bool needCheckOpen,
            InterfaceGenerator interfaceGenerator
            )
        {
            NonQueryMethodDefinition(
                    source,
                    methodType,
                    builder,
                    sourceTypeName,
                    sourceParametrName,
                    useInAndOut: useInAndOut
                    );
            if (source.AsPartInterface)
            {
                NonQueryMethodDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    sourceTypeName,
                    sourceParametrName,
                    useInAndOut: useInAndOut,
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            MethodBody(
                source,
                needCheckOpen: needCheckOpen,
                sourceParametrName,
                methodType,
                QueryType.NonQuery,
                builder
                );
        }

        private void NonQueryMethodDefinition(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool useInAndOut,
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

            _commandGenerator.AddParametrs(source, builder, useInAndOut);
            _commandGenerator.AddFormatParametrs(source, builder);

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
        )");

        }

        public string ScalarMethodName(
            QueryBase source,
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

        public void ScalarMethodInner(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool useInAndOut,
            bool needCheckOpen,
            InterfaceGenerator interfaceGenerator
            )
        {
            ScalarMethodDefinition(
                    source,
                    methodType,
                    builder,
                    sourceTypeName,
                    sourceParametrName,
                    useInAndOut: useInAndOut
                    );
            if (source.AsPartInterface)
            {
                ScalarMethodDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    sourceTypeName,
                    sourceParametrName,
                    useInAndOut: useInAndOut,
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            MethodBody(
                source,
                needCheckOpen: needCheckOpen,
                sourceParametrName,
                methodType,
                QueryType.Scalar,
                builder
                );
        }

        private void ScalarMethodDefinition(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool useInAndOut,
            bool forInterface = false
            )
        {
            _commandGenerator.GetScalarType(source, ProviderInfo, out _, out _, out var typeName);
            var returnType = methodType == MethodType.Sync ? typeName : $"{source.MethodInfo.AsyncResultType.ToResultType()}<{typeName}>";
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;

            builder.Append($@"        
        {accessModifier} {staticModifier} {asyncKeyword} {returnType} {ScalarMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            _commandGenerator.AddParametrs(source, builder, useInAndOut);
            _commandGenerator.AddFormatParametrs(source, builder);

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
            )");
        }

        private void MethodBody(
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
        }}
");
        }
    }
}
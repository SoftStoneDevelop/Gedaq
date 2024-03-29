﻿using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.Enums;
using Gedaq.Helpers;
using System.Text;

namespace Gedaq.Base.Query
{
    internal abstract class QueryReadBase
    {
        private readonly CommandGeneratorBase _commandGenerator;

        public QueryReadBase(CommandGeneratorBase commandGenerator)
        {
            _commandGenerator = commandGenerator;
        }

        protected abstract ProviderInfo ProviderInfo { get; }

        public void Generate(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            QueryCommonBase.ThrowExceptionIfOutCannotExist(source);
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                ReadMethod(source, builder, interfaceGenerator);
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                ReadAsyncMethod(source, builder, interfaceGenerator);
            }
        }

        protected virtual void ReadMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ReadMethodInner(
                source,
                MethodType.Sync,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        protected virtual void ReadAsyncMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            ReadMethodInner(
                source,
                MethodType.Async,
                builder,
                ProviderInfo.DefaultSourceType(),
                ProviderInfo.DefaultSourceTypeParametr(),
                needCheckOpen: true,
                interfaceGenerator
                );
        }

        public string ReadMethodName(
            QueryBase source,
            MethodType methodType
            )
        {
            if (methodType == MethodType.Sync)
            {
                return $"{source.MethodName}";
            }
            else
            {
                return $"{source.MethodName}Async";
            }
        }

        protected void ReadMethodInner(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool needCheckOpen,
            InterfaceGenerator interfaceGenerator
            )
        {
            ReadMethodDefinition(
                source,
                methodType,
                builder,
                sourceTypeName,
                sourceParametrName
                );
            if (source.AsPartInterface)
            {
                ReadMethodDefinition(
                    source,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    sourceTypeName,
                    sourceParametrName,
                    forInterface: true
                    );
                interfaceGenerator.AddMethodDefinition();
            }
            ReadMethodBody(
                source,
                needCheckOpen: needCheckOpen,
                sourceParametrName,
                methodType,
                builder
                );
        }

        private void ReadMethodDefinition(
            QueryBaseCommand source,
            MethodType methodType,
            StringBuilder builder,
            string sourceTypeName,
            string sourceParametrName,
            bool forInterface = false
            )
        {
            string ExecuteCommandReturnType()
            {
                switch (source.ReturnType)
                {
                    case ReturnType.Enumerable:
                    {
                        return methodType == MethodType.Async ?
                            $"IAsyncEnumerable<{_commandGenerator.ItemTypeName(source)}>" :
                            $"IEnumerable<{_commandGenerator.ItemTypeName(source)}>"
                            ;
                    }
                    case ReturnType.Single:
                    case ReturnType.SingleOrDefault:
                    case ReturnType.First:
                    case ReturnType.FirstOrDefault:
                    default:
                    {
                        return methodType == MethodType.Async ?
                            $"{source.MethodInfo.AsyncResultType.ToResultType()}<{_commandGenerator.ItemTypeName(source)}>" :
                            $"{_commandGenerator.ItemTypeName(source)}"
                            ;
                    }
                }
            }

            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : source.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : source.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async "
                ;

            builder.Append($@"        
        {accessModifier} {staticModifier} {asyncKeyword}{ExecuteCommandReturnType()} {ReadMethodName(source, methodType)}(
            {source.ContainTypeName.GCThisWordOrEmpty()}{sourceTypeName} {sourceParametrName}");

            _commandGenerator.AddParametrs(source, builder, false);
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
                var enumeratorCancellation = forInterface ? string.Empty : "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default");

            }

            builder.Append($@"
        )");

        }

        private void ReadMethodBody(
            QueryBaseCommand source,
            bool needCheckOpen,
            string sourceParametrName,
            MethodType methodType,
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
            }}");

            }
            
            builder.Append($@"
            {ProviderInfo.CommandType()} command = null;
            {ProviderInfo.ReaderType()} reader = null;
            try
            {{
                command =");

            _commandGenerator.CreateCommand(source, sourceParametrName, methodType, builder);

            if(source.ContainTypeName.GCIsStatic())
            {
                builder.Append($@"
                ;
                command.{_commandGenerator.SetParametrsMethodName(source)}(");
            }
            else
            {
                builder.Append($@"
                ;
                {_commandGenerator.SetParametrsMethodName(source)}(
                    command");
            }
            _commandGenerator.WriteSetParametrs(source, builder, ProviderInfo);
            builder.Append($@"
                    );");

            _commandGenerator.ExecuteReader(source, methodType, builder);

            builder.Append($@"
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
                }}");

            if (needCheckOpen)
            {
                builder.Append($@"
                if (needClose)
                {{
                    {await}connection.Close{disposeOrCloseAsync};
                }}");
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
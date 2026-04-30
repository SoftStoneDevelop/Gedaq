using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class BinaryImportGenerator : BaseGenerator
    {
        public BinaryImportGenerator(SourceProductionContext context)
            : base(context)
        {
        }

        public void Generate(
            BinaryImport binaryImport,
            InterfaceGenerator interfaceGenerator)
        {
            Reset();
            Start(binaryImport);
            GenerateMethod(binaryImport, interfaceGenerator);
            EndClass();
            EndNameSpace();
        }

        private void Start(BinaryImport binaryImport)
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

namespace {binaryImport.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(binaryImport.ContainTypeName, binaryImport.MethodInfo, "Npgsql")}
    {{
");
        }

        private void GenerateMethod(BinaryImport binaryImport, InterfaceGenerator interfaceGenerator)
        {
            if (binaryImport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                if(binaryImport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Sync, false, interfaceGenerator);
                }

                if (binaryImport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, false, interfaceGenerator);
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, true, interfaceGenerator);
                }
            }

            if (binaryImport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                if (binaryImport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync, false, interfaceGenerator);
                }

                if (binaryImport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Async, false, interfaceGenerator);
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, true, interfaceGenerator);
                }
            }
        }

        private void GenerateMethod(
            BinaryImport binaryImport,
            NpgsqlSourceType sourceType,
            MethodType methodType,
            bool isAsyncCollection,
            InterfaceGenerator interfaceGenerator)
        {
            MethodDefinition(
                binaryImport, 
                sourceType, 
                methodType, 
                isAsyncCollection, 
                _methodCode, 
                forInterface: false);

            if(binaryImport.AsPartInterface)
            {
                MethodDefinition(
                    binaryImport, 
                    sourceType, 
                    methodType, 
                    isAsyncCollection, 
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true);

                interfaceGenerator.AddMethodDefinition();
            }

            MethodBody(binaryImport, sourceType, methodType, isAsyncCollection);
            EndMethod();
        }

        private void MethodDefinition(
            BinaryImport binaryImport,
            NpgsqlSourceType sourceType,
            MethodType methodType,
            bool isAsyncCollection,
            StringBuilder builder,
            bool forInterface = false)
        {
            var mapType = binaryImport.MapTypeInfos[0].MapType;
            var collectionType = $"I{(isAsyncCollection ? "Async" : "")}Enumerable<{mapType.GetFullTypeName(true, true)}>";
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : binaryImport.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : binaryImport.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            var returnType = methodType == MethodType.Async ? binaryImport.MethodInfo.AsyncResultType.ToResultType() : "void";
            var methodName = methodType == MethodType.Async ? $@"{binaryImport.MethodName}Async" : binaryImport.MethodName;

            builder.Append($@"
        {accessModifier} {staticModifier} {asyncKeyword}{returnType} {methodName}(
            {binaryImport.ContainTypeName.GCThisWordOrEmpty()}{sourceType.ToTypeName()} {sourceType.ToParametrName()},
            {collectionType} collection");

            if (binaryImport.IsDynamicQuery())
            {
                builder.Append($@",
            System.String query");
            }

            builder.Append($@",
            TimeSpan? timeout = null");

            if (methodType == MethodType.Async)
            {
                builder.Append($@",
            CancellationToken cancellationToken = default");

            }

            builder.Append($@")");
        }

        private void MethodBody(
            BinaryImport binaryImport,
            NpgsqlSourceType sourceType,
            MethodType methodType,
            bool isAsyncCollection)
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "cancellationToken" : "";
            _methodCode.Append($@"
        {{");

            if (sourceType == NpgsqlSourceType.NpgsqlDataSource)
            {
                _methodCode.Append($@"
            {NpgsqlSourceType.NpgsqlConnection.ToTypeName()} {NpgsqlSourceType.NpgsqlConnection.ToParametrName()} = {GeneratorHelper.AwaitWord(isAsync)} {sourceType.ToParametrName()}.OpenConnection{GeneratorHelper.AsyncWord(isAsync)}({cancellation});");
            }

            var query = binaryImport.IsDynamicQuery() ?
                "query" :
                $@"@""
{binaryImport.Query}
""";

            _methodCode.Append($@"
            NpgsqlBinaryImporter import = null;
            try
            {{
                import = {GeneratorHelper.AwaitWord(isAsync)}{NpgsqlSourceType.NpgsqlConnection.ToParametrName()}.BeginBinaryImport{GeneratorHelper.AsyncWord(isAsync)}({query}
{(isAsync ? ", cancellationToken" : "")});

                if(timeout.HasValue)
                {{
                    import.Timeout = timeout.Value;
                }}

                {(isAsyncCollection ? GeneratorHelper.AwaitWord(isAsync) : "")}foreach (var item in collection{(isAsyncCollection ? ".WithCancellation(cancellationToken)" : "")})
                {{
                    {GeneratorHelper.AwaitWord(isAsync)}import.StartRow{GeneratorHelper.AsyncWord(isAsync)}({cancellation});");

            WriteItem(binaryImport, methodType);
            _methodCode.Append($@"
                }}
                {GeneratorHelper.AwaitWord(isAsync)}import.Complete{GeneratorHelper.AsyncWord(isAsync)}({cancellation});
                {GeneratorHelper.AwaitWord(isAsync)}import.Dispose{GeneratorHelper.AsyncWord(isAsync)}();
                import = null;
            }}
            finally
            {{
                if(import != null)
                {{
                    try
                    {{
                        {GeneratorHelper.AwaitWord(isAsync)}import.Close{GeneratorHelper.AsyncWord(isAsync)}();
                    }}
                    catch {{ /* ignore */ }}

                    {GeneratorHelper.AwaitWord(isAsync)}import.Dispose{GeneratorHelper.AsyncWord(isAsync)}();
                }}
            }}");
        }

        private static string DbTypeParamPass(Field field)
        {
            return
                field.HaveAdditionalInfo ?
                $",(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType})" :
                string.Empty;
        }

        private static string CtParametrPass(bool isAsync)
        {
            return
                isAsync ?
                $",cancellationToken" :
                string.Empty;
        }

        public void WriteItem(
            BinaryImport binaryImport,
            MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "(cancellationToken)" : "()";

            var mapTypeInfo = binaryImport.MapTypeInfos[0];
            if (NpgsqlMapTypeHelper.IsKnownProviderType(mapTypeInfo.MapType))
            {
                var field = mapTypeInfo.Aliases.Fields()[0];
                var dbType = DbTypeParamPass(field);
                if (mapTypeInfo.MapType.IsNullableType())
                {
                    _methodCode.Append($@"
                    if (!item.HasValue)
                    {{
                        {GeneratorHelper.AwaitWord(isAsync)}import.WriteNull{GeneratorHelper.AsyncWord(isAsync)}{cancellation};
                    }}
                    else
                    {{
                        {GeneratorHelper.AwaitWord(isAsync)}import.Write{GeneratorHelper.AsyncWord(isAsync)}(item.Value{dbType}{CtParametrPass(isAsync)});
                    }}");
                }
                else
                {
                    _methodCode.Append($@"
                    {GeneratorHelper.AwaitWord(isAsync)}import.Write{GeneratorHelper.AsyncWord(isAsync)}(item{dbType}{CtParametrPass(isAsync)});");
                }
            }
            else if (mapTypeInfo.MapType.TypeKind == TypeKind.Class || mapTypeInfo.MapType.TypeKind == TypeKind.Struct)
            {
                ComplicateItem(mapTypeInfo.Aliases, mapTypeInfo.MapType, methodType);
            }
            else
            {
                DiagnosticHelper.ReportDiagnostic(
                    _context,
                    DiagnosticConstants.BICouldNotDetermine,
                    DiagnosticConstants.BICouldNotDetermineDescr,
                    DiagnosticSeverity.Error,
                    new string[] { binaryImport.MethodName, mapTypeInfo.MapType.Name});
            }
        }

        private void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "(cancellationToken)" : "()"; ;

            var aliases = new Stack<ItemPair>();
            var root = new ItemPair(rootAliase, rootMapTypeName, "item", 0);
            aliases.Push(root);
            var needSkip = root.Aliases.AllFields().Length;
            if (rootMapTypeName.IsNullableType())
            {
                _methodCode.Append($@"
                    if(!item.HasValue)
                    {{");
            }
            else if (rootMapTypeName.TypeKind == TypeKind.Class)
            {
                _methodCode.Append($@"
                    if(item == null)
                    {{");
            }

            for (var i = 0; i < needSkip; i++)
            {
                _methodCode.Append($@"
                        {GeneratorHelper.AwaitWord(isAsync)}import.WriteNull{GeneratorHelper.AsyncWord(isAsync)}{cancellation};");
            }

            _methodCode.Append($@"
                        continue;
                    }}
");

            var itemId = 0;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (!pair.HaveUnprocess)
                {
                    //close brackets and set
                    EndInnerEntity(pair, GeneratorHelper.AwaitWord(isAsync), GeneratorHelper.AsyncWord(isAsync), cancellation);
                    continue;
                }

                if (!pair.GetUnprocessFieldOrInnerAlias(out var field, out var inner))
                {
                    throw new InvalidOperationException();
                }

                aliases.Push(pair);

                if (field != null)
                {
                    WriteFields(field, pair, methodType);
                    continue;
                }

                if (inner != null)
                {
                    pair.MapTypeName.GetPropertyOrFieldName(inner.EntityName, out var propertyName, out var pairType);
                    var newPair = 
                        new ItemPair(
                            inner, 
                            pairType, 
                            $"item{++itemId}",
                            pair,
                            propertyName,
                            0);
                    aliases.Push(newPair);

                    _methodCode.Append($@"
                    {GeneratorHelper.Tabs(newPair.Tabs)}if(item.{newPair.PathInItem()} != null)
                    {GeneratorHelper.Tabs(newPair.Tabs)}{{");
                    continue;
                }
            }
        }

        private void EndInnerEntity(
            ItemPair pair,
            string await,
            string async,
            string cancellation)
        {
            if(pair.HaveUnprocess || pair.Parent == null)
            {
                return;
            }

            _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}}}
                    {GeneratorHelper.Tabs(pair.Tabs)}else
                    {GeneratorHelper.Tabs(pair.Tabs)}{{");
            var needSkip = pair.Aliases.AllFields().Length;
            for (var i = 0; i < needSkip; i++)
            {
                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}    {await}import.WriteNull{async}{cancellation};");
            }

            _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}}}");
        }

        private void WriteFields(
            Field field,
            ItemPair pair,
            MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "(cancellationToken)" : "()"; ;

            var dbType = DbTypeParamPass(field);
            var tabs = pair.Parent != null ? pair.Tabs + 1 : pair.Tabs;
            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            var pathInItem = pair.PathInItem(propertyName);
            if (propertyType.IsReferenceType)
            {
                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(tabs)}if (item.{pathInItem} == null)
                    {GeneratorHelper.Tabs(tabs)}{{
                    {GeneratorHelper.Tabs(tabs)}    {GeneratorHelper.AwaitWord(isAsync)}import.WriteNull{GeneratorHelper.AsyncWord(isAsync)}{cancellation};
                    {GeneratorHelper.Tabs(tabs)}}}
                    {GeneratorHelper.Tabs(tabs)}else
                    {GeneratorHelper.Tabs(tabs)}{{
                    {GeneratorHelper.Tabs(tabs)}    {GeneratorHelper.AwaitWord(isAsync)}import.Write{GeneratorHelper.AsyncWord(isAsync)}(item.{pathInItem}{dbType}{CtParametrPass(isAsync)});
                    {GeneratorHelper.Tabs(tabs)}}}");
            }
            else if (propertyType.IsNullableType())
            {
                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(tabs)}if (!item.{pathInItem}.HasValue)
                    {GeneratorHelper.Tabs(tabs)}{{
                    {GeneratorHelper.Tabs(tabs)}    {GeneratorHelper.AwaitWord(isAsync)}import.WriteNull{GeneratorHelper.AsyncWord(isAsync)}{cancellation};
                    {GeneratorHelper.Tabs(tabs)}}}
                    {GeneratorHelper.Tabs(tabs)}else
                    {GeneratorHelper.Tabs(tabs)}{{
                    {GeneratorHelper.Tabs(tabs)}    {GeneratorHelper.AwaitWord(isAsync)}import.Write{GeneratorHelper.AsyncWord(isAsync)}(item.{pathInItem}.Value{dbType}{CtParametrPass(isAsync)});
                    {GeneratorHelper.Tabs(tabs)}}}");
            }
            else
            {
                if (propertyType.IsReferenceType)
                {
                    _methodCode.Append($@"
                    {GeneratorHelper.Tabs(tabs)}if(item.{pathInItem} == null)
                    {GeneratorHelper.Tabs(tabs)}{{
                    {GeneratorHelper.Tabs(tabs)}    {GeneratorHelper.AwaitWord(isAsync)}import.WriteNull{GeneratorHelper.AsyncWord(isAsync)}{cancellation};
                    {GeneratorHelper.Tabs(tabs)}}}
                    {GeneratorHelper.Tabs(tabs)}else
                    {GeneratorHelper.Tabs(tabs)}{{
                    {GeneratorHelper.Tabs(tabs)}    {GeneratorHelper.AwaitWord(isAsync)}import.Write{GeneratorHelper.AsyncWord(isAsync)}(item.{pathInItem}{dbType}{CtParametrPass(isAsync)});
                    {GeneratorHelper.Tabs(tabs)}}}");
                }
                else
                {
                    _methodCode.Append($@"
                    {GeneratorHelper.Tabs(tabs)}{GeneratorHelper.AwaitWord(isAsync)}import.Write{GeneratorHelper.AsyncWord(isAsync)}(item.{pathInItem}{dbType}{CtParametrPass(isAsync)});");
                }
            }
        }

        private void EndMethod()
        {
            _methodCode.Append($@"
        }}
");
        }

        private void EndClass()
        {
            _methodCode.Append($@"
    }}");
        }

        private void EndNameSpace()
        {
            _methodCode.Append($@"
}}");
        }
    }
}
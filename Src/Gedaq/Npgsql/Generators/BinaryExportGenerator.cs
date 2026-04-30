using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class BinaryExportGenerator : BaseGenerator
    {
        public BinaryExportGenerator(SourceProductionContext context)
            : base(context)
        {
        }

        public void Generate(
            BinaryExport binaryExport, 
            InterfaceGenerator interfaceGenerator)
        {
            Reset();
            Start(binaryExport);
            GenerateMethod(binaryExport, interfaceGenerator);
            EndClass();
            EndNameSpace();
        }

        private void Start(BinaryExport binaryExport)
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

namespace {binaryExport.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(binaryExport.ContainTypeName, binaryExport.MethodInfo, "Npgsql")}
    {{
");
        }

        private void GenerateMethod(BinaryExport binaryExport, InterfaceGenerator interfaceGenerator)
        {
            if (binaryExport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                if(binaryExport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlConnection, MethodType.Sync, interfaceGenerator);
                }

                if (binaryExport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, interfaceGenerator);
                }
            }

            if (binaryExport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                if (binaryExport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync, interfaceGenerator);
                }

                if (binaryExport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Async, interfaceGenerator);
                }
            }
        }

        private void GenerateMethod(
            BinaryExport binaryExport, 
            NpgsqlSourceType sourceType, 
            MethodType methodType,
            InterfaceGenerator interfaceGenerator)
        {
            MethodDefinition(
                binaryExport, 
                sourceType, 
                methodType,
                _methodCode,
                forInterface: false);

            if(binaryExport.AsPartInterface)
            {
                MethodDefinition(
                    binaryExport,
                    sourceType,
                    methodType,
                    interfaceGenerator.DefinitionBuilder(),
                    forInterface: true
                    );

                interfaceGenerator.AddMethodDefinition();
            }
            MethodBody(binaryExport, sourceType, methodType);
            EndMethod();
        }

        private void MethodDefinition(
            BinaryExport binaryExport, 
            NpgsqlSourceType sourceType, 
            MethodType methodType,
            StringBuilder builder,
            bool forInterface = false)
        {
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async ";

            string returnType;
            if (binaryExport.IsCollectionDelegateMap)
            {
                returnType = methodType == MethodType.Async ?
                    "Task" :
                    "void";
            }
            else
            {
                returnType = methodType == MethodType.Async ?
                    $@"IAsyncEnumerable<{binaryExport.MapTypeInfos[0].MapType.GetFullTypeName(true, true)}>" :
                    $@"IEnumerable<{binaryExport.MapTypeInfos[0].MapType.GetFullTypeName(true, true)}>";
            }

            var methodName = methodType == MethodType.Async ? $@"{binaryExport.MethodName}Async" : $@"{binaryExport.MethodName}";

            builder.Append($@"
        {binaryExport.AccessModifier.ToLowerInvariant()} {binaryExport.MethodStaticModifier} {asyncKeyword}{returnType} {methodName}(
            {binaryExport.ContainTypeName.GCThisWordOrEmpty()}{sourceType.ToTypeName()} {sourceType.ToParametrName()}");

            if (binaryExport.IsDynamicQuery())
            {
                builder.Append($@",
            System.String query");
            }

            builder.Append($@",
            TimeSpan? timeout = null");

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation = forInterface ? string.Empty : "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default");

            }

            builder.Append($@")
");
        }

        private void MethodBody(
            BinaryExport binaryExport,
            NpgsqlSourceType sourceType,
            MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "cancellationToken" : "";
            _methodCode.Append($@"
        {{");

            if (sourceType == NpgsqlSourceType.NpgsqlDataSource)
            {
                _methodCode.Append($@"
            {NpgsqlSourceType.NpgsqlConnection.ToTypeName()} {NpgsqlSourceType.NpgsqlConnection.ToParametrName()} = {GeneratorHelper.AwaitWord(isAsync)}{sourceType.ToParametrName()}.OpenConnection{GeneratorHelper.AsyncWord(isAsync)}({cancellation});");
            }

            var query = binaryExport.IsDynamicQuery() ?
                "query" :
                $@"@""
{binaryExport.Query}
""";

            _methodCode.Append($@"
            NpgsqlBinaryExporter export = null;
            try
            {{
                export = {GeneratorHelper.AwaitWord(isAsync)}{NpgsqlSourceType.NpgsqlConnection.ToParametrName()}.BeginBinaryExport{GeneratorHelper.AsyncWord(isAsync)}({query}
{(isAsync ? ", cancellationToken" : "")});
                if(timeout.HasValue)
                {{
                    export.Timeout = timeout.Value;
                }}

                while({GeneratorHelper.AwaitWord(isAsync)}export.StartRow{GeneratorHelper.AsyncWord(isAsync)}({cancellation}) != -1)
                {{");

            YieldItem(binaryExport, methodType);
            _methodCode.Append($@"
                }}

                {GeneratorHelper.AwaitWord(isAsync)}export.Dispose{GeneratorHelper.AsyncWord(isAsync)}();
                export = null;
            }}
            finally
            {{
                if(export != null)
                {{
                    try
                    {{
                        {GeneratorHelper.AwaitWord(isAsync)}export.Cancel{GeneratorHelper.AsyncWord(isAsync)}();
                    }}
                    catch {{ /* ignore */ }}

                    {GeneratorHelper.AwaitWord(isAsync)}export.Dispose{GeneratorHelper.AsyncWord(isAsync)}();
                }}
            }}");
        }

        public void YieldItem(
            BinaryExport binaryExport,
            MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var cancelation = isAsync ? "(cancellationToken)" : "()";

            if (binaryExport.IsCollectionDelegateMap)
            {
                _methodCode.Append($@"
                // TODO By the power of BANANA;");
            }
            else
            {
                var mapType = binaryExport.MapTypeInfos[0].MapType;
                var aliases = binaryExport.MapTypeInfos[0].Aliases;
                if (NpgsqlMapTypeHelper.IsKnownProviderType(mapType))
                {
                    var field = aliases.AllFields()[0];
                    _methodCode.Append($@"
                    yield return export.Read{GeneratorHelper.AsyncWord(isAsync)}<{mapType.GetFullTypeName()}>({GetReadParametrs(field, isAsync)});");
                }
                else if (mapType.IsNullableType())
                {
                    var field = aliases.AllFields()[0];
                    _methodCode.Append($@"
                    if (export.IsNull)
                    {{
                        export.Skip{GeneratorHelper.AsyncWord(isAsync)}{cancelation};
                        yield return ({mapType.GetFullTypeName(true, true)})null;
                    }}
                    else
                    {{
                        yield return export.Read{GeneratorHelper.AsyncWord(isAsync)}<{mapType.GetFullTypeName(true, addQuestionNoatble: false)}>({GetReadParametrs(field, isAsync)});
                    }}");
                }
                else if (mapType.Name == nameof(Object))
                {
                    var field = aliases.AllFields()[0];
                    _methodCode.Append($@"
                    yield return export.Read{GeneratorHelper.AsyncWord(isAsync)}<object>({GetReadParametrs(field, isAsync)});");
                }
                else if (mapType.TypeKind == TypeKind.Class || mapType.TypeKind == TypeKind.Struct)
                {
                    ComplicateItem(aliases, mapType, methodType);
                    _methodCode.Append($@" 
                    yield return item;");
                }
                else
                {
                    var field = aliases.AllFields()[0];
                    _methodCode.Append($@"
                    yield return export.Read{GeneratorHelper.AsyncWord(isAsync)}<{mapType.GetFullTypeName()}>({GetReadParametrs(field, isAsync)});");
                }
            }
        }

        private string GetReadParametrs(Field field, bool isAsync)
        {
            if (field.HaveAdditionalInfo)
            {
                if(isAsync)
                {
                    return $"(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType}), cancellationToken";
                }
                else
                {
                    return $"(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType})";
                }
            }
            else
            {
                if (isAsync)
                {
                    return "cancellationToken";
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        private void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType
            )
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "(cancellationToken)" : "()";

            var aliases = new Stack<ItemPair>();
            {
                var root = new ItemPair(rootAliase, rootMapTypeName, "item", 0);
                aliases.Push(root);
                _methodCode.Append($@"
                    var {root.ItemName} = new {root.MapTypeName.GetFullTypeName()}();");
            }

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
                    SetFields(field, pair, methodType);
                    continue;
                }

                if (inner != null)
                {
                    pair.MapTypeName.GetPropertyOrFieldName(inner.EntityName, out var propertyName, out var pairType);
                    var newPair = new ItemPair(inner, pairType, $"item{++itemId}", pair, propertyName, pair.Tabs + 1);
                    aliases.Push(newPair);

                    if (newPair.Aliases.HaveLinkKey)
                    {
                        _methodCode.Append($@"
                    {GeneratorHelper.Tabs(newPair.Tabs)}if(!export.IsNull)
                    {GeneratorHelper.Tabs(newPair.Tabs)}{{
                    {GeneratorHelper.Tabs(newPair.Tabs)}    var {newPair.ItemName} = new {newPair.MapTypeName.GetFullTypeName()}();");
                    }
                    else
                    {
                        _methodCode.Append($@" 
                    {GeneratorHelper.Tabs(newPair.Tabs)}    {newPair.MapTypeName.GetFullTypeName()}{(newPair.MapTypeName.TypeKind != TypeKind.Class ? "?" : "")} {newPair.ItemName} = null;");
                    }
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

            if (pair.Aliases.HaveLinkKey)
            {
                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {GeneratorHelper.Tabs(pair.Tabs)}}}
                    {GeneratorHelper.Tabs(pair.Tabs)}else
                    {GeneratorHelper.Tabs(pair.Tabs)}{{");

                var needSkip = pair.Aliases.AllFields().Length;
                for ( var i = 0; i < needSkip; i++)
                {
                    _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}    {await}export.Skip{async}{cancellation};");
                }

                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}}}");
            }
            else
            {
                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}if({pair.ItemName} != null)
                    {GeneratorHelper.Tabs(pair.Tabs)}{{");

                if (!pair.Parent.Aliases.IsRoot)
                {
                    _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}    if({pair.Parent.ItemName} == null)
                    {GeneratorHelper.Tabs(pair.Tabs)}    {{
                    {GeneratorHelper.Tabs(pair.Tabs)}        {pair.Parent.ItemName} = new {pair.Parent.MapTypeName.GetFullTypeName()}();
                    {GeneratorHelper.Tabs(pair.Tabs)}    }}");
                }
                _methodCode.Append($@"
                    {GeneratorHelper.Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {GeneratorHelper.Tabs(pair.Tabs)}}}");
            }
        }

        private void SetFields(Field field, ItemPair pair, MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var cancelation = isAsync ? "(cancellationToken)" : "()"; ;

            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            _methodCode.Append($@"
                        {GeneratorHelper.Tabs(pair.Tabs)}if(!export.IsNull)
                        {GeneratorHelper.Tabs(pair.Tabs)}{{");

            if (pair.Parent != null && !pair.Aliases.HaveLinkKey)
            {
                _methodCode.Append($@"
                            {GeneratorHelper.Tabs(pair.Tabs)}if({pair.ItemName} == null)
                            {GeneratorHelper.Tabs(pair.Tabs)}{{
                                {GeneratorHelper.Tabs(pair.Tabs)} {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                            {GeneratorHelper.Tabs(pair.Tabs)}}}");
            }

            if (propertyType.IsNullableType())
            {
                _methodCode.Append($@"
                            {GeneratorHelper.Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {GeneratorHelper.AwaitWord(isAsync)}export.Read{GeneratorHelper.AsyncWord(isAsync)}<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>({GetReadParametrs(field, isAsync)});");
            }
            else
            {
                _methodCode.Append($@"
                            {GeneratorHelper.Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {GeneratorHelper.AwaitWord(isAsync)}export.Read{GeneratorHelper.AsyncWord(isAsync)}<{propertyType.GetFullTypeName()}>({GetReadParametrs(field, isAsync)});");
            }

            _methodCode.Append($@"
                        {GeneratorHelper.Tabs(pair.Tabs)}}}
                        {GeneratorHelper.Tabs(pair.Tabs)}else
                        {GeneratorHelper.Tabs(pair.Tabs)}{{
                        {GeneratorHelper.Tabs(pair.Tabs)}    {GeneratorHelper.AwaitWord(isAsync)}export.Skip{GeneratorHelper.AsyncWord(isAsync)}{cancelation};
                        {GeneratorHelper.Tabs(pair.Tabs)}}}");
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
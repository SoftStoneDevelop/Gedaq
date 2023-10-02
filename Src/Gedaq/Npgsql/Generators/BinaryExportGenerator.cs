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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class BinaryExportGenerator : BaseGenerator
    {
        public void Generate(
            BinaryExport binaryExport, 
            InterfaceGenerator interfaceGenerator
            )
        {
            Reset();
            Start(binaryExport);
            GenerateMethod(binaryExport, interfaceGenerator);
            EndClass();
            EndNameSpace();
        }

        private void Start(
            BinaryExport binaryExport
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
            InterfaceGenerator interfaceGenerator
            )
        {
            MethodDefinition(
                binaryExport, 
                sourceType, 
                methodType,
                _methodCode,
                forInterface: false
                );
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
            bool forInterface = false
            )
        {
            var accessModifier = forInterface ? AccessModifier.Public.ToLowerInvariant() : binaryExport.AccessModifier.ToLowerInvariant();
            var staticModifier = forInterface ? string.Empty : binaryExport.MethodStaticModifier;
            var asyncKeyword =
                methodType != MethodType.Async || forInterface ?
                string.Empty :
                "async"
                ;
            var returnType = methodType == MethodType.Async ? 
                $@"IAsyncEnumerable<{binaryExport.MapTypeName.GetFullTypeName(true, true)}>" : 
                $@"IEnumerable<{binaryExport.MapTypeName.GetFullTypeName(true, true)}>"
                ;
            var methodName = methodType == MethodType.Async ? $@"{binaryExport.MethodName}Async" : $@"{binaryExport.MethodName}";

            builder.Append($@"
        {binaryExport.AccessModifier.ToLowerInvariant()} {binaryExport.MethodStaticModifier} {asyncKeyword} {returnType} {methodName}(
            {binaryExport.ContainTypeName.GCThisWordOrEmpty()}{sourceType.ToTypeName()} {sourceType.ToParametrName()},
            TimeSpan? timeout = null");

            if (methodType == MethodType.Async)
            {
                var enumeratorCancellation = forInterface ? string.Empty : "[EnumeratorCancellation]";
                builder.Append($@",
            {enumeratorCancellation} CancellationToken cancellationToken = default");

            }

            builder.Append($@"
            )
");
        }

        private void MethodBody(
            BinaryExport binaryExport,
            NpgsqlSourceType sourceType,
            MethodType methodType
            )
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "cancellationToken" : "";
            var async = isAsync ? "Async" : "";
            var await = isAsync ? "await " : "";
            _methodCode.Append($@"
        {{");

            if (sourceType == NpgsqlSourceType.NpgsqlDataSource)
            {
                _methodCode.Append($@"
            {NpgsqlSourceType.NpgsqlConnection.ToTypeName()} {NpgsqlSourceType.NpgsqlConnection.ToParametrName()} = {await} {sourceType.ToParametrName()}.OpenConnection{async}({cancellation});
");
            }

            _methodCode.Append($@"
            NpgsqlBinaryExporter export = null;
            try
            {{
                export = {await}{NpgsqlSourceType.NpgsqlConnection.ToParametrName()}.BeginBinaryExport{async}(@""
{binaryExport.Query}
""{(isAsync ? ", cancellationToken" : "")});
                if(timeout.HasValue)
                {{
                    export.Timeout = timeout.Value;
                }}

                while({await}export.StartRow{async}({cancellation}) != -1)
                {{  
");
            YieldItem(binaryExport, methodType);
            _methodCode.Append($@"
                }}

                {await}export.Dispose{async}();
                export = null;
            }}
            finally
            {{
                if(export != null)
                {{
                    try
                    {{
                        {await}export.Cancel{async}();
                    }}
                    catch {{ /* ignore */ }}

                    {await}export.Dispose{async}();
                }}
            }}
");
        }

        public void YieldItem(
            BinaryExport binaryExport,
            MethodType methodType
            )
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async" : "";
            var cancelation = isAsync ? "(cancellationToken)" : "()";

            if (NpgsqlMapTypeHelper.IsKnownProviderType(binaryExport.MapTypeName))
            {
                var field = binaryExport.Aliases.AllFieldsOrderByPosition().First();
                _methodCode.Append($@"
                    yield return export.Read{async}<{binaryExport.MapTypeName.GetFullTypeName()}>({GetReadParametrs(field, isAsync)});
");
            }
            else if (binaryExport.MapTypeName.IsNullableType())
            {
                var field = binaryExport.Aliases.AllFieldsOrderByPosition().First();
                _methodCode.Append($@"
                    if (export.IsNull)
                    {{
                        export.Skip{async}{cancelation};
                        yield return ({binaryExport.MapTypeName.GetFullTypeName(true, true)})null;
                    }}
                    else
                    {{
                        yield return export.Read{async}<{binaryExport.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>({GetReadParametrs(field, isAsync)});
                    }}
");
            }
            else if (binaryExport.MapTypeName.Name == nameof(Object))
            {
                var field = binaryExport.Aliases.AllFieldsOrderByPosition().First();
                _methodCode.Append($@"
                    yield return export.Read{async}<object>({GetReadParametrs(field, isAsync)});
");
            }
            else if (binaryExport.MapTypeName.TypeKind == TypeKind.Class || binaryExport.MapTypeName.TypeKind == TypeKind.Struct)
            {
                ComplicateItem(binaryExport.Aliases, binaryExport.MapTypeName, methodType);
                _methodCode.Append($@" 
                    yield return item;
");
            }
            else
            {
                var field = binaryExport.Aliases.AllFieldsOrderByPosition().First();
                _methodCode.Append($@"
                    yield return export.Read{async}<{binaryExport.MapTypeName.GetFullTypeName()}>({GetReadParametrs(field, isAsync)});
");
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
            var async = isAsync ? "Async" : "";
            var cancellation = isAsync ? "(cancellationToken)" : "()"; ;
            var await = isAsync ? "await " : "";

            var aliases = new Stack<ItemPair>();
            {
                var root = new ItemPair(rootAliase, rootMapTypeName, "item", 0);
                aliases.Push(root);
                _methodCode.Append($@"
                    var {root.ItemName} = new {root.MapTypeName.GetFullTypeName()}();
");
            }

            var itemId = 0;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (!pair.HaveUnprocess)
                {
                    //close brackets and set
                    EndInnerEntity(methodType, pair, await, async, cancellation);
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
                        var linkField = newPair.Aliases.GetLinkField();
                        _methodCode.Append($@"
                    {Tabs(newPair.Tabs)}if(!export.IsNull)
                    {Tabs(newPair.Tabs)}{{
                    {Tabs(newPair.Tabs)}    var {newPair.ItemName} = new {newPair.MapTypeName.GetFullTypeName()}();
");
                    }
                    else
                    {
                        _methodCode.Append($@" 
                    {Tabs(newPair.Tabs)}    {newPair.MapTypeName.GetFullTypeName()}{(newPair.MapTypeName.TypeKind != TypeKind.Class ? "?" : "")} {newPair.ItemName} = null;
");
                    }
                    continue;
                }
            }
        }

        private void EndInnerEntity(
            MethodType methodType,
            ItemPair pair,
            string await,
            string async,
            string cancellation
            )
        {
            if(pair.HaveUnprocess || pair.Parent == null)
            {
                return;
            }

            if (pair.Aliases.HaveLinkKey)
            {
                _methodCode.Append($@"
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(pair.Tabs)}}}
                    {Tabs(pair.Tabs)}else
                    {Tabs(pair.Tabs)}{{
");
                var needSkip = pair.Aliases.AllFieldsOrderByPosition().Count;
                for ( var i = 0; i < needSkip; i++)
                {
                    _methodCode.Append($@"
                    {Tabs(pair.Tabs)}    {await}export.Skip{async}{cancellation};
");
                }

                _methodCode.Append($@"
                    {Tabs(pair.Tabs)}}}
");
            }
            else
            {
                _methodCode.Append($@"
                    {Tabs(pair.Tabs)}if({pair.ItemName} != null)
                    {Tabs(pair.Tabs)}{{
");
                if (!pair.Parent.Aliases.IsRoot)
                {
                    _methodCode.Append($@"
                    {Tabs(pair.Tabs)}    if({pair.Parent.ItemName} == null)
                    {Tabs(pair.Tabs)}    {{
                    {Tabs(pair.Tabs)}        {pair.Parent.ItemName} = new {pair.Parent.MapTypeName.GetFullTypeName()}();
                    {Tabs(pair.Tabs)}    }}
");
                }
                _methodCode.Append($@"
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(pair.Tabs)}}}
");
            }
        }

        private void SetFields(Field field, ItemPair pair, MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async" : "";
            var cancelation = isAsync ? "(cancellationToken)" : "()"; ;
            var await = isAsync ? "await " : "";

            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            _methodCode.Append($@"
                        {Tabs(pair.Tabs)}if(!export.IsNull)
                        {Tabs(pair.Tabs)}{{
");

            if (pair.Parent != null && !pair.Aliases.HaveLinkKey)
            {
                _methodCode.Append($@"
                            {Tabs(pair.Tabs)}if({pair.ItemName} == null)
                            {Tabs(pair.Tabs)}{{
                                {Tabs(pair.Tabs)} {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                            {Tabs(pair.Tabs)}}}
");
            }

            if (propertyType.IsNullableType())
            {
                _methodCode.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {await} export.Read{async}<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>({GetReadParametrs(field, isAsync)});
");
            }
            else
            {
                _methodCode.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {await} export.Read{async}<{propertyType.GetFullTypeName()}>({GetReadParametrs(field, isAsync)});
");
            }

            _methodCode.Append($@"
                        {Tabs(pair.Tabs)}}}
                        {Tabs(pair.Tabs)}else
                        {Tabs(pair.Tabs)}{{
                        {Tabs(pair.Tabs)}    {await} export.Skip{async}{cancelation};
                        {Tabs(pair.Tabs)}}}
");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
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
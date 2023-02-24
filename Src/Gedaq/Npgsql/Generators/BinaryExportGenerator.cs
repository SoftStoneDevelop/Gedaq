using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class BinaryExportGenerator : BaseGenerator
    {
        public void Generate(BinaryExport binaryExport)
        {
            Reset();
            Start(binaryExport);
            GenerateMethod(binaryExport);
            End();
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

namespace {binaryExport.ContainTypeName.ContainingNamespace}
{{
    public static class {binaryExport.MethodName}NpgsqlExtension
    {{
");
        }

        private void GenerateMethod(BinaryExport binaryExport)
        {
            if (binaryExport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                if(binaryExport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlConnection, MethodType.Sync);
                }

                if (binaryExport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async);
                }
            }

            if (binaryExport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                if (binaryExport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync);
                }

                if (binaryExport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryExport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Async);
                }
            }
        }

        private void GenerateMethod(BinaryExport binaryExport, NpgsqlSourceType sourceType, MethodType methodType)
        {
            StartMethod(binaryExport, sourceType, methodType);
            MethodBody(binaryExport, sourceType, methodType);
            EndMethod();
        }

        private void StartMethod(BinaryExport binaryExport, NpgsqlSourceType sourceType, MethodType methodType)
        {
            if(methodType == MethodType.Async)
            {
                _methodCode.Append($@"
        public static async IAsyncEnumerable<{binaryExport.MapTypeName.GetFullTypeName(true, true)}> {binaryExport.MethodName}Async(
            this {sourceType.ToTypeName()} {sourceType.ToParametrName()},
            [EnumeratorCancellation] CancellationToken cancellationToken = default
            )
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        public static IEnumerable<{binaryExport.MapTypeName.GetFullTypeName(true, true)}> {binaryExport.MethodName}(this {sourceType.ToTypeName()} {sourceType.ToParametrName()})
        {{
");
            }
        }

        private void MethodBody(
            BinaryExport binaryExport,
            NpgsqlSourceType sourceType,
            MethodType methodType
            )
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async(cancellationToken)" : "()";
            var await = isAsync ? "await " : "";

            if (sourceType == NpgsqlSourceType.NpgsqlDataSource)
            {
                _methodCode.Append($@"
            {await}using var {NpgsqlSourceType.NpgsqlConnection.ToParametrName()} = {await} {sourceType.ToParametrName()}.OpenConnection{async};
");
            }

            _methodCode.Append($@"
            {await}using (var export = {await}connection.BeginBinaryExport{(isAsync ? "Async" : "")}(@""
{binaryExport.Query}
""{(isAsync ? ", cancellationToken" : "")}))
            {{
                while({await}export.StartRow{async} != -1)
                {{
");
            YieldItem(binaryExport, methodType);
            _methodCode.Append($@"
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
                _methodCode.Append($@"
                    yield return export.Read{async}<{binaryExport.MapTypeName.GetFullTypeName()}>{cancelation};
");
            }
            else if (binaryExport.MapTypeName.IsNullableType())
            {
                _methodCode.Append($@"
                    if (export.IsNull)
                    {{
                        export.Skip{async}{cancelation};
                        yield return ({binaryExport.MapTypeName.GetFullTypeName(true, true)})null;
                    }}
                    else
                    {{
                        yield return export.Read{async}<{binaryExport.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>{cancelation};
                    }}
");
            }
            else if (binaryExport.MapTypeName.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    yield return export.Read{async}<object>{cancelation};
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
                _methodCode.Append($@"
                    yield return export.Read{async}<{binaryExport.MapTypeName.GetFullTypeName()}>{cancelation};
");
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
            var cancelation = isAsync ? "(cancellationToken)" : "()"; ;
            var await = isAsync ? "await " : "";

            var aliases = new Stack<ItemPair>();
            aliases.Push(new ItemPair(rootAliase, rootMapTypeName, "item"));

            var itemId = 0;
            int tabs = -1;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (pair.Parent != null)
                {
                    if (pair.Aliases.HaveLinkKey)
                    {
                        var linkField = pair.Aliases.GetLinkField();
                        _methodCode.Append($@"
                    {Tabs(pair.Tabs)}if(!export.IsNull)
                    {Tabs(pair.Tabs)}{{
                    {Tabs(pair.Tabs)}    var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
");
                        SetFields(pair, false, methodType);
                    }
                    else
                    {
                        _methodCode.Append($@" 
                    {Tabs(pair.Tabs)}    {pair.MapTypeName.GetFullTypeName()}{(pair.MapTypeName.TypeKind != TypeKind.Class ? "?" : "")} {pair.ItemName} = null;
");
                        SetFields(pair, true, methodType);

                    }


                    if (pair.Aliases.InnerEntities.Count == 0)
                    {
                        var current = pair;
                        while (current.Parent != null)
                        {
                            if (current.Aliases.HaveLinkKey)
                            {
                                _methodCode.Append($@"
                    {Tabs(current.Tabs)}    {current.Parent.ItemName}.{current.PropertyName} = {current.ItemName};
                    {Tabs(current.Tabs)}}}
                    {Tabs(current.Tabs)}else
                    {Tabs(current.Tabs)}{{
");
                                var inDeepStack = new Stack<Aliases>();
                                inDeepStack.Push(current.Aliases);
                                while(inDeepStack.Count != 0)
                                {
                                    var alias = inDeepStack.Pop();
                                    foreach (var item in alias.Fields)
                                    {
                                        _methodCode.Append($@"
                    {Tabs(current.Tabs)}    {await}export.Skip{async}{cancelation};
");
                                    }

                                    foreach (var inner in alias.InnerEntities)
                                    {
                                        inDeepStack.Push(inner);
                                    }
                                }
                                _methodCode.Append($@"
                    {Tabs(current.Tabs)}}}
");
                            }
                            else
                            {
                                _methodCode.Append($@"
                    {Tabs(current.Tabs)}if({current.ItemName} != null)
                    {Tabs(current.Tabs)}{{
");
                                if (!current.Parent.Aliases.IsRoot)
                                {
                                    _methodCode.Append($@"
                    {Tabs(current.Tabs)}    if({current.Parent.ItemName} == null)
                    {Tabs(current.Tabs)}    {{
                    {Tabs(current.Tabs)}        {current.Parent.ItemName} = new {current.Parent.MapTypeName.GetFullTypeName()}();
                    {Tabs(current.Tabs)}    }}
");
                                }
                                _methodCode.Append($@"
                    {Tabs(current.Tabs)}    {current.Parent.ItemName}.{current.PropertyName} = {current.ItemName};
                    {Tabs(current.Tabs)}}}
");
                            }

                            current = current.Parent;
                        }

                        continue;
                    }
                }
                else//is root
                {
                    _methodCode.Append($@"
                    var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
");
                    SetFields(pair, true, methodType);
                }

                if (pair.Aliases.InnerEntities.Count != 0)
                {
                    ++tabs;
                    for (var i = 0; i < pair.Aliases.InnerEntities.Count; i++)
                    {
                        var alias = pair.Aliases.InnerEntities[i];
                        pair.MapTypeName.GetPropertyOrFieldName(alias.EntityName, out var propertyName, out var pairType);
                        var newPair = new ItemPair(alias, pairType, $"item{++itemId}", propertyName);
                        newPair.Parent = pair;
                        newPair.Tabs = tabs;
                        aliases.Push(newPair);
                    }
                }
            }
        }

        private void SetFields(ItemPair pair, bool createItemIfNull, MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async" : "";
            var cancelation = isAsync ? "(cancellationToken)" : "()"; ;
            var await = isAsync ? "await " : "";

            var tabs = pair.Tabs;
            for (int i = 0; i < pair.Aliases.Fields.Count; i++)
            {
                var field = pair.Aliases.Fields[i];
                pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                _methodCode.Append($@"
                        {Tabs(tabs)}if(!export.IsNull)
                        {Tabs(tabs)}{{
");

                if (createItemIfNull)
                {
                    _methodCode.Append($@"
                            {Tabs(tabs)}if({pair.ItemName} == null)
                            {Tabs(tabs)}{{
                                {Tabs(tabs)} {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                            {Tabs(tabs)}}}
");
                }

                if (propertyType.IsNullableType())
                {
                    _methodCode.Append($@"
                            {Tabs(tabs)}{pair.ItemName}.{propertyName} = {await} export.Read{async}<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>{cancelation};
");
                }
                else
                {
                    _methodCode.Append($@"
                            {Tabs(tabs)}{pair.ItemName}.{propertyName} = {await} export.Read{async}<{propertyType.GetFullTypeName()}>{cancelation};
");
                }

                _methodCode.Append($@"
                        {Tabs(tabs)}}}
                        {Tabs(tabs)}else
                        {Tabs(tabs)}{{
                        {Tabs(tabs)}    {await} export.Skip{async}{cancelation};
                        {Tabs(tabs)}}}
");
            }
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
    }
}
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
                var inDeepStack = new Stack<Aliases>();
                inDeepStack.Push(pair.Aliases);
                while (inDeepStack.Count != 0)
                {
                    var alias = inDeepStack.Pop();
                    foreach (var item in alias.Fields)
                    {
                        _methodCode.Append($@"
                    {Tabs(pair.Tabs)}    {await}export.Skip{async}{cancellation};
");
                    }

                    foreach (var inner in alias.InnerEntities)
                    {
                        inDeepStack.Push(inner);
                    }
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
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {await} export.Read{async}<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>{cancelation};
");
            }
            else
            {
                _methodCode.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {await} export.Read{async}<{propertyType.GetFullTypeName()}>{cancelation};
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
    }
}
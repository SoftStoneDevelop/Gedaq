using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class MappingHelper
    {
        public static void MapItem(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            if (provider.IsKnownProviderType(source.MapTypeName))
            {
                ReturnKnownProviderType(
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr
                    );
            }
            else
            if (provider.IsSpecialHandlerType(source.MapTypeName))
            {
                ReturnSpecialHandlerType(
                    source, 
                    builder, 
                    provider,
                    mapVariableName,
                    castTypeExpr
                    );
            }
            else
            if (source.MapTypeName.Name == nameof(Object))
            {
                ReturnObject(
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr
                    );
            }
            else
            if (source.MapTypeName is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                ReturnObjectArr(
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr
                    );
            }
            else if (source.MapTypeName.TypeKind == TypeKind.Class || source.MapTypeName.TypeKind == TypeKind.Struct)
            {
                ReturnComplicateItem(
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr
                    );
            }
            else
            {
                ReturnDefaultMap(
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr
                    );
            }
        }

        private static void ReturnKnownProviderType(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            if (source.MapTypeName.IsNullableType())
            {
                builder.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        {mapVariableName} = {castTypeExpr}({source.MapTypeName.GetFullTypeName(true)})null;
                    }}
                    else
                    {{
                        {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>(0);
                    }}");
            }
            else
            {
                builder.Append($@"
                    {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);");
            }
        }

        private static void ReturnObject(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            builder.Append($@"
                    {mapVariableName} = {castTypeExpr}reader.GetValue(0);");
        }

        private static void ReturnObjectArr(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            builder.Append($@"
                    var tempItem = new object[reader.FieldCount];
                    reader.GetValues(tempItem);
                    {mapVariableName} = {castTypeExpr}tempItem;");
        }

        private static void ReturnSpecialHandlerType(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            if (source.MapTypeName.IsNullableType())
            {
                builder.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        {mapVariableName} = {castTypeExpr}({provider.GetSpecialTypeValue(source.MapTypeName, 0)})null;
                    }}
                    else
                    {{
                        {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{provider.GetSpecialTypeValue(source.MapTypeName, 0)}>(0);
                    }}");
            }
            else
            {
                builder.Append($@"
                    {mapVariableName} = {castTypeExpr}{provider.GetSpecialTypeValue(source.MapTypeName, 0)};");
            }
        }

        private static void ReturnComplicateItem(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            ComplicateItem(source.Aliases, source.MapTypeName, source.MethodType, builder, provider);
            builder.Append($@" 
                    {mapVariableName} = {castTypeExpr}root;");
        }

        private static void ReturnDefaultMap(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = ""
            )
        {
            builder.Append($@"
                    {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);");
        }


        private static void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType,
            StringBuilder builder,
            ProviderInfo provider
            )
        {
            var aliases = new Stack<ItemPair>();
            {
                var root = new ItemPair(rootAliase, rootMapTypeName, "root", 0);
                aliases.Push(root);
                builder.Append($@"
                    var {root.ItemName} = new {root.MapTypeName.GetFullTypeName()}();");
            }

            var itemId = 0;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (!pair.HaveUnprocess)
                {
                    //close brackets and set
                    EndInnerEntity(methodType, pair, builder);
                    continue;
                }

                if (!pair.GetUnprocessFieldOrInnerAlias(out var field, out var inner))
                {
                    throw new InvalidOperationException();
                }

                aliases.Push(pair);

                if (field != null)
                {
                    SetFields(field, pair, builder, true, provider);

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
                        builder.Append($@"
                    {Tabs(newPair.Tabs)}if(!{(methodType == MethodType.Async ? "await " : "")}reader.IsDBNull{(methodType == MethodType.Async ? "Async" : "")}({linkField.Position}))
                    {Tabs(newPair.Tabs)}{{
                    {Tabs(newPair.Tabs)}    var {newPair.ItemName} = new {newPair.MapTypeName.GetFullTypeName()}();");
                    }
                    else
                    {
                        builder.Append($@" 
                    {Tabs(newPair.Tabs)}    {newPair.MapTypeName.GetFullTypeName()}{(newPair.MapTypeName.TypeKind != TypeKind.Class ? "?" : "")} {newPair.ItemName} = null;");
                    }
                    continue;
                }
            }
        }

        private static void EndInnerEntity(
            MethodType methodType,
            ItemPair pair,
            StringBuilder builder
            )
        {
            if (pair.HaveUnprocess || pair.Parent == null)
            {
                return;
            }

            if (pair.Aliases.HaveLinkKey)
            {
                builder.Append($@"
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(pair.Tabs)}}}");
            }
            else
            {
                builder.Append($@"
                    {Tabs(pair.Tabs)}if({pair.ItemName} != null)
                    {Tabs(pair.Tabs)}{{");
                if (!pair.Parent.Aliases.IsRoot)
                {
                    builder.Append($@"
                    {Tabs(pair.Tabs)}    if({pair.Parent.ItemName} == null)
                    {Tabs(pair.Tabs)}    {{
                    {Tabs(pair.Tabs)}        {pair.Parent.ItemName} = new {pair.Parent.MapTypeName.GetFullTypeName()}();
                    {Tabs(pair.Tabs)}    }}");
                }
                builder.Append($@"
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(pair.Tabs)}}}");
            }
        }

        private static void SetFields(
            Field field,
            ItemPair pair,
            StringBuilder builder,
            bool createItemIfNull,
            ProviderInfo provider
            )
        {
            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            builder.Append($@"
                        {Tabs(pair.Tabs)}if(!reader.IsDBNull({field.Position}))
                        {{");

            if (createItemIfNull)
            {
                builder.Append($@"
                            {Tabs(pair.Tabs)}if({pair.ItemName} == null)
                            {Tabs(pair.Tabs)}{{
                                {Tabs(pair.Tabs)} {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                            {Tabs(pair.Tabs)}}}");
            }

            if (propertyType.IsNullableType())
            {
                builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>({field.Position});");
            }
            else
            {
                if (provider.IsSpecialHandlerType(propertyType))
                {
                    builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {provider.GetSpecialTypeValue(propertyType, field.Position)};");
                }
                else
                {
                    builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position});");
                }
            }

            builder.Append($@"
                        }}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }
    }
}
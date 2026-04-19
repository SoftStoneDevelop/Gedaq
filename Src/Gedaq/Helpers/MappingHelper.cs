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
        public static void MapItems(
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = "")
        {
            foreach (var mapType in source.MapTypeInfos)
            {
                MapItem(
                    mapType.MapType,
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr);
            }
        }

        public static void MapItem(
            ITypeSymbol mapType,
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = "")
        {
            if (provider.IsKnownProviderType(mapType))
            {
                ReturnKnownProviderType(
                    mapType,
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (provider.IsSpecialHandlerType(mapType))
            {
                ReturnSpecialHandlerType(
                    mapType,
                    builder, 
                    provider,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (mapType.Name == nameof(Object))
            {
                ReturnObject(
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (mapType is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                ReturnObjectArr(
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (mapType.TypeKind == TypeKind.Class || mapType.TypeKind == TypeKind.Struct)
            {
                ReturnComplicateItem(
                    mapType,
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr);
            }
            else
            {
                ReturnDefaultMap(
                    mapType,
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
        }

        private static void ReturnKnownProviderType(
            ITypeSymbol mapType,
            StringBuilder builder,
            string mapVariableName,
            string castTypeExpr = "")
        {
            if (mapType.IsNullableType())
            {
                builder.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        {mapVariableName} = {castTypeExpr}({mapType.GetFullTypeName(true)})null;
                    }}
                    else
                    {{
                        {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{mapType.GetFullTypeName(true, addQuestionNoatble: false)}>(0);
                    }}");
            }
            else
            {
                builder.Append($@"
                    {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{mapType.GetFullTypeName()}>(0);");
            }
        }

        private static void ReturnObject(
            StringBuilder builder,
            string mapVariableName,
            string castTypeExpr = "")
        {
            builder.Append($@"
                    {mapVariableName} = {castTypeExpr}reader.GetValue(0);");
        }

        private static void ReturnObjectArr(
            StringBuilder builder,
            string mapVariableName,
            string castTypeExpr = "")
        {
            builder.Append($@"
                    var tempItem = new object[reader.FieldCount];
                    reader.GetValues(tempItem);
                    {mapVariableName} = {castTypeExpr}tempItem;");
        }

        private static void ReturnSpecialHandlerType(
            ITypeSymbol mapType,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = "")
        {
            var field = Field.OnlyPositionalField(0);
            if (mapType.IsNullableType())
            {
                builder.Append($@"
                    if(reader.IsDBNull({provider.ValueReaderKey(field)}))
                    {{
                        {mapVariableName} = {castTypeExpr}({provider.GetSpecialTypeValue(mapType, field)})null;
                    }}
                    else
                    {{
                        {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{provider.GetSpecialTypeValue(mapType, field)}>({provider.ValueReaderKey(field)});
                    }}");
            }
            else
            {
                builder.Append($@"
                    {mapVariableName} = {castTypeExpr}{provider.GetSpecialTypeValue(mapType, field)};");
            }
        }

        private static void ReturnComplicateItem(
            ITypeSymbol mapType,
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = "")
        {
            ComplicateItem(source.MapTypeInfos[0].Aliases, mapType, source.MethodType, builder, provider);
            builder.Append($@" 
                    {mapVariableName} = {castTypeExpr}root;");
        }

        private static void ReturnDefaultMap(
            ITypeSymbol mapType,
            StringBuilder builder,
            string mapVariableName,
            string castTypeExpr = "")
        {
            builder.Append($@"
                    {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{mapType.GetFullTypeName()}>(0);");
        }


        private static void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType,
            StringBuilder builder,
            ProviderInfo provider)
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
            StringBuilder builder)
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
            ProviderInfo provider)
        {
            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            builder.Append($@"
                        {Tabs(pair.Tabs)}if(!reader.IsDBNull({provider.ValueReaderKey(field)}))
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
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>({provider.ValueReaderKey(field)});");
            }
            else
            {
                if (provider.IsSpecialHandlerType(propertyType))
                {
                    builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {provider.GetSpecialTypeValue(propertyType, field)};");
                }
                else
                {
                    builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({provider.ValueReaderKey(field)});");
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
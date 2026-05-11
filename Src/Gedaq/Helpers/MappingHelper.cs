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
            MapTypeInfo mapTypeInfo,
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = "")
        {
            if (mapTypeInfo.MapType is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                ReturnObjectArr(
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (mapTypeInfo.MapType.Name == nameof(Object))
            {
                ReturnObject(
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (provider.IsKnownProviderType(mapTypeInfo.MapType))
            {
                ReturnKnownProviderType(
                    mapTypeInfo.MapType,
                    builder,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (provider.IsSpecialHandlerType(mapTypeInfo.MapType))
            {
                ReturnSpecialHandlerType(
                    mapTypeInfo.MapType,
                    builder, 
                    provider,
                    mapVariableName,
                    castTypeExpr);
            }
            else if (mapTypeInfo.MapType.TypeKind == TypeKind.Class || mapTypeInfo.MapType.TypeKind == TypeKind.Struct)
            {
                ReturnComplicateItem(
                    mapTypeInfo,
                    source,
                    builder,
                    provider,
                    mapVariableName,
                    castTypeExpr);
            }
            else
            {
                ReturnDefaultMap(
                    mapTypeInfo.MapType,
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
                    if(reader.IsDBNull({provider.ValueReaderKey(string.Empty, field)}))
                    {{
                        {mapVariableName} = {castTypeExpr}({provider.GetSpecialTypeValue(mapType, string.Empty, field)})null;
                    }}
                    else
                    {{
                        {mapVariableName} = {castTypeExpr}reader.GetFieldValue<{provider.GetSpecialTypeValue(mapType, string.Empty, field)}>({provider.ValueReaderKey(string.Empty, field)});
                    }}");
            }
            else
            {
                builder.Append($@"
                    {mapVariableName} = {castTypeExpr}{provider.GetSpecialTypeValue(mapType, string.Empty, field)};");
            }
        }

        private static void ReturnComplicateItem(
            MapTypeInfo mapTypeInfo,
            QueryBaseCommand source,
            StringBuilder builder,
            ProviderInfo provider,
            string mapVariableName,
            string castTypeExpr = "")
        {
            ComplicateItem(mapTypeInfo.Aliases, mapTypeInfo.MapType, source.MethodType, builder, provider);
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
                    {root.MapTypeName.GetFullTypeName()} {root.ItemName} = default;");
            }

            var itemId = 0;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (!pair.HaveUnprocess)
                {
                    //close brackets and set
                    EndInnerEntity(pair, builder);
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
                {Tabs(newPair.Tabs)}    {newPair.MapTypeName.GetFullTypeName()} {newPair.ItemName} = default;");
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
            ItemPair pair,
            StringBuilder builder)
        {
            if (pair.HaveUnprocess || pair.Parent == null)
            {
                return;
            }

            builder.Append($@"
                    {Tabs(pair.Tabs)}if({pair.Parent.ItemName} == null)
                    {Tabs(pair.Tabs)}{{
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName} = new {pair.Parent.MapTypeName.GetFullTypeName()}();
                    {Tabs(pair.Tabs)}}}");

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

                builder.Append($@"
                        {Tabs(pair.Tabs)}if({pair.ItemName} == null)
                        {Tabs(pair.Tabs)}{{
                            {Tabs(pair.Tabs)}{pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                        {Tabs(pair.Tabs)}}}");

                builder.Append($@"
                    {Tabs(pair.Tabs)}{pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
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
                    {Tabs(pair.Tabs)}if(!reader.IsDBNull({provider.ValueReaderKey(pair.Aliases.Prefix, field)}))
                    {Tabs(pair.Tabs)}{{");

            if (createItemIfNull)
            {
                builder.Append($@"
                        {Tabs(pair.Tabs)}if({pair.ItemName} == null)
                        {Tabs(pair.Tabs)}{{
                            {Tabs(pair.Tabs)}{pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                        {Tabs(pair.Tabs)}}}");
            }

            if (propertyType.IsNullableType())
            {
                builder.Append($@"
                        {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>({provider.ValueReaderKey(pair.Aliases.Prefix, field)});");
            }
            else
            {
                if (provider.IsSpecialHandlerType(propertyType))
                {
                    builder.Append($@"
                        {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {provider.GetSpecialTypeValue(propertyType, pair.Aliases.Prefix, field)};");
                }
                else
                {
                    builder.Append($@"
                        {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({provider.ValueReaderKey(pair.Aliases.Prefix, field)});");
                }
            }

            builder.Append($@"
                    {Tabs(pair.Tabs)}}}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }
    }
}
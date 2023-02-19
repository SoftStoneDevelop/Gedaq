using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Base
{
    internal abstract class DbCommonBase
    {
        public abstract string GetParametrValue(BaseParametr parametr, int index, string source);

        public abstract string CommandType();

        public abstract string ReaderType();

        public abstract string BatchType();

        public abstract bool IsKnownProviderType(ITypeSymbol type);

        private class ItemPair
        {
            public ItemPair(
                Aliases aliases,
                ITypeSymbol mapTypeName,
                string itemName
                )
            {
                Aliases = aliases;
                MapTypeName = mapTypeName;
                ItemName = itemName;
            }

            public ItemPair(
                Aliases aliases,
                ITypeSymbol mapTypeName,
                string itemName,
                string propertyName
                )
                : this(aliases, mapTypeName, itemName)
            {
                PropertyName = propertyName;
            }

            public Aliases Aliases { get; private set; }
            public ITypeSymbol MapTypeName { get; private set; }
            public string PropertyName { get; private set; }
            public string ItemName { get; private set; }

            public ItemPair Parent { get; set; }
            public int Tabs { get; set; }
        }

        public void YieldItem(
            QueryBase source,
            StringBuilder builder,
            string castTypeExpr = ""
            )
        {
            if (IsKnownProviderType(source.MapTypeName))
            {
                builder.Append($@"
                    yield return {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if (source.MapTypeName.IsNullableType())
            {
                builder.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        yield return {castTypeExpr}({source.MapTypeName.GetFullTypeName(true)})null;
                    }}
                    else
                    {{
                        yield return {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>(0);
                    }}
");
            }
            else if (source.MapTypeName.Name == nameof(Object))
            {
                builder.Append($@"
                    yield return {castTypeExpr}reader.GetValue(0);
");
            }
            else if (source.MapTypeName is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                builder.Append($@"
                    var item = new object[reader.FieldCount];
                    reader.GetValues(item);
                    yield return {castTypeExpr}item;
");
            }
            else if(source.MapTypeName.TypeKind == TypeKind.Class || source.MapTypeName.TypeKind == TypeKind.Struct)
            {
                ComplicateItem(source.Aliases, source.MapTypeName, source.MethodType, builder);
                builder.Append($@" 
                    yield return {castTypeExpr}item;
");
            }
            else
            {
                builder.Append($@"
                    yield return {castTypeExpr}reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
        }


        private void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            var aliases = new Stack<ItemPair>();
            aliases.Push(new ItemPair(rootAliase, rootMapTypeName, "item"));

            var itemId = 0;
            int tabs = -1;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (pair.Parent != null)
                {
                    var linkField = pair.Aliases.GetLinkField();
                    builder.Append($@"
                    {Tabs(pair.Tabs)}if(!{(methodType == MethodType.Async ? "await " : "")}reader.IsDBNull{(methodType == MethodType.Async ? "Async" : "")}({linkField.Position}))
                    {Tabs(pair.Tabs)}{{
                        {Tabs(pair.Tabs)}var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}
                        {Tabs(pair.Tabs)}{{
");
                    for (int i = 0; i < pair.Aliases.Fields.Count; i++)
                    {
                        var field = pair.Aliases.Fields[i];
                        pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                        if (propertyType.IsNullableType())
                        {
                            builder.Append($@"
                            {Tabs(pair.Tabs)}{propertyName} = reader.IsDBNull(field.Position) ? ({propertyType.GetFullTypeName(true)})null : reader.GetFieldValue<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>(field.Position),
");
                        }
                        else
                        {
                            builder.Append($@"
                            {Tabs(pair.Tabs)}{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                        }
                    }
                    builder.Append($@" 
                        {Tabs(pair.Tabs)}}};
");
                    if (pair.Aliases.InnerEntities.Count == 0)
                    {
                        var current = pair;
                        while (current.Parent != null)
                        {
                            builder.Append($@"
                        {Tabs(current.Tabs)}{current.Parent.ItemName}.{current.PropertyName} = {current.ItemName};
                    {Tabs(current.Tabs)}}}
");
                            current = current.Parent;
                        }

                        continue;
                    }
                }
                else//is root
                {
                    builder.Append($@"
                    var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}
                    {{
");
                    for (int i = 0; i < pair.Aliases.Fields.Count; i++)
                    {
                        var field = pair.Aliases.Fields[i];
                        pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                        builder.Append($@"
                        {propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                    }
                    builder.Append($@" 
                    }};
");
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }
    }
}
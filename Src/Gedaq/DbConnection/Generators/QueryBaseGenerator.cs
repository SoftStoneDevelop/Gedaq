using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.DbConnection.Generators
{
    internal abstract class QueryBaseGenerator
    {
        protected StringBuilder _methodCode = new StringBuilder();

        public string GetCode()
        {
            var code = _methodCode.ToString();
            return code;
        }

        protected void Reset()
        {
            _methodCode.Clear();
        }

        protected void EndMethod()
        {
            _methodCode.Append($@"
        }}
");
        }

        protected void End()
        {
            _methodCode.Append($@"
    }}
}}
");
        }

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

        protected void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType
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
                    _methodCode.Append($@"
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
                            _methodCode.Append($@"
                            {Tabs(pair.Tabs)}{propertyName} = reader.IsDBNull(field.Position) ? ({propertyType.GetFullTypeName(true)})null : reader.GetFieldValue<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>(field.Position),
");
                        }
                        else
                        {
                            _methodCode.Append($@"
                            {Tabs(pair.Tabs)}{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                        }
                    }
                    _methodCode.Append($@" 
                        {Tabs(pair.Tabs)}}};
");
                    if (pair.Aliases.InnerEntities.Count == 0)
                    {
                        var current = pair;
                        while (current.Parent != null)
                        {
                            _methodCode.Append($@"
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
                    _methodCode.Append($@"
                    var {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}
                    {{
");
                    for (int i = 0; i < pair.Aliases.Fields.Count; i++)
                    {
                        var field = pair.Aliases.Fields[i];
                        pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                        _methodCode.Append($@"
                        {propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position}),
");
                    }
                    _methodCode.Append($@" 
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
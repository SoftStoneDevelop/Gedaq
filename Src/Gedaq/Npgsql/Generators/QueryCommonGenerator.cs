using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System;

namespace Gedaq.Npgsql.Generators
{
    internal abstract class QueryCommonGenerator
    {
        public virtual string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            return $"{source}.Parameters[{index}].Value";
        }

        public void SetOutAndReturnParametrs(QueryBase source, StringBuilder builder, QueryCommonGenerator generator)
        {
            var index = -1;
            foreach (var parametr in source.BaseParametrs())
            {
                ++index;
                if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                {
                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = {generator.GetParametrValue(parametr, index, "command")};
");
                }
            }
        }

        public void WriteSetParametrs(QueryBase source, StringBuilder builder)
        {
            builder.Append($@"
                command.Set{source.MethodName}Parametrs(
");
            var afterFirst = false;
            foreach (var parametr in source.BaseParametrs())
            {
                if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                {
                    continue;
                }

                if (afterFirst)
                {
                    builder.Append($@",");
                }

                builder.Append($@"
                    in {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");

                afterFirst |= true;
            }

            builder.Append($@"
                    );
");
        }

        public string GetScalarTypeName(QueryBase source)
        {
            if (source.Aliases.IsRowsAffected)
            {
                return "System.Int32";
            }

            if (MapTypeHelper.IsKnownProviderType(source.MapTypeName))
            {
                return source.MapTypeName.GetFullTypeName();
            }

            var firstField = source.Aliases.GetFirstFieldInQuery();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }

        public void WriteOutParametrs(BaseParametr parametr, StringBuilder builder)
        {
            if (parametr.Direction == System.Data.ParameterDirection.InputOutput || parametr.Direction == System.Data.ParameterDirection.Output)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Output))}
");
                return;
            }

            if (parametr.Direction == System.Data.ParameterDirection.ReturnValue)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.ReturnValue))}
");
                return;
            }
        }

        public void ThrowExceptionIfOutCannotExist(QueryBase source)
        {
            if (source.BaseParametrs().Any(an => an.Direction != System.Data.ParameterDirection.Input))
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }

        public abstract bool IsKnownProviderType(ITypeSymbol type);

        public void YieldItem(
            QueryBase source,
            StringBuilder builder
            )
        {
            if (IsKnownProviderType(source.MapTypeName))
            {
                builder.Append($@"
                    yield return reader.GetFieldValue<{source.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if (source.MapTypeName.IsNullableType())
            {
                builder.Append($@"
                    if(reader.IsDBNull(0))
                    {{
                        yield return ({source.MapTypeName.GetFullTypeName(true)})null;
                    }}
                    else
                    {{
                        yield return reader.GetFieldValue<{source.MapTypeName.GetFullTypeName(true, addQuestionNoatble: false)}>(0);
                    }}
");
            }
            else if (source.MapTypeName.Name == nameof(Object))
            {
                builder.Append($@"
                    yield return reader.GetValue(0);
");
            }
            else if (source.MapTypeName is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                builder.Append($@"
                    var item = new object[reader.FieldCount];
                    reader.GetValues(item);
                    yield return item;
");
            }
            else
            {
                ComplicateItem(source.Aliases, source.MapTypeName, source.MethodType, builder);
                builder.Append($@" 
                    yield return item;
");
            }
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
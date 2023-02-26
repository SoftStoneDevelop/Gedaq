using Gedaq.Base.Model;
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

        public abstract string DefaultSourceType();
        public abstract string DefaultSourceTypeParametr();

        public abstract bool IsKnownProviderType(ITypeSymbol type);

        public abstract bool IsSpecialHandlerType(ITypeSymbol type);

        public abstract string GetSpecialTypeValue(ITypeSymbol type, int fieldId, string source = "reader");

        public void WriteOutParametrs(BaseParametr parametr, StringBuilder builder, string batchPostfix = "")
        {
            if (parametr.Direction == System.Data.ParameterDirection.InputOutput || parametr.Direction == System.Data.ParameterDirection.Output)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Output))}{batchPostfix}
");
                return;
            }

            if (parametr.Direction == System.Data.ParameterDirection.ReturnValue)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.ReturnValue))}{batchPostfix}
");
                return;
            }
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
            else if(IsSpecialHandlerType(source.MapTypeName))
            {
                builder.Append($@"
                    yield return {castTypeExpr}{GetSpecialTypeValue(source.MapTypeName, 0)};
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
            {
                var root = new ItemPair(rootAliase, rootMapTypeName, "item", 0);
                aliases.Push(new ItemPair(rootAliase, rootMapTypeName, "item", 0));
                builder.Append($@"
                    var {root.ItemName} = new {root.MapTypeName.GetFullTypeName()}();
");
            }

            var itemId = 0;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if(!pair.HaveUnprocess)
                {
                    //close brackets and set
                    EndInnerEntity(methodType, pair, builder);
                    continue;
                }

                if(!pair.GetUnprocessFieldOrInnerAlias(out var field, out var inner))
                {
                    throw new InvalidOperationException();
                }

                aliases.Push(pair);

                if (field != null)
                {
                    SetFields(field, pair, builder, true);

                    continue;
                }

                if(inner != null)
                {
                    pair.MapTypeName.GetPropertyOrFieldName(inner.EntityName, out var propertyName, out var pairType);
                    var newPair = new ItemPair(inner, pairType, $"item{++itemId}", pair, propertyName, pair.Tabs + 1);
                    aliases.Push(newPair);

                    if(newPair.Aliases.HaveLinkKey)
                    {
                        var linkField = newPair.Aliases.GetLinkField();
                        builder.Append($@"
                    {Tabs(newPair.Tabs)}if(!{(methodType == MethodType.Async ? "await " : "")}reader.IsDBNull{(methodType == MethodType.Async ? "Async" : "")}({linkField.Position}))
                    {Tabs(newPair.Tabs)}{{
                    {Tabs(newPair.Tabs)}    var {newPair.ItemName} = new {newPair.MapTypeName.GetFullTypeName()}();
");
                    }
                    else
                    {
                        builder.Append($@" 
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
            StringBuilder builder
            )
        {
            if(pair.HaveUnprocess || pair.Parent == null)
            {
                return;
            }

            if (pair.Aliases.HaveLinkKey)
            {
                builder.Append($@"
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(pair.Tabs)}}}
");
            }
            else
            {
                builder.Append($@"
                    {Tabs(pair.Tabs)}if({pair.ItemName} != null)
                    {Tabs(pair.Tabs)}{{
");
                if (!pair.Parent.Aliases.IsRoot)
                {
                    builder.Append($@"
                    {Tabs(pair.Tabs)}    if({pair.Parent.ItemName} == null)
                    {Tabs(pair.Tabs)}    {{
                    {Tabs(pair.Tabs)}        {pair.Parent.ItemName} = new {pair.Parent.MapTypeName.GetFullTypeName()}();
                    {Tabs(pair.Tabs)}    }}
");
                }
                builder.Append($@"
                    {Tabs(pair.Tabs)}    {pair.Parent.ItemName}.{pair.PropertyName} = {pair.ItemName};
                    {Tabs(pair.Tabs)}}}
");
            }
        }

        private void SetFields(Field field, ItemPair pair, StringBuilder builder, bool createItemIfNull)
        {
            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            builder.Append($@"
                        {Tabs(pair.Tabs)}if(!reader.IsDBNull({field.Position}))
                        {{
");

            if (createItemIfNull)
            {
                builder.Append($@"
                            {Tabs(pair.Tabs)}if({pair.ItemName} == null)
                            {Tabs(pair.Tabs)}{{
                                {Tabs(pair.Tabs)} {pair.ItemName} = new {pair.MapTypeName.GetFullTypeName()}();
                            {Tabs(pair.Tabs)}}}
");
            }

            if (propertyType.IsNullableType())
            {
                builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName(true, addQuestionNoatble: false)}>({field.Position});
");
            }
            else
            {
                if (IsSpecialHandlerType(propertyType))
                {
                    builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = {GetSpecialTypeValue(propertyType, field.Position)};
");
                }
                else
                {
                    builder.Append($@"
                            {Tabs(pair.Tabs)}{pair.ItemName}.{propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({field.Position});
");
                }
            }

            builder.Append($@"
                        }}
");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }
    }
}
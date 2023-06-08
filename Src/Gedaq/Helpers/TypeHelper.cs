﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class TypeHelper
    {
        internal static bool IsAssignableFrom(
            this INamedTypeSymbol type,
            string fullNamespace,
            string typeName
        )
        {
            var nestedStack = new Stack<INamedTypeSymbol>();
            nestedStack.Push(type);
            while (nestedStack.Count != 0)
            {
                var currentType = nestedStack.Pop();
                if (currentType.ContainingNamespace.GetFullNamespace() == fullNamespace && currentType.Name == typeName)
                {
                    return true;
                }
                if (currentType.BaseType != null)
                {
                    nestedStack.Push(currentType.BaseType);
                }
            }
            return false;
        }

        internal static string GetFullNamespace(
            this INamespaceSymbol namespaceSymbol
        )
        {
            var builder = new StringBuilder();
            var nestedStack = new Stack<INamespaceSymbol>();
            var currentNamespace = namespaceSymbol;
            while (currentNamespace != null)
            {
                nestedStack.Push(currentNamespace);
                currentNamespace = currentNamespace.ContainingNamespace;
            }

            while(nestedStack.Count != 0)
            {
                currentNamespace = nestedStack.Pop();
                if(currentNamespace.IsGlobalNamespace)
                {
                    continue;
                }

                builder.Append(currentNamespace.Name);
                if(nestedStack.Count != 0)
                {
                    builder.Append(".");
                }
            }

            return builder.ToString();
        }

        internal static string GetFullTypeName(
            this ITypeSymbol typeSymbol,
            bool replaceNullable = false,
            bool addQuestionNoatble = true
            )
        {
            if(replaceNullable && typeSymbol.IsNullableType())
            {
                var named = (INamedTypeSymbol)typeSymbol;
                var firstArg = named.TypeArguments[0];

                return $"{firstArg.GetFullTypeName()}{(addQuestionNoatble ? "?" : "")}";
            }

            if(typeSymbol is INamedTypeSymbol namedTypeSymbol)
            {
                return $"{namedTypeSymbol.ContainingNamespace.GetFullNamespace()}.{typeSymbol.Name}";
            }

            if(typeSymbol is IArrayTypeSymbol arrayTypeSymbol)
            {
                return $"{arrayTypeSymbol.ElementType.GetFullTypeName()}[]";
            }

            throw new NotImplementedException();
        }

        internal static bool IsArrayType(
            this ITypeSymbol typeSymbol,
            out ITypeSymbol elementType
            )
        {
            if (typeSymbol is IArrayTypeSymbol arrayTypeSymbol)
            {
                elementType = arrayTypeSymbol.ElementType;
                return true;
            }

            elementType = null;
            return false;
        }

        internal static bool IsNullableType(this ITypeSymbol typeSymbol)
        {
            if(!(typeSymbol is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsGenericType ||
                namedTypeSymbol.ConstructedFrom == null ||
                namedTypeSymbol.ConstructedFrom.GetFullTypeName() != "System.Nullable"
                )
            {
                return false;
            }

            return true;
        }

        internal static void GetPropertyOrFieldName(
            this ITypeSymbol typeSymbol,
            string propertyName,
            out string findName,
            out ITypeSymbol findType
            )
        {
            var propertyLower = propertyName.ToLowerInvariant();
            foreach (var member in typeSymbol.GetMembers())
            {
                if (member is IPropertySymbol propertySymbol && propertySymbol.Name.ToLowerInvariant() == propertyLower)
                {
                    findName = propertySymbol.Name;
                    findType = propertySymbol.Type;
                    return;
                }

                if (member is IFieldSymbol fieldSymbol && fieldSymbol.Name.ToLowerInvariant() == propertyLower)
                {
                    findName = fieldSymbol.Name;
                    findType = fieldSymbol.Type;
                    return;
                }
            }

            throw new Exception($"Type '{typeSymbol.GetFullTypeName()}' does not contain a member named '{propertyName}'");
        }

        public static bool IsPowerOfTwo(this int x)
        {
            //for example 4
            //1000 x
            //0111 (x - 1)
            //0000 result &
            return
                (x != 0) && ((x & (x - 1)) == 0);
        }
    }
}
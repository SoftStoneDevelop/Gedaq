using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class TypeHelper
    {
        internal static bool IsAssignableFrom(
            this INamedTypeSymbol type,
            string fullNamespace,
            string typeName)
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
            this INamespaceSymbol namespaceSymbol)
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
            bool addQuestionNoatble = true)
        {
            if(replaceNullable && typeSymbol.IsNullableType())
            {
                var named = (INamedTypeSymbol)typeSymbol;
                var firstArg = (INamedTypeSymbol)named.TypeArguments[0];

                return $"{firstArg.NameSpaceWithName()}{(addQuestionNoatble ? "?" : "")}";
            }

            if(typeSymbol is INamedTypeSymbol namedTypeSymbol)
            {
                if (typeSymbol.IsListType(out var elementListType))
                {
                    return $"System.Collections.Generic.List<{elementListType.NameSpaceWithName()}>";
                }

                return namedTypeSymbol.NameSpaceWithName();
            }

            if(typeSymbol.IsArrayType(out var elementArrType))
            {
                return $"{elementArrType.NameSpaceWithName()}[]";
            }

            throw new NotImplementedException();
        }

        private static string NameSpaceWithName(
            this INamedTypeSymbol namedTypeSymbol)
        {
            return $"{namedTypeSymbol.ContainingNamespace.GetFullNamespace()}.{namedTypeSymbol.Name}";
        }

        internal static bool IsArrayType(
            this ITypeSymbol typeSymbol,
            out INamedTypeSymbol elementType)
        {
            if (typeSymbol is IArrayTypeSymbol arrayTypeSymbol)
            {
                elementType = (INamedTypeSymbol)arrayTypeSymbol.ElementType;
                return true;
            }

            elementType = null;
            return false;
        }

        internal static bool IsListType(
            this ITypeSymbol typeSymbol,
            out INamedTypeSymbol elementType)
        {
            if (!(typeSymbol is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsGenericType ||
                namedTypeSymbol.ConstructedFrom == null ||
                namedTypeSymbol.ConstructedFrom.NameSpaceWithName() != "System.Collections.Generic.List")
            {
                elementType = null;
                return false;
            }

            elementType = (INamedTypeSymbol)namedTypeSymbol.TypeArguments[0];
            return true;
        }

        internal static bool IsNullableType(this ITypeSymbol typeSymbol)
        {
            if(!(typeSymbol is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsGenericType ||
                namedTypeSymbol.ConstructedFrom == null ||
                namedTypeSymbol.ConstructedFrom.NameSpaceWithName() != "System.Nullable")
            {
                return false;
            }

            return true;
        }

        internal static bool GetPropertyOrFieldName(
            this ITypeSymbol typeSymbol,
            string propertyName,
            out string findName,
            out ITypeSymbol findType,
            bool throwExceptionIfNotFind = true)
        {
            var propertyLower = propertyName.ToLowerInvariant();
            foreach (var member in typeSymbol.GetMembers())
            {
                if (member is IPropertySymbol propertySymbol && propertySymbol.Name.ToLowerInvariant() == propertyLower)
                {
                    findName = propertySymbol.Name;
                    findType = propertySymbol.Type;
                    return true;
                }

                if (member is IFieldSymbol fieldSymbol && fieldSymbol.Name.ToLowerInvariant() == propertyLower)
                {
                    findName = fieldSymbol.Name;
                    findType = fieldSymbol.Type;
                    return true;
                }
            }

            if (throwExceptionIfNotFind)
            {
                throw new Exception($"Type '{typeSymbol.GetFullTypeName()}' does not contain a member named '{propertyName}'");
            }
            else
            {
                findName = null;
                findType = null;
                return false;
            }
        }

        internal static bool GetPropertyAttributes(
            this ITypeSymbol typeSymbol,
            string propertyName,
            out ImmutableArray<AttributeData> attributes)
        {
            var propertyLower = propertyName.ToLowerInvariant();
            foreach (var member in typeSymbol.GetMembers())
            {
                if (member is IPropertySymbol propertySymbol && propertySymbol.Name.ToLowerInvariant() == propertyLower)
                {
                    attributes = propertySymbol.GetAttributes();
                    return true;
                }
            }

            attributes = default;
            return false;
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
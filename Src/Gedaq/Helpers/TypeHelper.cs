using Microsoft.CodeAnalysis;
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
            this ITypeSymbol typeSymbol
            )
        {
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

        internal static bool IsPrimitive(
            this ITypeSymbol namedTypeSymbol
            )
        {
            switch (namedTypeSymbol.Name)
            {
                case "Int32":
                {
                    return true;
                }

                case "UInt32":
                {
                    return true;
                }

                case "Int64":
                {
                    return true;
                }

                case "UInt64":
                {
                    return true;
                }

                case "SByte":
                {
                    return true;
                }

                case "Byte":
                {
                    return true;
                }

                case "Int16":
                {
                    return true;
                }

                case "UInt16":
                {
                    return true;
                }

                case "Char":
                {
                    return true;
                }

                case "Decimal":
                {
                    return true;
                }

                case "Double":
                {
                    return true;
                }

                case "Boolean":
                {
                    return true;
                }

                case "Single":
                {
                    return true;
                }

                default:
                {
                    return false;
                }
            }
        }
    }
}
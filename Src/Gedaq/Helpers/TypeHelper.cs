using Microsoft.CodeAnalysis;
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
    }
}
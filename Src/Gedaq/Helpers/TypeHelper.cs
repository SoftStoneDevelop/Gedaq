using Gedaq.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Linq;

namespace Gedaq.Helpers
{
    internal static class TypeHelper
    {
        internal static bool IsPatrial(this INamedTypeSymbol type)
        {
            foreach (var item in type.DeclaringSyntaxReferences)
            {
                var syntax = item.GetSyntax();
                if (!(syntax is ClassDeclarationSyntax classDeclarationSyntax))
                {
                    continue;
                }

                if (classDeclarationSyntax.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)))
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool IsStatic(this INamedTypeSymbol type)
        {
            foreach (var item in type.DeclaringSyntaxReferences)
            {
                var syntax = item.GetSyntax();
                if (!(syntax is ClassDeclarationSyntax classDeclarationSyntax))
                {
                    continue;
                }

                if (classDeclarationSyntax.Modifiers.Any(m => m.IsKind(SyntaxKind.StaticKeyword)))
                {
                    return true;
                }
            }

            return false;
        }

        internal static string ThisWordOrEmpty(this INamedTypeSymbol type)
        {
            return type.IsStatic() ? "this " : "";
        }

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
    }
}
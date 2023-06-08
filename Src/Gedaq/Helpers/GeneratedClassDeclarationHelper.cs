using Gedaq.Base.Model;
using Gedaq.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace Gedaq.Helpers
{
    internal static class GeneratedClassDeclarationHelper
    {
        public static ISymbol GetDeclaredSymbol(this SyntaxNode node, Compilation compilation)
        {
            var model = compilation.GetSemanticModel(node.SyntaxTree);
            return model.GetDeclaredSymbol(node);
        }

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

        internal static bool GCIsStatic(this INamedTypeSymbol type)
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

            return !type.IsPatrial();
        }

        internal static string GCThisWordOrEmpty(this INamedTypeSymbol type)
        {
            return type.GCIsStatic() ? "this " : "";
        }

        internal static string GCPartialWordOrEmpty(this INamedTypeSymbol type)
        {
            return type.IsPatrial() ? "partial" : "";
        }

        internal static string GCStaticWordOrEmpty(this INamedTypeSymbol type)
        {
            return type.GCIsStatic() ? "static" : "";
        }

        internal static string GCDeclarationName(
            INamedTypeSymbol type,
            BaseMethodInfo methodInfo,
            string extansionPrefix
            )
        {
            return $@"{type.ToAccessModifier().ToLowerInvariant()} {type.GCStaticWordOrEmpty()} {type.GCPartialWordOrEmpty()} class {(type.IsPatrial() ? type.Name : $"{methodInfo.MethodName}{extansionPrefix}Extension")}";
        }

        internal static AccessModifier ToAccessModifier(
            this INamedTypeSymbol type
            )
        {
            if (type.DeclaredAccessibility == Accessibility.Private)
            {
                return AccessModifier.Private;
            }

            if (type.DeclaredAccessibility == Accessibility.Protected)
            {
                return AccessModifier.Protected;
            }

            if (type.DeclaredAccessibility == Accessibility.Internal)
            {
                return AccessModifier.Internal;
            }

            return AccessModifier.Public;
        }
    }
}
using Gedaq.Comparers;
using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq
{
    [Generator]
    public partial class Gedaq : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var classDeclarations = context.SyntaxProvider
                .CreateSyntaxProvider(
                predicate: (s, _) => IsSyntaxTargetForGeneration(s),
                transform: (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(m => m != null)
                .Collect()
                .Select((sel, _) => sel.Distinct())
                .SelectMany(
                    (sel, _) =>
                    sel.GroupBy(gr => gr.Identifier.ValueText)
                    .Select(grSel => grSel.ToImmutableArray()));

            var compilationAndClasses =
                classDeclarations
                .Combine(context.CompilationProvider)
                .WithComparer(ByArrayComparer.Default);

            context.RegisterSourceOutput(
                compilationAndClasses,
                (spc, source) => Execute(source.Item2, source.Item1, spc));
        }

        private static bool IsSyntaxTargetForGeneration(SyntaxNode node)
            => (node is MethodDeclarationSyntax m && m.AttributeLists.Count > 0) ||
            (node is ClassDeclarationSyntax c && c.AttributeLists.Count > 0) ||
            (node is StructDeclarationSyntax s && s.AttributeLists.Count > 0);

        private static TypeDeclarationSyntax GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var typeDeclaration = GetSemanticClassOrStruct(context);
            if (typeDeclaration != null)
            {
                return typeDeclaration;
            }

            typeDeclaration = GetSemanticFromMethod(context);

            return typeDeclaration;
        }

        private static TypeDeclarationSyntax GetSemanticFromMethod(GeneratorSyntaxContext context)
        {
            if (!(context.Node is MethodDeclarationSyntax methodDeclarationSyntax))
            {
                return null;
            }

            foreach (AttributeListSyntax attributeListSyntax in methodDeclarationSyntax.AttributeLists)
            {
                foreach (AttributeSyntax attributeSyntax in attributeListSyntax.Attributes)
                {
                    IMethodSymbol attributeSymbol = context.SemanticModel.GetSymbolInfo(attributeSyntax).Symbol as IMethodSymbol;
                    if (attributeSymbol == null)
                    {
                        continue;
                    }

                    INamedTypeSymbol attributeContainingTypeSymbol = attributeSymbol.ContainingType;

                    if (attributeContainingTypeSymbol.ContainingNamespace.GetFullNamespace().StartsWith("Gedaq."))
                    {
                        return methodDeclarationSyntax.Parent as TypeDeclarationSyntax;
                    }
                }
            }

            return null;
        }

        private static TypeDeclarationSyntax GetSemanticClassOrStruct(GeneratorSyntaxContext context)
        {
            if (!(context.Node is ClassDeclarationSyntax) && !(context.Node is StructDeclarationSyntax))
            {
                return null;
            }

            var typeDeclarationSyntax = (TypeDeclarationSyntax)context.Node;
            foreach (var attributeListSyntax in typeDeclarationSyntax.AttributeLists)
            {
                foreach (AttributeSyntax attributeSyntax in attributeListSyntax.Attributes)
                {
                    IMethodSymbol attributeSymbol = context.SemanticModel.GetSymbolInfo(attributeSyntax).Symbol as IMethodSymbol;
                    if (attributeSymbol == null)
                    {
                        continue;
                    }

                    INamedTypeSymbol attributeContainingTypeSymbol = attributeSymbol.ContainingType;

                    if (attributeContainingTypeSymbol.ContainingNamespace.GetFullNamespace().StartsWith("Gedaq."))
                    {
                        return typeDeclarationSyntax;
                    }
                }
            }

            return null;
        }

        //private static int _counter;
        private static void Execute(
            Compilation compilation,
            ImmutableArray<TypeDeclarationSyntax> partialGroup,
            SourceProductionContext context)
        {
            // System.Diagnostics.Debugger.Launch();

            if (!partialGroup.Any())
            {
                return;
            }

            //var incremented = Interlocked.Increment(ref _counter);
            //if (partialGroup.First().Identifier.ValueText == "Tests_BigInteger_numeric")
            //{
            //    context.AddSource($"Aperf.cs", $@"//
            //// Counter: {incremented}
            //");
            //}

            try
            {
                var processor = new AttributeProcessor(context);
                foreach (var typeDeclarationSyntax in partialGroup)
                {
                    processor.TryFillFrom(
                        typeDeclarationSyntax,
                        compilation,
                        (INamedTypeSymbol)compilation.GetSemanticModel(typeDeclarationSyntax.SyntaxTree).GetDeclaredSymbol(typeDeclarationSyntax));
                }

                processor.CompleteProcessContainTypes();
                processor.GenerateAndSaveMethods();
            }
            catch (Exception ex)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.Exception,
                    DiagnosticConstants.ExceptionDescr,
                    DiagnosticSeverity.Error,
                    ex.Message,
                    ex.StackTrace);
            }
        }
    }
}
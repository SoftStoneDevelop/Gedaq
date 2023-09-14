using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

namespace Gedaq
{
    [Generator]
    public partial class Gedaq : IIncrementalGenerator
    {
        public class ByArrayComparer : IEqualityComparer<(Compilation compilation, ImmutableArray<TypeDeclarationSyntax> Nodes)>
        {
            public bool Equals(
               (Compilation compilation, ImmutableArray<TypeDeclarationSyntax> Nodes) x,
               (Compilation compilation, ImmutableArray<TypeDeclarationSyntax> Nodes) y)
            {
                return x.Nodes.Equals(y.Nodes);
            }

            public int GetHashCode((Compilation compilation, ImmutableArray<TypeDeclarationSyntax> Nodes) obj)
            {
                return obj.Nodes.GetHashCode();
            }
        }

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var classDeclarations = context.SyntaxProvider
                .CreateSyntaxProvider(
                predicate: (s, _) => IsSyntaxTargetForGeneration(s),
                transform: (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(m => m != null)
                .Collect()
                .Select((sel, _) => sel.Distinct().ToImmutableArray())
                ;

            var compilationAndClasses =
                context.CompilationProvider.Combine(classDeclarations)
                .WithComparer(new ByArrayComparer())
                ;

            context.RegisterSourceOutput(compilationAndClasses,
                (spc, source) => Execute(source.Item1, source.Item2, spc));
        }

        static bool IsSyntaxTargetForGeneration(SyntaxNode node)
            => (node is MethodDeclarationSyntax m && m.AttributeLists.Count > 0) || 
            (node is ClassDeclarationSyntax c && c.AttributeLists.Count > 0) ||
            (node is StructDeclarationSyntax s && s.AttributeLists.Count > 0)
            ;

        static TypeDeclarationSyntax GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var typeDeclaration = GetSemanticClassOrStruct(context);
            if (typeDeclaration != null)
            {
                return typeDeclaration;
            }

            typeDeclaration = GetSemanticFromMethod(context);

            return typeDeclaration;
        }

        static TypeDeclarationSyntax GetSemanticFromMethod(GeneratorSyntaxContext context)
        {
            if(!(context.Node is MethodDeclarationSyntax methodDeclarationSyntax))
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

        static TypeDeclarationSyntax GetSemanticClassOrStruct(GeneratorSyntaxContext context)
        {
            if(!(context.Node is ClassDeclarationSyntax) && !(context.Node is StructDeclarationSyntax))
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
        private static void Execute(Compilation compilation, ImmutableArray<TypeDeclarationSyntax> types, SourceProductionContext context)
        {
            if (types.IsDefaultOrEmpty)
            {
                return;
            }

            //context.AddSource($"perf.cs", $@"//
            //// Counter: {Interlocked.Increment(ref _counter)}
            //");

            //System.Diagnostics.Debugger.Launch();
            var distinctTypes = types.Distinct().GroupBy(gr => gr.Identifier.ValueText);

            var processor = new AttributeProcessor();
            foreach (var item in distinctTypes)
            {
                INamedTypeSymbol containType = null;
                foreach (var typeDeclarationSyntax in item)
                {
                    if(containType == null)
                    {
                        containType = (INamedTypeSymbol)compilation.GetSemanticModel(typeDeclarationSyntax.SyntaxTree).GetDeclaredSymbol(typeDeclarationSyntax);
                    }

                    processor.TryFillFrom(typeDeclarationSyntax, compilation, containType);
                }

                processor.CompleteProcessContainTypes();
            }
            
            processor.GenerateAndSaveMethods(context);
        }
    }
}
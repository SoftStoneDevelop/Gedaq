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
        public class ByArrayComparer : IEqualityComparer<(ImmutableArray<TypeDeclarationSyntax> Nodes, Compilation compilation)>
        {
            public bool Equals(
               (ImmutableArray<TypeDeclarationSyntax> Nodes, Compilation compilation) left,
               (ImmutableArray<TypeDeclarationSyntax> Nodes, Compilation compilation) rigth
                )
            {
                if(left.Nodes.Length != rigth.Nodes.Length)
                {
                    return false;
                }

                for(int i = 0; i < left.Nodes.Length; i++)
                {
                    var leftNode = left.Nodes[i];
                    var rigthNode = rigth.Nodes[i];

                    if(!leftNode.IsEquivalentTo(rigthNode))
                    {
                        return false;
                    }
                }

                return true;
            }

            public int GetHashCode((ImmutableArray<TypeDeclarationSyntax> Nodes, Compilation compilation) obj)
            {
                int hash = 0;
                unchecked
                {
                    for (int i = 0; i < obj.Nodes.Length; i++)
                    {
                        hash += obj.Nodes[i].GetHashCode();
                    }
                }

                return hash;
            }
        }

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            //System.Diagnostics.Debugger.Launch();

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
                .Select(grSel => grSel.ToImmutableArray())
                )
                ;

            var compilationAndClasses =
                classDeclarations.Combine(context.CompilationProvider)
                .WithComparer(new ByArrayComparer())
                ;

            context.RegisterSourceOutput(compilationAndClasses,
                (spc, source) => Execute(source.Item2, source.Item1, spc));
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

        static TypeDeclarationSyntax GetSemanticClassOrStruct(GeneratorSyntaxContext context)
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

        private static int _counter;
        private static void Execute(Compilation compilation, ImmutableArray<TypeDeclarationSyntax> partialGroup, SourceProductionContext context)
        {
            //System.Diagnostics.Debugger.Launch();

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

            var processor = new AttributeProcessor();
            foreach (var typeDeclarationSyntax in partialGroup)
            {
                processor.TryFillFrom(
                    typeDeclarationSyntax,
                    compilation,
                    (INamedTypeSymbol)compilation.GetSemanticModel(typeDeclarationSyntax.SyntaxTree).GetDeclaredSymbol(typeDeclarationSyntax),
                    context.CancellationToken
                    );
            }

            processor.CompleteProcessContainTypes();

            processor.GenerateAndSaveMethods(context, context.CancellationToken);
        }
    }
}
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq;
using TestsGenegator.Generators;
using TestsGenegator.Helpers;

namespace TestsGenegator
{
    [Generator]
    public partial class Generator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            //System.Diagnostics.Debugger.Launch();
            var classDeclarations = context.SyntaxProvider
                .CreateSyntaxProvider(
                predicate: (s, _) => IsSyntaxTargetForGeneration(s),
                transform: (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(m => m != null);

            var compilationAndClasses = context.CompilationProvider.Combine(classDeclarations.Collect());
            context.RegisterSourceOutput(
                compilationAndClasses,
                (spc, source) => Execute(source.Item1, source.Item2, spc)
                );
        }

        static bool IsSyntaxTargetForGeneration(SyntaxNode node)
            => (node is ClassDeclarationSyntax c && c.AttributeLists.Count > 0)
            ;

        static ClassDeclarationSyntax GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var typeDeclarationSyntax = (ClassDeclarationSyntax)context.Node;
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

                    if (attributeContainingTypeSymbol.ContainingNamespace.GetFullNamespace().StartsWith("NUnit.Framework"))
                    {
                        return typeDeclarationSyntax;
                    }
                }
            }

            return null;
        }

        private static void Execute(Compilation compilation, ImmutableArray<ClassDeclarationSyntax> types, SourceProductionContext context)
        {
            if(types.IsDefaultOrEmpty)
            {
                return;
            }

            //System.Diagnostics.Debugger.Launch();
            var distinctTypes = types.Distinct();

            var generator = new TestsGenerator();
            foreach (var classDeclaration in distinctTypes)
            {
                var type = (INamedTypeSymbol)compilation.GetSemanticModel(classDeclaration.SyntaxTree).GetDeclaredSymbol(classDeclaration);
                var attributes = type.GetAttributes();
                foreach (var attributeData in attributes)
                {
                    if(attributeData.AttributeClass.IsAssignableFrom("NUnit.Framework", "DescriptionAttribute"))
                    {
                        var description = attributeData.ConstructorArguments[0];
                        var dbType = (string)description.Value;
                        switch (dbType)
                        {
                            case "PostgreSQL":
                            {
                                generator.Generate(Enums.Database.PostgreSQL, context);
                                break;
                            }

                            case "MsSQL":
                            {
                                generator.Generate(Enums.Database.MsSQL, context);
                                break;
                            }

                            case "MySQL":
                            {
                                generator.Generate(Enums.Database.MySQL, context);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
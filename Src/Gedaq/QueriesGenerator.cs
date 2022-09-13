using Gedaq.Helpers;
using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Gedaq
{
    public partial class Gedaq
    {
        private class MethodLocalVariable
        {
            public VariableDeclaratorSyntax Declarator { get; set; }
            public INamedTypeSymbol Type { get; set; }
        }

        private void GenerateQueries(
            in Dictionary<INamedTypeSymbol, ProviderWrapper> providers,
            in List<INamedTypeSymbol> useTypes,
            in CSharpCompilation compilation
            )
        {
            var classProviderFields = new List<IFieldSymbol>();
            var methodProviderVariable = new List<MethodLocalVariable>();
            foreach (var currentType in useTypes)
            {
                classProviderFields.Clear();
                foreach (var member in currentType.GetMembers())
                {
                    if (member is IFieldSymbol fieldSymbol && 
                        fieldSymbol.Type is INamedTypeSymbol namedType &&
                        namedType.IsProvider()
                        )
                    {
                        providers.AddProviderIfNotContains(in namedType);
                        classProviderFields.Add(fieldSymbol);
                    }
                }

                foreach(var member in currentType.GetMembers())
                {
                    if (member is IMethodSymbol methodSymbol
                        && methodSymbol.GetAttributes().Any(wh => wh.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "UseProviderAttribute"))
                        )
                    {
                        foreach (var syntaxRefernce in methodSymbol.DeclaringSyntaxReferences)
                        {
                            var syntax = syntaxRefernce.GetSyntax();
                            if(!(syntax is MethodDeclarationSyntax methodDeclaration))
                            {
                                continue;
                            }

                            if(methodDeclaration.Body == null)
                            {
                                continue;
                            }

                            methodProviderVariable.Clear();
                            foreach (var statment in methodDeclaration.Body.Statements)
                            {
                                if (statment is LocalDeclarationStatementSyntax localDeclarationStatementSyntax)
                                {
                                    var model = compilation.GetSemanticModel(localDeclarationStatementSyntax.SyntaxTree);
                                    var symbolInfo = model.GetSymbolInfo(localDeclarationStatementSyntax.Declaration.Type);
                                    if (
                                        symbolInfo.Symbol is INamedTypeSymbol namedType &&
                                        namedType.IsProvider())
                                    {
                                        providers.AddProviderIfNotContains(in namedType);
                                        foreach (var variableDeclarator in localDeclarationStatementSyntax.Declaration.Variables)
                                        {
                                            methodProviderVariable.Add(new MethodLocalVariable(){ Declarator = variableDeclarator, Type = namedType });
                                        }
                                    }
                                }
                                else
                                if (statment is ExpressionStatementSyntax expressionStatementSyntax)
                                {
                                    var model = compilation.GetSemanticModel(expressionStatementSyntax.SyntaxTree);
                                    SyntaxNode previusNode = null;
                                    foreach (var item in expressionStatementSyntax.DescendantNodes())
                                    {
                                        if(item is IdentifierNameSyntax identifierName)
                                        {
                                            ProviderWrapper providerType = null;
                                            if (previusNode is ThisExpressionSyntax)
                                            {
                                                var provider = classProviderFields.FirstOrDefault(wh => wh.Name == identifierName.Identifier.ValueText);
                                                if (provider?.Type is INamedTypeSymbol namedType)
                                                {
                                                    providerType = providers[namedType];
                                                }
                                            }
                                            else
                                            {
                                                var providerMethod = methodProviderVariable.FirstOrDefault(wh => wh.Declarator.Identifier.ValueText == identifierName.Identifier.ValueText);
                                                if (providerMethod != null)
                                                {
                                                    providerType = providers[providerMethod.Type];
                                                }
                                                else
                                                {
                                                    var provider = classProviderFields.FirstOrDefault(wh => wh.Name == identifierName.Identifier.ValueText);
                                                    if (provider?.Type is INamedTypeSymbol namedType)
                                                    {
                                                        providerType = providers[namedType];
                                                    }
                                                }
                                            }

                                            if(providerType != null)
                                            {
                                                //TODO parse expression and generate query
                                            }
                                        }

                                        previusNode = item;
                                    }
                                }
                            }
                        }
                    }
                    else if (
                        member is IPropertySymbol propertySymbol
                        && propertySymbol.GetAttributes().Any(wh => wh.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "UseProviderAttribute"))
                        )
                    {
                        //TODO
                    }
                }
            }
        }
    }
}
;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;

namespace Gedaq
{
    [Generator]
    public partial class Gedaq : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            //System.Diagnostics.Debugger.Launch();

            var c = (CSharpCompilation)context.Compilation;
            
            var useProviderTypes = new List<INamedTypeSymbol>();
            var models = new Dictionary<INamedTypeSymbol, ModelWrapper>(SymbolEqualityComparer.Default);
            var providers = new Dictionary<INamedTypeSymbol, ProviderWrapper>(SymbolEqualityComparer.Default);
            
            FillTypes(
                in useProviderTypes,
                in models,
                in providers,
                c.Assembly.GlobalNamespace
                );
            FillModels(in models);
            GenerateQueries(in providers, in useProviderTypes, in c);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }

        private void FillTypes(
            in List<INamedTypeSymbol> useProviderTypes,
            in Dictionary<INamedTypeSymbol, ModelWrapper> models,
            in Dictionary<INamedTypeSymbol, ProviderWrapper> providers,
            INamespaceOrTypeSymbol symbol
            )
        {
            var queue = new Queue<INamespaceOrTypeSymbol>();
            queue.Enqueue(symbol);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current is INamedTypeSymbol type)
                {
                    var attributes = type.GetAttributes();
                    bool useProvider = false;
                    bool isModel = false;

                    foreach (var attribute in attributes)
                    {
                        if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "UseProviderAttribute"))
                        {
                            useProvider = true;
                        }

                        if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "TableAttribute"))
                        {
                            isModel = true;
                        }
                    }

                    if(useProvider)
                    {
                        useProviderTypes.Add(type);
                    }

                    if(isModel)
                    {
                        if(!models.ContainsKey(type))
                        {
                            models.Add(type, new ModelWrapper(type));
                        }
                    }
                }

                foreach (var child in current.GetMembers())
                {
                    if (child is INamespaceOrTypeSymbol symbolChild)
                    {
                        queue.Enqueue(symbolChild);
                    }
                }
            }
        }
    }
}
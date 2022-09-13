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
            System.Diagnostics.Debugger.Launch();

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
            GenerateQueries(in providers, in useProviderTypes);
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
                    bool isProvider = false;
                    bool isModel = false;
                    bool isProviderAttr = false;
                    ProviderDialect providerDialect = ProviderDialect.Unknown;

                    if (type.IsAssignableFrom("Gedaq.Provider", "GedaqRequest"))
                    {
                        isProvider = true;
                    }

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

                        if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "ProviderAttribute"))
                        {
                            isProviderAttr = true;
                            providerDialect = DialectHelper.ToDialect(attribute.AttributeClass);

                            if (providerDialect == ProviderDialect.Unknown)
                            {
                                throw new System.Exception($"Unknown provider dialect: {attribute.AttributeClass.Name}");
                            }
                        }

                        if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "ProviderAttribute"))
                        {
                            isProviderAttr = true;
                            providerDialect = DialectHelper.ToDialect(attribute.AttributeClass);

                            if (providerDialect == ProviderDialect.Unknown)
                            {
                                throw new System.Exception($"Unknown provider dialect: {attribute.AttributeClass.Name}");
                            }
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

                    if(isProvider)
                    {
                        if(!isProviderAttr)
                        {
                            throw new System.Exception("The provider must have a database type attribute");
                        }

                        if (!providers.ContainsKey(type))
                        {
                            providers.Add(type, new ProviderWrapper(type, providerDialect));
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
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
            var models = new HashSet<ModelWrapper>();
            var providers = new HashSet<ProviderWrapper>();

            FillTypes(
            in useProviderTypes,
                in models,
                in providers,
                c.Assembly.GlobalNamespace
                );
            FillModels(in models, in providers);
            GenerateQueries(in providers, in useProviderTypes);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }

        private void FillTypes(
            in List<INamedTypeSymbol> useProviderTypes,
            in HashSet<ModelWrapper> models,
            in HashSet<ProviderWrapper> providers,
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
                        if (attribute.AttributeClass.Name == "UseProviderAttribute" &&
                            attribute.AttributeClass.ContainingNamespace.GetFullNamespace() == "Gedaq.Provider.Attributes"
                            )
                        {
                            useProvider = true;
                        }

                        if (attribute.AttributeClass.Name == "TableAttribute" &&
                            attribute.AttributeClass.ContainingNamespace.GetFullNamespace() == "Gedaq.Provider.Attributes"
                            )
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
                        models.Add(new ModelWrapper(type));
                    }

                    if(isProvider)
                    {
                        if(!isProviderAttr)
                        {
                            throw new System.Exception("The provider must have a database type attribute");
                        }

                        providers.Add(new ProviderWrapper(type, providerDialect));
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
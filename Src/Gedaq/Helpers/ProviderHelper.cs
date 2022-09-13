using Gedaq.Enums;
using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Helpers
{
    internal static class ProviderHelper
    {
        internal static bool IsDefaultProvider(this INamedTypeSymbol namedTypeSymbol, out ProviderWrapper wrapper)
        {
            if(namedTypeSymbol.Name == "PostgresRequest" && namedTypeSymbol.ContainingNamespace.GetFullNamespace() == "Gedaq.Npgsql")
            {
                wrapper = new ProviderWrapper(namedTypeSymbol, Enums.ProviderDialect.PostgresSQL);
                return true;
            }

            wrapper = null;
            return false;
        }

        internal static bool IsProvider(this INamedTypeSymbol namedTypeSymbol)
        {
            return namedTypeSymbol.IsAssignableFrom("Gedaq.Provider", "GedaqRequest");
        }

        internal static ProviderWrapper AddProviderIfNotContains(
            this Dictionary<INamedTypeSymbol, ProviderWrapper> providers,
            in INamedTypeSymbol namedTypeSymbol
            )
        {
            if (providers.TryGetValue(namedTypeSymbol, out var provider))
            {
                return provider;
            }

            if (namedTypeSymbol.IsDefaultProvider(out provider))
            {
                providers.Add(namedTypeSymbol, provider);
                return provider;
            }

            var providerAttribute = namedTypeSymbol.GetAttributes().FirstOrDefault(wh => wh.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "ProviderAttribute"));
            if (providerAttribute == null)
            {
                throw new System.Exception("The provider must have a database type attribute");
            }

            var providerDialect = DialectHelper.ToDialect(providerAttribute.AttributeClass);
            if (providerDialect == ProviderDialect.Unknown)
            {
                throw new System.Exception($"Unknown provider dialect: {providerAttribute.AttributeClass.Name}");
            }

            providers.Add(namedTypeSymbol, new ProviderWrapper(namedTypeSymbol, providerDialect));

            return provider;
        }
    }
}
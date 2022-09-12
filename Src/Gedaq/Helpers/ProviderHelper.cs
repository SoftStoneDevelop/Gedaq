using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;

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
    }
}
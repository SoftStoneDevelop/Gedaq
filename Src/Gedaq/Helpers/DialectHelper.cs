using Gedaq.Enums;
using Microsoft.CodeAnalysis;

namespace Gedaq.Helpers
{
    internal static class DialectHelper
    {
        internal static ProviderDialect ToDialect(this INamedTypeSymbol namedTypeSymbol)
        {
            if(namedTypeSymbol.Name == "NpgsqlProvider" && namedTypeSymbol.ContainingNamespace.GetFullNamespace() == "Gedaq.Npgsql.Attributes")
            {
                return ProviderDialect.PostgresSQL;
            }

            return ProviderDialect.Unknown;
        }
    }
}
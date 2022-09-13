using Gedaq.Enums;
using Microsoft.CodeAnalysis;

namespace Gedaq.TypeWrappers
{
    internal class ProviderWrapper
    {
        public ProviderWrapper(
            INamedTypeSymbol type,
            ProviderDialect dialect
            )
        {
            Type = type;
            Dialect = dialect;
        }

        public INamedTypeSymbol Type { get; private set; }

        public ProviderDialect Dialect { get; private set; }
    }
}
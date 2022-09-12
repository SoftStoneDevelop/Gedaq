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

        public override bool Equals(object obj)
        {
            if(!(obj is ProviderWrapper rightWrapper))
            {
                return false;
            }

            return SymbolEqualityComparer.Default.Equals(Type, rightWrapper.Type);
        }

        public override int GetHashCode()
        {
            return SymbolEqualityComparer.Default.GetHashCode(Type);
        }

        public bool TypeEquals(INamedTypeSymbol right)
        {
            return SymbolEqualityComparer.Default.Equals(Type, right);
        }
    }
}
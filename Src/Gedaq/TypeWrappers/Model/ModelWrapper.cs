using Gedaq.Enums;
using Gedaq.TypeWrappers.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Gedaq.TypeWrappers
{
    internal class ModelWrapper
    {
        public ModelWrapper(
            INamedTypeSymbol type
            )
        {
            Type = type;
        }

        public INamedTypeSymbol Type { get; private set; }

        public Dictionary<ProviderDialect, string> TableName { get; } = new Dictionary<ProviderDialect, string>();

        public List<Column> Columns { get; } = new List<Column>();

        public override bool Equals(object obj)
        {
            if (!(obj is ModelWrapper rightWrapper))
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
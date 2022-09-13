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
    }
}
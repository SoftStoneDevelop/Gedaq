using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Gedaq
{
    public partial class Gedaq
    {
        private void GenerateQueries(
            in HashSet<ProviderWrapper> providers,
            in List<INamedTypeSymbol> useTypes
            )
        {
            foreach (var currentType in useTypes)
            {
                //TODO generate query methods for providers
            }
        }
    }
}

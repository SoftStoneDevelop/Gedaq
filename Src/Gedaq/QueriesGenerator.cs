using Gedaq.Helpers;
using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq
{
    public partial class Gedaq
    {
        private void GenerateQueries(
            in Dictionary<INamedTypeSymbol, ProviderWrapper> providers,
            in List<INamedTypeSymbol> useTypes
            )
        {
            foreach (var currentType in useTypes)
            {
                foreach(var member in currentType.GetMembers())
                {
                    var type = member.GetType();
                    var interf = type.GetInterfaces();
                    if (member is IMethodSymbol methodSymbol
                        && methodSymbol.GetAttributes().Any(wh => wh.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "UseProviderAttribute"))
                        )
                    {
                        
                    }
                    else if (
                        member is IPropertySymbol propertySymbol
                        && propertySymbol.GetAttributes().Any(wh => wh.AttributeClass.IsAssignableFrom("Gedaq.Provider.Attributes", "UseProviderAttribute"))
                        )
                    {
                        //TODO
                    }
                }
            }
        }
    }
}

using Gedaq.Helpers;
using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Gedaq
{
    public partial class Gedaq
    {
        private void FillModels(
            in Dictionary<INamedTypeSymbol, ModelWrapper> models
            )
        {
            foreach (var model in models.Values)
            {
                ModelHelper.FillModel(in model);
            }
        }
    }
}
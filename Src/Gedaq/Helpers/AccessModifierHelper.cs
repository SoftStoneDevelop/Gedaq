using Gedaq.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class AccessModifierHelper
    {
        internal static string ToLowerInvariant(this AccessModifier accessModifier)
        {
            return accessModifier.ToString().ToLowerInvariant();
        }
    }
}
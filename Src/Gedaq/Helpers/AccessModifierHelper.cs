using Gedaq.Enums;

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
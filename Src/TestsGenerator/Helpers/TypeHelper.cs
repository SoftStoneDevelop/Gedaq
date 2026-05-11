using System.Runtime.CompilerServices;

namespace TestsGenerator.Helpers
{
    internal static class TypeHelper
    {
        internal static string ThisAsInterface(string interfaceTypeName)
        {
            return $"(({interfaceTypeName})this)";
        }

        internal static string ArrayDimensions(int dimensions)
        {
            var builder = new DefaultInterpolatedStringHandler();
            builder.AppendLiteral("[");
            for (int i = 0; i < dimensions - 1; i++)
            {
                builder.AppendLiteral(",");
            }
            builder.AppendLiteral("]");

            return builder.ToStringAndClear();
        }
    }
}
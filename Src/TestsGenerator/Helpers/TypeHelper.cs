namespace TestsGenerator.Helpers
{
    internal static class TypeHelper
    {
        internal static string ThisAsInterface(string interfaceTypeName)
        {
            return $"(({interfaceTypeName})this)";
        }
    }
}
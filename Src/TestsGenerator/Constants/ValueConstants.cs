namespace TestsGenerator.Constants
{
    internal static class ValueConstants
    {
        public readonly static string NullValue = "null";

        public readonly static bool[] BoolValues = [true, false];

        public static string DynamicQueryPrefix(bool isDynamicQuery)
        {
            return isDynamicQuery ? "DynQuery" : string.Empty;
        }

        public static string ToLowerString(this bool value)
        {
            return value.ToString().ToLowerInvariant();
        }
    }

    internal static class NameConstants
    {
        public readonly static string DynamicParametr = "DynPar";
    }
}
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

        public static string MultiMapQueryPrefix(bool isMultyMap)
        {
            return isMultyMap ? "MM" : string.Empty;
        }

        public static string FlatModelPrefix(bool isFlat)
        {
            return isFlat ? "Flat" : string.Empty;
        }
    }

    internal static class NameConstants
    {
        public readonly static string DynamicParametr = "DynPar";
    }
}
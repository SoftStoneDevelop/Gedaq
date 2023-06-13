namespace TestsGenerator.Helpers
{
    internal static class DefaultTypeHelper
    {
        public static string Convert(string type, string defaultType, string value)
        {
            if (type == "System.DateOnly" && defaultType == "System.DateTime")
            {
                return $"({value}).ToDateTime(TimeOnly.MinValue)";
            }

            if (type == "System.TimeOnly" && defaultType == "System.TimeSpan")
            {
                return $"({value}).ToTimeSpan()";
            }

            if (type == "System.Char" && defaultType == "System.String")
            {
                return $"({value}).ToString()";
            }

            return $"({value})";
        }

        public static bool IsNullable(this string type)
        {
            switch(type)
            {
                case "System.Net.IPAddress":
                case "System.String":
                {
                    return true;
                }

                default: 
                {
                    return false;
                }
            }
        }
    }
}
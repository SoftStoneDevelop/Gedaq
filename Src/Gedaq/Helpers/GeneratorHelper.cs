namespace Gedaq.Helpers
{
    internal static class GeneratorHelper
    {
        public static string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }

        public static string AsyncWord(bool isAsync)
        {
            return isAsync ?
                "Async" :
                string.Empty;
        }

        public static string AwaitWord(bool isAsync)
        {
            return isAsync ?
                "await " :
                string.Empty;
        }
    }
}
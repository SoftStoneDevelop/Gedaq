using System;

namespace TestsGenerator.Helpers
{
    internal static class PrimitiveRandomaiser
    {
        public static bool Boolean()
        {
            var result = Random.Shared.Next(0, 1) != 0;
            return result;
        }

        public static char Char()
        {
            var result = (char)Random.Shared.Next('a', 'z');
            return result;
        }
    }
}
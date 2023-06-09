using System;

namespace TestsGenerator.Helpers
{
    internal static class PrimitiveRandomaiser
    {
        public static int Int32()
        {
            var result = Random.Shared.Next(0, int.MaxValue);
            return result;
        }

        public static uint UInt32()
        {
            var result = (uint)Random.Shared.Next(0, int.MaxValue);
            return result;
        }

        public static long Int64()
        {
            var result = Random.Shared.NextInt64(0, long.MaxValue);
            return result;
        }

        public static ulong UInt64()
        {
            var result = (ulong)Random.Shared.NextInt64(0, long.MaxValue);
            return result;
        }

        public static byte Byte()
        {
            var result = (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue);
            return result;
        }

        public static sbyte SByte()
        {
            var result = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue);
            return result;
        }

        public static short Int16()
        {
            var result = (short)Random.Shared.NextInt64(short.MinValue, short.MaxValue);
            return result;
        }

        public static ushort UInt16()
        {
            var result = (ushort)Random.Shared.NextInt64(ushort.MinValue, ushort.MaxValue);
            return result;
        }

        public static decimal Decimal()
        {
            var result = (decimal)Random.Shared.NextDouble();
            return result;
        }

        public static double Double()
        {
            var result = (double)Random.Shared.NextDouble();
            return result;
        }

        public static bool Boolean()
        {
            var result = Random.Shared.Next(0, 1) != 0;
            return result;
        }

        public static float Single()
        {
            var result = (float)Random.Shared.NextSingle();
            return result;
        }

        public static char Char()
        {
            var result = (char)Random.Shared.Next('a', 'z');
            return result;
        }

        public static string String()
        {
            var length = Random.Shared.Next(0, 20);
            var initArr = new char[length];
            for (int i = 0; i < length; i++)
            {
                initArr[i] = Char();
            }
            return new string(initArr);
        }
    }
}
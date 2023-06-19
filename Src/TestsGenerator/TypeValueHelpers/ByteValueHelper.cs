using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class ByteValueHelper : ValueHelper
    {
        public ByteValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new ByteValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue);
            return $"{result}";
        }
    }
}
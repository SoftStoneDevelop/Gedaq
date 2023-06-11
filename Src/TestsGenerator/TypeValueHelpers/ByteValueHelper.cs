using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class ByteValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new ByteValueHelper();
        }

        public override string NewValue()
        {
            var result = (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue);
            return $"{result}";
        }
    }
}
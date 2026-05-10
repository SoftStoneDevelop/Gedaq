using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class UInt32ValueHelper : ValueHelper
    {
        public UInt32ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new UInt32ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            return NewValue(out _);
        }

        public string NewValue(out uint result)
        {
            return NewValue(uint.MinValue, uint.MaxValue, out result);
        }

        public string NewValue(uint minValue, uint maxValue, out uint result)
        {
            result = (uint)Random.Shared.NextInt64(minValue, maxValue);
            return $"{result}";
        }
    }
}
using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class UInt16ValueHelper : ValueHelper
    {
        public UInt16ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new UInt16ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (ushort)Random.Shared.NextInt64(0, ushort.MaxValue);
            return $"{result}";
        }
    }
}
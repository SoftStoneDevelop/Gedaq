using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class UInt64ValueHelper : ValueHelper
    {
        public UInt64ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new UInt64ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = Random.Shared.NextInt64((long)ulong.MinValue, long.MaxValue);
            return $"{result}L";
        }
    }
}
using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class BigIntegerValueHelper : ValueHelper
    {
        public BigIntegerValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new BigIntegerValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = Random.Shared.NextInt64(0, long.MaxValue);
            return $"new System.Numerics.BigInteger({result}L)";
        }
    }
}
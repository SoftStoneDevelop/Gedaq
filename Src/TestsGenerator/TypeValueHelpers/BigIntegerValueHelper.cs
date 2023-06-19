using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class BigIntegerValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new BigIntegerValueHelper();
        }

        public override string NewValue()
        {
            var result = Random.Shared.NextInt64(0, long.MaxValue);
            return $"new System.Numerics.BigInteger({result}L)";
        }
    }
}
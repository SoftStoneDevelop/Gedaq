using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int64ValueHelper : ValueHelper
    {
        public Int64ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new Int64ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = Random.Shared.NextInt64(0, long.MaxValue);
            return $"{result}L";
        }
    }
}
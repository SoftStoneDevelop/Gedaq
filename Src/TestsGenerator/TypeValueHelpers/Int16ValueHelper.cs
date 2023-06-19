using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int16ValueHelper : ValueHelper
    {
        public Int16ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new Int16ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (short)Random.Shared.NextInt64(0, short.MaxValue);
            return $"{result}";
        }
    }
}
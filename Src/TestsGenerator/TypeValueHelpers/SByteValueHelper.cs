using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class SByteValueHelper : ValueHelper
    {
        public SByteValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new SByteValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue);
            return $@"{result}";
        }
    }
}
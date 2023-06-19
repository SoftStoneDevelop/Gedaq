using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int32ValueHelper : ValueHelper
    {
        public Int32ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new Int32ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            return NewValue(out _);
        }

        public string NewValue(out int result)
        {
            result = Random.Shared.Next(0, int.MaxValue);
            return $"{result}";
        }
    }
}
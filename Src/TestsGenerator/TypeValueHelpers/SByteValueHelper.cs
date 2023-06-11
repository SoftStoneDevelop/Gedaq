using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class SByteValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new SByteValueHelper();
        }

        public override string NewValue()
        {
            var result = (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue);
            return $@"{result}";
        }
    }
}
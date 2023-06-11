using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DecimalValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new DecimalValueHelper();
        }

        public override string NewValue()
        {
            var result = (decimal)Random.Shared.NextDouble();
            return $"{result}m";
        }
    }
}
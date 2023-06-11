using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DoubleValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new DoubleValueHelper();
        }

        public override string NewValue()
        {
            var result = (double)Random.Shared.NextDouble();
            return $"{result}d";
        }
    }
}
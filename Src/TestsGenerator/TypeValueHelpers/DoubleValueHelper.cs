using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DoubleValueHelper : ValueHelper
    {
        public DoubleValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new DoubleValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (double)Random.Shared.NextDouble();
            return $"{result.ToString(System.Globalization.CultureInfo.InvariantCulture)}d";
        }

        public override ValuePair NewSingleValuePair()
        {
            var result = (double)Random.Shared.NextDouble();

            return new (result, $"{result.ToString(System.Globalization.CultureInfo.InvariantCulture)}d");
        }
    }
}
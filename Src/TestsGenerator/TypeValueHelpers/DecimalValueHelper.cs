using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DecimalValueHelper : ValueHelper
    {
        private readonly int _round;
        public DecimalValueHelper(EnumerableType enumerableType, int round = -1) : base(enumerableType)
        {
            _round = round;
        }

        public override ValueHelper NewInstance()
        {
            return new DecimalValueHelper(_enumerableType, _round);
        }

        public override string NewSingleValue()
        {
            var result = (decimal)Random.Shared.NextDouble();

            if(_round != -1)
                result = decimal.Round(result, _round);
            return $"{result.ToString(System.Globalization.CultureInfo.InvariantCulture)}m";
        }
    }
}
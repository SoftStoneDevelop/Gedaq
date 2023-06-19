using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DecimalValueHelper : ValueHelper
    {
        private readonly int _round;
        public DecimalValueHelper(int round = -1)
        {
            _round = round;
        }

        public override ValueHelper NewInstance()
        {
            return new DecimalValueHelper(_round);
        }

        public override string NewValue()
        {
            var result = (decimal)Random.Shared.NextDouble();

            if(_round != -1)
                result = decimal.Round(result, _round);
            return $"{result}m";
        }
    }
}
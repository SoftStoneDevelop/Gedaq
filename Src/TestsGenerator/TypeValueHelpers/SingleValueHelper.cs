using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class SingleValueHelper : ValueHelper
    {
        public SingleValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {

        }

        public override ValueHelper NewInstance()
        {
            return new SingleValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (float)Random.Shared.NextSingle();
            return $@"{result.ToString(System.Globalization.CultureInfo.InvariantCulture)}f";
        }
    }
}
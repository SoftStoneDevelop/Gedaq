using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlCircleValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new(EnumerableType.SingleType);

        public NpgsqlCircleValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlCircleValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var radius = Random.Shared.NextDouble();
            return $"new NpgsqlTypes.NpgsqlCircle(center: {_pointValueHelper.NewSingleValue()}, radius: {radius}d)";
        }
    }
}
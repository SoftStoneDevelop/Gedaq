using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlCircleValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new();

        public override ValueHelper NewInstance()
        {
            return new NpgsqlCircleValueHelper();
        }

        public override string NewValue()
        {
            var radius = Random.Shared.NextDouble();
            return $"new NpgsqlTypes.NpgsqlCircle(center: {_pointValueHelper.NewValue()}, radius: {radius}d)";
        }
    }
}
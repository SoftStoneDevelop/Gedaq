using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPointValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new NpgsqlPointValueHelper();
        }

        public override string NewValue()
        {
            var x = Random.Shared.NextDouble();
            var y = Random.Shared.NextDouble();

            return $"new NpgsqlTypes.NpgsqlPoint(x: {x}d, y: {y}d)";
        }
    }
}
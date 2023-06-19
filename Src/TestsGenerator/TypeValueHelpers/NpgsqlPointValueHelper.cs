using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPointValueHelper : ValueHelper
    {
        public NpgsqlPointValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlPointValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var x = Random.Shared.NextDouble();
            var y = Random.Shared.NextDouble();

            return $"new NpgsqlTypes.NpgsqlPoint(x: {x}d, y: {y}d)";
        }
    }
}
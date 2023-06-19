using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlLineValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new NpgsqlLineValueHelper();
        }

        public override string NewValue()
        {
            var a = Random.Shared.NextDouble();
            var b = Random.Shared.NextDouble();
            var c = Random.Shared.NextDouble();

            return $"new NpgsqlTypes.NpgsqlLine(a: {a}d, b: {b}d, c: {c}d)";
        }
    }
}
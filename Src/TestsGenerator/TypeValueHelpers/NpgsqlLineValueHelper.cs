using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlLineValueHelper : ValueHelper
    {
        public NpgsqlLineValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlLineValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var a = Random.Shared.NextDouble();
            var b = Random.Shared.NextDouble();
            var c = Random.Shared.NextDouble();

            return $"new NpgsqlTypes.NpgsqlLine(a: {a}d, b: {b}d, c: {c}d)";
        }
    }
}
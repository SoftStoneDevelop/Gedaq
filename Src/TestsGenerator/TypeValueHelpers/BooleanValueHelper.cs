using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class BooleanValueHelper : ValueHelper
    {
        public BooleanValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new BooleanValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = PrimitiveRandomaiser.Boolean();
            return $"{result.ToString().ToLowerInvariant()}";
        }
    }
}
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class BooleanValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new BooleanValueHelper();
        }

        public override string NewValue()
        {
            var result = PrimitiveRandomaiser.Boolean();
            return $"{result.ToString().ToLowerInvariant()}";
        }
    }
}
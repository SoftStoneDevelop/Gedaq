using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class CharValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new CharValueHelper();
        }

        public override string NewValue()
        {
            return $"'{PrimitiveRandomaiser.Char()}'";
        }
    }
}
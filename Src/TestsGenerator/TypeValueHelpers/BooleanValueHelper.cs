using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class BooleanValueHelper : ValueHelper
    {
        public BooleanValueHelper() : base(@"
{0}
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new BooleanValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Boolean().ToString().ToLowerInvariant());
            return newValue;
        }
    }
}
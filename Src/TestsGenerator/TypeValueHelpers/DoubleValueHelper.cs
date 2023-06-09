using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DoubleValueHelper : ValueHelper
    {
        public DoubleValueHelper() : base(@"
{0}d
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new DoubleValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Double());
            return newValue;
        }
    }
}
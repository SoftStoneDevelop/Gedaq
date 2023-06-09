using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DecimalValueHelper : ValueHelper
    {
        public DecimalValueHelper() : base(@"
{0}m
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new DecimalValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Decimal());
            return newValue;
        }
    }
}
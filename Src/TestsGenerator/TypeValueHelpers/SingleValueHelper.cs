using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class SingleValueHelper : ValueHelper
    {
        public SingleValueHelper() : base(@"
{0}f
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new SingleValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Single());
            return newValue;
        }
    }
}
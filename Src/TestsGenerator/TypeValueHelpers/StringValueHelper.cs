using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class StringValueHelper : ValueHelper
    {
        public StringValueHelper() : base(@"
""{0}""
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new StringValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Single());
            return newValue;
        }
    }
}
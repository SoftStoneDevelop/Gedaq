using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class CharValueHelper : ValueHelper
    {
        public CharValueHelper() : base(@"
'{0}'
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new CharValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Char());
            return newValue;
        }
    }
}
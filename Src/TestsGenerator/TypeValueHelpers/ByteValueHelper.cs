using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class ByteValueHelper : ValueHelper
    {
        public ByteValueHelper() : base(@"
{0}
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new ByteValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Byte());
            return newValue;
        }
    }
}
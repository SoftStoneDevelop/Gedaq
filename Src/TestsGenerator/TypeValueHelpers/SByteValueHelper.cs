using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class SByteValueHelper : ValueHelper
    {
        public SByteValueHelper() : base(@"
{0}
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new SByteValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.SByte());
            return newValue;
        }
    }
}
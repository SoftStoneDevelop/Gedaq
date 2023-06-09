using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int64ValueHelper : ValueHelper
    {
        public Int64ValueHelper() : base(@"
{0}L
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new Int64ValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Int64());
            return newValue;
        }
    }
}
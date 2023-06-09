using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int16ValueHelper : ValueHelper
    {
        public Int16ValueHelper() : base(@"
{0}
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new Int16ValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Int16());
            return newValue;
        }
    }
}
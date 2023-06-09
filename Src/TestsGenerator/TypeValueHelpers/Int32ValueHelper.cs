using TestsGenerator.Helpers;
namespace TestsGenerator.TypeValueHelpers
{
    internal class Int32ValueHelper : ValueHelper
    {
        public Int32ValueHelper() : base(@"
{0}
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new Int32ValueHelper();
        }

        public override string NewValue()
        {
            var newValue = string.Format(_newValueFormat, PrimitiveRandomaiser.Int32());
            return newValue;
        }

        public string NewValue(out int result)
        {
            result = PrimitiveRandomaiser.Int32();
            var newValue = string.Format(_newValueFormat, result);
            return newValue;
        }
    }
}
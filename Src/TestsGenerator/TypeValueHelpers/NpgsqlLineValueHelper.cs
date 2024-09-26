using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlLineValueHelper : ValueHelper
    {
        private readonly DoubleValueHelper _doubleValueHelper = new(EnumerableType.SingleType);

        public NpgsqlLineValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlLineValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var a = _doubleValueHelper.NewSingleValue();
            var b = _doubleValueHelper.NewSingleValue();
            var c = _doubleValueHelper.NewSingleValue();

            return $"new NpgsqlTypes.NpgsqlLine(a: {a}, b: {b}, c: {c})";
        }
    }
}
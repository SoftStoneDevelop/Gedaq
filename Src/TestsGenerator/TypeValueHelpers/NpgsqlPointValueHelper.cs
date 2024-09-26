using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPointValueHelper : ValueHelper
    {
        private readonly DoubleValueHelper _doubleValueHelper = new(EnumerableType.SingleType);

        public NpgsqlPointValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlPointValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var x = _doubleValueHelper.NewSingleValue();
            var y = _doubleValueHelper.NewSingleValue();

            return $"new NpgsqlTypes.NpgsqlPoint(x: {x}, y: {y})";
        }

        public override ValuePair NewSingleValuePair()
        {
            var x = _doubleValueHelper.NewSingleValuePair();
            var y = _doubleValueHelper.NewSingleValuePair();

            return new (
                new NpgsqlTypes.NpgsqlPoint((double)x.Value, (double)y.Value),
                $"new NpgsqlTypes.NpgsqlPoint(x: {x.Represent}, y: {y.Represent})");
        }
    }
}
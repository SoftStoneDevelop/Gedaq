using NpgsqlTypes;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlBoxValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new(EnumerableType.SingleType);

        public NpgsqlBoxValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlBoxValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var upperRight = _pointValueHelper.NewSingleValuePair();
            var lowerLeft = _pointValueHelper.NewSingleValuePair();
            var box = new NpgsqlTypes.NpgsqlBox((NpgsqlPoint)upperRight.Value, (NpgsqlPoint)lowerLeft.Value);

            return $"new NpgsqlTypes.NpgsqlBox(" +
                $"top: {box.Top.ToString(System.Globalization.CultureInfo.InvariantCulture)}d," +
                $"right: {box.Right.ToString(System.Globalization.CultureInfo.InvariantCulture)}d," +
                $"bottom: {box.Bottom.ToString(System.Globalization.CultureInfo.InvariantCulture)}d," +
                $"left: {box.Left.ToString(System.Globalization.CultureInfo.InvariantCulture)}d)";
        }
    }
}
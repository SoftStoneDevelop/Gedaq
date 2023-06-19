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
            return $"new NpgsqlTypes.NpgsqlBox(upperRight: {_pointValueHelper.NewSingleValue()}, lowerLeft: {_pointValueHelper.NewSingleValue()})";
        }
    }
}
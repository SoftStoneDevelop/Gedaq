using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPolygonValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new(EnumerableType.SingleType);

        public NpgsqlPolygonValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlPolygonValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            return $"new NpgsqlTypes.NpgsqlPolygon({_pointValueHelper.NewSingleValue()}, {_pointValueHelper.NewSingleValue()}, {_pointValueHelper.NewSingleValue()})";
        }
    }
}
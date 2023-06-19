using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPathValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new(EnumerableType.SingleType);

        public NpgsqlPathValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlPathValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            return $"new NpgsqlTypes.NpgsqlPath({_pointValueHelper.NewSingleValue()}, {_pointValueHelper.NewSingleValue()}, {_pointValueHelper.NewSingleValue()})";
        }
    }
}
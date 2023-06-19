namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPolygonValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new();

        public override ValueHelper NewInstance()
        {
            return new NpgsqlPolygonValueHelper();
        }

        public override string NewValue()
        {
            return $"new NpgsqlTypes.NpgsqlPolygon({_pointValueHelper.NewValue()}, {_pointValueHelper.NewValue()}, {_pointValueHelper.NewValue()})";
        }
    }
}
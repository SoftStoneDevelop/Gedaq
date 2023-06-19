namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlPathValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new();

        public override ValueHelper NewInstance()
        {
            return new NpgsqlPathValueHelper();
        }

        public override string NewValue()
        {
            return $"new NpgsqlTypes.NpgsqlPath({_pointValueHelper.NewValue()}, {_pointValueHelper.NewValue()}, {_pointValueHelper.NewValue()})";
        }
    }
}
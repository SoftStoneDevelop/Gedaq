namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlBoxValueHelper : ValueHelper
    {
        private readonly NpgsqlPointValueHelper _pointValueHelper = new();

        public override ValueHelper NewInstance()
        {
            return new NpgsqlBoxValueHelper();
        }

        public override string NewValue()
        {
            return $"new NpgsqlTypes.NpgsqlBox(upperRight: {_pointValueHelper.NewValue()}, lowerLeft: {_pointValueHelper.NewValue()})";
        }
    }
}
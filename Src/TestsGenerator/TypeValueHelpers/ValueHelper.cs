namespace TestsGenerator.TypeValueHelpers
{
    internal abstract class ValueHelper
    {
        public ValueHelper(string newValueFormat)
        {
            _newValueFormat = newValueFormat;
        }

        public string _newValueFormat { get; }

        public abstract string NewValue();

        public abstract ValueHelper NewInstance();
    }
}

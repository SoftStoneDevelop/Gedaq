using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal abstract class ValueHelper
    {
        public readonly EnumerableType _enumerableType;

        public ValueHelper(EnumerableType enumerableType)
        {
            _enumerableType = enumerableType;
        }

        public abstract string NewSingleValue();

        public abstract ValueHelper NewInstance();
    }
}

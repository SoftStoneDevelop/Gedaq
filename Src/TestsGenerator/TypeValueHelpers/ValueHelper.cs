using System;
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

        public virtual ValuePair NewSingleValuePair()
        {
            throw new NotImplementedException();
        }
    }

    internal class ValuePair
    {
        public object Value { get; init; }
        public string Represent { get; init; }

        public ValuePair(object value, string represent)
        {
            Value = value;
            Represent = represent;
        }
    }
}

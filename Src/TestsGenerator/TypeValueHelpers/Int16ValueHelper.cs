using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int16ValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new Int16ValueHelper();
        }

        public override string NewValue()
        {
            var result = (short)Random.Shared.NextInt64(0, short.MaxValue);
            return $"{result}";
        }
    }
}
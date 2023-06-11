using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class Int64ValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new Int64ValueHelper();
        }

        public override string NewValue()
        {
            var result = Random.Shared.NextInt64(0, long.MaxValue);
            return $"{result}L";
        }
    }
}
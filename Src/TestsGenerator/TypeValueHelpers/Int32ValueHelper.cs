using System;
namespace TestsGenerator.TypeValueHelpers
{
    internal class Int32ValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new Int32ValueHelper();
        }

        public override string NewValue()
        {
            return NewValue(out _);
        }

        public string NewValue(out int result)
        {
            result = Random.Shared.Next(0, int.MaxValue);
            return $"{result}";
        }
    }
}
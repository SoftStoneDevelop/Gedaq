using System;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class StringValueHelper : ValueHelper
    {
        public StringValueHelper() : base(@"
""{0}""
")
        {

        }

        public override ValueHelper NewInstance()
        {
            return new StringValueHelper();
        }

        public override string NewValue()
        {
            var length = Random.Shared.Next(0, 30);
            var initArray = new char[length];
            for (int i = 0; i < initArray.Length; i++)
            {
                initArray[i] = PrimitiveRandomaiser.Char();
            }
            var str = new string(initArray);
            var newValue = string.Format(_newValueFormat, str);
            return newValue;
        }
    }
}
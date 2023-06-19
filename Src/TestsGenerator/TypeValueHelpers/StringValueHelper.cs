using System;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class StringValueHelper : ValueHelper
    {
        public StringValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {

        }

        public override ValueHelper NewInstance()
        {
            return new StringValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var length = Random.Shared.Next(0, 30);
            var initArray = new char[length];
            for (int i = 0; i < initArray.Length; i++)
            {
                initArray[i] = PrimitiveRandomaiser.Char();
            }
            var str = new string(initArray);
            return $@"""{str}""";
        }
    }
}
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeValueHelpers
{
    internal class CharValueHelper : ValueHelper
    {
        public CharValueHelper(EnumerableType enumerableType) : base(enumerableType) 
        {

        }

        public override ValueHelper NewInstance()
        {
            return new CharValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            return $"'{PrimitiveRandomaiser.Char()}'";
        }
    }
}
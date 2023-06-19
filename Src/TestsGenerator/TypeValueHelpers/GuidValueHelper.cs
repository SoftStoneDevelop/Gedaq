using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class GuidValueHelper : ValueHelper
    {
        public GuidValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new GuidValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var guid = Guid.NewGuid();
            return $@"Guid.Parse(""{guid}"")";
        }
    }
}

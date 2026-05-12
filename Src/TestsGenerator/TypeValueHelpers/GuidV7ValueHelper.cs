using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class GuidV7ValueHelper : ValueHelper
    {
        public GuidV7ValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new GuidV7ValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var guid = Guid.CreateVersion7();
            return $@"Guid.Parse(""{guid}"")";
        }
    }
}

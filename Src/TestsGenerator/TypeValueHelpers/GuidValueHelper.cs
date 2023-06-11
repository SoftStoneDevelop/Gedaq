using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class GuidValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new GuidValueHelper();
        }

        public override string NewValue()
        {
            var guid = Guid.NewGuid();
            return $@"Guid.Parse(""{guid}"")";
        }
    }
}

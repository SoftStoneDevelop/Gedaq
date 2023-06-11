using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class IPAddressValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new IPAddressValueHelper();
        }

        public override string NewValue()
        {
            var p1 = Random.Shared.Next(0, 255);
            var p2 = Random.Shared.Next(0, 255);
            var p3 = Random.Shared.Next(0, 255);
            var p4 = Random.Shared.Next(0, 255);
            return $@"System.Net.IPAddress.Parse(""{p1}.{p2}.{p3}.{p4}"")";
        }
    }
}

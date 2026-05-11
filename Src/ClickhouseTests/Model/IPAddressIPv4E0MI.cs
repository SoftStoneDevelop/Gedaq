
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class IPAddressIPv4E0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Net.IPAddress Value { get; set; }

        
        
        public System.Net.IPAddress? NullableValue { get; set; }

        public static void AssertModel(IPAddressIPv4E0MI actual, IPAddressIPv4E0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
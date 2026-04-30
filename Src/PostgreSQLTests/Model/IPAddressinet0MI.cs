
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class IPAddressinet0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Net.IPAddress Value { get; set; }

        
        
        public System.Net.IPAddress NullableValue { get; set; }

        public static void AssertModel(IPAddressinet0MI actual, IPAddressinet0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
                if (expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                    Assert.That(actual.NullableValue, Is.EqualTo(expect.NullableValue));
                }

        }
    }
}


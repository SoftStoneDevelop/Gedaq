
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class IPAddressIPv40M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Net.IPAddress Value { get; set; }

        public IPAddressIPv40MI ModelInner { get; set; }

        
        public System.Net.IPAddress? NullableValue { get; set; }

        public static void AssertModel(IPAddressIPv40M actual, IPAddressIPv40M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
                if(expect.ModelInner == null)
                {
                    Assert.That(actual.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(actual.ModelInner, Is.Not.Null);
                    Assert.That(actual.ModelInner.Id, Is.EqualTo(expect.ModelInner.Id));
                    if (checkInInnerOnlyId)
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Net.IPAddress)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}



using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatIPAddressinetListD1E2M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Collections.Generic.List<System.Net.IPAddress> Value { get; set; }



        
        public System.Collections.Generic.List<System.Net.IPAddress> NullableValue { get; set; }

        public static void AssertModel(FlatIPAddressinetListD1E2M actual, IPAddressinetListD1E2M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));

                if(expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                }
        }
    }
}


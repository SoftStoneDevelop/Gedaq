
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class BytesmallintListD12MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Collections.Generic.List<System.Byte> Value { get; set; }

        
        
        public System.Collections.Generic.List<System.Byte> NullableValue { get; set; }

        public static void AssertModel(BytesmallintListD12MI actual, BytesmallintListD12MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));

                if (expect.NullableValue == null)
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
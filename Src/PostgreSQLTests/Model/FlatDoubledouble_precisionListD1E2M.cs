
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatDoubledouble_precisionListD1E2M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Collections.Generic.List<System.Double> Value { get; set; }



        
        public System.Collections.Generic.List<System.Double> NullableValue { get; set; }

        public static void AssertModel(FlatDoubledouble_precisionListD1E2M actual, Doubledouble_precisionListD1E2M expect, bool checkInInnerOnlyId)
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


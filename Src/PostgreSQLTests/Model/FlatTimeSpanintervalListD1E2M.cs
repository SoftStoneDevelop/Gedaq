
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatTimeSpanintervalListD1E2M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Collections.Generic.List<System.TimeSpan> Value { get; set; }



        
        public System.Collections.Generic.List<System.TimeSpan> NullableValue { get; set; }

        public static void AssertModel(FlatTimeSpanintervalListD1E2M actual, TimeSpanintervalListD1E2M expect, bool checkInInnerOnlyId)
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


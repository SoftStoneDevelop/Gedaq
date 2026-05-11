
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int64bigintListD1E2MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Collections.Generic.List<System.Int64> Value { get; set; }

        
        
        public System.Collections.Generic.List<System.Int64> NullableValue { get; set; }

        public static void AssertModel(Int64bigintListD1E2MI actual, Int64bigintListD1E2MI expect, bool checkInInnerOnlyId)
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
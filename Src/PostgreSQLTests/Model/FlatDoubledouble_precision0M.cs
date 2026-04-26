
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatDoubledouble_precision0M
    {
        public System.Int32 Id { get; set; }

        public System.Double Value { get; set; }



        public System.Double? NullableValue { get; set; }

        public static void AssertModel(FlatDoubledouble_precision0M actual, Doubledouble_precision0M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
                if(expect.NullableValue == null)
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


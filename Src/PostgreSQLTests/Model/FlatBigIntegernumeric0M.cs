
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatBigIntegernumeric0M
    {
        public System.Int32 Id { get; set; }

        public System.Numerics.BigInteger Value { get; set; }



        public System.Numerics.BigInteger? NullableValue { get; set; }

        public static void AssertModel(FlatBigIntegernumeric0M actual, BigIntegernumeric0M expect, bool checkInInnerOnlyId)
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


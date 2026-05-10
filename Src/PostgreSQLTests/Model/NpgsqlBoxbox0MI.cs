
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlBoxbox0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public NpgsqlTypes.NpgsqlBox Value { get; set; }

        
        
        public NpgsqlTypes.NpgsqlBox? NullableValue { get; set; }

        public static void AssertModel(NpgsqlBoxbox0MI actual, NpgsqlBoxbox0MI expect, bool checkInInnerOnlyId)
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
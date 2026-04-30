
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatNpgsqlCirclecircle0M
    {
        
        public System.Int32 Id { get; set; }

        
        public NpgsqlTypes.NpgsqlCircle Value { get; set; }



        
        public NpgsqlTypes.NpgsqlCircle? NullableValue { get; set; }

        public static void AssertModel(FlatNpgsqlCirclecircle0M actual, NpgsqlCirclecircle0M expect, bool checkInInnerOnlyId)
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


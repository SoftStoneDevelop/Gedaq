
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatInt32Int320M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Int32 Value { get; set; }



        
        public System.Int32? NullableValue { get; set; }

        public static void AssertModel(FlatInt32Int320M actual, Int32Int320M expect, bool checkInInnerOnlyId)
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



using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Guidv7UUIDE0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Guid Value { get; set; }

        
        
        public System.Guid? NullableValue { get; set; }

        public static void AssertModel(Guidv7UUIDE0MI actual, Guidv7UUIDE0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}

using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class StringStringE0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.String Value { get; set; }

        
        
        public System.String? NullableValue { get; set; }

        public static void AssertModel(StringStringE0MI actual, StringStringE0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
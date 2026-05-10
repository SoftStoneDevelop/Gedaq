
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class StringString0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.String Value { get; set; }

        
        
        public System.String? NullableValue { get; set; }

        public static void AssertModel(StringString0MI actual, StringString0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
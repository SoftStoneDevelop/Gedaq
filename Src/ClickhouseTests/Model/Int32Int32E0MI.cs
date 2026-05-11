
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int32Int32E0MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Int32 Value { get; set; }

        
        
        public System.Int32? NullableValue { get; set; }

        public static void AssertModel(Int32Int32E0MI actual, Int32Int32E0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}

using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt64UInt640MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.UInt64 Value { get; set; }

        
        
        public System.UInt64? NullableValue { get; set; }

        public static void AssertModel(UInt64UInt640MI actual, UInt64UInt640MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
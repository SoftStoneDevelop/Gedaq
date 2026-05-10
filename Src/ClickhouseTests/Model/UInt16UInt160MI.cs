
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt16UInt160MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.UInt16 Value { get; set; }

        
        
        public System.UInt16? NullableValue { get; set; }

        public static void AssertModel(UInt16UInt160MI actual, UInt16UInt160MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
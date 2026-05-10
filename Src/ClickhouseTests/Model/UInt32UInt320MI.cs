
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt32UInt320MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.UInt32 Value { get; set; }

        
        
        public System.UInt32? NullableValue { get; set; }

        public static void AssertModel(UInt32UInt320MI actual, UInt32UInt320MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
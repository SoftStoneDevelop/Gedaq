
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class ByteUInt80MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Byte Value { get; set; }

        
        
        public System.Byte? NullableValue { get; set; }

        public static void AssertModel(ByteUInt80MI actual, ByteUInt80MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
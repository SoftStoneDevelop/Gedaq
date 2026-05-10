
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class SByteInt80MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.SByte Value { get; set; }

        
        
        public System.SByte? NullableValue { get; set; }

        public static void AssertModel(SByteInt80MI actual, SByteInt80MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
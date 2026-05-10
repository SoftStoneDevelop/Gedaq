
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int64Int640MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Int64 Value { get; set; }

        
        
        public System.Int64? NullableValue { get; set; }

        public static void AssertModel(Int64Int640MI actual, Int64Int640MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
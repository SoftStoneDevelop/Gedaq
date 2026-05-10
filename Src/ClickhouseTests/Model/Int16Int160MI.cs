
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int16Int160MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Int16 Value { get; set; }

        
        
        public System.Int16? NullableValue { get; set; }

        public static void AssertModel(Int16Int160MI actual, Int16Int160MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
        }
    }
}
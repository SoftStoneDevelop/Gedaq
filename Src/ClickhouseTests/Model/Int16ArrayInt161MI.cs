
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int16ArrayInt161MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Int16[] Value { get; set; }

        
        
        public System.Int16[] NullableValue { get; set; }

        public static void AssertModel(Int16ArrayInt161MI actual, Int16ArrayInt161MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectEnumerValue = expect.Value;
                    Assert.That(actual.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = actual.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
        }
    }
}
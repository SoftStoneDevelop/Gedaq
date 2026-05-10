
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt32ArrayUInt321MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.UInt32[] Value { get; set; }

        
        
        public System.UInt32[] NullableValue { get; set; }

        public static void AssertModel(UInt32ArrayUInt321MI actual, UInt32ArrayUInt321MI expect, bool checkInInnerOnlyId)
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
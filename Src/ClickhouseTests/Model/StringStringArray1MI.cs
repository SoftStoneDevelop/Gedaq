
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class StringStringArray1MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.String[] Value { get; set; }

        
        
        public System.String[] NullableValue { get; set; }

        public static void AssertModel(StringStringArray1MI actual, StringStringArray1MI expect, bool checkInInnerOnlyId)
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

using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int16MArrayD1E1MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Int16[] Value { get; set; }

        
        
        public System.Int16[] NullableValue { get; set; }

        public static void AssertModel(Int16MArrayD1E1MI actual, Int16MArrayD1E1MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectCollection = actual.Value;
                    var actualCollection = expect.Value;
                    Assert.That(actualCollection.Length, Is.EqualTo(expectCollection.Length));
                    Assert.That(actualCollection.Rank, Is.EqualTo(expectCollection.Rank)); // and must be 1
                    Assert.That(actualCollection.GetLength(0), Is.EqualTo(expectCollection.GetLength(0)));
                    for(int i0 = 0; i0 < expectCollection.GetLength(0); i0++)
                    {
                        var expectItem = expectCollection[i0];
                        var actualItem = actualCollection[i0];
                        Assert.That(expectItem, Is.EqualTo(actualItem));
                    }
                }
        }
    }
}
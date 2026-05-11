
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class SinglerealMArrayD11MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Single[] Value { get; set; }

        
        
        public System.Single[] NullableValue { get; set; }

        public static void AssertModel(SinglerealMArrayD11MI actual, SinglerealMArrayD11MI expect, bool checkInInnerOnlyId)
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

                if (expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                {
                    var expectCollection = actual.NullableValue;
                    var actualCollection = expect.NullableValue;
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
}
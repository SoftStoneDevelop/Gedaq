
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt16ArrayArrayUInt161MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.UInt16[,] Value { get; set; }

        
        
        public System.UInt16[,] NullableValue { get; set; }

        public static void AssertModel(UInt16ArrayArrayUInt161MI actual, UInt16ArrayArrayUInt161MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectCollection = actual.Value;
                    var actualCollection = expect.Value;
                    Assert.That(actualCollection.Length, Is.EqualTo(expectCollection.Length));
                    Assert.That(actualCollection.Rank, Is.EqualTo(expectCollection.Rank)); // and must be 2
                    Assert.That(actualCollection.GetLength(0), Is.EqualTo(expectCollection.GetLength(0)));
                    Assert.That(actualCollection.GetLength(1), Is.EqualTo(expectCollection.GetLength(1)));
                    for(int i0 = 0; i0 < expectCollection.GetLength(0); i0++)
                    {
                    for(int i1 = 0; i1 < expectCollection.GetLength(1); i1++)
                    {
                        var expectItem = expectCollection[i0,i1];
                        var actualItem = actualCollection[i0,i1];
                        Assert.That(expectItem, Is.EqualTo(actualItem));
                    }
                    }
                }
        }
    }
}
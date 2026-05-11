
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int32integerMMArrayD3E1MI
    {
        
        
        public System.Int32 Id { get; set; }

        
        
        public System.Int32[,,] Value { get; set; }

        
        
        public System.Int32[,,] NullableValue { get; set; }

        public static void AssertModel(Int32integerMMArrayD3E1MI actual, Int32integerMMArrayD3E1MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectCollection = actual.Value;
                    var actualCollection = expect.Value;
                    Assert.That(actualCollection.Length, Is.EqualTo(expectCollection.Length));
                    Assert.That(actualCollection.Rank, Is.EqualTo(expectCollection.Rank)); // and must be 3
                    Assert.That(actualCollection.GetLength(0), Is.EqualTo(expectCollection.GetLength(0)));
                    Assert.That(actualCollection.GetLength(1), Is.EqualTo(expectCollection.GetLength(1)));
                    Assert.That(actualCollection.GetLength(2), Is.EqualTo(expectCollection.GetLength(2)));
                    for(int i0 = 0; i0 < expectCollection.GetLength(0); i0++)
                    {
                    for(int i1 = 0; i1 < expectCollection.GetLength(1); i1++)
                    {
                    for(int i2 = 0; i2 < expectCollection.GetLength(2); i2++)
                    {
                        var expectItem = expectCollection[i0,i1,i2];
                        var actualItem = actualCollection[i0,i1,i2];
                        Assert.That(expectItem, Is.EqualTo(actualItem));
                    }
                    }
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
                    Assert.That(actualCollection.Rank, Is.EqualTo(expectCollection.Rank)); // and must be 3
                    Assert.That(actualCollection.GetLength(0), Is.EqualTo(expectCollection.GetLength(0)));
                    Assert.That(actualCollection.GetLength(1), Is.EqualTo(expectCollection.GetLength(1)));
                    Assert.That(actualCollection.GetLength(2), Is.EqualTo(expectCollection.GetLength(2)));
                    for(int i0 = 0; i0 < expectCollection.GetLength(0); i0++)
                    {
                    for(int i1 = 0; i1 < expectCollection.GetLength(1); i1++)
                    {
                    for(int i2 = 0; i2 < expectCollection.GetLength(2); i2++)
                    {
                        var expectItem = expectCollection[i0,i1,i2];
                        var actualItem = actualCollection[i0,i1,i2];
                        Assert.That(expectItem, Is.EqualTo(actualItem));
                    }
                    }
                    }
                }
                }
        }
    }
}
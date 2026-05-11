
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class FlatDoubledouble_precisionMMArrayD3E1M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Double[,,] Value { get; set; }



        
        public System.Double[,,] NullableValue { get; set; }

        public static void AssertModel(FlatDoubledouble_precisionMMArrayD3E1M actual, Doubledouble_precisionMMArrayD3E1M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectCollection = expect.Value;
                    var actualCollection = actual.Value;
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

                if(expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                {
                    var expectCollection = expect.NullableValue;
                    var actualCollection = actual.NullableValue;
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


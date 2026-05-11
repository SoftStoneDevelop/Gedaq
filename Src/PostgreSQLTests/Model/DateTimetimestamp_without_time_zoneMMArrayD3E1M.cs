
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DateTimetimestamp_without_time_zoneMMArrayD3E1M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.DateTime[,,] Value { get; set; }

        public DateTimetimestamp_without_time_zoneMMArrayD3E1MI ModelInner { get; set; }

        
        public System.DateTime[,,] NullableValue { get; set; }

        public static void AssertModel(DateTimetimestamp_without_time_zoneMMArrayD3E1M actual, DateTimetimestamp_without_time_zoneMMArrayD3E1M expect, bool checkInInnerOnlyId)
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

                if(expect.ModelInner == null)
                {
                    Assert.That(actual.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(actual.ModelInner, Is.Not.Null);
                    Assert.That(actual.ModelInner.Id, Is.EqualTo(expect.ModelInner.Id));
                    if (checkInInnerOnlyId)
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.DateTime[,,])default));
                        Assert.That(actual.ModelInner.NullableValue, Is.Null);
                    }
                    else
                    {
                {
                    var expectCollection = actual.ModelInner.Value;
                    var actualCollection = expect.ModelInner.Value;
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

                        if(expect.ModelInner.NullableValue == null)
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Null);
                        }
                        else
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectCollection = actual.ModelInner.NullableValue;
                    var actualCollection = expect.ModelInner.NullableValue;
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
    }
}


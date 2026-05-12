
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Guidv7MArrayD1E1M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Guid[] Value { get; set; }

        public Guidv7MArrayD1E1MI ModelInner { get; set; }

        
        public System.Guid[] NullableValue { get; set; }

        public static void AssertModel(Guidv7MArrayD1E1M actual, Guidv7MArrayD1E1M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectCollection = expect.Value;
                    var actualCollection = actual.Value;
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                    }
                    else
                    {
                {
                    var expectCollection = actual.ModelInner.Value;
                    var actualCollection = expect.ModelInner.Value;
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
}


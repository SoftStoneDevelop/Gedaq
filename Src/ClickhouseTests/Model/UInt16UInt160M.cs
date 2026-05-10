
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt16UInt160M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.UInt16 Value { get; set; }

        public UInt16UInt160MI ModelInner { get; set; }

        
        public System.UInt16? NullableValue { get; set; }

        public static void AssertModel(UInt16UInt160M actual, UInt16UInt160M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.UInt16)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}


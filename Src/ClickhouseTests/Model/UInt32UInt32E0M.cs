
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class UInt32UInt32E0M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.UInt32 Value { get; set; }

        public UInt32UInt32E0MI ModelInner { get; set; }

        
        public System.UInt32? NullableValue { get; set; }

        public static void AssertModel(UInt32UInt32E0M actual, UInt32UInt32E0M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.UInt32)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}


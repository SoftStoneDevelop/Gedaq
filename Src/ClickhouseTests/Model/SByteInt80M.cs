
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class SByteInt80M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.SByte Value { get; set; }

        public SByteInt80MI ModelInner { get; set; }

        
        public System.SByte? NullableValue { get; set; }

        public static void AssertModel(SByteInt80M actual, SByteInt80M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.SByte)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}


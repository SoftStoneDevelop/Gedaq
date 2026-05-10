
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class ByteUInt80M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Byte Value { get; set; }

        public ByteUInt80MI ModelInner { get; set; }

        
        public System.Byte? NullableValue { get; set; }

        public static void AssertModel(ByteUInt80M actual, ByteUInt80M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Byte)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}


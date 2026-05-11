
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int32Int32E0M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Int32 Value { get; set; }

        public Int32Int320MI ModelInner { get; set; }

        
        public System.Int32? NullableValue { get; set; }

        public static void AssertModel(Int32Int32E0M actual, Int32Int32E0M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Int32)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}


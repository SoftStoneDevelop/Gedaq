
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int16Int16E0M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Int16 Value { get; set; }

        public Int16Int16E0MI ModelInner { get; set; }

        
        public System.Int16? NullableValue { get; set; }

        public static void AssertModel(Int16Int16E0M actual, Int16Int16E0M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Int16)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}


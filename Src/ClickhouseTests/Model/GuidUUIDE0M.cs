
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class GuidUUIDE0M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Guid Value { get; set; }

        public GuidUUID0MI ModelInner { get; set; }

        
        public System.Guid? NullableValue { get; set; }

        public static void AssertModel(GuidUUIDE0M actual, GuidUUIDE0M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Guid)default));

                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                    }
                }

        }
    }
}



using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int16smallintListD1E2M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Collections.Generic.List<System.Int16> Value { get; set; }

        public Int16smallintListD12MI ModelInner { get; set; }

        
        public System.Collections.Generic.List<System.Int16> NullableValue { get; set; }

        public static void AssertModel(Int16smallintListD1E2M actual, Int16smallintListD1E2M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));

                if(expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int16>)default));
                        Assert.That(actual.ModelInner.NullableValue, Is.Null);
                    }
                    else
                    {

                        if(expect.ModelInner.NullableValue == null)
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Null);
                        }
                        else
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Not.Null);
                        }

                    }
                }

        }
    }
}


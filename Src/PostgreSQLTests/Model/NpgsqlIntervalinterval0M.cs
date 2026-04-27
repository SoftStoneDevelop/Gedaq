
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlIntervalinterval0M
    {
        
        public System.Int32 Id { get; set; }

        
        public NpgsqlTypes.NpgsqlInterval Value { get; set; }

        public NpgsqlIntervalinterval0MI ModelInner { get; set; }

        
        public NpgsqlTypes.NpgsqlInterval? NullableValue { get; set; }

        public static void AssertModel(NpgsqlIntervalinterval0M actual, NpgsqlIntervalinterval0M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
                if(expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                    Assert.That(actual.NullableValue, Is.EqualTo(expect.NullableValue));
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
                        Assert.That(actual.ModelInner.NullableValue, Is.Null);
                    }
                    else
                    {
                        Assert.That(actual.ModelInner.Value, Is.EqualTo(expect.ModelInner.Value));
                        if(expect.ModelInner.NullableValue == null)
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Null);
                        }
                        else
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Not.Null);
                            Assert.That(actual.ModelInner.NullableValue, Is.EqualTo(expect.ModelInner.NullableValue));
                        }
                    }
                }

        }
    }
}


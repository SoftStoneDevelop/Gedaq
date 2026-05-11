
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlLinelineListD1E2M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine> Value { get; set; }

        public NpgsqlLinelineListD12MI ModelInner { get; set; }

        
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine> NullableValue { get; set; }

        public static void AssertModel(NpgsqlLinelineListD1E2M actual, NpgsqlLinelineListD1E2M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>)default));
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


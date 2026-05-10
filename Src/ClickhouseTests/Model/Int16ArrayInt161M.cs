
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int16ArrayInt161M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Int16[] Value { get; set; }

        public Int16ArrayInt161MI ModelInner { get; set; }

        
        public System.Int16[] NullableValue { get; set; }

        public static void AssertModel(Int16ArrayInt161M actual, Int16ArrayInt161M expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                {
                    var expectEnumerValue = expect.Value;
                    Assert.That(actual.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = actual.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Int16[])default));
                    }
                    else
                    {  
                        {
                            var expectEnumerValue = expect.ModelInner.Value;
                            Assert.That(actual.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                            for(int i = 0; i < expectEnumerValue.Count(); i++)
                            {
                                var expectItem = expectEnumerValue[i];
                                var haveItem = actual.ModelInner.Value[i];
                                Assert.That(expectItem, Is.EqualTo(haveItem));
                            }
                        }

                    }
                }

        }
    }
}


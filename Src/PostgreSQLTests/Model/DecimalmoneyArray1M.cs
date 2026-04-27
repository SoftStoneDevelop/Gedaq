
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DecimalmoneyArray1M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Decimal[] Value { get; set; }

        public DecimalmoneyArray1MI ModelInner { get; set; }

        
        public System.Decimal[] NullableValue { get; set; }

        public static void AssertModel(DecimalmoneyArray1M actual, DecimalmoneyArray1M expect, bool checkInInnerOnlyId)
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
                if(expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expect.NullableValue;
                        Assert.That(actual.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = actual.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Decimal[])default));
                        Assert.That(actual.ModelInner.NullableValue, Is.Null);
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
                        if(expect.ModelInner.NullableValue == null)
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Null);
                        }
                        else
                        {
                            Assert.That(actual.ModelInner.NullableValue, Is.Not.Null);
                            {
                                var expectEnumerValue = expect.ModelInner.NullableValue;
                                Assert.That(actual.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                                for(int i = 0; i < expectEnumerValue.Count(); i++)
                                {
                                    var expectItem = expectEnumerValue[i];
                                    var haveItem = actual.ModelInner.NullableValue[i];
                                    Assert.That(expectItem, Is.EqualTo(haveItem));
                                }
                            }
                        }
                    }
                }

        }
    }
}


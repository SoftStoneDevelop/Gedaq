
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Int64bigintArray2M
    {
        
        public System.Int32 Id { get; set; }

        
        public System.Collections.Generic.List<System.Int64> Value { get; set; }

        public Int64bigintArray2MI ModelInner { get; set; }

        
        public System.Collections.Generic.List<System.Int64> NullableValue { get; set; }

        public static void AssertModel(Int64bigintArray2M actual, Int64bigintArray2M expect, bool checkInInnerOnlyId)
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
                        Assert.That(actual.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
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


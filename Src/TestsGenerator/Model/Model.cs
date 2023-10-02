using System;
using TestsGenerator.Constants;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal partial class ModelType : BaseModelType
    {
        public ModelType(
            TypeInfo idTypeInfo,
            TypeInfo typeInfo,
            Func<ValueHelper> valueStorageFactory
            ) 
            : base(idTypeInfo, typeInfo, valueStorageFactory())
        {
            ModelInner = new ModelInnerType(idTypeInfo, typeInfo, valueStorageFactory());
        }

        public override string ClassName => $"{TypeInfo.ItemTypeName}{TypeInfo.DbSqlTypeWithoutSpace()}{(int)TypeInfo.EnumerableType}M";

        public override string TableName => ClassName.ToLowerInvariant();

        public string ModelInnerName => "ModelInner";

        public string ModelInnerColumnName => $"{ModelInner.TableName}_id";

        public string ModelInnerType => ModelInner.ClassName;

        public readonly ModelInnerType ModelInner;

        public ModelValueStorage NewStorage()
        {
            return new ModelValueStorage(TypeInfo, ValueStorage);
        }

        public string Assert(string modelVariable, ModelValue expectValue, bool innerHaveOnlyId = false)
        {
            if (TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                return AssertSingle(modelVariable, expectValue, innerHaveOnlyId);
            }
            else
            {
                return AssertEnumerable(modelVariable, expectValue, innerHaveOnlyId);
            }
        }

        private string AssertSingle(string modelVariable, ModelValue expectValue, bool innerHaveOnlyId)
        {
            var builder = new StringBuilderArray.StringBuilderArray();
            builder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{IdName}, Is.EqualTo({expectValue.Id}));
                Assert.That({modelVariable}.{ValueName}, Is.EqualTo({expectValue.Value}));
");
            if (expectValue.NullableValue == ValueConstants.NullValue)
            {
                builder.Append($@"
                Assert.That({modelVariable}.{NullableValueName}, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                Assert.That({modelVariable}.{NullableValueName}, Is.Not.Null);
                Assert.That({modelVariable}.{NullableValueName}, Is.EqualTo({expectValue.NullableValue}));
");
            }

            if (expectValue.InnerModel == null)
            {
                builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}, Is.Not.Null);
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.IdName}, Is.EqualTo({expectValue.InnerModel.Id}));
");
                if (innerHaveOnlyId)
                {
                    builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.ValueName}, Is.EqualTo(({ModelInner.ValueType})default));
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
");
                }
                else
                {
                    builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.ValueName}, Is.EqualTo({expectValue.InnerModel.Value}));
");
                    if (expectValue.InnerModel.NullableValue == ValueConstants.NullValue)
                    {
                        builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
");
                    }
                    else
                    {
                        builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Not.Null);
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.EqualTo({expectValue.InnerModel.NullableValue}));
");
                    }
                }
            }
            return builder.ToString();
        }

        public string AssertEnumerable(string modelVariable, ModelValue expectValue, bool innerHaveOnlyId)
        {
            var builder = new StringBuilderArray.StringBuilderArray();
            builder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{IdName}, Is.EqualTo({expectValue.Id}));
                {{
                    var expectEnumerValue = {expectValue.Value};
                    Assert.That({modelVariable}.{ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{ValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}
");
            if (expectValue.NullableValue == ValueConstants.NullValue)
            {
                builder.Append($@"
                Assert.That({modelVariable}.{NullableValueName}, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                Assert.That({modelVariable}.{NullableValueName}, Is.Not.Null);
                {{
                    var expectEnumerValue = {expectValue.NullableValue};
                    Assert.That({modelVariable}.{NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{NullableValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}
");
            }

            if (expectValue.InnerModel == null)
            {
                builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}, Is.Not.Null);
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.IdName}, Is.EqualTo({expectValue.InnerModel.Id}));
");
                if (innerHaveOnlyId)
                {
                    builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.ValueName}, Is.EqualTo(({ModelInner.ValueType})default));
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
");
                }
                else
                {
                    builder.Append($@"
                {{
                    var expectEnumerValue = {expectValue.InnerModel.Value};
                    Assert.That({modelVariable}.{ModelInnerName}.{ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{ModelInnerName}.{ValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}
");
                    if (expectValue.InnerModel.NullableValue == ValueConstants.NullValue)
                    {
                        builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
");
                    }
                    else
                    {
                        builder.Append($@"
                Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Not.Null);
                {{
                    var expectEnumerValue = {expectValue.InnerModel.NullableValue};
                    Assert.That({modelVariable}.{ModelInnerName}.{NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{ModelInnerName}.{NullableValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}
");
                    }
                }
            }
            return builder.ToString();
        }

        public string Assert(string modelVariable, string expectVariable, bool innerHaveOnlyId = false)
        {
            if (TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                return AssertSingle(modelVariable, expectVariable, innerHaveOnlyId);
            }
            else
            {
                return AssertEnumerable(modelVariable, expectVariable, innerHaveOnlyId);
            }
        }

        private string AssertSingle(string modelVariable, string expectVariable, bool innerHaveOnlyId)
        {
            var builder = new StringBuilderArray.StringBuilderArray();
            builder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{IdName}, Is.EqualTo({expectVariable}.{IdName}));
                Assert.That({modelVariable}.{ValueName}, Is.EqualTo({expectVariable}.{ValueName}));
                if({expectVariable}.{NullableValueName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Not.Null);
                    Assert.That({modelVariable}.{NullableValueName}, Is.EqualTo({expectVariable}.{NullableValueName}));
                }}

                if({expectVariable}.{ModelInnerName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{ModelInnerName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{ModelInnerName}, Is.Not.Null);
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.IdName}, Is.EqualTo({expectVariable}.{ModelInnerName}.{ModelInner.IdName}));
");
            if (innerHaveOnlyId)
            {
                builder.Append($@"
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.ValueName}, Is.EqualTo(({ModelInner.ValueType})default));
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.ValueName}, Is.EqualTo({expectVariable}.{ModelInnerName}.{ModelInner.ValueName}));
                    if({expectVariable}.{ModelInnerName}.{ModelInner.NullableValueName} == {ValueConstants.NullValue})
                    {{
                        Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
                    }}
                    else
                    {{
                        Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Not.Null);
                        Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.EqualTo({expectVariable}.{ModelInnerName}.{ModelInner.NullableValueName}));
                    }}
");
            }

            builder.Append($@"
                }}
");
            return builder.ToString();
        }

        private string AssertEnumerable(string modelVariable, string expectVariable, bool innerHaveOnlyId)
        {
            var builder = new StringBuilderArray.StringBuilderArray();
            builder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{IdName}, Is.EqualTo({expectVariable}.{IdName}));
                {{
                    var expectEnumerValue = {expectVariable}.{ValueName};
                    Assert.That({modelVariable}.{ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{ValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}
                if({expectVariable}.{NullableValueName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Not.Null);
                    {{
                        var expectEnumerValue = {expectVariable}.{NullableValueName};
                        Assert.That({modelVariable}.{NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {{
                            var expectItem = expectEnumerValue[i];
                            var haveItem = {modelVariable}.{NullableValueName}[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }}
                    }}
                }}

                if({expectVariable}.{ModelInnerName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{ModelInnerName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{ModelInnerName}, Is.Not.Null);
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.IdName}, Is.EqualTo({expectVariable}.{ModelInnerName}.{ModelInner.IdName}));
");
            if (innerHaveOnlyId)
            {
                builder.Append($@"
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.ValueName}, Is.EqualTo(({ModelInner.ValueType})default));
                    Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                    {{
                        var expectEnumerValue = {expectVariable}.{ModelInnerName}.{ValueName};
                        Assert.That({modelVariable}.{ModelInnerName}.{ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {{
                            var expectItem = expectEnumerValue[i];
                            var haveItem = {modelVariable}.{ModelInnerName}.{ValueName}[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }}
                    }}
                    if({expectVariable}.{ModelInnerName}.{ModelInner.NullableValueName} == {ValueConstants.NullValue})
                    {{
                        Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Null);
                    }}
                    else
                    {{
                        Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}, Is.Not.Null);
                        {{
                            var expectEnumerValue = {expectVariable}.{ModelInnerName}.{ModelInner.NullableValueName};
                            Assert.That({modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                            for(int i = 0; i < expectEnumerValue.Count(); i++)
                            {{
                                var expectItem = expectEnumerValue[i];
                                var haveItem = {modelVariable}.{ModelInnerName}.{ModelInner.NullableValueName}[i];
                                Assert.That(expectItem, Is.EqualTo(haveItem));
                            }}
                        }}
                    }}
");
            }

            builder.Append($@"
                }}
");
            return builder.ToString();
        }
    }
}
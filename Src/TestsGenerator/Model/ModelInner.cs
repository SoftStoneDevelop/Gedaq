using System.Text;
using TestsGenerator.Constants;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class ModelInnerType : BaseModelType
    {
        public ModelInnerType(
            TypeInfo idTypeInfo,
            TypeInfo typeInfo,
            ValueHelper valueStorage
            )
            : base(idTypeInfo, typeInfo, valueStorage)
        {
        }

        public override string ClassName => $"{TypeInfo.ItemTypeName}{TypeInfo.DbSqlTypeWithoutSpace()}{(int)TypeInfo.EnumerableType}MI";

        public override string TableName => ClassName.ToLowerInvariant();

        public string Assert(string modelVariable, InnerModelValue expectValue)
        {
            if(TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                return AssertSingle(modelVariable, expectValue);
            }
            else
            {
                return AssertEnumerable(modelVariable, expectValue);
            }
        }

        private string AssertSingle(string modelVariable, InnerModelValue expectValue)
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

            return builder.ToString();
        }

        private string AssertEnumerable(string modelVariable, InnerModelValue expectValue)
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

            return builder.ToString();
        }

        public string Assert(string modelVariable, string expectVariable)
        {
            if (TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                return AssertSingle(modelVariable, expectVariable);
            }
            else
            {
                return AssertEnumerable(modelVariable, expectVariable);
            }
        }

        private string AssertSingle(string modelVariable, string expectVariable)
        {
            return
                $@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{IdName}, Is.EqualTo({expectVariable}.{IdName}));
                Assert.That({modelVariable}.{ValueName}, Is.EqualTo({expectVariable}.{ValueName}));
                if({expectVariable}.{NullableValueName} != {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Not.Null);
                    Assert.That({modelVariable}.{NullableValueName}, Is.EqualTo({expectVariable}.{NullableValueName}));
                }}
                else
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Null);
                }}
";
        }

        private string AssertEnumerable(string modelVariable, string expectVariable)
        {
            return
                $@"
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
                if({expectVariable}.{NullableValueName} != {ValueConstants.NullValue})
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
                else
                {{
                    Assert.That({modelVariable}.{NullableValueName}, Is.Null);
                }}
";
        }
    }
}
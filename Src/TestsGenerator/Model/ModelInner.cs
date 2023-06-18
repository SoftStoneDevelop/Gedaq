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

        public override string ClassName => $"{TypeInfo.TypeName}_{TypeInfo.DbSqlTypeWithoutSpace()}_ModelInner";

        public override string TableName => ClassName.ToLowerInvariant();

        public string Assert(string modelVariable, InnerModelValue expectValue)
        {
            var builder = new StringBuilder();
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

        public string Assert(string modelVariable, string expectVariable)
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
    }
}
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

        public string Assert(InnerModelValue expectValue)
        {
            var builder = new StringBuilder();
            builder.Append($@"
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo({expectValue.Id}));
                Assert.That(model.Value, Is.EqualTo({expectValue.Value}));
");
            if (expectValue.NullableValue == ValueConstants.NullValue)
            {
                builder.Append($@"
                Assert.That(model.NullableValue, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo({expectValue.NullableValue}));
");
            }

            return builder.ToString();
        }
    }
}
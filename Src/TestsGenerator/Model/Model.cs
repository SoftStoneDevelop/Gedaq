using System;
using System.Text;
using TestsGenerator.Constants;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class ModelType : BaseModelType
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

        public override string ClassName => TypeInfo.TypeName + "Model";

        public override string TableName => ClassName.ToLowerInvariant();

        public string ModelInnerName => "ModelInner";

        public string ModelInnerColumnName => $"{ModelInner.TableName}_id";

        public string ModelInnerType => ModelInner.ClassName;

        public readonly ModelInnerType ModelInner;

        public ModelValueStorage NewStorage()
        {
            return new ModelValueStorage(ValueStorage);
        }

        public string Assert(ModelValue expectValue, bool innerHaveOnlyId = false)
        {
            var builder = new StringBuilder();
            builder.Append($@"
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo({expectValue.Id}));
                Assert.That(model.Value, Is.EqualTo({expectValue.Value}));
");
            if(expectValue.NullableValue == ValueConstants.NullValue)
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

            if (expectValue.InnerModel == null)
            {
                builder.Append($@"
                Assert.That(model.ModelInner, Is.Null);
");
            }
            else
            {
                builder.Append($@"
                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo({expectValue.InnerModel.Id}));
");
                if(innerHaveOnlyId)
                {
                    builder.Append($@"
                Assert.That(model.ModelInner.Value, Is.EqualTo(({ModelInner.ValueType})default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);
");
                }
                else
                {
                    builder.Append($@"
                Assert.That(model.ModelInner.Value, Is.EqualTo({expectValue.InnerModel.Value}));
");
                    if (expectValue.InnerModel.NullableValue == ValueConstants.NullValue)
                    {
                        builder.Append($@"
                Assert.That(model.ModelInner.NullableValue, Is.Null);
");
                    }
                    else
                    {
                        builder.Append($@"
                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo({expectValue.InnerModel.NullableValue}));
");
                    }
                }
            }
            return builder.ToString();
        }
    }
}
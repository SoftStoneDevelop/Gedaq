using System;
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

        public string ModelInnerType => ModelInner.ClassName;

        public readonly ModelInnerType ModelInner;

        public ModelValueStorage NewStorage()
        {
            return new ModelValueStorage(ValueStorage);
        }
    }
}
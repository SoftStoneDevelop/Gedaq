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
            Func<ValueHelper> valueStorageFactory)
            : base(idTypeInfo, typeInfo, valueStorageFactory())
        {
            ModelInner = new ModelInnerType(idTypeInfo, typeInfo, valueStorageFactory());
        }

        public override string ClassName(bool isFlat, bool withDbTypeAttributes = false)
        {
            return $"{ValueConstants.FlatModelPrefix(isFlat)}{TypeInfo.ItemTypeName}{TypeInfo.DbSqlTypeWithoutSpace()}{(int)TypeInfo.EnumerableType}M{(withDbTypeAttributes ? "WA" : string.Empty)}";
        }

        public override string TableName => ClassName(false).ToLowerInvariant();

        public string ModelInnerName => "ModelInner";

        public string ModelInnerColumnName => $"{ModelInner.TableName}_id";

        public string ModelInnerType => ModelInner.ClassName(false);

        public readonly ModelInnerType ModelInner;

        public ModelValueStorage NewStorage()
        {
            return new ModelValueStorage(TypeInfo, ValueStorage);
        }
    }
}
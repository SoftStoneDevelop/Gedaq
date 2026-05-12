using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class ModelInnerType : BaseModelType
    {
        public ModelInnerType(
            TypeInfo idTypeInfo,
            TypeInfo typeInfo,
            ValueHelper valueStorage)
            : base(idTypeInfo, typeInfo, valueStorage)
        {
        }

        public override string ClassName(bool isFlat, bool withDbTypeAttributes = false)
        {
            return $"{TypeInfo.ItemTypeName}{TypeInfo.ItemTypeNamePostfix}{TypeInfo.DbSqlTypeWithoutSpace()}E{(int)TypeInfo.EnumerableType}MI{(withDbTypeAttributes ? "WA" : string.Empty)}";
        }

        public override string TableName => ClassName(false).ToLowerInvariant();
    }
}
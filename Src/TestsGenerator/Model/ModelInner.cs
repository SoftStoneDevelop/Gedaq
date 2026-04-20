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

        public override string ClassName(bool isFlat)
        {
            return $"{TypeInfo.ItemTypeName}{TypeInfo.DbSqlTypeWithoutSpace()}{(int)TypeInfo.EnumerableType}MI";
        }

        public override string TableName => ClassName(false).ToLowerInvariant();
    }
}
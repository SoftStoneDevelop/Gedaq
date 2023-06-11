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
    }
}
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal abstract class BaseModelType
    {
        public BaseModelType(
            TypeInfo idTypeInfo, 
            TypeInfo typeInfo, 
            ValueHelper valueStorage
            )
        {
            TypeInfo = typeInfo;
            IdTypeInfo = idTypeInfo;
            ValueStorage = valueStorage;
        }

        public ValueHelper ValueStorage { get; }

        public string IdName => "Id";

        public string IdType => "System.Int32";

        public TypeInfo IdTypeInfo { get; }

        public string IdColumnName => IdName.ToLowerInvariant();

        public string ValueName => "Value";

        public string ValueType => TypeInfo.TypeFullName;

        public string ValueColumnName => ValueName.ToLowerInvariant();

        public string NullableValueName => "NullableValue";

        public string NullableValueType => (TypeInfo.IsReferenceType || TypeInfo.EnumerableType != Enums.EnumerableType.SingleType) ? TypeInfo.TypeFullName : TypeInfo.TypeFullName + "?";

        public string NullableValueColumnName => NullableValueName.ToLowerInvariant();

        public TypeInfo TypeInfo { get; }

        public abstract string TableName { get; }

        public abstract string ClassName { get; }
    }
}
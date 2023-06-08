namespace TestsGenegator.Model
{
    internal abstract class BaseModel
    {
        public BaseModel(string idDbType, TypeInfo typeInfo)
        {
            TypeInfo = typeInfo;
            IdDbType = idDbType;
        }

        public string IdName => "Id";

        public string IdType => "System.Int32";

        public string IdDbType { get; }

        public string IdColumnName => IdName.ToLowerInvariant();

        public string ValueName => "Value";

        public string ValueType => TypeInfo.TypeFullName;

        public string ValueColumnName => ValueName.ToLowerInvariant();


        public string NullableValueName => "NullableValue";

        public string NullableValueType => TypeInfo.IsReferenceType ? TypeInfo.TypeFullName : TypeInfo.TypeFullName + "?";

        public string NullableValueColumnName => NullableValueName.ToLowerInvariant();

        public TypeInfo TypeInfo { get; }

        public abstract string TableName { get; }

        public abstract string ClassName { get; }
    }
}
namespace TestsGenegator.Model
{
    internal class ModelInner : BaseModel
    {
        public ModelInner(
            string dbType,
            string typeName, 
            string typeFullName,
            string idDbType,
            bool isReferenceType
            )
            : base(idDbType, new TypeInfo(dbType, typeName, typeFullName, isReferenceType))
        {
        }

        public override string ClassName => TypeInfo.TypeName + "ModelInner";

        public override string TableName => ClassName.ToLowerInvariant();
    }
}
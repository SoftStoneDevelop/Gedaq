namespace TestsGenegator.Model
{
    internal class Model : BaseModel
    {
        public Model(
            string dbType,
            string typeName, 
            string typeFullName,
            string idDbType,
            bool isReferenceType = false
            ) 
            : base(idDbType, new TypeInfo(dbType, typeName, typeFullName, isReferenceType))
        {
            ModelInner = new ModelInner(dbType, typeName, typeFullName, idDbType, isReferenceType);
        }

        public override string ClassName => TypeInfo.TypeName + "Model";

        public override string TableName => ClassName.ToLowerInvariant();

        public string ModelInnerName => "ModelInner";

        public string ModelInnerType => ModelInner.ClassName;

        public readonly ModelInner ModelInner;
    }
}
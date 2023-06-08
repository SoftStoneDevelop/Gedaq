namespace TestsGenegator.Model
{
    internal class NpgsqlModel : Model
    {
        public NpgsqlModel(
            string dbType,
            string typeName,
            string typeFullName,
            bool isReferenceType = false
            )
            : base(dbType, typeName, typeFullName, "integer", isReferenceType)
        {

        }
    }
}
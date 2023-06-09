using System.Data;

namespace TestsGenerator.TypeInfos
{
    internal abstract class TypeInfo
    {
        public TypeInfo(
            DbType dbType,
            string dbTypeStr,
            string typeName,
            string typeFullName,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            )
        {
            DbType = dbType;
            DbSqlType = dbTypeStr;
            TypeName = typeName;
            TypeFullName = typeFullName;
            IsReferenceType = isReferenceType;

            MustHaveSize = mustHaveSize;
            Size = size;
        }

        public readonly DbType DbType;

        public abstract string SpecialDbTypeStr();

        public abstract string DbTypeStr();

        public readonly bool MustHaveSize;

        public readonly int Size;

        public readonly string DbSqlType;

        public readonly string TypeName;

        public readonly string TypeFullName;

        public readonly bool IsReferenceType;
    }
}
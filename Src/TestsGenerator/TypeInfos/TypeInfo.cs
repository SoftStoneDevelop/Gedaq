using System.Data;
using System.Text.RegularExpressions;

namespace TestsGenerator.TypeInfos
{
    internal abstract partial class TypeInfo
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

        public string DbSqlTypeWithoutSpace()
        {
            var result = WhiteSpaces().Replace(DbSqlType, "_");
            return result;
        }

        public abstract string DbSqlAfterType();

        [GeneratedRegex("\\s+")]
        public static partial Regex WhiteSpaces();

        public readonly string TypeName;

        public readonly string TypeFullName;

        public readonly bool IsReferenceType;
    }
}
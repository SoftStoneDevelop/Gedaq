using System.Data;
using System.Text.RegularExpressions;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeInfos
{
    internal abstract partial class TypeInfo
    {
        public TypeInfo(
            DbType dbType,
            string dbTypeStr,
            string typeName,
            string typeFullName,
            EnumerableType enumerableType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            )
        {
            DbType = dbType;
            DbSqlType = dbTypeStr;
            ItemTypeName = typeName;
            ItemTypeFullName = typeFullName;
            IsReferenceType = isReferenceType;

            MustHaveSize = mustHaveSize;
            Size = size;
            EnumerableType = enumerableType;
        }

        public EnumerableType EnumerableType { get; }

        public readonly DbType DbType;

        public abstract string SpecialDbTypeStr();

        public abstract string DbTypeStr();

        public readonly bool MustHaveSize;

        public readonly int Size;

        public readonly string DbSqlType;

        public abstract string DefaultMapType { get; }

        public string DefaultMapTypeNullable
        {
            get
            {
                if(DefaultMapType.IsNullable())
                {
                    return DefaultMapType;
                }

                return $"{DefaultMapType}?";
            }
        }

        public string DbSqlTypeWithoutSpace()
        {
            var result = WhiteSpaces().Replace(DbSqlType, "_");
            result = SquareBracketsSpaces().Replace(result, "Array");
            return result;
        }

        public abstract string DbSqlAfterType();

        [GeneratedRegex("\\s+")]
        public static partial Regex WhiteSpaces();
        [GeneratedRegex("\\[\\]")]
        public static partial Regex SquareBracketsSpaces();

        public readonly string ItemTypeName;

        public readonly string ItemTypeFullName;

        public abstract string TypeName { get; }

        public abstract string TypeFullName { get; }

        public readonly bool IsReferenceType;
    }
}
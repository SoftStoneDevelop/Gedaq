using NpgsqlTypes;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeInfos
{
    internal class PostgreSQLTypeInfo : TypeInfo
    {
        public PostgreSQLTypeInfo(
            NpgsqlDbType npgsqlDbType,
            string typeName,
            string typeFullName,
            EnumerableType enumerableType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false,
            int arrayDimensions = 1)
            : base(
                npgsqlDbType.ToDbType(),
                npgsqlDbType.ToDbSqlTableType(arrayDimensions),
                typeName,
                typeFullName,
                enumerableType,
                size,
                mustHaveSize,
                isReferenceType,
                arrayDimensions: arrayDimensions)
        {
            NpgsqlDbType = npgsqlDbType;
        }

        public readonly NpgsqlDbType NpgsqlDbType;

        public override string DefaultMapType => NpgsqlDbType.ToDefaultMapType(ArrayDimensions);

        public override string TypeName
        {
            get
            {
                switch (EnumerableType)
                {
                    default:
                    case EnumerableType.SingleType:
                    {
                        return $"{ItemTypeName}";
                    }

                    case EnumerableType.MArray:
                    {
                        return $"{ItemTypeName}{TypeHelper.ArrayDimensions(ArrayDimensions)}";
                    }

                    case EnumerableType.List:
                    {
                        return $"List<{ItemTypeName}>";
                    }
                }
            }
        }

        public override string TypeFullName
        {
            get
            {
                switch (EnumerableType)
                {
                    default:
                    case EnumerableType.SingleType:
                    {
                        return $"{ItemTypeFullName}";
                    }

                    case EnumerableType.MArray:
                    {
                        return $"{ItemTypeFullName}{TypeHelper.ArrayDimensions(ArrayDimensions)}";
                    }

                    case EnumerableType.List:
                    {
                        return $"System.Collections.Generic.List<{ItemTypeFullName}>";
                    }
                }
            }
        }

        public override string SpecialDbTypeStr()
        {
            return $"(NpgsqlTypes.NpgsqlDbType)({(int)NpgsqlDbType})";
        }

        public override string DbTypeStr()
        {
            return $"(System.Data.DbType)({(int)DbType})";
        }

        public override string DbSqlAfterType()
        {
            return string.Empty;
        }
    }
}
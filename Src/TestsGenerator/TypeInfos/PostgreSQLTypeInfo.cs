using NpgsqlTypes;
using System;
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
            bool isReferenceType = false
            ) : base(npgsqlDbType.ToDbType(), npgsqlDbType.ToDbSqlTableType(), typeName, typeFullName, enumerableType, size, mustHaveSize, isReferenceType)
        {
            NpgsqlDbType = npgsqlDbType;
        }

        public readonly NpgsqlDbType NpgsqlDbType;

        public override string DefaultMapType => NpgsqlDbType.ToDefaultMapType();

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

                    case EnumerableType.Array:
                    {
                        return $"{ItemTypeName}[]";
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

                    case EnumerableType.Array:
                    {
                        return $"{ItemTypeFullName}[]";
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
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeInfos
{
    internal class ClickhouseTypeInfo : TypeInfo
    {
        public ClickhouseTypeInfo(
            string clickHouseType,
            string typeName,
            string typeFullName,
            EnumerableType enumerableType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false) :
            base(
                clickHouseType.ToDbType(),
                clickHouseType.ToDbSqlTableType(),
                typeName,
                typeFullName,
                enumerableType,
                size,
                mustHaveSize,
                isReferenceType)
        {
            ClickHouseType = clickHouseType;
        }

        public readonly string ClickHouseType;

        public override string DefaultMapType => ClickHouseType.ToDefaultMapType();

        public override string SpecialDbTypeStr()
        {
            return $"(System.String)({ClickHouseType})";
        }

        public override string DbTypeStr()
        {
            return $"(System.Data.DbType)({(int)DbType})";
        }

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
                }
            }
        }

        public override string DbSqlAfterType()
        {
            return string.Empty;
        }
    }
}
using System;
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
            bool isReferenceType = false,
            int arrayDimensions = 1,
            string typeNamePostfix = "") :
            base(
                clickHouseType.ToDbType(),
                clickHouseType.ToDbSqlTableType(enumerableType, arrayDimensions),
                typeName,
                typeFullName,
                enumerableType,
                size,
                mustHaveSize,
                isReferenceType,
                arrayDimensions: arrayDimensions,
                typeNamePostfix: typeNamePostfix)
        {
            ClickHouseBaseType = clickHouseType;
        }

        public readonly string ClickHouseBaseType;

        public override string DefaultMapType => ClickHouseBaseType.ToDefaultMapType(EnumerableType, ArrayDimensions);

        public override string SpecialDbTypeStr()
        {
            return DbSqlType;
        }

        public override string DbTypeStr()
        {
            throw new NotImplementedException();
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

                    case EnumerableType.MArray:
                    {
                        return $"{ItemTypeName}{TypeHelper.ArrayDimensions(ArrayDimensions)}";
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
                }
            }
        }

        public override string DbSqlAfterType()
        {
            return string.Empty;
        }
    }
}
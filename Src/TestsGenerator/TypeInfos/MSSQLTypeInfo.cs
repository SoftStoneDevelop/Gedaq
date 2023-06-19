using System;
using System.Data;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeInfos
{
    internal class MSSQLTypeInfo : TypeInfo
    {
        public MSSQLTypeInfo(
            SqlDbType sqlDbType,
            string typeName,
            string typeFullName,
            EnumerableType enumerableType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            ) : base(sqlDbType.ToDbType(), sqlDbType.ToDbSqlTableType(), typeName, typeFullName, enumerableType, size, mustHaveSize, isReferenceType)
        {
            SqlDbType = sqlDbType;
        }

        public readonly SqlDbType SqlDbType;

        public override string DefaultMapType => SqlDbType.ToDefaultMapType();

        public override string SpecialDbTypeStr()
        {
            return $"System.Data.{SqlDbType.ToString()}";
        }

        public override string DbTypeStr()
        {
            return $"System.Data.DbType.{DbType.ToString()}";
        }

        public override string TypeName
        {
            get
            {
                return ItemTypeName;
            }
        }

        public override string TypeFullName
        {
            get
            {
                return ItemTypeFullName;
            }
        }

        public override string DbSqlAfterType()
        {
            if(SqlDbType == SqlDbType.Decimal)
            {
                return "(38, 38)";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
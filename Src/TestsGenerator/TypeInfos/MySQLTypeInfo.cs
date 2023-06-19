using MySqlConnector;
using System;
using System.Data;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeInfos
{
    internal class MySQLTypeInfo : TypeInfo
    {
        public MySQLTypeInfo(
            MySqlDbType mySqlDbType,
            string typeName,
            string typeFullName,
            EnumerableType enumerableType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            ) : base(mySqlDbType.ToDbType(), mySqlDbType.ToDbSqlTableType(), typeName, typeFullName, enumerableType, size, mustHaveSize, isReferenceType)
        {
            MySqlDbType = mySqlDbType;
        }

        public readonly MySqlDbType MySqlDbType;

        public override string DefaultMapType => MySqlDbType.ToDefaultMapType();

        public override string SpecialDbTypeStr()
        {
            return $"MySqlConnector.{MySqlDbType.ToString()}";
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
            if (MySqlDbType == MySqlDbType.DateTime)
            {
                return "(6)";
            }
            if (MySqlDbType == MySqlDbType.Decimal)
            {
                return "(30, 30)";
            }
            if (MySqlDbType == MySqlDbType.Float)
            {
                return "(30, 30)";
            }
            if (MySqlDbType == MySqlDbType.Time)
            {
                return "(6)";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
using MySqlConnector;
using System;
using System.Data;

namespace TestsGenerator.Helpers
{
    internal static class MySqlDbTypeExtension
    {
        public static DbType ToDbType(this MySqlDbType mySqlDbType)
        {
            var param = new MySqlParameter();
            param.MySqlDbType = mySqlDbType;
            return param.DbType;
        }

        public static string ToDbSqlTableType(this MySqlDbType mySqlDbType)
        {
            switch (mySqlDbType)
            {
                case MySqlDbType.Int32:
                {
                    return "int";
                }

                case MySqlDbType.Int64:
                {
                    return "bigint";
                }

                case MySqlDbType.Int16:
                {
                    return "smallint";
                }

                case MySqlDbType.Bool:
                {
                    return "boolean";
                }

                case MySqlDbType.Decimal:
                {
                    return "decimal";
                }

                case MySqlDbType.Double:
                {
                    return "double";
                }

                case MySqlDbType.Float:
                {
                    return "float";
                }

                case MySqlDbType.Date:
                {
                    return "date";
                }

                case MySqlDbType.DateTime:
                {
                    return "datetime";
                }

                case MySqlDbType.Time:
                {
                    return "time";
                }

                case MySqlDbType.Text:
                {
                    return "text";
                }

                case MySqlDbType.Guid:
                {
                    return "text";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
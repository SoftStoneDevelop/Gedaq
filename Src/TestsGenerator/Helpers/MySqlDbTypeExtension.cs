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
                case MySqlDbType.UInt32:
                {
                    return "int UNSIGNED";
                }

                case MySqlDbType.Int32:
                {
                    return "int";
                }

                case MySqlDbType.UInt64:
                {
                    return "bigint UNSIGNED";
                }

                case MySqlDbType.Int64:
                {
                    return "bigint";
                }

                case MySqlDbType.UInt16:
                {
                    return "smallint UNSIGNED";
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

                case MySqlDbType.UByte:
                {
                    return "tinyint UNSIGNED";
                }

                case MySqlDbType.Byte:
                {
                    return "tinyint";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToDefaultMapType(this MySqlDbType mySqlDbType)
        {
            switch (mySqlDbType)
            {
                case MySqlDbType.UInt32:
                {
                    return "System.UInt32";
                }

                case MySqlDbType.Int32:
                {
                    return "System.Int32";
                }

                case MySqlDbType.UInt64:
                {
                    return "System.UInt64";
                }

                case MySqlDbType.Int64:
                {
                    return "System.Int64";
                }

                case MySqlDbType.UInt16:
                {
                    return "System.UInt16";
                }

                case MySqlDbType.Int16:
                {
                    return "System.Int16";
                }

                case MySqlDbType.Bool:
                {
                    return "System.Boolean";
                }

                case MySqlDbType.Decimal:
                {
                    return "System.Decimal";
                }

                case MySqlDbType.Double:
                {
                    return "System.Double";
                }

                case MySqlDbType.Float:
                {
                    return "System.Single";
                }

                case MySqlDbType.Date:
                {
                    return "System.DateTime";
                }

                case MySqlDbType.DateTime:
                {
                    return "System.DateTime";
                }

                case MySqlDbType.Time:
                {
                    return "System.TimeSpan";
                }

                case MySqlDbType.Text:
                {
                    return "System.String";
                }

                case MySqlDbType.Guid:
                {
                    return "System.Guid";
                }

                case MySqlDbType.Byte:
                {
                    return "System.SByte";
                }

                case MySqlDbType.UByte:
                {
                    return "System.Byte";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
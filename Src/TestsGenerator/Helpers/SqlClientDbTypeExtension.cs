using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace TestsGenerator.Helpers
{
    internal static class SqlClientDbTypeExtension
    {
        public static DbType ToDbType(this SqlDbType sqlDbType)
        {
            var param = new SqlParameter();
            param.SqlDbType = sqlDbType;
            return param.DbType;
        }

        public static string ToDbSqlTableType(this SqlDbType npgsqlDbType)
        {
            switch (npgsqlDbType)
            {
                case SqlDbType.Int:
                {
                    return "int";
                }

                case SqlDbType.BigInt:
                {
                    return "bigint";
                }

                case SqlDbType.TinyInt:
                {
                    return "tinyint";
                }

                case SqlDbType.SmallInt:
                {
                    return "smallint";
                }

                case SqlDbType.Decimal:
                {
                    return "decimal";
                }

                case SqlDbType.Float:
                {
                    return "float";
                }

                case SqlDbType.Bit:
                {
                    return "bit";
                }

                case SqlDbType.Real:
                {
                    return "real";
                }

                case SqlDbType.Time:
                {
                    return "time";
                }

                case SqlDbType.DateTime2:
                {
                    return "datetime2";
                }

                case SqlDbType.Date:
                {
                    return "date";
                }

                case SqlDbType.Text:
                {
                    return "text";
                }

                case SqlDbType.UniqueIdentifier:
                {
                    return "uniqueidentifier";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToDefaultMapType(this SqlDbType npgsqlDbType)
        {
            switch (npgsqlDbType)
            {
                case SqlDbType.Int:
                {
                    return "System.Int32";
                }

                case SqlDbType.BigInt:
                {
                    return "System.Int64";
                }

                case SqlDbType.TinyInt:
                {
                    return "System.Byte";
                }

                case SqlDbType.SmallInt:
                {
                    return "System.Int16";
                }

                case SqlDbType.Decimal:
                {
                    return "System.Decimal";
                }

                case SqlDbType.Float:
                {
                    return "System.Double";
                }

                case SqlDbType.Bit:
                {
                    return "System.Boolean";
                }

                case SqlDbType.Real:
                {
                    return "System.Single";
                }

                case SqlDbType.Time:
                {
                    return "System.TimeSpan";
                }

                case SqlDbType.DateTime2:
                {
                    return "System.DateTime";
                }

                case SqlDbType.Date:
                {
                    return "System.DateTime";
                }

                case SqlDbType.Text:
                {
                    return "System.String";
                }

                case SqlDbType.UniqueIdentifier:
                {
                    return "System.Guid";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
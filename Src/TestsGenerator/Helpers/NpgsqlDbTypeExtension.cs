using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;

namespace TestsGenerator.Helpers
{
    internal static class NpgsqlDbTypeExtension
    {
        public static DbType ToDbType(this NpgsqlDbType npgsqlDbType)
        {
            var param = new NpgsqlParameter();
            param.NpgsqlDbType = npgsqlDbType;
            return param.DbType;
        }

        public static string ToDbSqlTableType(this NpgsqlDbType npgsqlDbType)
        {
            switch (npgsqlDbType)
            {
                case NpgsqlDbType.Bigint:
                {
                    return "bigint";
                }
                case NpgsqlDbType.Double:
                {
                    return "double precision";
                }
                case NpgsqlDbType.Integer:
                {
                    return "integer";
                }
                case NpgsqlDbType.Numeric:
                {
                    return "numeric";
                }
                case NpgsqlDbType.Money:
                {
                    return "money";
                }
                case NpgsqlDbType.Real:
                {
                    return "real";
                }
                case NpgsqlDbType.Smallint:
                {
                    return "smallint";
                }
                case NpgsqlDbType.Boolean:
                {
                    return "boolean";
                }
                case NpgsqlDbType.Char:
                {
                    return "char";
                }
                case NpgsqlDbType.Text:
                {
                    return "text";
                }
                case NpgsqlDbType.Timestamp:
                {
                    return "timestamp without time zone";
                }
                case NpgsqlDbType.Time:
                {
                    return "time without time zone";
                }
                case NpgsqlDbType.TimeTz:
                {
                    return "time with time zone";
                }
                case NpgsqlDbType.Date:
                {
                    return "date";
                }
                case NpgsqlDbType.TimestampTz:
                {
                    return "timestamp with time zone";
                }
                case NpgsqlDbType.Inet:
                {
                    return "inet";
                }
                case NpgsqlDbType.Uuid:
                {
                    return "uuid";
                }
                case NpgsqlDbType.Interval:
                {
                    return "interval";
                }
                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToDefaultMapType(this NpgsqlDbType npgsqlDbType)
        {
            switch (npgsqlDbType)
            {
                case NpgsqlDbType.Bigint:
                {
                    return "System.Int64";
                }
                case NpgsqlDbType.Double:
                {
                    return "System.Double";
                }
                case NpgsqlDbType.Integer:
                {
                    return "System.Int32";
                }
                case NpgsqlDbType.Numeric:
                {
                    return "System.Decimal";
                }
                case NpgsqlDbType.Money:
                {
                    return "System.Decimal";
                }
                case NpgsqlDbType.Real:
                {
                    return "System.Single";
                }
                case NpgsqlDbType.Smallint:
                {
                    return "System.Int16";
                }
                case NpgsqlDbType.Boolean:
                {
                    return "System.Boolean";
                }
                case NpgsqlDbType.Char:
                {
                    return "System.String";
                }
                case NpgsqlDbType.Text:
                {
                    return "System.String";
                }
                case NpgsqlDbType.Timestamp:
                {
                    return "System.DateTime";
                }
                case NpgsqlDbType.Time:
                {
                    return "System.TimeSpan";
                }
                case NpgsqlDbType.TimeTz:
                {
                    return "System.DateTimeOffset";
                }
                case NpgsqlDbType.Date:
                {
                    return "System.DateTime";
                }
                case NpgsqlDbType.TimestampTz:
                {
                    return "System.DateTime";
                }
                case NpgsqlDbType.Inet:
                {
                    return "System.Net.IPAddress";
                }
                case NpgsqlDbType.Uuid:
                {
                    return "System.Guid";
                }
                case NpgsqlDbType.Interval:
                {
                    return "System.TimeSpan";
                }
                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
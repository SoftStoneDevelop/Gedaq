using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
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
                case NpgsqlDbType.MacAddr:
                {
                    return "macaddr";
                }
                case NpgsqlDbType.Uuid:
                {
                    return "uuid";
                }
                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
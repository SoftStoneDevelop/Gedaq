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
                case NpgsqlDbType.Bigint | NpgsqlDbType.Array:
                {
                    return "bigint[]";
                }

                case NpgsqlDbType.Double:
                {
                    return "double precision";
                }case NpgsqlDbType.Double | NpgsqlDbType.Array:
                {
                    return "double precision[]";
                }

                case NpgsqlDbType.Integer:
                {
                    return "integer";
                }
                case NpgsqlDbType.Integer | NpgsqlDbType.Array:
                {
                    return "integer[]";
                }

                case NpgsqlDbType.Numeric:
                {
                    return "numeric";
                }
                case NpgsqlDbType.Numeric | NpgsqlDbType.Array:
                {
                    return "numeric[]";
                }

                case NpgsqlDbType.Money:
                {
                    return "money";
                }
                case NpgsqlDbType.Money | NpgsqlDbType.Array:
                {
                    return "money[]";
                }

                case NpgsqlDbType.Real:
                {
                    return "real";
                }
                case NpgsqlDbType.Real | NpgsqlDbType.Array:
                {
                    return "real[]";
                }

                case NpgsqlDbType.Smallint:
                {
                    return "smallint";
                }
                case NpgsqlDbType.Smallint | NpgsqlDbType.Array:
                {
                    return "smallint[]";
                }

                case NpgsqlDbType.Boolean:
                {
                    return "boolean";
                }
                case NpgsqlDbType.Boolean | NpgsqlDbType.Array:
                {
                    return "boolean[]";
                }

                case NpgsqlDbType.Char:
                {
                    return "char";
                }
                case NpgsqlDbType.Char | NpgsqlDbType.Array:
                {
                    return "char[]";
                }

                case NpgsqlDbType.Text:
                {
                    return "text";
                }
                case NpgsqlDbType.Text | NpgsqlDbType.Array:
                {
                    return "text[]";
                }

                case NpgsqlDbType.Timestamp:
                {
                    return "timestamp without time zone";
                }
                case NpgsqlDbType.Timestamp | NpgsqlDbType.Array:
                {
                    return "timestamp without time zone[]";
                }

                case NpgsqlDbType.Time:
                {
                    return "time without time zone";
                }
                case NpgsqlDbType.Time | NpgsqlDbType.Array:
                {
                    return "time without time zone[]";
                }

                case NpgsqlDbType.TimeTz:
                {
                    return "time with time zone";
                }
                case NpgsqlDbType.TimeTz | NpgsqlDbType.Array:
                {
                    return "time with time zone[]";
                }

                case NpgsqlDbType.Date:
                {
                    return "date";
                }
                case NpgsqlDbType.Date | NpgsqlDbType.Array:
                {
                    return "date[]";
                }

                case NpgsqlDbType.TimestampTz:
                {
                    return "timestamp with time zone";
                }
                case NpgsqlDbType.TimestampTz | NpgsqlDbType.Array:
                {
                    return "timestamp with time zone[]";
                }

                case NpgsqlDbType.Inet:
                {
                    return "inet";
                }
                case NpgsqlDbType.Inet | NpgsqlDbType.Array:
                {
                    return "inet[]";
                }

                case NpgsqlDbType.Uuid:
                {
                    return "uuid";
                }
                case NpgsqlDbType.Uuid | NpgsqlDbType.Array:
                {
                    return "uuid[]";
                }

                case NpgsqlDbType.Interval:
                {
                    return "interval";
                }
                case NpgsqlDbType.Interval | NpgsqlDbType.Array:
                {
                    return "interval[]";
                }

                case NpgsqlDbType.Line:
                {
                    return "line";
                }
                case NpgsqlDbType.Line | NpgsqlDbType.Array:
                {
                    return "line[]";
                }

                case NpgsqlDbType.Polygon:
                {
                    return "polygon";
                }
                case NpgsqlDbType.Polygon | NpgsqlDbType.Array:
                {
                    return "polygon[]";
                }

                case NpgsqlDbType.Point:
                {
                    return "point";
                }
                case NpgsqlDbType.Point | NpgsqlDbType.Array:
                {
                    return "point[]";
                }

                case NpgsqlDbType.Circle:
                {
                    return "circle";
                }
                case NpgsqlDbType.Circle | NpgsqlDbType.Array:
                {
                    return "circle[]";
                }

                case NpgsqlDbType.Box:
                {
                    return "box";
                }
                case NpgsqlDbType.Box | NpgsqlDbType.Array:
                {
                    return "box[]";
                }

                case NpgsqlDbType.Path:
                {
                    return "path";
                }
                case NpgsqlDbType.Path | NpgsqlDbType.Array:
                {
                    return "path[]";
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
                case NpgsqlDbType.Bigint | NpgsqlDbType.Array:
                {
                    return "System.Int64[]";
                }

                case NpgsqlDbType.Double:
                {
                    return "System.Double";
                }
                case NpgsqlDbType.Double | NpgsqlDbType.Array:
                {
                    return "System.Double[]";
                }

                case NpgsqlDbType.Integer:
                {
                    return "System.Int32";
                }
                case NpgsqlDbType.Integer | NpgsqlDbType.Array:
                {
                    return "System.Int32[]";
                }

                case NpgsqlDbType.Numeric:
                {
                    return "System.Decimal";
                }
                case NpgsqlDbType.Numeric | NpgsqlDbType.Array:
                {
                    return "System.Decimal[]";
                }

                case NpgsqlDbType.Money:
                {
                    return "System.Decimal";
                }
                case NpgsqlDbType.Money | NpgsqlDbType.Array:
                {
                    return "System.Decimal[]";
                }

                case NpgsqlDbType.Real:
                {
                    return "System.Single";
                }
                case NpgsqlDbType.Real | NpgsqlDbType.Array:
                {
                    return "System.Single[]";
                }

                case NpgsqlDbType.Smallint:
                {
                    return "System.Int16";
                }
                case NpgsqlDbType.Smallint | NpgsqlDbType.Array:
                {
                    return "System.Int16[]";
                }

                case NpgsqlDbType.Boolean:
                {
                    return "System.Boolean";
                }
                case NpgsqlDbType.Boolean | NpgsqlDbType.Array:
                {
                    return "System.Boolean[]";
                }

                case NpgsqlDbType.Char:
                {
                    return "System.String";
                }
                case NpgsqlDbType.Char | NpgsqlDbType.Array:
                {
                    return "System.String[]";
                }

                case NpgsqlDbType.Text:
                {
                    return "System.String";
                }
                case NpgsqlDbType.Text | NpgsqlDbType.Array:
                {
                    return "System.String[]";
                }

                case NpgsqlDbType.Timestamp:
                {
                    return "System.DateTime";
                }
                case NpgsqlDbType.Timestamp | NpgsqlDbType.Array:
                {
                    return "System.DateTime[]";
                }

                case NpgsqlDbType.Time:
                {
                    return "System.TimeSpan";
                }
                case NpgsqlDbType.Time | NpgsqlDbType.Array:
                {
                    return "System.TimeSpan[]";
                }

                case NpgsqlDbType.TimeTz:
                {
                    return "System.DateTimeOffset";
                }
                case NpgsqlDbType.TimeTz | NpgsqlDbType.Array:
                {
                    return "System.DateTimeOffset[]";
                }

                case NpgsqlDbType.Date:
                {
                    return "System.DateTime";
                }
                case NpgsqlDbType.Date | NpgsqlDbType.Array:
                {
                    return "System.DateTime[]";
                }

                case NpgsqlDbType.TimestampTz:
                {
                    return "System.DateTime";
                }
                case NpgsqlDbType.TimestampTz | NpgsqlDbType.Array:
                {
                    return "System.DateTime[]";
                }

                case NpgsqlDbType.Inet:
                {
                    return "System.Net.IPAddress";
                }
                case NpgsqlDbType.Inet | NpgsqlDbType.Array:
                {
                    return "System.Net.IPAddress[]";
                }

                case NpgsqlDbType.Uuid:
                {
                    return "System.Guid";
                }
                case NpgsqlDbType.Uuid | NpgsqlDbType.Array:
                {
                    return "System.Guid[]";
                }

                case NpgsqlDbType.Interval:
                {
                    return "System.TimeSpan";
                }
                case NpgsqlDbType.Interval | NpgsqlDbType.Array:
                {
                    return "System.TimeSpan[]";
                }

                case NpgsqlDbType.Line:
                {
                    return "NpgsqlTypes.NpgsqlLine";
                }
                case NpgsqlDbType.Line | NpgsqlDbType.Array:
                {
                    return "NpgsqlTypes.NpgsqlLine[]";
                }

                case NpgsqlDbType.Polygon:
                {
                    return "NpgsqlTypes.NpgsqlPolygon";
                }
                case NpgsqlDbType.Polygon | NpgsqlDbType.Array:
                {
                    return "NpgsqlTypes.NpgsqlPolygon[]";
                }

                case NpgsqlDbType.Point:
                {
                    return "NpgsqlTypes.NpgsqlPoint";
                }
                case NpgsqlDbType.Point | NpgsqlDbType.Array:
                {
                    return "NpgsqlTypes.NpgsqlPoint[]";
                }

                case NpgsqlDbType.Circle:
                {
                    return "NpgsqlTypes.NpgsqlCircle";
                }
                case NpgsqlDbType.Circle | NpgsqlDbType.Array:
                {
                    return "NpgsqlTypes.NpgsqlCircle[]";
                }

                case NpgsqlDbType.Box:
                {
                    return "NpgsqlTypes.NpgsqlBox";
                }
                case NpgsqlDbType.Box | NpgsqlDbType.Array:
                {
                    return "NpgsqlTypes.NpgsqlBox[]";
                }

                case NpgsqlDbType.Path:
                {
                    return "NpgsqlTypes.NpgsqlPath";
                }
                case NpgsqlDbType.Path | NpgsqlDbType.Array:
                {
                    return "NpgsqlTypes.NpgsqlPath[]";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
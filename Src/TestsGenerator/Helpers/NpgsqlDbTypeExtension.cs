using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Runtime.CompilerServices;

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

        private static string ArrayDimensions(int dimensions = 1)
        {
            var builder = new DefaultInterpolatedStringHandler();
            for (int i = 0; i < dimensions; i++)
            {
                builder.AppendLiteral("[]");
            }

            return builder.ToStringAndClear();
        }

        public static string ToDbSqlTableType(this NpgsqlDbType npgsqlDbType, int dimensions = 1)
        {
            switch (npgsqlDbType)
            {
                case NpgsqlDbType.Bigint:
                {
                    return "bigint";
                }
                case NpgsqlDbType.Bigint | NpgsqlDbType.Array:
                {
                    return $"bigint{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Double:
                {
                    return "double precision";
                }case NpgsqlDbType.Double | NpgsqlDbType.Array:
                {
                    return $"double precision{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Integer:
                {
                    return "integer";
                }
                case NpgsqlDbType.Integer | NpgsqlDbType.Array:
                {
                    return $"integer{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Numeric:
                {
                    return "numeric";
                }
                case NpgsqlDbType.Numeric | NpgsqlDbType.Array:
                {
                    return $"numeric{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Money:
                {
                    return "money";
                }
                case NpgsqlDbType.Money | NpgsqlDbType.Array:
                {
                    return $"money{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Real:
                {
                    return "real";
                }
                case NpgsqlDbType.Real | NpgsqlDbType.Array:
                {
                    return $"real{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Smallint:
                {
                    return "smallint";
                }
                case NpgsqlDbType.Smallint | NpgsqlDbType.Array:
                {
                    return $"smallint{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Boolean:
                {
                    return "boolean";
                }
                case NpgsqlDbType.Boolean | NpgsqlDbType.Array:
                {
                    return $"boolean{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Char:
                {
                    return "char";
                }
                case NpgsqlDbType.Char | NpgsqlDbType.Array:
                {
                    return $"char{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Text:
                {
                    return "text";
                }
                case NpgsqlDbType.Text | NpgsqlDbType.Array:
                {
                    return $"text{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Timestamp:
                {
                    return "timestamp without time zone";
                }
                case NpgsqlDbType.Timestamp | NpgsqlDbType.Array:
                {
                    return $"timestamp without time zone{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Time:
                {
                    return "time without time zone";
                }
                case NpgsqlDbType.Time | NpgsqlDbType.Array:
                {
                    return $"time without time zone{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.TimeTz:
                {
                    return "time with time zone";
                }
                case NpgsqlDbType.TimeTz | NpgsqlDbType.Array:
                {
                    return $"time with time zone{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Date:
                {
                    return "date";
                }
                case NpgsqlDbType.Date | NpgsqlDbType.Array:
                {
                    return $"date{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.TimestampTz:
                {
                    return "timestamp with time zone";
                }
                case NpgsqlDbType.TimestampTz | NpgsqlDbType.Array:
                {
                    return $"timestamp with time zone{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Inet:
                {
                    return "inet";
                }
                case NpgsqlDbType.Inet | NpgsqlDbType.Array:
                {
                    return $"inet{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Uuid:
                {
                    return "uuid";
                }
                case NpgsqlDbType.Uuid | NpgsqlDbType.Array:
                {
                    return $"uuid{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Interval:
                {
                    return "interval";
                }
                case NpgsqlDbType.Interval | NpgsqlDbType.Array:
                {
                    return $"interval{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Line:
                {
                    return "line";
                }
                case NpgsqlDbType.Line | NpgsqlDbType.Array:
                {
                    return $"line{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Polygon:
                {
                    return "polygon";
                }
                case NpgsqlDbType.Polygon | NpgsqlDbType.Array:
                {
                    return $"polygon{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Point:
                {
                    return "point";
                }
                case NpgsqlDbType.Point | NpgsqlDbType.Array:
                {
                    return $"point{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Circle:
                {
                    return "circle";
                }
                case NpgsqlDbType.Circle | NpgsqlDbType.Array:
                {
                    return $"circle{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Box:
                {
                    return "box";
                }
                case NpgsqlDbType.Box | NpgsqlDbType.Array:
                {
                    return $"box{ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Path:
                {
                    return "path";
                }
                case NpgsqlDbType.Path | NpgsqlDbType.Array:
                {
                    return $"path{ArrayDimensions(dimensions)}";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToDefaultMapType(this NpgsqlDbType npgsqlDbType, int dimensions = 1)
        {
            switch (npgsqlDbType)
            {
                case NpgsqlDbType.Bigint:
                {
                    return "System.Int64";
                }

                case NpgsqlDbType.Bigint | NpgsqlDbType.Array:
                {
                    return $"System.Int64{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Double:
                {
                    return "System.Double";
                }

                case NpgsqlDbType.Double | NpgsqlDbType.Array:
                {
                    return $"System.Double{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Integer:
                {
                    return "System.Int32";
                }

                case NpgsqlDbType.Integer | NpgsqlDbType.Array:
                {
                    return $"System.Int32{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Numeric:
                {
                    return "System.Decimal";
                }

                case NpgsqlDbType.Numeric | NpgsqlDbType.Array:
                {
                    return $"System.Decimal{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Money:
                {
                    return "System.Decimal";
                }

                case NpgsqlDbType.Money | NpgsqlDbType.Array:
                {
                    return $"System.Decimal{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Real:
                {
                    return "System.Single";
                }

                case NpgsqlDbType.Real | NpgsqlDbType.Array:
                {
                    return $"System.Single{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Smallint:
                {
                    return "System.Int16";
                }

                case NpgsqlDbType.Smallint | NpgsqlDbType.Array:
                {
                    return $"System.Int16{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Boolean:
                {
                    return "System.Boolean";
                }

                case NpgsqlDbType.Boolean | NpgsqlDbType.Array:
                {
                    return $"System.Boolean{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Char:
                {
                    return "System.String";
                }

                case NpgsqlDbType.Char | NpgsqlDbType.Array:
                {
                    return $"System.String{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Text:
                {
                    return "System.String";
                }

                case NpgsqlDbType.Text | NpgsqlDbType.Array:
                {
                    return $"System.String{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Timestamp:
                {
                    return "System.DateTime";
                }

                case NpgsqlDbType.Timestamp | NpgsqlDbType.Array:
                {
                    return $"System.DateTime{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Time:
                {
                    return "System.TimeOnly";
                }

                case NpgsqlDbType.Time | NpgsqlDbType.Array:
                {
                    return $"System.TimeOnly{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.TimeTz:
                {
                    return "System.DateTimeOffset";
                }

                case NpgsqlDbType.TimeTz | NpgsqlDbType.Array:
                {
                    return $"System.DateTimeOffset{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Date:
                {
                    return "System.DateOnly";
                }

                case NpgsqlDbType.Date | NpgsqlDbType.Array:
                {
                    return $"System.DateOnly{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.TimestampTz:
                {
                    return "System.DateTime";
                }

                case NpgsqlDbType.TimestampTz | NpgsqlDbType.Array:
                {
                    return $"System.DateTime{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Inet:
                {
                    return "System.Net.IPAddress";
                }

                case NpgsqlDbType.Inet | NpgsqlDbType.Array:
                {
                    return $"System.Net.IPAddress{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Uuid:
                {
                    return "System.Guid";
                }

                case NpgsqlDbType.Uuid | NpgsqlDbType.Array:
                {
                    return $"System.Guid{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Interval:
                {
                    return "System.TimeSpan";
                }

                case NpgsqlDbType.Interval | NpgsqlDbType.Array:
                {
                    return $"System.TimeSpan{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Line:
                {
                    return "NpgsqlTypes.NpgsqlLine";
                }

                case NpgsqlDbType.Line | NpgsqlDbType.Array:
                {
                    return $"NpgsqlTypes.NpgsqlLine{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Polygon:
                {
                    return "NpgsqlTypes.NpgsqlPolygon";
                }

                case NpgsqlDbType.Polygon | NpgsqlDbType.Array:
                {
                    return $"NpgsqlTypes.NpgsqlPolygon{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Point:
                {
                    return "NpgsqlTypes.NpgsqlPoint";
                }

                case NpgsqlDbType.Point | NpgsqlDbType.Array:
                {
                    return $"NpgsqlTypes.NpgsqlPoint{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Circle:
                {
                    return "NpgsqlTypes.NpgsqlCircle";
                }

                case NpgsqlDbType.Circle | NpgsqlDbType.Array:
                {
                    return $"NpgsqlTypes.NpgsqlCircle{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Box:
                {
                    return "NpgsqlTypes.NpgsqlBox";
                }

                case NpgsqlDbType.Box | NpgsqlDbType.Array:
                {
                    return $"NpgsqlTypes.NpgsqlBox{TypeHelper.ArrayDimensions(dimensions)}";
                }

                case NpgsqlDbType.Path:
                {
                    return "NpgsqlTypes.NpgsqlPath";
                }

                case NpgsqlDbType.Path | NpgsqlDbType.Array:
                {
                    return $"NpgsqlTypes.NpgsqlPath{TypeHelper.ArrayDimensions(dimensions)}";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
using ClickHouse.Driver.ADO.Parameters;
using System;
using System.Data;
using TestsGenerator.Enums;

namespace TestsGenerator.Helpers
{
    internal static class ClickhouseDbTypeExtension
    {
        public static DbType ToDbType(this string clickhouseDbType)
        {
            var param = new ClickHouseDbParameter();
            param.ClickHouseType = clickhouseDbType;
            return param.DbType;
        }

        public static string ToDbSqlTableType(this string clickhouseDbType, EnumerableType enumerableType)
        {
            switch (enumerableType)
            {
                case EnumerableType.SingleType:
                {
                    return clickhouseDbType;
                }

                case EnumerableType.Array:
                {
                    return $"Array({clickhouseDbType})";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToDefaultMapType(string clickhouseDbType)
        {
            switch (clickhouseDbType)
            {
                case "Int8":
                {
                    return "System.SByte";
                }

                case "UInt8":
                {
                    return "System.Byte";
                }

                case "Int16":
                {
                    return "System.Int16";
                }

                case "UInt16":
                {
                    return "System.UInt16";
                }

                case "Int32":
                {
                    return "System.Int32";
                }

                case "UInt32":
                {
                    return "System.UInt32";
                }

                case "Int64":
                {
                    return "System.Int64";
                }

                case "UInt64":
                {
                    return "System.UInt64";
                }

                case "Int128":
                case "UInt128":
                case "Int256":
                case "UInt256":
                {
                    return "System.Numerics.BigInteger";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToDefaultMapType(
            this string clickhouseDbType,
            EnumerableType enumerableType)
        {
            var mapType = ToDefaultMapType(clickhouseDbType);
            switch (enumerableType)
            {
                case EnumerableType.SingleType:
                {
                    return mapType;
                }

                case EnumerableType.Array:
                {
                    return mapType + "[]";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
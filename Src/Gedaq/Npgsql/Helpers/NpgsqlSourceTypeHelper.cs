using Gedaq.Npgsql.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Helpers
{
    internal static class NpgsqlSourceTypeHelper
    {
        public static string ToTypeName(this NpgsqlSourceType sourceType)
        {
            switch (sourceType)
            {
                case NpgsqlSourceType.NpgsqlConnection:
                {
                    return "Npgsql.NpgsqlConnection";
                }

                case NpgsqlSourceType.NpgsqlDataSource:
                {
                    return "Npgsql.NpgsqlDataSource";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToParametrName(this NpgsqlSourceType sourceType)
        {
            switch (sourceType)
            {
                case NpgsqlSourceType.NpgsqlConnection:
                {
                    return "connection";
                }

                case NpgsqlSourceType.NpgsqlDataSource:
                {
                    return "dataSource";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
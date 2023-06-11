using TestsGenerator.Enums;

namespace TestsGenerator.Helpers
{
    internal static class DatabaseExtensions
    {
        public static string ToUsings(this Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    return @"
using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;
";
                }
                case Database.MsSQL:
                {
                    return @"
using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;
";
                }
                case Database.MySQL:
                {
                    return @"
//TODO
";
                }
                default:
                    return "";
            }
        }

        public static string ToDefaultSchema(this Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    return "public";
                }
                case Database.MsSQL:
                {
                    return "dbo";
                }
                case Database.MySQL:
                {
                    return @"
//TODO
";
                }
                default:
                    return "";
            }
        }
    }
}
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
using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;
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
                    return @"gedaqtests";
                }

                default:
                    return "";
            }
        }
    }
}
using TestsGenerator.Enums;

namespace TestsGenerator.Helpers
{
    internal static class DatabaseUsings
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
//TODO
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
    }
}
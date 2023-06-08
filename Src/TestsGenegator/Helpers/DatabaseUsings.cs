using System;
using System.Collections.Generic;
using System.Text;
using TestsGenegator.Enums;

namespace TestsGenegator.Helpers
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
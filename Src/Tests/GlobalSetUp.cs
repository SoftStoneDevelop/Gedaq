using Npgsql;
using NUnit.Framework;
using System.Data.Common;

namespace Tests
{
    [Description("PostgreSQL")]
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static NpgsqlDataSource NpgsqlDataSource;

        public static NpgsqlConnection GetConnection => NpgsqlDataSource.CreateConnection();

        public static DbConnection GetDbConnection => NpgsqlDataSource.CreateConnection();
    }
}
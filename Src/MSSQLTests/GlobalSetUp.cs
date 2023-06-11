using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Data.Common;
using System.IO;
using System.Threading.Tasks;

namespace Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        private static IConfiguration _configuration;

        public static SqlConnection GetConnection
        {
            get
            {
                var connection = (SqlConnection)SqlClientFactory.Instance.CreateConnection();
                connection.ConnectionString = _configuration.GetConnectionString("SqlConnection");
                return connection;
            }
        }

        public static DbConnection GetDbConnection => GetConnection;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            _configuration = builder.Build();

            await using (var masterConnection = (SqlConnection)SqlClientFactory.Instance.CreateConnection())
            {
                masterConnection.ConnectionString = _configuration.GetConnectionString("MasterConnection");
                await masterConnection.OpenAsync();

                await using var createCmd = masterConnection.CreateCommand();
                createCmd.CommandText = $@"
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'gedaqtests'
)
CREATE DATABASE gedaqtests
;
";
                createCmd.ExecuteNonQuery();
            }
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await using (var masterConnection = (SqlConnection)SqlClientFactory.Instance.CreateConnection())
            {
                masterConnection.ConnectionString = _configuration.GetConnectionString("MasterConnection");
                await masterConnection.OpenAsync();
                await using var command = masterConnection.CreateCommand();
                command.CommandText = $@"
DROP DATABASE gedaqtests;
";
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
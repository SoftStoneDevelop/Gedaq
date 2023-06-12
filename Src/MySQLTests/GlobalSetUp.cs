using Microsoft.Extensions.Configuration;
using MySqlConnector;
using NUnit.Framework;
using System.Data.Common;
using System.IO;
using System.Threading.Tasks;

namespace Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        private IConfiguration _configuration;

        public static MySqlDataSource MySqlDataSource;

        public static MySqlConnection GetConnection => MySqlDataSource.CreateConnection();

        public static DbConnection GetDbConnection => MySqlDataSource.CreateConnection();

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            _configuration = builder.Build();

            MySqlDataSource = new MySqlDataSource(_configuration.GetConnectionString("SqlConnection"));

            await using (var masterConnection = new MySqlConnection(_configuration.GetConnectionString("MasterConnection")))
            {
                await masterConnection.OpenAsync();
                await using var createCmd = masterConnection.CreateCommand();
                createCmd.CommandText = $@"
CREATE DATABASE IF NOT EXISTS gedaqtests;
";
                createCmd.ExecuteNonQuery();
            }
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await using (var masterConnection = new MySqlConnection(_configuration.GetConnectionString("MasterConnection")))
            {
                await masterConnection.OpenAsync();
                await using var command = masterConnection.CreateCommand();
                command.CommandText = $@"
DROP DATABASE IF EXISTS gedaqtests;
";
                await command.ExecuteNonQueryAsync();
            }

            await MySqlDataSource.DisposeAsync();
        }
    }
}
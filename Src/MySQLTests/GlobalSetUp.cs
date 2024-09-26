using MySqlConnector;
using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;
using Testcontainers.MySql;

namespace Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static MySqlDataSource MySqlDataSource;

        public static MySqlConnection GetConnection => MySqlDataSource.CreateConnection();

        public static DbConnection GetDbConnection => MySqlDataSource.CreateConnection();

        private MySqlContainer _mysql;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _mysql =
                new MySqlBuilder()
                .WithUsername("root")
                .WithPassword("dhgvbh73j")
                .Build();

            await _mysql.StartAsync();

            await using (var masterConnection = new MySqlConnection(_mysql.GetConnectionString()))
            {
                await masterConnection.OpenAsync();
                await using var createCmd = masterConnection.CreateCommand();
                createCmd.CommandText = $@"
CREATE DATABASE IF NOT EXISTS gedaqtests;
";
                createCmd.ExecuteNonQuery();
            }

            var builder = new MySqlConnectionStringBuilder(_mysql.GetConnectionString());
            builder.Database = "gedaqtests";

            MySqlDataSource = new MySqlDataSource(builder.ConnectionString);
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            var dataSource = MySqlDataSource;
            if (dataSource != null)
            {
                await MySqlDataSource.DisposeAsync();
            }

            if (_mysql != null)
            {
                await using (var masterConnection = new MySqlConnection(_mysql.GetConnectionString()))
                {
                    await masterConnection.OpenAsync();
                    await using var command = masterConnection.CreateCommand();
                    command.CommandText = $@"
DROP DATABASE IF EXISTS gedaqtests;
";
                    await command.ExecuteNonQueryAsync();
                }

                await _mysql.DisposeAsync();
            }
        }
    }
}
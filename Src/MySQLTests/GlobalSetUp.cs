using DotNet.Testcontainers.Builders;
using MySqlConnector;
using NUnit.Framework;
using System;
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
                new MySqlBuilder("mysql:9.5.0")
                .WithUsername("root")
                .WithPassword("dhgvbh73j")
                .WithPortBinding(3306, true)
                .WithAutoRemove(true)
                .WithWaitStrategy(Wait.ForUnixContainer().UntilExternalTcpPortIsAvailable(3306))
                .Build();

            await _mysql.StartAsync();
            await _mysql.WaitContainerStateRunningAsync(TimeSpan.FromMinutes(1));
            await _mysql.WaitResponseAsync(TimeSpan.FromMinutes(1));

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
                try
                {
                    await MySqlDataSource.DisposeAsync();
                }
                catch
                {
                    // ignore
                }
            }

            if (_mysql != null)
            {
                try
                {
                    await _mysql.DisposeAsync();
                }
                catch
                {
                    // ignore
                }
            }
        }
    }
}
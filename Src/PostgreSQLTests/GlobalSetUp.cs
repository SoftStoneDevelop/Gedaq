using DotNet.Testcontainers.Builders;
using Npgsql;
using NUnit.Framework;
using System;
using System.Data.Common;
using System.Threading.Tasks;
using Testcontainers.PostgreSql;

namespace Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static NpgsqlDataSource NpgsqlDataSource;

        public static NpgsqlConnection GetConnection => NpgsqlDataSource.CreateConnection();

        public static DbConnection GetDbConnection => NpgsqlDataSource.CreateConnection();

        private PostgreSqlContainer _postgre;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _postgre =
                new PostgreSqlBuilder("postgres:18.3")
                .WithPassword("dhgvbh73j")
                .WithPortBinding(5432, true)
                .WithAutoRemove(true)
                .WithWaitStrategy(Wait.ForUnixContainer().UntilExternalTcpPortIsAvailable(5432))
                .Build();

            await _postgre.StartAsync();
            await _postgre.WaitContainerStateRunningAsync(TimeSpan.FromMinutes(1));
            await _postgre.WaitResponseAsync(TimeSpan.FromMinutes(1));

            await using (var masterConnection = new NpgsqlConnection(_postgre.GetConnectionString()))
            {
                await masterConnection.OpenAsync();
                await using var command = masterConnection.CreateCommand();
                command.CommandText = $@"
SELECT
    datname
FROM
    pg_database
WHERE 
    datname='gedaqtests'
;
";
                var dbName = (string)await command.ExecuteScalarAsync();
                if(dbName == null)
                {
                    await using var createCmd = masterConnection.CreateCommand();
                    createCmd.CommandText = $@"
CREATE DATABASE gedaqtests TEMPLATE template0 CONNECTION LIMIT = -1;
;
";
                    createCmd.ExecuteNonQuery();
                }
            }

            var builder = new NpgsqlConnectionStringBuilder(_postgre.GetConnectionString());
            builder.Database = "gedaqtests";
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(builder.ConnectionString);

            NpgsqlDataSource = dataSourceBuilder.Build();
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            var dataSource = NpgsqlDataSource;
            if (dataSource != null)
            {
                try
                {
                    await NpgsqlDataSource.DisposeAsync();
                }
                catch
                {
                    // ignore
                }
            }

            if (_postgre != null)
            {
                try
                {
                    await _postgre.DisposeAsync();
                }
                catch
                {
                    // ignore
                }
            }
        }
    }
}
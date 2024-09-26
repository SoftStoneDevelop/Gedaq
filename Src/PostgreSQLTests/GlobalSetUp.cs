using Npgsql;
using NUnit.Framework;
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
                new PostgreSqlBuilder()
                .WithImage("postgres:16.0")
                .WithPassword("dhgvbh73j")
                .Build();

            await _postgre.StartAsync();

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
                await NpgsqlDataSource.DisposeAsync();
            }

            if (_postgre != null)
            {
                await using (var masterConnection = new NpgsqlConnection(_postgre.GetConnectionString()))
                {
                    await masterConnection.OpenAsync();
                    await using var command = masterConnection.CreateCommand();
                    command.CommandText = $@"
DROP DATABASE gedaqtests WITH (FORCE);
";
                    await command.ExecuteNonQueryAsync();
                }

                await _postgre.DisposeAsync();
            }
        }
    }
}
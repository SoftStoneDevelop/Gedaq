using Microsoft.Extensions.Configuration;
using Npgsql;
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

        public static NpgsqlDataSource NpgsqlDataSource;

        public static NpgsqlConnection GetConnection => NpgsqlDataSource.CreateConnection();

        public static DbConnection GetDbConnection => NpgsqlDataSource.CreateConnection();

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            _configuration = builder.Build();

            var dataSourceBuilder = new NpgsqlDataSourceBuilder(_configuration.GetConnectionString("SqlConnection"));
            NpgsqlDataSource = dataSourceBuilder.Build();

            await using (var masterConnection = new NpgsqlConnection(_configuration.GetConnectionString("MasterConnection")))
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
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await using (var masterConnection = new NpgsqlConnection(_configuration.GetConnectionString("MasterConnection")))
            {
                await masterConnection.OpenAsync();
                await using var command = masterConnection.CreateCommand();
                command.CommandText = $@"
DROP DATABASE gedaqtests WITH (FORCE);
;
";
                await command.ExecuteNonQueryAsync();
            }

            await NpgsqlDataSource.DisposeAsync();
        }
    }
}
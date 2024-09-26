using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;
using Testcontainers.MsSql;

namespace Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static SqlConnection GetConnection
        {
            get
            {
                var connection = (SqlConnection)SqlClientFactory.Instance.CreateConnection();
                connection.ConnectionString = _connectionString;
                return connection;
            }
        }

        public static DbConnection GetDbConnection => GetConnection;

        private MsSqlContainer _mssql;
        private static string _connectionString;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _mssql =
                new MsSqlBuilder()
                .WithPassword("dhgvbh73j")
                .Build();

            await _mssql.StartAsync();

            await using (var masterConnection = (SqlConnection)SqlClientFactory.Instance.CreateConnection())
            {
                masterConnection.ConnectionString = _mssql.GetConnectionString();
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

            var builder = new SqlConnectionStringBuilder(_mssql.GetConnectionString());
            builder.DataSource = "gedaqtests";
            _connectionString = builder.ConnectionString;
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            if (_mssql != null)
            {
                await using (var masterConnection = (SqlConnection)SqlClientFactory.Instance.CreateConnection())
                {
                    masterConnection.ConnectionString = _mssql.GetConnectionString();
                    await masterConnection.OpenAsync();
                    await using var command = masterConnection.CreateCommand();
                    command.CommandText = $@"
ALTER DATABASE gedaqtests SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE gedaqtests;
";
                    await command.ExecuteNonQueryAsync();
                }

                await _mssql.DisposeAsync();
            }
        }
    }
}
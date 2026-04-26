using DotNet.Testcontainers.Builders;
using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System;
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
                new MsSqlBuilder("mcr.microsoft.com/mssql/server:2022-CU14-ubuntu-22.04")
                .WithPortBinding(1433, true)
                .WithAutoRemove(true)
                .WithWaitStrategy(Wait.ForUnixContainer().UntilExternalTcpPortIsAvailable(1433))
                .Build();

            await _mssql.StartAsync();
            await _mssql.WaitContainerStateRunningAsync(TimeSpan.FromMinutes(1));
            await _mssql.WaitResponseAsync(TimeSpan.FromMinutes(1));

            var builder = new SqlConnectionStringBuilder(_mssql.GetConnectionString());
            builder.Encrypt = false;
            builder.TrustServerCertificate = false;
            builder.IntegratedSecurity = false;

            await using (var masterConnection = (SqlConnection)SqlClientFactory.Instance.CreateConnection())
            {
                masterConnection.ConnectionString = builder.ConnectionString;
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

            builder = new SqlConnectionStringBuilder(_mssql.GetConnectionString());
            builder.Encrypt = false;
            builder.TrustServerCertificate = false;
            builder.IntegratedSecurity = false;
            builder.InitialCatalog = "gedaqtests";
            _connectionString = builder.ConnectionString;
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            if (_mssql != null)
            {
                await _mssql.DisposeAsync();
            }
        }
    }
}
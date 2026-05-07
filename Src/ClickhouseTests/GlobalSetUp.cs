using ClickHouse.Driver.ADO;
using DotNet.Testcontainers.Builders;
using NUnit.Framework;
using System;
using System.Data.Common;
using System.Threading.Tasks;
using Testcontainers.ClickHouse;

namespace Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static ClickHouseDataSource ClickhouseDataSource;

        public static ClickHouseConnection GetConnection => ClickhouseDataSource.CreateConnection();

        public static DbConnection GetDbConnection => ClickhouseDataSource.CreateConnection();

        private ClickHouseContainer _clickHouse;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _clickHouse =
                new ClickHouseBuilder("clickhouse/clickhouse-server:23.10.1.1976-alpine")
                .WithPassword("f8Nkn2sDe56rw")
                .WithPortBinding(8123, true)
                .WithAutoRemove(true)
                .WithWaitStrategy(Wait.ForUnixContainer().UntilExternalTcpPortIsAvailable(8123))
                .Build();

            await _clickHouse.StartAsync();
            await _clickHouse.WaitContainerStateRunningAsync(TimeSpan.FromMinutes(1));
            await _clickHouse.WaitResponseAsync(TimeSpan.FromMinutes(1));

            var databaseName = "gedaqtests";
            await using (var masterConnection = new ClickHouseConnection(_clickHouse.GetConnectionString()))
            {
                await masterConnection.OpenAsync();
                await using var command = masterConnection.CreateCommand();
                command.CommandText = $@"CREATE DATABASE IF NOT EXISTS {databaseName};";
                await command.ExecuteScalarAsync();
            }

            var builder = new ClickHouseConnectionStringBuilder(_clickHouse.GetConnectionString());
            builder.Database = databaseName;
            var dataSourceBuilder = new ClickHouseDataSource(builder.ConnectionString);

            ClickhouseDataSource = dataSourceBuilder;
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            var dataSource = ClickhouseDataSource;
            if (dataSource != null)
            {
                try
                {
                    await ClickhouseDataSource.DisposeAsync();
                }
                catch
                {
                    // ignore
                }
            }

            if (_clickHouse != null)
            {
                try
                {
                    await _clickHouse.DisposeAsync();
                }
                catch
                {
                    // ignore
                }
            }
        }
    }
}


using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class UInt64MArrayArrayUInt64
    {


        private async Task CreateModelInnerTable(ClickHouseCommand cmd)
        {
            // ignore
        }


        private async Task DropModelInnerTable(ClickHouseCommand cmd)
        {
            // ignore
        }


        private async Task CreateModelTable(ClickHouseCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS gedaqtests.uint64arrayuint64e1m
(
    m_id Int32,
    m_value Array(UInt64),
    mi_id Int32,
    mi_value Array(UInt64)
)
ENGINE = MergeTree
PARTITION BY (intHash32(m_id) % 5)
ORDER BY m_id
SETTINGS index_granularity = 8192;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(ClickHouseCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE IF EXISTS gedaqtests.uint64arrayuint64e1m;
";
            await cmd.ExecuteNonQueryAsync();
        }


        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                await using var cmd = connection.CreateCommand();
                await CreateModelInnerTable(cmd);
                await CreateModelTable(cmd);
            }
        }


        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                await using var cmd = connection.CreateCommand();
                await DropModelTable(cmd);
                await DropModelInnerTable(cmd);
            }
        }


    }
}


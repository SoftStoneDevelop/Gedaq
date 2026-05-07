

using ClickHouse.Driver;
using System;
using Gedaq.Common.Enums;


using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class Int32SingleTypeInt32
    {


        private async Task CreateModelInnerTable(ClickhouseCommand cmd)
        {
            // ignore
        }


        private async Task DropModelInnerTable(ClickhouseCommand cmd)
        {
            // ignore
        }


        private async Task CreateModelInnerTable(ClickhouseCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS gedaqtests.int32int320mi
(
    id Int32,
    value Int32,
	nullablevalue Int32
)
ENGINE = MergeTree
PARTITION BY (intHash32(id) % 5)
ORDER BY id
SETTINGS index_granularity = 8192;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(ClickhouseCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE IF EXISTS gedaqtests.int32int320m;
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




using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class SByteSingleTypetinyint
    {


        private async Task CreateModelInnerTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE gedaqtests.sbytetinyinte0mi (
    id int  NOT NULL,
    value tinyint NOT NULL,
	nullablevalue tinyint NULL,
    PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE IF EXISTS gedaqtests.sbytetinyinte0mi
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE gedaqtests.sbytetinyinte0m
(
    id int NOT NULL,
    value tinyint NOT NULL,
    nullablevalue tinyint,
    sbytetinyinte0mi_id int,
    PRIMARY KEY (id),
    FOREIGN KEY (sbytetinyinte0mi_id)
        REFERENCES gedaqtests.sbytetinyinte0mi (id)
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE IF EXISTS gedaqtests.sbytetinyinte0m;
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


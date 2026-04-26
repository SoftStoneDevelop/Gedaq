

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
    internal partial class StringSingleTypetext
    {


        private async Task CreateModelInnerTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE gedaqtests.stringtext0mi (
    id int  NOT NULL,
    value text NOT NULL,
	nullablevalue text NULL,
    PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE IF EXISTS gedaqtests.stringtext0mi
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE gedaqtests.stringtext0m
(
    id int NOT NULL,
    value text NOT NULL,
    nullablevalue text,
    stringtext0mi_id int,
    PRIMARY KEY (id),
    FOREIGN KEY (stringtext0mi_id)
        REFERENCES gedaqtests.stringtext0mi (id)
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(MySqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE IF EXISTS gedaqtests.stringtext0m;
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


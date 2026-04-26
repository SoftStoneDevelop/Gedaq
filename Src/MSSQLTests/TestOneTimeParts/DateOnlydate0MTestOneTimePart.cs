

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class DateOnlySingleTypedate
    {


        private async Task CreateModelInnerTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE dbo.dateonlydate0mi(
	id int NOT NULL,
	value date NOT NULL,
	nullablevalue date NULL,
    CONSTRAINT PK_dateonlydate0mi PRIMARY KEY NONCLUSTERED (id)
)
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE dbo.dateonlydate0mi
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE dbo.dateonlydate0m(
	id int NOT NULL,
	value date NOT NULL,
    nullablevalue date NULL,
	dateonlydate0mi_id int NULL,
    CONSTRAINT PK_dateonlydate0m PRIMARY KEY NONCLUSTERED (id),
    CONSTRAINT FK_dateonlydate0m_dateonlydate0mi FOREIGN KEY (dateonlydate0mi_id)
        REFERENCES dbo.dateonlydate0mi (id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
)
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE dbo.dateonlydate0m
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


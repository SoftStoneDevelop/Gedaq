

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
    internal partial class GuidSingleTypeuniqueidentifier
    {


        private async Task CreateModelInnerTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE dbo.guiduniqueidentifiere0mi(
	id int NOT NULL,
	value uniqueidentifier NOT NULL,
	nullablevalue uniqueidentifier NULL,
    CONSTRAINT PK_guiduniqueidentifiere0mi PRIMARY KEY NONCLUSTERED (id)
)
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE dbo.guiduniqueidentifiere0mi
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE dbo.guiduniqueidentifiere0m(
	id int NOT NULL,
	value uniqueidentifier NOT NULL,
    nullablevalue uniqueidentifier NULL,
	guiduniqueidentifiere0mi_id int NULL,
    CONSTRAINT PK_guiduniqueidentifiere0m PRIMARY KEY NONCLUSTERED (id),
    CONSTRAINT FK_guiduniqueidentifiere0m_guiduniqueidentifiere0mi FOREIGN KEY (guiduniqueidentifiere0mi_id)
        REFERENCES dbo.guiduniqueidentifiere0mi (id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
)
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(SqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE dbo.guiduniqueidentifiere0m
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


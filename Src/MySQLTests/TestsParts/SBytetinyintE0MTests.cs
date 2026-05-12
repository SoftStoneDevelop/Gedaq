

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface ISByteSingleTypetinyint
    {
    }
    
    internal partial class SByteSingleTypetinyint : ISByteSingleTypetinyint
    {


#region TestData

        private readonly SBytetinyintE0M[] _testData = new SBytetinyintE0M[]
        {
            new SBytetinyintE0M
{
    Id = 3,
    Value = 20,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 7,
    Value = -3,
    ModelInner = new SBytetinyintE0MI
{
    Id = 3,
    Value = 32,
    NullableValue = -126,
},
    NullableValue = -41,
},
            new SBytetinyintE0M
{
    Id = 16,
    Value = -98,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 24,
    Value = -38,
    ModelInner = new SBytetinyintE0MI
{
    Id = 5,
    Value = -51,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 32,
    Value = 120,
    ModelInner = null,
    NullableValue = 36,
},
            new SBytetinyintE0M
{
    Id = 40,
    Value = -78,
    ModelInner = new SBytetinyintE0MI
{
    Id = 8,
    Value = 73,
    NullableValue = null,
},
    NullableValue = 102,
},
            new SBytetinyintE0M
{
    Id = 46,
    Value = 14,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 51,
    Value = 38,
    ModelInner = new SBytetinyintE0MI
{
    Id = 12,
    Value = -102,
    NullableValue = null,
},
    NullableValue = 93,
},
            new SBytetinyintE0M
{
    Id = 56,
    Value = -66,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 57,
    Value = 39,
    ModelInner = new SBytetinyintE0MI
{
    Id = 19,
    Value = 99,
    NullableValue = -62,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 63,
    Value = -31,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 72,
    Value = 114,
    ModelInner = new SBytetinyintE0MI
{
    Id = 28,
    Value = 26,
    NullableValue = -7,
},
    NullableValue = -94,
},
            new SBytetinyintE0M
{
    Id = 75,
    Value = 117,
    ModelInner = null,
    NullableValue = 108,
},
            new SBytetinyintE0M
{
    Id = 79,
    Value = -91,
    ModelInner = new SBytetinyintE0MI
{
    Id = 37,
    Value = 87,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 88,
    Value = 21,
    ModelInner = null,
    NullableValue = 1,
},
            new SBytetinyintE0M
{
    Id = 94,
    Value = -109,
    ModelInner = new SBytetinyintE0MI
{
    Id = 39,
    Value = 125,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 95,
    Value = -128,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 96,
    Value = 110,
    ModelInner = new SBytetinyintE0MI
{
    Id = 42,
    Value = 51,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 102,
    Value = -8,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 110,
    Value = 42,
    ModelInner = new SBytetinyintE0MI
{
    Id = 50,
    Value = -52,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 115,
    Value = -51,
    ModelInner = null,
    NullableValue = 31,
},
            new SBytetinyintE0M
{
    Id = 124,
    Value = -117,
    ModelInner = new SBytetinyintE0MI
{
    Id = 51,
    Value = 3,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 131,
    Value = -128,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 134,
    Value = -4,
    ModelInner = new SBytetinyintE0MI
{
    Id = 53,
    Value = -26,
    NullableValue = null,
},
    NullableValue = -120,
},
            new SBytetinyintE0M
{
    Id = 139,
    Value = -80,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 143,
    Value = -122,
    ModelInner = new SBytetinyintE0MI
{
    Id = 55,
    Value = -68,
    NullableValue = null,
},
    NullableValue = 51,
},
            new SBytetinyintE0M
{
    Id = 147,
    Value = 120,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 153,
    Value = -125,
    ModelInner = new SBytetinyintE0MI
{
    Id = 56,
    Value = -43,
    NullableValue = null,
},
    NullableValue = 65,
},
            new SBytetinyintE0M
{
    Id = 156,
    Value = 0,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 160,
    Value = 52,
    ModelInner = new SBytetinyintE0MI
{
    Id = 64,
    Value = -74,
    NullableValue = null,
},
    NullableValue = -94,
},
            new SBytetinyintE0M
{
    Id = 162,
    Value = 12,
    ModelInner = null,
    NullableValue = -22,
},
            new SBytetinyintE0M
{
    Id = 165,
    Value = 2,
    ModelInner = new SBytetinyintE0MI
{
    Id = 69,
    Value = -102,
    NullableValue = -12,
},
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 171,
    Value = -112,
    ModelInner = null,
    NullableValue = null,
},
            new SBytetinyintE0M
{
    Id = 176,
    Value = -104,
    ModelInner = new SBytetinyintE0MI
{
    Id = 73,
    Value = 16,
    NullableValue = null,
},
    NullableValue = -110,
},
            new SBytetinyintE0M
{
    Id = 180,
    Value = -31,
    ModelInner = null,
    NullableValue = -12,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytetinyinte0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(1)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(1))]
        public void InsertModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((ISByteSingleTypetinyint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypetinyint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((ISByteSingleTypetinyint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytetinyinte0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(14)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(14), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytetinyinte0m(
	id,
    value,
    nullablevalue,
    sbytetinyinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @sbytetinyinte0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(1)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(1),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "sbytetinyinte0mi_id", 
                methodParametrName: "sbytetinyinte0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true)]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((ISByteSingleTypetinyint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypetinyint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((ISByteSingleTypetinyint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbytetinyinte0m(
	id,
    value,
    nullablevalue,
    sbytetinyinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @sbytetinyinte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.SByte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(14)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(14),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "sbytetinyinte0mi_id", 
                methodParametrName: "sbytetinyinte0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((ISByteSingleTypetinyint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypetinyint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytetinyintE0M), typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                await((ISByteSingleTypetinyint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                ((ISByteSingleTypetinyint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((ISByteSingleTypetinyint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((ISByteSingleTypetinyint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
LEFT JOIN gedaqtests.sbytetinyinte0mi mi ON mi.id = m.sbytetinyinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((ISByteSingleTypetinyint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((ISByteSingleTypetinyint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytetinyintE0M), typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                await((ISByteSingleTypetinyint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                ((ISByteSingleTypetinyint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteSingleTypetinyint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteSingleTypetinyint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
LEFT JOIN gedaqtests.sbytetinyinte0mi mi ON mi.id = m.sbytetinyinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((ISByteSingleTypetinyint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteSingleTypetinyint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytetinyintE0M), typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                await((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                await ((ISByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                await ((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                ((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                 ((ISByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                 ((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[6],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[7],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                await ((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(models[6],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(models[7],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(models[8],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(models[9],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(models[10],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(models[11],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(models[12],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(models[13],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(models[14],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(models[15],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(models[16],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(models[17],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(models[18],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(models[19],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[20],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[21],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[22],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[23],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                 ((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
LEFT JOIN gedaqtests.sbytetinyinte0mi mi ON mi.id = m.sbytetinyinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteSingleTypetinyint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SBytetinyintE0M.AssertModel(models[0],_testData[25], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[26], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[27], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[28], false);
                        SBytetinyintE0M.AssertModel(models[4],_testData[29], false);
                        SBytetinyintE0M.AssertModel(models[5],_testData[30], false);
                        SBytetinyintE0M.AssertModel(models[6],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[7],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[8],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SBytetinyintE0M.AssertModel(models[0],_testData[12], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[13], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[14], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[15], false);
                        SBytetinyintE0M.AssertModel(models[4],_testData[16], false);
                        SBytetinyintE0M.AssertModel(models[5],_testData[17], false);
                        SBytetinyintE0M.AssertModel(models[6],_testData[18], false);
                        SBytetinyintE0M.AssertModel(models[7],_testData[19], false);
                        SBytetinyintE0M.AssertModel(models[8],_testData[20], false);
                        SBytetinyintE0M.AssertModel(models[9],_testData[21], false);
                        SBytetinyintE0M.AssertModel(models[10],_testData[22], false);
                        SBytetinyintE0M.AssertModel(models[11],_testData[23], false);
                        SBytetinyintE0M.AssertModel(models[12],_testData[24], false);
                        SBytetinyintE0M.AssertModel(models[13],_testData[25], false);
                        SBytetinyintE0M.AssertModel(models[14],_testData[26], false);
                        SBytetinyintE0M.AssertModel(models[15],_testData[27], false);
                        SBytetinyintE0M.AssertModel(models[16],_testData[28], false);
                        SBytetinyintE0M.AssertModel(models[17],_testData[29], false);
                        SBytetinyintE0M.AssertModel(models[18],_testData[30], false);
                        SBytetinyintE0M.AssertModel(models[19],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[20],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[21],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteSingleTypetinyint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SBytetinyintE0M.AssertModel(models[0],_testData[15], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[16], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[17], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[18], false);
                        SBytetinyintE0M.AssertModel(models[4],_testData[19], false);
                        SBytetinyintE0M.AssertModel(models[5],_testData[20], false);
                        SBytetinyintE0M.AssertModel(models[6],_testData[21], false);
                        SBytetinyintE0M.AssertModel(models[7],_testData[22], false);
                        SBytetinyintE0M.AssertModel(models[8],_testData[23], false);
                        SBytetinyintE0M.AssertModel(models[9],_testData[24], false);
                        SBytetinyintE0M.AssertModel(models[10],_testData[25], false);
                        SBytetinyintE0M.AssertModel(models[11],_testData[26], false);
                        SBytetinyintE0M.AssertModel(models[12],_testData[27], false);
                        SBytetinyintE0M.AssertModel(models[13],_testData[28], false);
                        SBytetinyintE0M.AssertModel(models[14],_testData[29], false);
                        SBytetinyintE0M.AssertModel(models[15],_testData[30], false);
                        SBytetinyintE0M.AssertModel(models[16],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[17],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[18],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SBytetinyintE0M.AssertModel(models[0],_testData[22], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[23], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[24], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[25], false);
                        SBytetinyintE0M.AssertModel(models[4],_testData[26], false);
                        SBytetinyintE0M.AssertModel(models[5],_testData[27], false);
                        SBytetinyintE0M.AssertModel(models[6],_testData[28], false);
                        SBytetinyintE0M.AssertModel(models[7],_testData[29], false);
                        SBytetinyintE0M.AssertModel(models[8],_testData[30], false);
                        SBytetinyintE0M.AssertModel(models[9],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[10],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[11],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytetinyintE0M), typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                await((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                await ((ISByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                await ((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytetinyintE0M>();
                var models2 = new List<FlatSBytetinyintE0M>();
                ((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                 ((ISByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var firstItems2 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                 ((ISByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 162, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 153, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(models[6],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(models[7],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(models[8],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(models[9],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[10],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[11],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[12],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[13],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                await ((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[6], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[7], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[8], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(models[6],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(models[7],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(models[8],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(models[9],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(models[10],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(models[11],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(models[12],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(models[13],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(models[14],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(models[15],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(models[16],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(models[17],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(models[18],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(models[19],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(models[20],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(models[21],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(models[22],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(models[23],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[24],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[25],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[26],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[27],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytetinyintE0M.AssertModel(models[0],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(models[1],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(models[2],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(models[3],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(models[4],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(models[5],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(models[6],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(models[7],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(models[8],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(models[9],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(models[10],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(models[11],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(models[12],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(models[13],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(models[14],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(models[15],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(models[16],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(models[17],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(models[18],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(models[19],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(models[20],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.sbytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems1 = new List<FlatSBytetinyintE0M>();
                var secondItems2 = new List<FlatSBytetinyintE0M>();
                 ((ISByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatSBytetinyintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSBytetinyintE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSBytetinyintE0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
LEFT JOIN gedaqtests.sbytetinyinte0mi mi ON mi.id = m.sbytetinyinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((ISByteSingleTypetinyint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypetinyint)this).DbConnectionSTSelectModelBatchAsync(connection, 88, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SBytetinyintE0M.AssertModel(models[0],_testData[15], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[16], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[17], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[18], false);
                        SBytetinyintE0M.AssertModel(models[4],_testData[19], false);
                        SBytetinyintE0M.AssertModel(models[5],_testData[20], false);
                        SBytetinyintE0M.AssertModel(models[6],_testData[21], false);
                        SBytetinyintE0M.AssertModel(models[7],_testData[22], false);
                        SBytetinyintE0M.AssertModel(models[8],_testData[23], false);
                        SBytetinyintE0M.AssertModel(models[9],_testData[24], false);
                        SBytetinyintE0M.AssertModel(models[10],_testData[25], false);
                        SBytetinyintE0M.AssertModel(models[11],_testData[26], false);
                        SBytetinyintE0M.AssertModel(models[12],_testData[27], false);
                        SBytetinyintE0M.AssertModel(models[13],_testData[28], false);
                        SBytetinyintE0M.AssertModel(models[14],_testData[29], false);
                        SBytetinyintE0M.AssertModel(models[15],_testData[30], false);
                        SBytetinyintE0M.AssertModel(models[16],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[17],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[18],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SBytetinyintE0M.AssertModel(models[0],_testData[9], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[10], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[11], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[12], false);
                        SBytetinyintE0M.AssertModel(models[4],_testData[13], false);
                        SBytetinyintE0M.AssertModel(models[5],_testData[14], false);
                        SBytetinyintE0M.AssertModel(models[6],_testData[15], false);
                        SBytetinyintE0M.AssertModel(models[7],_testData[16], false);
                        SBytetinyintE0M.AssertModel(models[8],_testData[17], false);
                        SBytetinyintE0M.AssertModel(models[9],_testData[18], false);
                        SBytetinyintE0M.AssertModel(models[10],_testData[19], false);
                        SBytetinyintE0M.AssertModel(models[11],_testData[20], false);
                        SBytetinyintE0M.AssertModel(models[12],_testData[21], false);
                        SBytetinyintE0M.AssertModel(models[13],_testData[22], false);
                        SBytetinyintE0M.AssertModel(models[14],_testData[23], false);
                        SBytetinyintE0M.AssertModel(models[15],_testData[24], false);
                        SBytetinyintE0M.AssertModel(models[16],_testData[25], false);
                        SBytetinyintE0M.AssertModel(models[17],_testData[26], false);
                        SBytetinyintE0M.AssertModel(models[18],_testData[27], false);
                        SBytetinyintE0M.AssertModel(models[19],_testData[28], false);
                        SBytetinyintE0M.AssertModel(models[20],_testData[29], false);
                        SBytetinyintE0M.AssertModel(models[21],_testData[30], false);
                        SBytetinyintE0M.AssertModel(models[22],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[23],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[24],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteSingleTypetinyint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypetinyint)this).DbConnectionSTSelectModelBatch(connection, 162, 171))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SBytetinyintE0M.AssertModel(models[0],_testData[31], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[32], false);
                        SBytetinyintE0M.AssertModel(models[2],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SBytetinyintE0M.AssertModel(models[0],_testData[33], false);
                        SBytetinyintE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ISByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((ISByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                SBytetinyintE0M.AssertModel(models[0],_testData[21], false);
                SBytetinyintE0M.AssertModel(models[1],_testData[22], false);
                SBytetinyintE0M.AssertModel(models[2],_testData[23], false);
                SBytetinyintE0M.AssertModel(models[3],_testData[24], false);
                SBytetinyintE0M.AssertModel(models[4],_testData[25], false);
                SBytetinyintE0M.AssertModel(models[5],_testData[26], false);
                SBytetinyintE0M.AssertModel(models[6],_testData[27], false);
                SBytetinyintE0M.AssertModel(models[7],_testData[28], false);
                SBytetinyintE0M.AssertModel(models[8],_testData[29], false);
                SBytetinyintE0M.AssertModel(models[9],_testData[30], false);
                SBytetinyintE0M.AssertModel(models[10],_testData[31], false);
                SBytetinyintE0M.AssertModel(models[11],_testData[32], false);
                SBytetinyintE0M.AssertModel(models[12],_testData[33], false);
                SBytetinyintE0M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((ISByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                SBytetinyintE0M.AssertModel(models[0],_testData[20], false);
                SBytetinyintE0M.AssertModel(models[1],_testData[21], false);
                SBytetinyintE0M.AssertModel(models[2],_testData[22], false);
                SBytetinyintE0M.AssertModel(models[3],_testData[23], false);
                SBytetinyintE0M.AssertModel(models[4],_testData[24], false);
                SBytetinyintE0M.AssertModel(models[5],_testData[25], false);
                SBytetinyintE0M.AssertModel(models[6],_testData[26], false);
                SBytetinyintE0M.AssertModel(models[7],_testData[27], false);
                SBytetinyintE0M.AssertModel(models[8],_testData[28], false);
                SBytetinyintE0M.AssertModel(models[9],_testData[29], false);
                SBytetinyintE0M.AssertModel(models[10],_testData[30], false);
                SBytetinyintE0M.AssertModel(models[11],_testData[31], false);
                SBytetinyintE0M.AssertModel(models[12],_testData[32], false);
                SBytetinyintE0M.AssertModel(models[13],_testData[33], false);
                SBytetinyintE0M.AssertModel(models[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM gedaqtests.sbytetinyinte0m m
LEFT JOIN gedaqtests.sbytetinyinte0mi mi ON mi.id = m.sbytetinyinte0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypetinyint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypetinyint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((20)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-3)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((32)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-126)));//InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-41)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-98)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-51)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((120)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((36)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-78)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((73)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((102)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((14)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-102)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((93)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((39)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((99)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-62)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-31)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((114)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((26)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-7)));//InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-94)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((117)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((108)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((87)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((21)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((1)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((125)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-128)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((110)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((51)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-8)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((42)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-52)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-51)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((31)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-117)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((3)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-128)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-4)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-26)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((-120)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-80)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-122)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-68)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((51)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((120)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-125)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-43)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((65)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((0)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((52)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-74)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((-94)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((12)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-22)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((2)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-102)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-12)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-112)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-104)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((16)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((-110)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-31)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-12)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteSingleTypetinyint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((20)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-3)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((32)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-126)));//InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-41)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-98)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-51)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((120)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((36)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-78)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((73)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((102)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((14)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-102)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((93)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((39)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((99)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-62)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-31)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((114)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((26)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-7)));//InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-94)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((117)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((108)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((87)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((21)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((1)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((125)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-128)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((110)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((51)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-8)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((42)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-52)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-51)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((31)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-117)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((3)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-128)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-4)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-26)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((-120)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-80)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-122)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-68)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((51)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((120)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-125)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-43)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((65)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((0)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((52)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-74)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((-94)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((12)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-22)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((2)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((-102)));//InnerModel.Value

                Assert.That((System.SByte?)model[4], Is.EqualTo((-12)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-112)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-104)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.SByte)model[3], Is.EqualTo((16)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.SByte?)model[5], Is.EqualTo((-110)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.SByte)model[1], Is.EqualTo((-31)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.SByte?)model[5], Is.EqualTo((-12)));

            }
        }

#endregion

    }
}


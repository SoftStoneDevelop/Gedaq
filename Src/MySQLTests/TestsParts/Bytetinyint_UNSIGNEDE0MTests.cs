

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
    internal partial interface IByteSingleTypetinyint_UNSIGNED
    {
    }
    
    internal partial class ByteSingleTypetinyint_UNSIGNED : IByteSingleTypetinyint_UNSIGNED
    {


#region TestData

        private readonly Bytetinyint_UNSIGNEDE0M[] _testData = new Bytetinyint_UNSIGNEDE0M[]
        {
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 9,
    Value = 122,
    ModelInner = null,
    NullableValue = 102,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 14,
    Value = 166,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 8,
    Value = 129,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 19,
    Value = 63,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 25,
    Value = 235,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 12,
    Value = 4,
    NullableValue = 160,
},
    NullableValue = 236,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 29,
    Value = 201,
    ModelInner = null,
    NullableValue = 202,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 33,
    Value = 209,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 18,
    Value = 66,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 42,
    Value = 146,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 48,
    Value = 226,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 23,
    Value = 178,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 56,
    Value = 127,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 61,
    Value = 195,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 30,
    Value = 218,
    NullableValue = 200,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 64,
    Value = 139,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 71,
    Value = 37,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 39,
    Value = 53,
    NullableValue = 66,
},
    NullableValue = 148,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 72,
    Value = 182,
    ModelInner = null,
    NullableValue = 71,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 76,
    Value = 248,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 41,
    Value = 178,
    NullableValue = null,
},
    NullableValue = 115,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 79,
    Value = 33,
    ModelInner = null,
    NullableValue = 254,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 88,
    Value = 45,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 50,
    Value = 12,
    NullableValue = 142,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 91,
    Value = 204,
    ModelInner = null,
    NullableValue = 241,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 95,
    Value = 191,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 52,
    Value = 130,
    NullableValue = null,
},
    NullableValue = 172,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 97,
    Value = 110,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 99,
    Value = 6,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 55,
    Value = 179,
    NullableValue = null,
},
    NullableValue = 103,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 102,
    Value = 90,
    ModelInner = null,
    NullableValue = 167,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 109,
    Value = 30,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 60,
    Value = 213,
    NullableValue = 84,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 118,
    Value = 119,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 122,
    Value = 95,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 69,
    Value = 77,
    NullableValue = 54,
},
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 126,
    Value = 148,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 128,
    Value = 7,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 70,
    Value = 8,
    NullableValue = 41,
},
    NullableValue = 30,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 130,
    Value = 253,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 137,
    Value = 74,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 72,
    Value = 46,
    NullableValue = null,
},
    NullableValue = 200,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 141,
    Value = 18,
    ModelInner = null,
    NullableValue = 47,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 145,
    Value = 198,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 81,
    Value = 125,
    NullableValue = null,
},
    NullableValue = 73,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 147,
    Value = 174,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 149,
    Value = 204,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 82,
    Value = 26,
    NullableValue = null,
},
    NullableValue = 70,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 157,
    Value = 6,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 163,
    Value = 185,
    ModelInner = new Bytetinyint_UNSIGNEDE0MI
{
    Id = 83,
    Value = 177,
    NullableValue = 4,
},
    NullableValue = 212,
},
            new Bytetinyint_UNSIGNEDE0M
{
    Id = 172,
    Value = 108,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytetinyint_unsignede0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(501)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(501))]
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

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytetinyint_unsignede0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(2), 
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

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytetinyint_unsignede0m(
	id,
    value,
    nullablevalue,
    bytetinyint_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyint_unsignede0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(501)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(501),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyint_unsignede0mi_id", 
                methodParametrName: "bytetinyint_unsignede0mi_id", 
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

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytetinyint_unsignede0m(
	id,
    value,
    nullablevalue,
    bytetinyint_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyint_unsignede0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Byte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(2),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyint_unsignede0mi_id", 
                methodParametrName: "bytetinyint_unsignede0mi_id", 
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

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M), typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await((IByteSingleTypetinyint_UNSIGNED)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                ((IByteSingleTypetinyint_UNSIGNED)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
LEFT JOIN gedaqtests.bytetinyint_unsignede0mi mi ON mi.id = m.bytetinyint_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Bytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M), typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await((IByteSingleTypetinyint_UNSIGNED)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                ((IByteSingleTypetinyint_UNSIGNED)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
LEFT JOIN gedaqtests.bytetinyint_unsignede0mi mi ON mi.id = m.bytetinyint_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Bytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M), typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                 ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                 ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                 ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
LEFT JOIN gedaqtests.bytetinyint_unsignede0mi mi ON mi.id = m.bytetinyint_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Bytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[22], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[23], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[3], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[4], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[5], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[6], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[7], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[8], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[9], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[10], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[11], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[12], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[13], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[14], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[15], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[16], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[17], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[18], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[19], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[20], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[18],_testData[21], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[19],_testData[22], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[20],_testData[23], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[21],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[22],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[23],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[24],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[25],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[26],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[27],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[28],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[29],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[30],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M), typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 79, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var models2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                 ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                 ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[18],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[19],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[20],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[21],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[22],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[23],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[24],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[25],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 64, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 95, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[8], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[9], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[10], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[11], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[18],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[19],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[20],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[21],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[22],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[23],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[24],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[25],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(models[26],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
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
FROM gedaqtests.bytetinyint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatBytetinyint_UNSIGNEDE0M>();
                 ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBytetinyint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
LEFT JOIN gedaqtests.bytetinyint_unsignede0mi mi ON mi.id = m.bytetinyint_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Bytetinyint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED)),
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
                var models = await((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[18], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[19], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[20], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[21], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[22], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[23], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[16], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[17], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[18], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[19], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[20], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[21], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[22], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[23], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 122, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[17], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[18], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[19], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[20], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[21], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[22], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[23], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[24], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[25], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[26], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[27], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[28], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[29], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[30], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[31], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[32], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[33], false);
                        Bytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((IByteSingleTypetinyint_UNSIGNED)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteSingleTypetinyint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IByteSingleTypetinyint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[8], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[9], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[10], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[11], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[12], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[13], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[14], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[15], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[16], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[17], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[18], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[19], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[20], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[21], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[22], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[23], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[24], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[25], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[18],_testData[26], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[19],_testData[27], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[20],_testData[28], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[21],_testData[29], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[22],_testData[30], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[23],_testData[31], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[24],_testData[32], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[25],_testData[33], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypetinyint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypetinyint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models =  ((IByteSingleTypetinyint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                Bytetinyint_UNSIGNEDE0M.AssertModel(models[0],_testData[13], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[1],_testData[14], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[2],_testData[15], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[3],_testData[16], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[4],_testData[17], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[5],_testData[18], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[6],_testData[19], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[7],_testData[20], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[8],_testData[21], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[9],_testData[22], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[10],_testData[23], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[11],_testData[24], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[12],_testData[25], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[13],_testData[26], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[14],_testData[27], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[15],_testData[28], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[16],_testData[29], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[17],_testData[30], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[18],_testData[31], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[19],_testData[32], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[20],_testData[33], false);
                Bytetinyint_UNSIGNEDE0M.AssertModel(models[21],_testData[34], false);
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
FROM gedaqtests.bytetinyint_unsignede0m m
LEFT JOIN gedaqtests.bytetinyint_unsignede0mi mi ON mi.id = m.bytetinyint_unsignede0mi_id
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
            asPartInterface: typeof(IByteSingleTypetinyint_UNSIGNED))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((122)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((102)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((166)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((129)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((63)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((235)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((4)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((160)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((236)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((201)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((202)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((209)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((66)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((146)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((226)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((178)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((127)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((195)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((218)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((200)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((139)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((37)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((53)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((66)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((148)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((182)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((71)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((248)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((178)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((115)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((33)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((254)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((45)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((12)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((142)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((241)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((191)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((172)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((110)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((6)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((179)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((103)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((90)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((167)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((30)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((213)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((84)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((119)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((95)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((77)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((54)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((148)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((7)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((8)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((41)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((30)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((253)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((74)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((46)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((200)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((18)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((47)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((198)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((125)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((73)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((174)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((26)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((70)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((6)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((185)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((177)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((4)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((212)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((108)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteSingleTypetinyint_UNSIGNED)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((122)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((102)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((166)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((129)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((63)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((235)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((4)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((160)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((236)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((201)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((202)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((209)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((66)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((146)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((226)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((178)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((127)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((195)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((218)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((200)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((139)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((37)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((53)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((66)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((148)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((182)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((71)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((248)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((178)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((115)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((33)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((254)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((45)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((12)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((142)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((241)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((191)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((172)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((110)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((6)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((179)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((103)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((90)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((167)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((30)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((213)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((84)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((119)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((95)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((77)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((54)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((148)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((7)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((8)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((41)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((30)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((253)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((74)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((46)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((200)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((18)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((47)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((198)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((125)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((73)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((174)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((26)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((70)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((6)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((185)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((177)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((4)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((212)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((108)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


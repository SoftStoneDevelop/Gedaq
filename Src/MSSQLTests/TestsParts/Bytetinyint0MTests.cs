

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IByteSingleTypetinyint
    {
    }
    
    internal partial class ByteSingleTypetinyint : IByteSingleTypetinyint
    {


#region TestData

        private readonly Bytetinyint0M[] _testData = new Bytetinyint0M[]
        {
            new Bytetinyint0M
{
    Id = 9,
    Value = 133,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 16,
    Value = 183,
    ModelInner = new Bytetinyint0MI
{
    Id = 3,
    Value = 86,
    NullableValue = null,
},
    NullableValue = 152,
},
            new Bytetinyint0M
{
    Id = 18,
    Value = 157,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 25,
    Value = 238,
    ModelInner = new Bytetinyint0MI
{
    Id = 6,
    Value = 214,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 26,
    Value = 218,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 29,
    Value = 161,
    ModelInner = new Bytetinyint0MI
{
    Id = 8,
    Value = 102,
    NullableValue = 67,
},
    NullableValue = 209,
},
            new Bytetinyint0M
{
    Id = 37,
    Value = 242,
    ModelInner = null,
    NullableValue = 218,
},
            new Bytetinyint0M
{
    Id = 40,
    Value = 195,
    ModelInner = new Bytetinyint0MI
{
    Id = 10,
    Value = 195,
    NullableValue = null,
},
    NullableValue = 239,
},
            new Bytetinyint0M
{
    Id = 42,
    Value = 158,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 49,
    Value = 215,
    ModelInner = new Bytetinyint0MI
{
    Id = 11,
    Value = 171,
    NullableValue = null,
},
    NullableValue = 151,
},
            new Bytetinyint0M
{
    Id = 56,
    Value = 67,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 60,
    Value = 19,
    ModelInner = new Bytetinyint0MI
{
    Id = 20,
    Value = 106,
    NullableValue = 186,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 68,
    Value = 154,
    ModelInner = null,
    NullableValue = 201,
},
            new Bytetinyint0M
{
    Id = 71,
    Value = 38,
    ModelInner = new Bytetinyint0MI
{
    Id = 25,
    Value = 61,
    NullableValue = null,
},
    NullableValue = 9,
},
            new Bytetinyint0M
{
    Id = 76,
    Value = 66,
    ModelInner = null,
    NullableValue = 102,
},
            new Bytetinyint0M
{
    Id = 82,
    Value = 23,
    ModelInner = new Bytetinyint0MI
{
    Id = 27,
    Value = 218,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 86,
    Value = 235,
    ModelInner = null,
    NullableValue = 155,
},
            new Bytetinyint0M
{
    Id = 91,
    Value = 22,
    ModelInner = new Bytetinyint0MI
{
    Id = 29,
    Value = 92,
    NullableValue = 220,
},
    NullableValue = 162,
},
            new Bytetinyint0M
{
    Id = 98,
    Value = 108,
    ModelInner = null,
    NullableValue = 12,
},
            new Bytetinyint0M
{
    Id = 103,
    Value = 60,
    ModelInner = new Bytetinyint0MI
{
    Id = 34,
    Value = 185,
    NullableValue = 250,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 112,
    Value = 216,
    ModelInner = null,
    NullableValue = 73,
},
            new Bytetinyint0M
{
    Id = 114,
    Value = 111,
    ModelInner = new Bytetinyint0MI
{
    Id = 41,
    Value = 177,
    NullableValue = null,
},
    NullableValue = 157,
},
            new Bytetinyint0M
{
    Id = 118,
    Value = 172,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 125,
    Value = 60,
    ModelInner = new Bytetinyint0MI
{
    Id = 49,
    Value = 97,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 129,
    Value = 4,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 130,
    Value = 254,
    ModelInner = new Bytetinyint0MI
{
    Id = 56,
    Value = 78,
    NullableValue = 209,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 138,
    Value = 213,
    ModelInner = null,
    NullableValue = 129,
},
            new Bytetinyint0M
{
    Id = 145,
    Value = 197,
    ModelInner = new Bytetinyint0MI
{
    Id = 65,
    Value = 116,
    NullableValue = 69,
},
    NullableValue = 67,
},
            new Bytetinyint0M
{
    Id = 152,
    Value = 75,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 159,
    Value = 233,
    ModelInner = new Bytetinyint0MI
{
    Id = 68,
    Value = 114,
    NullableValue = null,
},
    NullableValue = 193,
},
            new Bytetinyint0M
{
    Id = 167,
    Value = 35,
    ModelInner = null,
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 173,
    Value = 13,
    ModelInner = new Bytetinyint0MI
{
    Id = 70,
    Value = 105,
    NullableValue = 43,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 175,
    Value = 153,
    ModelInner = null,
    NullableValue = 245,
},
            new Bytetinyint0M
{
    Id = 176,
    Value = 100,
    ModelInner = new Bytetinyint0MI
{
    Id = 77,
    Value = 73,
    NullableValue = 195,
},
    NullableValue = null,
},
            new Bytetinyint0M
{
    Id = 183,
    Value = 70,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(20)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(20))
            ]
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

                changedRows =  ((IByteSingleTypetinyint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)2),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)2, 
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

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0m(
	id,
    value,
    nullablevalue,
    bytetinyint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyint0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(20)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(20),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyint0mi_id", 
                methodParametrName: "bytetinyint0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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

                changedRows =  ((IByteSingleTypetinyint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyint0m(
	id,
    value,
    nullablevalue,
    bytetinyint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Byte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)2),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)2,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyint0mi_id", 
                methodParametrName: "bytetinyint0mi_id", 
                dbType: (System.Data.DbType)11,
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

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint0M), typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                await((IByteSingleTypetinyint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                ((IByteSingleTypetinyint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Bytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint0M), typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                await((IByteSingleTypetinyint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                ((IByteSingleTypetinyint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Bytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IByteSingleTypetinyint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteSingleTypetinyint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint0M), typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                await((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(models[3],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(models[4],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(models[5],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(models[6],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(models[7],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(models[8],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(models[9],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(models[10],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(models[11],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(models[12],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(models[13],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(models[14],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[15],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(models[3],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(models[4],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[5],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(models[3],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(models[4],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(models[5],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(models[6],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(models[7],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(models[8],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(models[9],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(models[10],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(models[11],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(models[12],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(models[13],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(models[14],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(models[15],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(models[16],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(models[17],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(models[18],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(models[19],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(models[20],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(models[21],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(models[22],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(models[23],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(models[24],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(models[25],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(models[26],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(models[27],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(models[28],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[29],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Bytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
                var models = await((IByteSingleTypetinyint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Bytetinyint0M.AssertModel(models[0],_testData[3], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[4], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[5], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[6], false);
                        Bytetinyint0M.AssertModel(models[4],_testData[7], false);
                        Bytetinyint0M.AssertModel(models[5],_testData[8], false);
                        Bytetinyint0M.AssertModel(models[6],_testData[9], false);
                        Bytetinyint0M.AssertModel(models[7],_testData[10], false);
                        Bytetinyint0M.AssertModel(models[8],_testData[11], false);
                        Bytetinyint0M.AssertModel(models[9],_testData[12], false);
                        Bytetinyint0M.AssertModel(models[10],_testData[13], false);
                        Bytetinyint0M.AssertModel(models[11],_testData[14], false);
                        Bytetinyint0M.AssertModel(models[12],_testData[15], false);
                        Bytetinyint0M.AssertModel(models[13],_testData[16], false);
                        Bytetinyint0M.AssertModel(models[14],_testData[17], false);
                        Bytetinyint0M.AssertModel(models[15],_testData[18], false);
                        Bytetinyint0M.AssertModel(models[16],_testData[19], false);
                        Bytetinyint0M.AssertModel(models[17],_testData[20], false);
                        Bytetinyint0M.AssertModel(models[18],_testData[21], false);
                        Bytetinyint0M.AssertModel(models[19],_testData[22], false);
                        Bytetinyint0M.AssertModel(models[20],_testData[23], false);
                        Bytetinyint0M.AssertModel(models[21],_testData[24], false);
                        Bytetinyint0M.AssertModel(models[22],_testData[25], false);
                        Bytetinyint0M.AssertModel(models[23],_testData[26], false);
                        Bytetinyint0M.AssertModel(models[24],_testData[27], false);
                        Bytetinyint0M.AssertModel(models[25],_testData[28], false);
                        Bytetinyint0M.AssertModel(models[26],_testData[29], false);
                        Bytetinyint0M.AssertModel(models[27],_testData[30], false);
                        Bytetinyint0M.AssertModel(models[28],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[29],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[30],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Bytetinyint0M.AssertModel(models[0],_testData[30], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IByteSingleTypetinyint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Bytetinyint0M.AssertModel(models[0],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Bytetinyint0M.AssertModel(models[0],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint0M), typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                await((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 167, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyint0M>();
                var models2 = new List<FlatBytetinyint0M>();
                ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var firstItems2 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 173, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[3], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(models[3],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(models[4],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(models[5],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(models[6],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(models[7],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(models[8],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(models[9],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(models[10],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(models[11],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(models[12],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(models[13],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(models[14],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(models[15],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(models[16],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(models[17],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(models[18],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(models[19],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(models[20],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(models[21],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(models[22],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(models[23],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(models[24],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(models[25],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(models[26],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(models[27],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(models[28],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(models[29],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[30],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[34], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 125, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(models[3],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(models[4],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(models[5],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(models[6],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[7],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBytetinyint0M.AssertModel(models[0],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(models[1],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(models[2],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(models[3],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(models[4],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(models[5],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(models[6],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(models[7],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(models[8],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(models[9],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(models[10],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(models[11],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(models[12],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(models[13],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(models[14],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(models[15],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(models[16],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(models[17],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(models[18],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(models[19],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(models[20],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(models[21],_testData[34], false);
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
FROM dbo.bytetinyint0m m
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
FROM dbo.bytetinyint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyint0M>();
                var secondItems1 = new List<FlatBytetinyint0M>();
                var secondItems2 = new List<FlatBytetinyint0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatch(connection, 49, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBytetinyint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBytetinyint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBytetinyint0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBytetinyint0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Bytetinyint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
                var models = await((IByteSingleTypetinyint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatchAsync(connection, 138, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Bytetinyint0M.AssertModel(models[0],_testData[27], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[28], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[29], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[30], false);
                        Bytetinyint0M.AssertModel(models[4],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[5],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[6],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Bytetinyint0M.AssertModel(models[0],_testData[19], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[20], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[21], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[22], false);
                        Bytetinyint0M.AssertModel(models[4],_testData[23], false);
                        Bytetinyint0M.AssertModel(models[5],_testData[24], false);
                        Bytetinyint0M.AssertModel(models[6],_testData[25], false);
                        Bytetinyint0M.AssertModel(models[7],_testData[26], false);
                        Bytetinyint0M.AssertModel(models[8],_testData[27], false);
                        Bytetinyint0M.AssertModel(models[9],_testData[28], false);
                        Bytetinyint0M.AssertModel(models[10],_testData[29], false);
                        Bytetinyint0M.AssertModel(models[11],_testData[30], false);
                        Bytetinyint0M.AssertModel(models[12],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[13],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[14],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[15],_testData[34], false);
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
                var models = ((IByteSingleTypetinyint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Bytetinyint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatch(connection, 129, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Bytetinyint0M.AssertModel(models[0],_testData[25], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[26], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[27], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[28], false);
                        Bytetinyint0M.AssertModel(models[4],_testData[29], false);
                        Bytetinyint0M.AssertModel(models[5],_testData[30], false);
                        Bytetinyint0M.AssertModel(models[6],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[7],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[8],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Bytetinyint0M.AssertModel(models[0],_testData[12], false);
                        Bytetinyint0M.AssertModel(models[1],_testData[13], false);
                        Bytetinyint0M.AssertModel(models[2],_testData[14], false);
                        Bytetinyint0M.AssertModel(models[3],_testData[15], false);
                        Bytetinyint0M.AssertModel(models[4],_testData[16], false);
                        Bytetinyint0M.AssertModel(models[5],_testData[17], false);
                        Bytetinyint0M.AssertModel(models[6],_testData[18], false);
                        Bytetinyint0M.AssertModel(models[7],_testData[19], false);
                        Bytetinyint0M.AssertModel(models[8],_testData[20], false);
                        Bytetinyint0M.AssertModel(models[9],_testData[21], false);
                        Bytetinyint0M.AssertModel(models[10],_testData[22], false);
                        Bytetinyint0M.AssertModel(models[11],_testData[23], false);
                        Bytetinyint0M.AssertModel(models[12],_testData[24], false);
                        Bytetinyint0M.AssertModel(models[13],_testData[25], false);
                        Bytetinyint0M.AssertModel(models[14],_testData[26], false);
                        Bytetinyint0M.AssertModel(models[15],_testData[27], false);
                        Bytetinyint0M.AssertModel(models[16],_testData[28], false);
                        Bytetinyint0M.AssertModel(models[17],_testData[29], false);
                        Bytetinyint0M.AssertModel(models[18],_testData[30], false);
                        Bytetinyint0M.AssertModel(models[19],_testData[31], false);
                        Bytetinyint0M.AssertModel(models[20],_testData[32], false);
                        Bytetinyint0M.AssertModel(models[21],_testData[33], false);
                        Bytetinyint0M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models = await ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
Bytetinyint0M.AssertModel(models[0],_testData[14], false);Bytetinyint0M.AssertModel(models[1],_testData[15], false);Bytetinyint0M.AssertModel(models[2],_testData[16], false);Bytetinyint0M.AssertModel(models[3],_testData[17], false);Bytetinyint0M.AssertModel(models[4],_testData[18], false);Bytetinyint0M.AssertModel(models[5],_testData[19], false);Bytetinyint0M.AssertModel(models[6],_testData[20], false);Bytetinyint0M.AssertModel(models[7],_testData[21], false);Bytetinyint0M.AssertModel(models[8],_testData[22], false);Bytetinyint0M.AssertModel(models[9],_testData[23], false);Bytetinyint0M.AssertModel(models[10],_testData[24], false);Bytetinyint0M.AssertModel(models[11],_testData[25], false);Bytetinyint0M.AssertModel(models[12],_testData[26], false);Bytetinyint0M.AssertModel(models[13],_testData[27], false);Bytetinyint0M.AssertModel(models[14],_testData[28], false);Bytetinyint0M.AssertModel(models[15],_testData[29], false);Bytetinyint0M.AssertModel(models[16],_testData[30], false);Bytetinyint0M.AssertModel(models[17],_testData[31], false);Bytetinyint0M.AssertModel(models[18],_testData[32], false);Bytetinyint0M.AssertModel(models[19],_testData[33], false);Bytetinyint0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models =  ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
Bytetinyint0M.AssertModel(models[0],_testData[29], false);Bytetinyint0M.AssertModel(models[1],_testData[30], false);Bytetinyint0M.AssertModel(models[2],_testData[31], false);Bytetinyint0M.AssertModel(models[3],_testData[32], false);Bytetinyint0M.AssertModel(models[4],_testData[33], false);Bytetinyint0M.AssertModel(models[5],_testData[34], false);
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
FROM dbo.bytetinyint0m m
LEFT JOIN dbo.bytetinyint0mi mi ON mi.id = m.bytetinyint0mi_id
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
            asPartInterface: typeof(IByteSingleTypetinyint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypetinyint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((133)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((183)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((86)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((152)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((157)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((238)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((214)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((218)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((161)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((102)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((67)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((209)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((242)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((218)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((195)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((195)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((239)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((158)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((215)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((171)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((151)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((67)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((19)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((106)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((186)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((154)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((201)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((61)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((9)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((102)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((23)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((218)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((155)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((22)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((92)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((220)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((162)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((108)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((12)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((60)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((185)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((250)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((216)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((73)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((111)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((177)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((157)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((60)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((97)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((4)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((254)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((78)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((209)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((213)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((129)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((197)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((116)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((69)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((67)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((75)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((233)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((114)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((193)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((35)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((13)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((105)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((43)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((245)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((100)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((73)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((195)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((70)));//Value

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
                var models =  ((IByteSingleTypetinyint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((133)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((183)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((86)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((152)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((157)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((238)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((214)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((218)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((161)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((102)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((67)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((209)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((242)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((218)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((195)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((195)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((239)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((158)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((215)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((171)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((151)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((67)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((19)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((106)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((186)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((154)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((201)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((61)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((9)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((102)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((23)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((218)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((155)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((22)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((92)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((220)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((162)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((108)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((12)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((60)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((185)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((250)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((216)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((73)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((111)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((177)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((157)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((60)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((97)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((4)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((254)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((78)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((209)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((213)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((129)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((197)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((116)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((69)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((67)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((75)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((233)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((114)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((193)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((35)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((13)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((105)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((43)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((245)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((100)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((73)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((195)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((70)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


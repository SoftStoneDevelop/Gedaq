

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

        private readonly BytetinyintE0M[] _testData = new BytetinyintE0M[]
        {
            new BytetinyintE0M
{
    Id = 6,
    Value = 226,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 12,
    Value = 70,
    ModelInner = new BytetinyintE0MI
{
    Id = 2,
    Value = 214,
    NullableValue = 201,
},
    NullableValue = 202,
},
            new BytetinyintE0M
{
    Id = 15,
    Value = 200,
    ModelInner = null,
    NullableValue = 24,
},
            new BytetinyintE0M
{
    Id = 21,
    Value = 226,
    ModelInner = new BytetinyintE0MI
{
    Id = 7,
    Value = 234,
    NullableValue = 149,
},
    NullableValue = 98,
},
            new BytetinyintE0M
{
    Id = 23,
    Value = 40,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 31,
    Value = 162,
    ModelInner = new BytetinyintE0MI
{
    Id = 14,
    Value = 55,
    NullableValue = 109,
},
    NullableValue = 107,
},
            new BytetinyintE0M
{
    Id = 33,
    Value = 42,
    ModelInner = null,
    NullableValue = 49,
},
            new BytetinyintE0M
{
    Id = 38,
    Value = 110,
    ModelInner = new BytetinyintE0MI
{
    Id = 19,
    Value = 245,
    NullableValue = 50,
},
    NullableValue = 49,
},
            new BytetinyintE0M
{
    Id = 44,
    Value = 102,
    ModelInner = null,
    NullableValue = 106,
},
            new BytetinyintE0M
{
    Id = 51,
    Value = 185,
    ModelInner = new BytetinyintE0MI
{
    Id = 25,
    Value = 170,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 58,
    Value = 245,
    ModelInner = null,
    NullableValue = 227,
},
            new BytetinyintE0M
{
    Id = 60,
    Value = 142,
    ModelInner = new BytetinyintE0MI
{
    Id = 34,
    Value = 119,
    NullableValue = 29,
},
    NullableValue = 13,
},
            new BytetinyintE0M
{
    Id = 65,
    Value = 109,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 70,
    Value = 140,
    ModelInner = new BytetinyintE0MI
{
    Id = 38,
    Value = 209,
    NullableValue = null,
},
    NullableValue = 159,
},
            new BytetinyintE0M
{
    Id = 73,
    Value = 89,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 79,
    Value = 62,
    ModelInner = new BytetinyintE0MI
{
    Id = 45,
    Value = 164,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 85,
    Value = 7,
    ModelInner = null,
    NullableValue = 189,
},
            new BytetinyintE0M
{
    Id = 93,
    Value = 250,
    ModelInner = new BytetinyintE0MI
{
    Id = 54,
    Value = 217,
    NullableValue = 57,
},
    NullableValue = 117,
},
            new BytetinyintE0M
{
    Id = 102,
    Value = 114,
    ModelInner = null,
    NullableValue = 234,
},
            new BytetinyintE0M
{
    Id = 107,
    Value = 10,
    ModelInner = new BytetinyintE0MI
{
    Id = 63,
    Value = 145,
    NullableValue = null,
},
    NullableValue = 49,
},
            new BytetinyintE0M
{
    Id = 109,
    Value = 177,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 116,
    Value = 236,
    ModelInner = new BytetinyintE0MI
{
    Id = 64,
    Value = 110,
    NullableValue = 120,
},
    NullableValue = 45,
},
            new BytetinyintE0M
{
    Id = 123,
    Value = 210,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 128,
    Value = 155,
    ModelInner = new BytetinyintE0MI
{
    Id = 67,
    Value = 175,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 131,
    Value = 239,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 138,
    Value = 87,
    ModelInner = new BytetinyintE0MI
{
    Id = 72,
    Value = 9,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 147,
    Value = 117,
    ModelInner = null,
    NullableValue = 212,
},
            new BytetinyintE0M
{
    Id = 152,
    Value = 150,
    ModelInner = new BytetinyintE0MI
{
    Id = 79,
    Value = 2,
    NullableValue = 12,
},
    NullableValue = 36,
},
            new BytetinyintE0M
{
    Id = 158,
    Value = 169,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 160,
    Value = 86,
    ModelInner = new BytetinyintE0MI
{
    Id = 87,
    Value = 239,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 164,
    Value = 52,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 172,
    Value = 30,
    ModelInner = new BytetinyintE0MI
{
    Id = 92,
    Value = 99,
    NullableValue = 250,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 175,
    Value = 12,
    ModelInner = null,
    NullableValue = 24,
},
            new BytetinyintE0M
{
    Id = 183,
    Value = 204,
    ModelInner = new BytetinyintE0MI
{
    Id = 93,
    Value = 22,
    NullableValue = null,
},
    NullableValue = 32,
},
            new BytetinyintE0M
{
    Id = 189,
    Value = 121,
    ModelInner = null,
    NullableValue = 0,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyinte0mi(
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
INSERT INTO dbo.bytetinyinte0mi(
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
INSERT INTO dbo.bytetinyinte0m(
	id,
    value,
    nullablevalue,
    bytetinyinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyinte0mi_id
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
                parametrName: "bytetinyinte0mi_id", 
                methodParametrName: "bytetinyinte0mi_id", 
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
INSERT INTO dbo.bytetinyinte0m(
	id,
    value,
    nullablevalue,
    bytetinyinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyinte0mi_id
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
                parametrName: "bytetinyinte0mi_id", 
                methodParametrName: "bytetinyinte0mi_id", 
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
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
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
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytetinyintE0M)],
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytetinyintE0M)],
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
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
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[1], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[26],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[27],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[28],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[29],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[30],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[31],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[32],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytetinyintE0M)],
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BytetinyintE0M.AssertModel(models[0],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BytetinyintE0M.AssertModel(models[0],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[34], false);
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BytetinyintE0M.AssertModel(models[0],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BytetinyintE0M.AssertModel(models[0],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 172, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 138, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 175, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 73, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[26],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[27],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[28],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[29],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[30],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[31],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 172, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatch(connection, 172, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytetinyintE0M)],
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatchAsync(connection, 131, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BytetinyintE0M.AssertModel(models[0],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BytetinyintE0M.AssertModel(models[0],_testData[2], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[3], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[4], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[5], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[6], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[7], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[8], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[26],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[27],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[28],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[29],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[30],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[31],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[32],_testData[34], false);
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
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatch(connection, 12, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BytetinyintE0M.AssertModel(models[0],_testData[2], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[3], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[4], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[5], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[6], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[7], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[8], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[26],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[27],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[28],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[29],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[30],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[31],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BytetinyintE0M.AssertModel(models[0],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[34], false);
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
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 164);
                var models = await ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                BytetinyintE0M.AssertModel(models[0],_testData[31], false);
                BytetinyintE0M.AssertModel(models[1],_testData[32], false);
                BytetinyintE0M.AssertModel(models[2],_testData[33], false);
                BytetinyintE0M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                BytetinyintE0M.AssertModel(models[0],_testData[11], false);
                BytetinyintE0M.AssertModel(models[1],_testData[12], false);
                BytetinyintE0M.AssertModel(models[2],_testData[13], false);
                BytetinyintE0M.AssertModel(models[3],_testData[14], false);
                BytetinyintE0M.AssertModel(models[4],_testData[15], false);
                BytetinyintE0M.AssertModel(models[5],_testData[16], false);
                BytetinyintE0M.AssertModel(models[6],_testData[17], false);
                BytetinyintE0M.AssertModel(models[7],_testData[18], false);
                BytetinyintE0M.AssertModel(models[8],_testData[19], false);
                BytetinyintE0M.AssertModel(models[9],_testData[20], false);
                BytetinyintE0M.AssertModel(models[10],_testData[21], false);
                BytetinyintE0M.AssertModel(models[11],_testData[22], false);
                BytetinyintE0M.AssertModel(models[12],_testData[23], false);
                BytetinyintE0M.AssertModel(models[13],_testData[24], false);
                BytetinyintE0M.AssertModel(models[14],_testData[25], false);
                BytetinyintE0M.AssertModel(models[15],_testData[26], false);
                BytetinyintE0M.AssertModel(models[16],_testData[27], false);
                BytetinyintE0M.AssertModel(models[17],_testData[28], false);
                BytetinyintE0M.AssertModel(models[18],_testData[29], false);
                BytetinyintE0M.AssertModel(models[19],_testData[30], false);
                BytetinyintE0M.AssertModel(models[20],_testData[31], false);
                BytetinyintE0M.AssertModel(models[21],_testData[32], false);
                BytetinyintE0M.AssertModel(models[22],_testData[33], false);
                BytetinyintE0M.AssertModel(models[23],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((226)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((214)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((201)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((202)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((200)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((24)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((226)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((234)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((149)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((98)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((40)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((162)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((55)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((109)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((107)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((42)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((49)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((110)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((245)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((50)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((49)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((102)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((106)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((185)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((170)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((245)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((227)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((142)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((119)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((29)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((13)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((109)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((140)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((209)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((159)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((89)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((62)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((164)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((7)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((189)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((250)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((217)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((57)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((117)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((114)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((234)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((10)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((145)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((49)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((177)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((236)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((110)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((120)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((45)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((155)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((175)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((239)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((87)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((9)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((117)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((212)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((150)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((2)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((12)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((36)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((169)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((86)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((239)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((52)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((30)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((99)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((250)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((12)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((24)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((22)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((32)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((121)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((0)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((226)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((214)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((201)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((202)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((200)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((24)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((226)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((234)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((149)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((98)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((40)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((162)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((55)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((109)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((107)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((42)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((49)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((110)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((245)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((50)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((49)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((102)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((106)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((185)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((170)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((245)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((227)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((142)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((119)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((29)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((13)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((109)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((140)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((209)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((159)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((89)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((62)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((164)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((7)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((189)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((250)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((217)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((57)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((117)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((114)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((234)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((10)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((145)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((49)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((177)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((236)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((110)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((120)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((45)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((155)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((175)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((239)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((87)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((9)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((117)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((212)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((150)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((2)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((12)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((36)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((169)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((86)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((239)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((52)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((30)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((99)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((250)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((12)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((24)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((22)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((32)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((121)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((0)));

            }
        }

#endregion

    }
}


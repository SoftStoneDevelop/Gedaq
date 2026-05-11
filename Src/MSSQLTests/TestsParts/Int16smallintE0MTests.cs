

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
    internal partial interface IInt16SingleTypesmallint
    {
    }
    
    internal partial class Int16SingleTypesmallint : IInt16SingleTypesmallint
    {


#region TestData

        private readonly Int16smallintE0M[] _testData = new Int16smallintE0M[]
        {
            new Int16smallintE0M
{
    Id = 4,
    Value = 629,
    ModelInner = null,
    NullableValue = 16188,
},
            new Int16smallintE0M
{
    Id = 7,
    Value = 4128,
    ModelInner = new Int16smallintE0MI
{
    Id = 4,
    Value = 4756,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 16,
    Value = 2749,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 23,
    Value = 17141,
    ModelInner = new Int16smallintE0MI
{
    Id = 10,
    Value = 15317,
    NullableValue = 20744,
},
    NullableValue = 21961,
},
            new Int16smallintE0M
{
    Id = 31,
    Value = 14461,
    ModelInner = null,
    NullableValue = 14276,
},
            new Int16smallintE0M
{
    Id = 34,
    Value = 1178,
    ModelInner = new Int16smallintE0MI
{
    Id = 14,
    Value = 25891,
    NullableValue = null,
},
    NullableValue = 11660,
},
            new Int16smallintE0M
{
    Id = 37,
    Value = 29,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 40,
    Value = 9168,
    ModelInner = new Int16smallintE0MI
{
    Id = 20,
    Value = 19265,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 42,
    Value = 3423,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 43,
    Value = 2514,
    ModelInner = new Int16smallintE0MI
{
    Id = 21,
    Value = 21046,
    NullableValue = 3923,
},
    NullableValue = 28812,
},
            new Int16smallintE0M
{
    Id = 52,
    Value = 9625,
    ModelInner = null,
    NullableValue = 14094,
},
            new Int16smallintE0M
{
    Id = 58,
    Value = 26813,
    ModelInner = new Int16smallintE0MI
{
    Id = 26,
    Value = 28341,
    NullableValue = 19094,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 67,
    Value = 13595,
    ModelInner = null,
    NullableValue = 21952,
},
            new Int16smallintE0M
{
    Id = 75,
    Value = 25609,
    ModelInner = new Int16smallintE0MI
{
    Id = 28,
    Value = 30337,
    NullableValue = 28895,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 76,
    Value = 10394,
    ModelInner = null,
    NullableValue = 7194,
},
            new Int16smallintE0M
{
    Id = 83,
    Value = 4866,
    ModelInner = new Int16smallintE0MI
{
    Id = 30,
    Value = 7960,
    NullableValue = null,
},
    NullableValue = 18584,
},
            new Int16smallintE0M
{
    Id = 87,
    Value = 5870,
    ModelInner = null,
    NullableValue = 19359,
},
            new Int16smallintE0M
{
    Id = 92,
    Value = 19430,
    ModelInner = new Int16smallintE0MI
{
    Id = 35,
    Value = 21493,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 97,
    Value = 25390,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 105,
    Value = 10817,
    ModelInner = new Int16smallintE0MI
{
    Id = 37,
    Value = 14072,
    NullableValue = null,
},
    NullableValue = 19106,
},
            new Int16smallintE0M
{
    Id = 112,
    Value = 9705,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 113,
    Value = 10369,
    ModelInner = new Int16smallintE0MI
{
    Id = 43,
    Value = 9481,
    NullableValue = 14966,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 116,
    Value = 5623,
    ModelInner = null,
    NullableValue = 7195,
},
            new Int16smallintE0M
{
    Id = 120,
    Value = 29,
    ModelInner = new Int16smallintE0MI
{
    Id = 44,
    Value = 11488,
    NullableValue = null,
},
    NullableValue = 6355,
},
            new Int16smallintE0M
{
    Id = 128,
    Value = 2747,
    ModelInner = null,
    NullableValue = 12790,
},
            new Int16smallintE0M
{
    Id = 134,
    Value = 809,
    ModelInner = new Int16smallintE0MI
{
    Id = 49,
    Value = 20307,
    NullableValue = 15824,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 136,
    Value = 4977,
    ModelInner = null,
    NullableValue = 27400,
},
            new Int16smallintE0M
{
    Id = 143,
    Value = 2753,
    ModelInner = new Int16smallintE0MI
{
    Id = 57,
    Value = 21206,
    NullableValue = 7591,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 147,
    Value = 4235,
    ModelInner = null,
    NullableValue = 22611,
},
            new Int16smallintE0M
{
    Id = 151,
    Value = 16129,
    ModelInner = new Int16smallintE0MI
{
    Id = 62,
    Value = 20224,
    NullableValue = 31598,
},
    NullableValue = 28344,
},
            new Int16smallintE0M
{
    Id = 159,
    Value = 10673,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 160,
    Value = 3077,
    ModelInner = new Int16smallintE0MI
{
    Id = 71,
    Value = 10790,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 166,
    Value = 14654,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 175,
    Value = 13251,
    ModelInner = new Int16smallintE0MI
{
    Id = 80,
    Value = 32324,
    NullableValue = 28112,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 183,
    Value = 3860,
    ModelInner = null,
    NullableValue = 3046,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(16)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(16))
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)10),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)10, 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallinte0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(16)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(16),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallinte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)10),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)10,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16SingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int16smallintE0M.AssertModel(models[0],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintE0M.AssertModel(models[0],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int16smallintE0M.AssertModel(models[0],_testData[8], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[9], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[25],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintE0M.AssertModel(models[0],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 4, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 58, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 92, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int16smallintE0M.AssertModel(models[0],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int16smallintE0M.AssertModel(models[0],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 120, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallintE0M.AssertModel(models[0],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int16smallintE0M.AssertModel(models[0],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                Int16smallintE0M.AssertModel(models[0],_testData[18], false);
                Int16smallintE0M.AssertModel(models[1],_testData[19], false);
                Int16smallintE0M.AssertModel(models[2],_testData[20], false);
                Int16smallintE0M.AssertModel(models[3],_testData[21], false);
                Int16smallintE0M.AssertModel(models[4],_testData[22], false);
                Int16smallintE0M.AssertModel(models[5],_testData[23], false);
                Int16smallintE0M.AssertModel(models[6],_testData[24], false);
                Int16smallintE0M.AssertModel(models[7],_testData[25], false);
                Int16smallintE0M.AssertModel(models[8],_testData[26], false);
                Int16smallintE0M.AssertModel(models[9],_testData[27], false);
                Int16smallintE0M.AssertModel(models[10],_testData[28], false);
                Int16smallintE0M.AssertModel(models[11],_testData[29], false);
                Int16smallintE0M.AssertModel(models[12],_testData[30], false);
                Int16smallintE0M.AssertModel(models[13],_testData[31], false);
                Int16smallintE0M.AssertModel(models[14],_testData[32], false);
                Int16smallintE0M.AssertModel(models[15],_testData[33], false);
                Int16smallintE0M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int16smallintE0M.AssertModel(models[0],_testData[25], false);
                Int16smallintE0M.AssertModel(models[1],_testData[26], false);
                Int16smallintE0M.AssertModel(models[2],_testData[27], false);
                Int16smallintE0M.AssertModel(models[3],_testData[28], false);
                Int16smallintE0M.AssertModel(models[4],_testData[29], false);
                Int16smallintE0M.AssertModel(models[5],_testData[30], false);
                Int16smallintE0M.AssertModel(models[6],_testData[31], false);
                Int16smallintE0M.AssertModel(models[7],_testData[32], false);
                Int16smallintE0M.AssertModel(models[8],_testData[33], false);
                Int16smallintE0M.AssertModel(models[9],_testData[34], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((629)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16188)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4128)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((4756)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2749)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17141)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15317)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((20744)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21961)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14461)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14276)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1178)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25891)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((11660)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9168)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19265)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3423)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2514)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21046)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((3923)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28812)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9625)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14094)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26813)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28341)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((19094)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13595)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21952)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25609)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((30337)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((28895)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10394)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7194)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4866)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((7960)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18584)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5870)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19359)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19430)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21493)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25390)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10817)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14072)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19106)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9705)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9481)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14966)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5623)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7195)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11488)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((6355)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2747)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12790)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((809)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20307)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15824)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4977)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((27400)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2753)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21206)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((7591)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22611)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16129)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20224)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31598)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28344)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10673)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3077)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10790)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14654)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13251)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32324)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((28112)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3860)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3046)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((629)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16188)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4128)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((4756)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2749)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17141)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15317)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((20744)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21961)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14461)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14276)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1178)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25891)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((11660)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9168)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19265)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3423)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2514)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21046)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((3923)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28812)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9625)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14094)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26813)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28341)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((19094)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13595)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21952)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25609)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((30337)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((28895)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10394)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7194)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4866)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((7960)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18584)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5870)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19359)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19430)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21493)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25390)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10817)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14072)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19106)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9705)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9481)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14966)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5623)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7195)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11488)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((6355)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2747)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12790)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((809)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20307)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15824)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4977)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((27400)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2753)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21206)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((7591)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22611)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16129)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20224)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31598)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28344)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10673)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3077)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10790)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14654)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13251)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32324)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((28112)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3860)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3046)));

            }
        }

#endregion

    }
}


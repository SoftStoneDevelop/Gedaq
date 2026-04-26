

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
    internal partial interface IInt16SingleTypesmallint
    {
    }
    
    internal partial class Int16SingleTypesmallint : IInt16SingleTypesmallint
    {


#region TestData

        private readonly Int16smallint0M[] _testData = new Int16smallint0M[]
        {
            new Int16smallint0M
{
    Id = 8,
    Value = 20646,
    ModelInner = null,
    NullableValue = 31965,
},
            new Int16smallint0M
{
    Id = 13,
    Value = 1046,
    ModelInner = new Int16smallint0MI
{
    Id = 4,
    Value = 19130,
    NullableValue = 15243,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 15,
    Value = 19458,
    ModelInner = null,
    NullableValue = 1488,
},
            new Int16smallint0M
{
    Id = 17,
    Value = 22492,
    ModelInner = new Int16smallint0MI
{
    Id = 8,
    Value = 23855,
    NullableValue = 18158,
},
    NullableValue = 11773,
},
            new Int16smallint0M
{
    Id = 21,
    Value = 7111,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 24,
    Value = 4985,
    ModelInner = new Int16smallint0MI
{
    Id = 13,
    Value = 19138,
    NullableValue = 17370,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 25,
    Value = 17386,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 31,
    Value = 5650,
    ModelInner = new Int16smallint0MI
{
    Id = 16,
    Value = 26980,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 33,
    Value = 8704,
    ModelInner = null,
    NullableValue = 25333,
},
            new Int16smallint0M
{
    Id = 41,
    Value = 17760,
    ModelInner = new Int16smallint0MI
{
    Id = 21,
    Value = 1093,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 47,
    Value = 2223,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 52,
    Value = 22475,
    ModelInner = new Int16smallint0MI
{
    Id = 25,
    Value = 15654,
    NullableValue = 26132,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 54,
    Value = 3490,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 56,
    Value = 17586,
    ModelInner = new Int16smallint0MI
{
    Id = 29,
    Value = 9283,
    NullableValue = 29033,
},
    NullableValue = 8381,
},
            new Int16smallint0M
{
    Id = 57,
    Value = 26172,
    ModelInner = null,
    NullableValue = 23610,
},
            new Int16smallint0M
{
    Id = 59,
    Value = 11015,
    ModelInner = new Int16smallint0MI
{
    Id = 37,
    Value = 5625,
    NullableValue = 23632,
},
    NullableValue = 26824,
},
            new Int16smallint0M
{
    Id = 64,
    Value = 30467,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 71,
    Value = 1797,
    ModelInner = new Int16smallint0MI
{
    Id = 38,
    Value = 19070,
    NullableValue = null,
},
    NullableValue = 23330,
},
            new Int16smallint0M
{
    Id = 78,
    Value = 12676,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 86,
    Value = 15985,
    ModelInner = new Int16smallint0MI
{
    Id = 39,
    Value = 17285,
    NullableValue = 6038,
},
    NullableValue = 31475,
},
            new Int16smallint0M
{
    Id = 91,
    Value = 32747,
    ModelInner = null,
    NullableValue = 7498,
},
            new Int16smallint0M
{
    Id = 100,
    Value = 15404,
    ModelInner = new Int16smallint0MI
{
    Id = 48,
    Value = 19174,
    NullableValue = 9285,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 103,
    Value = 6307,
    ModelInner = null,
    NullableValue = 21955,
},
            new Int16smallint0M
{
    Id = 105,
    Value = 21515,
    ModelInner = new Int16smallint0MI
{
    Id = 56,
    Value = 14764,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 112,
    Value = 23976,
    ModelInner = null,
    NullableValue = 1398,
},
            new Int16smallint0M
{
    Id = 114,
    Value = 6618,
    ModelInner = new Int16smallint0MI
{
    Id = 63,
    Value = 3476,
    NullableValue = null,
},
    NullableValue = 10277,
},
            new Int16smallint0M
{
    Id = 122,
    Value = 12567,
    ModelInner = null,
    NullableValue = 19320,
},
            new Int16smallint0M
{
    Id = 128,
    Value = 17663,
    ModelInner = new Int16smallint0MI
{
    Id = 71,
    Value = 17278,
    NullableValue = 7869,
},
    NullableValue = 19443,
},
            new Int16smallint0M
{
    Id = 129,
    Value = 2294,
    ModelInner = null,
    NullableValue = 23810,
},
            new Int16smallint0M
{
    Id = 135,
    Value = 7452,
    ModelInner = new Int16smallint0MI
{
    Id = 79,
    Value = 25059,
    NullableValue = 19581,
},
    NullableValue = 12320,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16smallint0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(2)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(2))]
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
INSERT INTO gedaqtests.int16smallint0mi(
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
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10), 
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

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallint0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(2)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(2),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallint0mi_id", 
                methodParametrName: "int16smallint0mi_id", 
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
INSERT INTO gedaqtests.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallint0mi_id
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallint0mi_id", 
                methodParametrName: "int16smallint0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int16smallint0m m
LEFT JOIN gedaqtests.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int16smallint0m m
LEFT JOIN gedaqtests.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
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
FROM gedaqtests.int16smallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
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
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[30], false);
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
FROM gedaqtests.int16smallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[1], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[2], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[22],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[23],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[24],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[25],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[26],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[27],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[30], false);
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
FROM gedaqtests.int16smallint0m m
LEFT JOIN gedaqtests.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int16smallint0M.AssertModel(models[0],_testData[8], false);
                        Int16smallint0M.AssertModel(models[1],_testData[9], false);
                        Int16smallint0M.AssertModel(models[2],_testData[10], false);
                        Int16smallint0M.AssertModel(models[3],_testData[11], false);
                        Int16smallint0M.AssertModel(models[4],_testData[12], false);
                        Int16smallint0M.AssertModel(models[5],_testData[13], false);
                        Int16smallint0M.AssertModel(models[6],_testData[14], false);
                        Int16smallint0M.AssertModel(models[7],_testData[15], false);
                        Int16smallint0M.AssertModel(models[8],_testData[16], false);
                        Int16smallint0M.AssertModel(models[9],_testData[17], false);
                        Int16smallint0M.AssertModel(models[10],_testData[18], false);
                        Int16smallint0M.AssertModel(models[11],_testData[19], false);
                        Int16smallint0M.AssertModel(models[12],_testData[20], false);
                        Int16smallint0M.AssertModel(models[13],_testData[21], false);
                        Int16smallint0M.AssertModel(models[14],_testData[22], false);
                        Int16smallint0M.AssertModel(models[15],_testData[23], false);
                        Int16smallint0M.AssertModel(models[16],_testData[24], false);
                        Int16smallint0M.AssertModel(models[17],_testData[25], false);
                        Int16smallint0M.AssertModel(models[18],_testData[26], false);
                        Int16smallint0M.AssertModel(models[19],_testData[27], false);
                        Int16smallint0M.AssertModel(models[20],_testData[28], false);
                        Int16smallint0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int16smallint0M.AssertModel(models[0],_testData[21], false);
                        Int16smallint0M.AssertModel(models[1],_testData[22], false);
                        Int16smallint0M.AssertModel(models[2],_testData[23], false);
                        Int16smallint0M.AssertModel(models[3],_testData[24], false);
                        Int16smallint0M.AssertModel(models[4],_testData[25], false);
                        Int16smallint0M.AssertModel(models[5],_testData[26], false);
                        Int16smallint0M.AssertModel(models[6],_testData[27], false);
                        Int16smallint0M.AssertModel(models[7],_testData[28], false);
                        Int16smallint0M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int16smallint0M.AssertModel(models[0],_testData[2], false);
                        Int16smallint0M.AssertModel(models[1],_testData[3], false);
                        Int16smallint0M.AssertModel(models[2],_testData[4], false);
                        Int16smallint0M.AssertModel(models[3],_testData[5], false);
                        Int16smallint0M.AssertModel(models[4],_testData[6], false);
                        Int16smallint0M.AssertModel(models[5],_testData[7], false);
                        Int16smallint0M.AssertModel(models[6],_testData[8], false);
                        Int16smallint0M.AssertModel(models[7],_testData[9], false);
                        Int16smallint0M.AssertModel(models[8],_testData[10], false);
                        Int16smallint0M.AssertModel(models[9],_testData[11], false);
                        Int16smallint0M.AssertModel(models[10],_testData[12], false);
                        Int16smallint0M.AssertModel(models[11],_testData[13], false);
                        Int16smallint0M.AssertModel(models[12],_testData[14], false);
                        Int16smallint0M.AssertModel(models[13],_testData[15], false);
                        Int16smallint0M.AssertModel(models[14],_testData[16], false);
                        Int16smallint0M.AssertModel(models[15],_testData[17], false);
                        Int16smallint0M.AssertModel(models[16],_testData[18], false);
                        Int16smallint0M.AssertModel(models[17],_testData[19], false);
                        Int16smallint0M.AssertModel(models[18],_testData[20], false);
                        Int16smallint0M.AssertModel(models[19],_testData[21], false);
                        Int16smallint0M.AssertModel(models[20],_testData[22], false);
                        Int16smallint0M.AssertModel(models[21],_testData[23], false);
                        Int16smallint0M.AssertModel(models[22],_testData[24], false);
                        Int16smallint0M.AssertModel(models[23],_testData[25], false);
                        Int16smallint0M.AssertModel(models[24],_testData[26], false);
                        Int16smallint0M.AssertModel(models[25],_testData[27], false);
                        Int16smallint0M.AssertModel(models[26],_testData[28], false);
                        Int16smallint0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallint0M.AssertModel(models[0],_testData[13], false);
                        Int16smallint0M.AssertModel(models[1],_testData[14], false);
                        Int16smallint0M.AssertModel(models[2],_testData[15], false);
                        Int16smallint0M.AssertModel(models[3],_testData[16], false);
                        Int16smallint0M.AssertModel(models[4],_testData[17], false);
                        Int16smallint0M.AssertModel(models[5],_testData[18], false);
                        Int16smallint0M.AssertModel(models[6],_testData[19], false);
                        Int16smallint0M.AssertModel(models[7],_testData[20], false);
                        Int16smallint0M.AssertModel(models[8],_testData[21], false);
                        Int16smallint0M.AssertModel(models[9],_testData[22], false);
                        Int16smallint0M.AssertModel(models[10],_testData[23], false);
                        Int16smallint0M.AssertModel(models[11],_testData[24], false);
                        Int16smallint0M.AssertModel(models[12],_testData[25], false);
                        Int16smallint0M.AssertModel(models[13],_testData[26], false);
                        Int16smallint0M.AssertModel(models[14],_testData[27], false);
                        Int16smallint0M.AssertModel(models[15],_testData[28], false);
                        Int16smallint0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 122, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 47, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 71, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[1], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[2], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[22],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[23],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[24],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[25],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[26],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[27],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[22],_testData[30], false);
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 86, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallint0m m
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
FROM gedaqtests.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[22],_testData[30], false);
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
FROM gedaqtests.int16smallint0m m
LEFT JOIN gedaqtests.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallint0M)],
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
            dbType: (System.Data.DbType)(11))]
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 24, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int16smallint0M.AssertModel(models[0],_testData[6], false);
                        Int16smallint0M.AssertModel(models[1],_testData[7], false);
                        Int16smallint0M.AssertModel(models[2],_testData[8], false);
                        Int16smallint0M.AssertModel(models[3],_testData[9], false);
                        Int16smallint0M.AssertModel(models[4],_testData[10], false);
                        Int16smallint0M.AssertModel(models[5],_testData[11], false);
                        Int16smallint0M.AssertModel(models[6],_testData[12], false);
                        Int16smallint0M.AssertModel(models[7],_testData[13], false);
                        Int16smallint0M.AssertModel(models[8],_testData[14], false);
                        Int16smallint0M.AssertModel(models[9],_testData[15], false);
                        Int16smallint0M.AssertModel(models[10],_testData[16], false);
                        Int16smallint0M.AssertModel(models[11],_testData[17], false);
                        Int16smallint0M.AssertModel(models[12],_testData[18], false);
                        Int16smallint0M.AssertModel(models[13],_testData[19], false);
                        Int16smallint0M.AssertModel(models[14],_testData[20], false);
                        Int16smallint0M.AssertModel(models[15],_testData[21], false);
                        Int16smallint0M.AssertModel(models[16],_testData[22], false);
                        Int16smallint0M.AssertModel(models[17],_testData[23], false);
                        Int16smallint0M.AssertModel(models[18],_testData[24], false);
                        Int16smallint0M.AssertModel(models[19],_testData[25], false);
                        Int16smallint0M.AssertModel(models[20],_testData[26], false);
                        Int16smallint0M.AssertModel(models[21],_testData[27], false);
                        Int16smallint0M.AssertModel(models[22],_testData[28], false);
                        Int16smallint0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int16smallint0M.AssertModel(models[0],_testData[14], false);
                        Int16smallint0M.AssertModel(models[1],_testData[15], false);
                        Int16smallint0M.AssertModel(models[2],_testData[16], false);
                        Int16smallint0M.AssertModel(models[3],_testData[17], false);
                        Int16smallint0M.AssertModel(models[4],_testData[18], false);
                        Int16smallint0M.AssertModel(models[5],_testData[19], false);
                        Int16smallint0M.AssertModel(models[6],_testData[20], false);
                        Int16smallint0M.AssertModel(models[7],_testData[21], false);
                        Int16smallint0M.AssertModel(models[8],_testData[22], false);
                        Int16smallint0M.AssertModel(models[9],_testData[23], false);
                        Int16smallint0M.AssertModel(models[10],_testData[24], false);
                        Int16smallint0M.AssertModel(models[11],_testData[25], false);
                        Int16smallint0M.AssertModel(models[12],_testData[26], false);
                        Int16smallint0M.AssertModel(models[13],_testData[27], false);
                        Int16smallint0M.AssertModel(models[14],_testData[28], false);
                        Int16smallint0M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 112, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int16smallint0M.AssertModel(models[0],_testData[25], false);
                        Int16smallint0M.AssertModel(models[1],_testData[26], false);
                        Int16smallint0M.AssertModel(models[2],_testData[27], false);
                        Int16smallint0M.AssertModel(models[3],_testData[28], false);
                        Int16smallint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int16smallint0M.AssertModel(models[0],_testData[20], false);
                        Int16smallint0M.AssertModel(models[1],_testData[21], false);
                        Int16smallint0M.AssertModel(models[2],_testData[22], false);
                        Int16smallint0M.AssertModel(models[3],_testData[23], false);
                        Int16smallint0M.AssertModel(models[4],_testData[24], false);
                        Int16smallint0M.AssertModel(models[5],_testData[25], false);
                        Int16smallint0M.AssertModel(models[6],_testData[26], false);
                        Int16smallint0M.AssertModel(models[7],_testData[27], false);
                        Int16smallint0M.AssertModel(models[8],_testData[28], false);
                        Int16smallint0M.AssertModel(models[9],_testData[29], false);
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
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int16smallint0M.AssertModel(models[0],_testData[1], false);Int16smallint0M.AssertModel(models[1],_testData[2], false);Int16smallint0M.AssertModel(models[2],_testData[3], false);Int16smallint0M.AssertModel(models[3],_testData[4], false);Int16smallint0M.AssertModel(models[4],_testData[5], false);Int16smallint0M.AssertModel(models[5],_testData[6], false);Int16smallint0M.AssertModel(models[6],_testData[7], false);Int16smallint0M.AssertModel(models[7],_testData[8], false);Int16smallint0M.AssertModel(models[8],_testData[9], false);Int16smallint0M.AssertModel(models[9],_testData[10], false);Int16smallint0M.AssertModel(models[10],_testData[11], false);Int16smallint0M.AssertModel(models[11],_testData[12], false);Int16smallint0M.AssertModel(models[12],_testData[13], false);Int16smallint0M.AssertModel(models[13],_testData[14], false);Int16smallint0M.AssertModel(models[14],_testData[15], false);Int16smallint0M.AssertModel(models[15],_testData[16], false);Int16smallint0M.AssertModel(models[16],_testData[17], false);Int16smallint0M.AssertModel(models[17],_testData[18], false);Int16smallint0M.AssertModel(models[18],_testData[19], false);Int16smallint0M.AssertModel(models[19],_testData[20], false);Int16smallint0M.AssertModel(models[20],_testData[21], false);Int16smallint0M.AssertModel(models[21],_testData[22], false);Int16smallint0M.AssertModel(models[22],_testData[23], false);Int16smallint0M.AssertModel(models[23],_testData[24], false);Int16smallint0M.AssertModel(models[24],_testData[25], false);Int16smallint0M.AssertModel(models[25],_testData[26], false);Int16smallint0M.AssertModel(models[26],_testData[27], false);Int16smallint0M.AssertModel(models[27],_testData[28], false);Int16smallint0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Int16smallint0M.AssertModel(models[0],_testData[22], false);Int16smallint0M.AssertModel(models[1],_testData[23], false);Int16smallint0M.AssertModel(models[2],_testData[24], false);Int16smallint0M.AssertModel(models[3],_testData[25], false);Int16smallint0M.AssertModel(models[4],_testData[26], false);Int16smallint0M.AssertModel(models[5],_testData[27], false);Int16smallint0M.AssertModel(models[6],_testData[28], false);Int16smallint0M.AssertModel(models[7],_testData[29], false);
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
FROM gedaqtests.int16smallint0m m
LEFT JOIN gedaqtests.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20646)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((31965)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1046)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19130)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15243)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19458)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1488)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22492)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((23855)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((18158)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((11773)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7111)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4985)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19138)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((17370)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17386)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5650)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26980)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8704)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25333)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17760)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((1093)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2223)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22475)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15654)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26132)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3490)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17586)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9283)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((29033)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8381)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((23610)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11015)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5625)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((23632)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26824)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30467)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1797)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19070)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((23330)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12676)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15985)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17285)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((6038)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((31475)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32747)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7498)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15404)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19174)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((9285)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6307)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21955)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21515)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14764)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23976)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1398)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6618)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3476)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10277)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12567)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19320)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17663)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17278)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((7869)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19443)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2294)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((23810)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7452)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25059)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((19581)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12320)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20646)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((31965)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1046)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19130)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15243)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19458)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1488)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22492)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((23855)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((18158)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((11773)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7111)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4985)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19138)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((17370)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17386)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5650)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26980)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8704)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25333)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17760)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((1093)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2223)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22475)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15654)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26132)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3490)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17586)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9283)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((29033)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8381)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((23610)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11015)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5625)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((23632)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26824)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30467)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1797)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19070)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((23330)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12676)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15985)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17285)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((6038)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((31475)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32747)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7498)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15404)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19174)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((9285)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6307)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21955)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21515)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14764)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23976)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1398)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6618)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3476)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10277)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12567)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19320)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17663)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17278)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((7869)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19443)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2294)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((23810)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7452)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25059)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((19581)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12320)));

            }
        }

#endregion

    }
}


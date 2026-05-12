

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

        private readonly Int16smallintE0M[] _testData = new Int16smallintE0M[]
        {
            new Int16smallintE0M
{
    Id = 6,
    Value = 13143,
    ModelInner = null,
    NullableValue = 29952,
},
            new Int16smallintE0M
{
    Id = 13,
    Value = 22820,
    ModelInner = new Int16smallintE0MI
{
    Id = 4,
    Value = 16533,
    NullableValue = 10764,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 17,
    Value = 15632,
    ModelInner = null,
    NullableValue = 9601,
},
            new Int16smallintE0M
{
    Id = 24,
    Value = 12714,
    ModelInner = new Int16smallintE0MI
{
    Id = 13,
    Value = 27858,
    NullableValue = 15178,
},
    NullableValue = 485,
},
            new Int16smallintE0M
{
    Id = 30,
    Value = 9552,
    ModelInner = null,
    NullableValue = 21309,
},
            new Int16smallintE0M
{
    Id = 38,
    Value = 15059,
    ModelInner = new Int16smallintE0MI
{
    Id = 20,
    Value = 17612,
    NullableValue = 22782,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 39,
    Value = 22559,
    ModelInner = null,
    NullableValue = 3319,
},
            new Int16smallintE0M
{
    Id = 46,
    Value = 5741,
    ModelInner = new Int16smallintE0MI
{
    Id = 21,
    Value = 32575,
    NullableValue = 26792,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 54,
    Value = 24609,
    ModelInner = null,
    NullableValue = 19857,
},
            new Int16smallintE0M
{
    Id = 61,
    Value = 22514,
    ModelInner = new Int16smallintE0MI
{
    Id = 25,
    Value = 29091,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 69,
    Value = 5269,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 76,
    Value = 15214,
    ModelInner = new Int16smallintE0MI
{
    Id = 32,
    Value = 13647,
    NullableValue = null,
},
    NullableValue = 14056,
},
            new Int16smallintE0M
{
    Id = 84,
    Value = 17261,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 87,
    Value = 3526,
    ModelInner = new Int16smallintE0MI
{
    Id = 34,
    Value = 9133,
    NullableValue = 12922,
},
    NullableValue = 1765,
},
            new Int16smallintE0M
{
    Id = 90,
    Value = 6801,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 94,
    Value = 30084,
    ModelInner = new Int16smallintE0MI
{
    Id = 42,
    Value = 11735,
    NullableValue = null,
},
    NullableValue = 29393,
},
            new Int16smallintE0M
{
    Id = 101,
    Value = 20485,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 109,
    Value = 14601,
    ModelInner = new Int16smallintE0MI
{
    Id = 48,
    Value = 18997,
    NullableValue = 22251,
},
    NullableValue = 18853,
},
            new Int16smallintE0M
{
    Id = 116,
    Value = 12104,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 122,
    Value = 7171,
    ModelInner = new Int16smallintE0MI
{
    Id = 50,
    Value = 24947,
    NullableValue = 31639,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 127,
    Value = 9312,
    ModelInner = null,
    NullableValue = 2340,
},
            new Int16smallintE0M
{
    Id = 130,
    Value = 2799,
    ModelInner = new Int16smallintE0MI
{
    Id = 55,
    Value = 31950,
    NullableValue = 4012,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 133,
    Value = 24961,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 141,
    Value = 31277,
    ModelInner = new Int16smallintE0MI
{
    Id = 63,
    Value = 11648,
    NullableValue = 8364,
},
    NullableValue = 7462,
},
            new Int16smallintE0M
{
    Id = 143,
    Value = 17783,
    ModelInner = null,
    NullableValue = 30400,
},
            new Int16smallintE0M
{
    Id = 151,
    Value = 13017,
    ModelInner = new Int16smallintE0MI
{
    Id = 67,
    Value = 8499,
    NullableValue = null,
},
    NullableValue = 7786,
},
            new Int16smallintE0M
{
    Id = 154,
    Value = 21938,
    ModelInner = null,
    NullableValue = 4913,
},
            new Int16smallintE0M
{
    Id = 155,
    Value = 32764,
    ModelInner = new Int16smallintE0MI
{
    Id = 68,
    Value = 31813,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 157,
    Value = 15508,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 166,
    Value = 4485,
    ModelInner = new Int16smallintE0MI
{
    Id = 71,
    Value = 31481,
    NullableValue = null,
},
    NullableValue = 5068,
},
            new Int16smallintE0M
{
    Id = 171,
    Value = 11997,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 179,
    Value = 6976,
    ModelInner = new Int16smallintE0MI
{
    Id = 74,
    Value = 7137,
    NullableValue = 12517,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 180,
    Value = 10904,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 183,
    Value = 32448,
    ModelInner = new Int16smallintE0MI
{
    Id = 76,
    Value = 8802,
    NullableValue = 3248,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 191,
    Value = 16419,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16smallinte0mi(
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
INSERT INTO gedaqtests.int16smallinte0mi(
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16smallinte0m(
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
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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
INSERT INTO gedaqtests.int16smallinte0m(
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
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
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
FROM gedaqtests.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 76;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 180;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int16smallintE0M.AssertModel(models[0],_testData[1], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[2], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[3], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[4], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[5], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[6], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[7], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[8], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[9], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[25],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[26],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[27],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[28],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[29],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[30],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[31],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[32],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int16smallintE0M.AssertModel(models[0],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int16smallintE0M.AssertModel(models[0],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 180, query1, 180, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 180, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 87, 171))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int16smallintE0M.AssertModel(models[0],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 109, 69))
                {
                    if(++resultIndex == 1)
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 180);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                Int16smallintE0M.AssertModel(models[0],_testData[33], false);
                Int16smallintE0M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13143)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29952)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22820)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((16533)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((10764)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15632)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((9601)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12714)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27858)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15178)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((485)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9552)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21309)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15059)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17612)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22782)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22559)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3319)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5741)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32575)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26792)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24609)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19857)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22514)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((29091)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5269)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13647)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((14056)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17261)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3526)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9133)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((12922)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1765)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6801)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30084)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11735)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((29393)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20485)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14601)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18997)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22251)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((18853)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12104)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7171)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24947)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31639)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9312)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((2340)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2799)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31950)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((4012)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24961)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31277)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11648)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8364)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7462)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17783)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((30400)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13017)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8499)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((7786)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21938)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4913)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32764)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31813)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15508)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4485)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31481)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((5068)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11997)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6976)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((7137)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((12517)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10904)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8802)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((3248)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16419)));//Value

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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13143)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29952)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22820)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((16533)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((10764)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15632)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((9601)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12714)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27858)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15178)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((485)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9552)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21309)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15059)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17612)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22782)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22559)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3319)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5741)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32575)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26792)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24609)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19857)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22514)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((29091)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5269)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13647)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((14056)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17261)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3526)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9133)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((12922)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1765)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6801)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30084)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11735)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((29393)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20485)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14601)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18997)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22251)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((18853)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12104)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7171)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24947)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31639)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9312)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((2340)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2799)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31950)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((4012)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24961)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31277)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((11648)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8364)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7462)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17783)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((30400)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13017)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8499)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((7786)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21938)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4913)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32764)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31813)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15508)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4485)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31481)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((5068)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11997)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6976)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((7137)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((12517)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10904)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8802)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((3248)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16419)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


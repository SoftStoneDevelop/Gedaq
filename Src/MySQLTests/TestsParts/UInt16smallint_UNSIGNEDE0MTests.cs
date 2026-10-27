

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
    internal partial interface IUInt16SingleTypesmallint_UNSIGNED
    {
    }
    
    internal partial class UInt16SingleTypesmallint_UNSIGNED : IUInt16SingleTypesmallint_UNSIGNED
    {


#region TestData

        private readonly UInt16smallint_UNSIGNEDE0M[] _testData = new UInt16smallint_UNSIGNEDE0M[]
        {
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 2,
    Value = 59585,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 11,
    Value = 43972,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 3,
    Value = 6020,
    NullableValue = null,
},
    NullableValue = 64584,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 17,
    Value = 770,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 23,
    Value = 25123,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 9,
    Value = 1764,
    NullableValue = 65310,
},
    NullableValue = 28259,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 29,
    Value = 37222,
    ModelInner = null,
    NullableValue = 30845,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 33,
    Value = 57265,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 10,
    Value = 3650,
    NullableValue = 53139,
},
    NullableValue = 45637,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 37,
    Value = 63002,
    ModelInner = null,
    NullableValue = 31646,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 41,
    Value = 45605,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 12,
    Value = 33678,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 49,
    Value = 56738,
    ModelInner = null,
    NullableValue = 649,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 50,
    Value = 52175,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 15,
    Value = 45450,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 59,
    Value = 22049,
    ModelInner = null,
    NullableValue = 20420,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 62,
    Value = 53335,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 22,
    Value = 38337,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 71,
    Value = 55879,
    ModelInner = null,
    NullableValue = 686,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 78,
    Value = 9052,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 30,
    Value = 4515,
    NullableValue = 60760,
},
    NullableValue = 35182,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 85,
    Value = 56841,
    ModelInner = null,
    NullableValue = 30644,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 91,
    Value = 41393,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 33,
    Value = 27878,
    NullableValue = 7967,
},
    NullableValue = 54263,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 98,
    Value = 65484,
    ModelInner = null,
    NullableValue = 64160,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 101,
    Value = 12209,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 36,
    Value = 35300,
    NullableValue = null,
},
    NullableValue = 2403,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 108,
    Value = 61612,
    ModelInner = null,
    NullableValue = 3318,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 117,
    Value = 59468,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 40,
    Value = 41371,
    NullableValue = 26002,
},
    NullableValue = 28007,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 120,
    Value = 18683,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 128,
    Value = 43448,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 41,
    Value = 4384,
    NullableValue = null,
},
    NullableValue = 31830,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 134,
    Value = 40632,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 138,
    Value = 17191,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 45,
    Value = 13764,
    NullableValue = 56458,
},
    NullableValue = 59300,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 140,
    Value = 28999,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 145,
    Value = 2377,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 54,
    Value = 35883,
    NullableValue = null,
},
    NullableValue = 39945,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 151,
    Value = 43544,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 155,
    Value = 31234,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 58,
    Value = 9422,
    NullableValue = 61800,
},
    NullableValue = 32968,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 156,
    Value = 53595,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 157,
    Value = 12574,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 59,
    Value = 122,
    NullableValue = 7533,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 164,
    Value = 16288,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 168,
    Value = 22981,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 60,
    Value = 17739,
    NullableValue = 33141,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 174,
    Value = 62583,
    ModelInner = null,
    NullableValue = 7118,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 183,
    Value = 34416,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 69,
    Value = 49244,
    NullableValue = 56278,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 189,
    Value = 27810,
    ModelInner = null,
    NullableValue = 22584,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16smallint_unsignede0mi(
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt16),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(502)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt16?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(502))]
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

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16smallint_unsignede0mi(
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(18)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(18), 
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

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16smallint_unsignede0m(
	id,
    value,
    nullablevalue,
    uint16smallint_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @uint16smallint_unsignede0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(502)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(502),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "uint16smallint_unsignede0mi_id", 
                methodParametrName: "uint16smallint_unsignede0mi_id", 
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

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16smallint_unsignede0m(
	id,
    value,
    nullablevalue,
    uint16smallint_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @uint16smallint_unsignede0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.UInt16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(18)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(18),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "uint16smallint_unsignede0mi_id", 
                methodParametrName: "uint16smallint_unsignede0mi_id", 
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

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M), typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await((IUInt16SingleTypesmallint_UNSIGNED)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                ((IUInt16SingleTypesmallint_UNSIGNED)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
LEFT JOIN gedaqtests.uint16smallint_unsignede0mi mi ON mi.id = m.uint16smallint_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(UInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M), typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await((IUInt16SingleTypesmallint_UNSIGNED)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                ((IUInt16SingleTypesmallint_UNSIGNED)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
LEFT JOIN gedaqtests.uint16smallint_unsignede0mi mi ON mi.id = m.uint16smallint_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(UInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M), typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 50;
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[1], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[30],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[31],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[32],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
LEFT JOIN gedaqtests.uint16smallint_unsignede0mi mi ON mi.id = m.uint16smallint_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(UInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[1], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[2], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[3], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[4], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[5], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[6], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[7], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[8], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[9], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[10], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[30],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[31],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[32],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[8], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[9], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[10], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M), typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 156, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 174, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 11, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[30],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[31],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
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
FROM gedaqtests.uint16smallint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt16smallint_UNSIGNEDE0M>();
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 168, query1, 2, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
LEFT JOIN gedaqtests.uint16smallint_unsignede0mi mi ON mi.id = m.uint16smallint_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(UInt16smallint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED)),
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
                var models = await((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[5], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[6], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[7], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[8], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[9], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[10], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt16smallint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 59, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IUInt16SingleTypesmallint_UNSIGNED)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IUInt16SingleTypesmallint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((IUInt16SingleTypesmallint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[4], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[5], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[6], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[7], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[8], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[9], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[10], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[11], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[12], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[13], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[14], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[15], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[16], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[17], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[18], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[19], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[20], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[21], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[22], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[23], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[24], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[25], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[26], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[27], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[28], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[29], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[30], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[31], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[32], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[33], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IUInt16SingleTypesmallint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IUInt16SingleTypesmallint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models =  ((IUInt16SingleTypesmallint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[5], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[6], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[7], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[8], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[9], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[10], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[11], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[12], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[13], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[14], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[15], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[16], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[17], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[18], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[19], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[20], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[21], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[22], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[23], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[24], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[25], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[26], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[27], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[28], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[29], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[30], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[31], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[32], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[33], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[34], false);
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
FROM gedaqtests.uint16smallint_unsignede0m m
LEFT JOIN gedaqtests.uint16smallint_unsignede0mi mi ON mi.id = m.uint16smallint_unsignede0mi_id
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
            asPartInterface: typeof(IUInt16SingleTypesmallint_UNSIGNED))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59585)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43972)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((6020)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((64584)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((770)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((25123)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((1764)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((65310)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((28259)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((37222)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((30845)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((57265)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((3650)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((53139)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((45637)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((63002)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((31646)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((45605)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((33678)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56738)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((649)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((52175)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((45450)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((22049)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((20420)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((53335)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((38337)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((55879)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((686)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9052)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((4515)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((60760)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((35182)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56841)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((30644)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((41393)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((27878)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((7967)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((54263)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((65484)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((64160)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((12209)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((35300)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((2403)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((61612)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((3318)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59468)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((41371)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((26002)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((28007)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((18683)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((4384)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((31830)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((40632)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((17191)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((13764)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((56458)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((59300)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((28999)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((2377)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((35883)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((39945)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43544)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((31234)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((9422)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((61800)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((32968)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((53595)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((12574)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((122)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((7533)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((16288)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((22981)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((17739)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((33141)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62583)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((7118)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((34416)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((49244)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((56278)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((27810)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((22584)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59585)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43972)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((6020)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((64584)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((770)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((25123)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((1764)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((65310)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((28259)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((37222)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((30845)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((57265)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((3650)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((53139)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((45637)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((63002)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((31646)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((45605)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((33678)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56738)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((649)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((52175)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((45450)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((22049)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((20420)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((53335)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((38337)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((55879)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((686)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9052)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((4515)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((60760)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((35182)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56841)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((30644)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((41393)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((27878)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((7967)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((54263)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((65484)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((64160)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((12209)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((35300)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((2403)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((61612)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((3318)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59468)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((41371)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((26002)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((28007)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((18683)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((4384)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((31830)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((40632)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((17191)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((13764)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((56458)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((59300)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((28999)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((2377)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((35883)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((39945)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43544)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((31234)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((9422)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((61800)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((32968)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((53595)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((12574)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((122)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((7533)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((16288)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((22981)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((17739)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((33141)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62583)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((7118)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((34416)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((49244)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((56278)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((27810)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((22584)));

            }
        }

#endregion

    }
}


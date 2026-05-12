

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
    Id = 4,
    Value = 42920,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 12,
    Value = 36388,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 1,
    Value = 21008,
    NullableValue = null,
},
    NullableValue = 13956,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 13,
    Value = 21630,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 16,
    Value = 60214,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 7,
    Value = 57285,
    NullableValue = 45428,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 25,
    Value = 62151,
    ModelInner = null,
    NullableValue = 27728,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 30,
    Value = 3939,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 8,
    Value = 31993,
    NullableValue = null,
},
    NullableValue = 15366,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 35,
    Value = 62229,
    ModelInner = null,
    NullableValue = 56593,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 39,
    Value = 9861,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 13,
    Value = 4463,
    NullableValue = null,
},
    NullableValue = 11909,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 48,
    Value = 16179,
    ModelInner = null,
    NullableValue = 20484,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 57,
    Value = 59798,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 18,
    Value = 7037,
    NullableValue = null,
},
    NullableValue = 62141,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 61,
    Value = 37142,
    ModelInner = null,
    NullableValue = 53525,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 67,
    Value = 58537,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 23,
    Value = 53252,
    NullableValue = null,
},
    NullableValue = 55151,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 72,
    Value = 30992,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 73,
    Value = 28085,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 28,
    Value = 37729,
    NullableValue = 61436,
},
    NullableValue = 1015,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 82,
    Value = 12388,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 91,
    Value = 33819,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 35,
    Value = 2812,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 99,
    Value = 13478,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 103,
    Value = 13933,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 39,
    Value = 6748,
    NullableValue = null,
},
    NullableValue = 3699,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 111,
    Value = 5370,
    ModelInner = null,
    NullableValue = 37777,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 115,
    Value = 61115,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 40,
    Value = 50520,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 122,
    Value = 26944,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 129,
    Value = 41586,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 46,
    Value = 44657,
    NullableValue = null,
},
    NullableValue = 33300,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 137,
    Value = 24146,
    ModelInner = null,
    NullableValue = 15324,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 140,
    Value = 43004,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 54,
    Value = 9649,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 142,
    Value = 11184,
    ModelInner = null,
    NullableValue = 63643,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 148,
    Value = 56818,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 56,
    Value = 64024,
    NullableValue = 17068,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 149,
    Value = 5307,
    ModelInner = null,
    NullableValue = 34797,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 151,
    Value = 24943,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 62,
    Value = 37026,
    NullableValue = 65023,
},
    NullableValue = 38919,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 157,
    Value = 1855,
    ModelInner = null,
    NullableValue = 54362,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 162,
    Value = 45113,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 65,
    Value = 15023,
    NullableValue = null,
},
    NullableValue = 55619,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 169,
    Value = 4659,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 177,
    Value = 64882,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 66,
    Value = 40559,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 178,
    Value = 50210,
    ModelInner = null,
    NullableValue = 3682,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 185,
    Value = 34605,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 75,
    Value = 21342,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 192,
    Value = 53018,
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 149;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[9], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[10], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[34], false);
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
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 162, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[34], false);
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
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[34], false);
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
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 82, query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[34], false);
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
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 4, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[34], false);
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
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 177, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 57, 178))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[10], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 35, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[7], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[8], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[9], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[10], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[11], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[12], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[13], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[14], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[15], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[34], false);
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
                ((IUInt16SingleTypesmallint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((IUInt16SingleTypesmallint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[15], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[16], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[17], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[18], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[19], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[20], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[21], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[22], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[23], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[24], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[25], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[26], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[27], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[28], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[29], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[30], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[31], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[32], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[33], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IUInt16SingleTypesmallint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IUInt16SingleTypesmallint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((IUInt16SingleTypesmallint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[6], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[7], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[8], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[9], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[10], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[11], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[12], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[13], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[14], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[15], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[16], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[17], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[18], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[19], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[20], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[21], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[22], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[23], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[24], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[25], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[26], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[27], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[28], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[29], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[30], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[31], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[32], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[33], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((42920)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((36388)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((21008)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((13956)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((21630)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((60214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((57285)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((45428)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62151)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((27728)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((3939)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((31993)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((15366)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62229)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((56593)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9861)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((4463)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((11909)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((16179)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((20484)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59798)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((7037)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((62141)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((37142)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((53525)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((58537)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((53252)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((55151)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((30992)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((28085)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37729)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((61436)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((1015)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((12388)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((33819)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((2812)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((13478)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((13933)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((6748)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((3699)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((5370)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((37777)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((61115)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((50520)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((26944)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((41586)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((44657)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((33300)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((24146)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((15324)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43004)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((9649)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((11184)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((63643)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56818)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((64024)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((17068)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((5307)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((34797)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((24943)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37026)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((65023)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((38919)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((1855)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((54362)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((45113)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((15023)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((55619)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((4659)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((64882)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((40559)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((50210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((3682)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((34605)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((21342)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((53018)));//Value

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
                var models =  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((42920)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((36388)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((21008)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((13956)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((21630)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((60214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((57285)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((45428)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62151)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((27728)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((3939)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((31993)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((15366)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62229)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((56593)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9861)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((4463)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((11909)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((16179)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((20484)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59798)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((7037)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((62141)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((37142)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((53525)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((58537)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((53252)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((55151)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((30992)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((28085)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37729)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((61436)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((1015)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((12388)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((33819)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((2812)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((13478)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((13933)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((6748)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((3699)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((5370)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((37777)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((61115)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((50520)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((26944)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((41586)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((44657)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((33300)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((24146)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((15324)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((43004)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((9649)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((11184)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((63643)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56818)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((64024)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((17068)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((5307)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((34797)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((24943)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37026)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((65023)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((38919)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((1855)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((54362)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((45113)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((15023)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((55619)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((4659)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((64882)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((40559)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((50210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((3682)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((34605)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((21342)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((53018)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


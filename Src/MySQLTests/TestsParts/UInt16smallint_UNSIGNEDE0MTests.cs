

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
    Value = 27088,
    ModelInner = null,
    NullableValue = 6351,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 9,
    Value = 60329,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 5,
    Value = 36789,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 12,
    Value = 59483,
    ModelInner = null,
    NullableValue = 5634,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 18,
    Value = 34050,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 12,
    Value = 6546,
    NullableValue = 7024,
},
    NullableValue = 12685,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 25,
    Value = 62192,
    ModelInner = null,
    NullableValue = 53686,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 31,
    Value = 55379,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 17,
    Value = 54962,
    NullableValue = 58640,
},
    NullableValue = 18380,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 39,
    Value = 56737,
    ModelInner = null,
    NullableValue = 47291,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 44,
    Value = 49047,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 19,
    Value = 58017,
    NullableValue = 28289,
},
    NullableValue = 36648,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 46,
    Value = 44422,
    ModelInner = null,
    NullableValue = 16770,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 55,
    Value = 10888,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 20,
    Value = 3684,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 64,
    Value = 59306,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 72,
    Value = 9126,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 24,
    Value = 20652,
    NullableValue = 49027,
},
    NullableValue = 4304,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 79,
    Value = 35514,
    ModelInner = null,
    NullableValue = 26890,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 82,
    Value = 827,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 28,
    Value = 53888,
    NullableValue = 5558,
},
    NullableValue = 42173,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 90,
    Value = 953,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 95,
    Value = 20761,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 29,
    Value = 11324,
    NullableValue = 10547,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 96,
    Value = 3101,
    ModelInner = null,
    NullableValue = 14052,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 100,
    Value = 26816,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 36,
    Value = 37119,
    NullableValue = null,
},
    NullableValue = 31734,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 107,
    Value = 17622,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 112,
    Value = 18431,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 45,
    Value = 12084,
    NullableValue = 38123,
},
    NullableValue = 9833,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 117,
    Value = 6526,
    ModelInner = null,
    NullableValue = 9495,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 118,
    Value = 57292,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 48,
    Value = 42943,
    NullableValue = 25327,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 122,
    Value = 7708,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 125,
    Value = 14036,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 49,
    Value = 38239,
    NullableValue = null,
},
    NullableValue = 24091,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 131,
    Value = 42745,
    ModelInner = null,
    NullableValue = 30704,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 139,
    Value = 36331,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 54,
    Value = 35993,
    NullableValue = 8165,
},
    NullableValue = 10942,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 148,
    Value = 9416,
    ModelInner = null,
    NullableValue = 21003,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 155,
    Value = 37162,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 55,
    Value = 37576,
    NullableValue = null,
},
    NullableValue = 45755,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 158,
    Value = 47936,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 167,
    Value = 9369,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 60,
    Value = 32776,
    NullableValue = 23815,
},
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 174,
    Value = 11054,
    ModelInner = null,
    NullableValue = null,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 176,
    Value = 45771,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 67,
    Value = 37037,
    NullableValue = null,
},
    NullableValue = 45933,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 182,
    Value = 2325,
    ModelInner = null,
    NullableValue = 65423,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 187,
    Value = 30525,
    ModelInner = new UInt16smallint_UNSIGNEDE0MI
{
    Id = 76,
    Value = 26189,
    NullableValue = 30802,
},
    NullableValue = 56498,
},
            new UInt16smallint_UNSIGNEDE0M
{
    Id = 191,
    Value = 31686,
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
                parametr1.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[29],_testData[34], false);
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
                parametr1.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[27],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 25;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[34], false);
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
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 125, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[34], false);
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
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 118, query1, 174, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[34], false);
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
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 31, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[34], false);
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
                await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 72, query2))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[34], false);
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
                 ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 46, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatUInt16smallint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 131))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[34], false);
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
                foreach(var batchResult in  ((IUInt16SingleTypesmallint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 90, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[16], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[17], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[18], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[19], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[20], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[21], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[22], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[23], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[24], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[25], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[26], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[27], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[28], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[29], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[30], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[31], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[32], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[33], false);
                        UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[34], false);
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
                ((IUInt16SingleTypesmallint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((IUInt16SingleTypesmallint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                UInt16smallint_UNSIGNEDE0M.AssertModel(models[0],_testData[2], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[1],_testData[3], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[2],_testData[4], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[3],_testData[5], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[4],_testData[6], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[5],_testData[7], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[6],_testData[8], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[7],_testData[9], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[8],_testData[10], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[9],_testData[11], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[10],_testData[12], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[11],_testData[13], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[12],_testData[14], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[13],_testData[15], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[14],_testData[16], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[15],_testData[17], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[16],_testData[18], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[17],_testData[19], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[18],_testData[20], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[19],_testData[21], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[20],_testData[22], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[21],_testData[23], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[22],_testData[24], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[23],_testData[25], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[24],_testData[26], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[25],_testData[27], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[26],_testData[28], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[27],_testData[29], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[28],_testData[30], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[29],_testData[31], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[30],_testData[32], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[31],_testData[33], false);
                UInt16smallint_UNSIGNEDE0M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IUInt16SingleTypesmallint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IUInt16SingleTypesmallint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((IUInt16SingleTypesmallint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.UInt16)model[1], Is.EqualTo((27088)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((6351)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((60329)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((36789)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59483)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((5634)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((34050)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((6546)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((7024)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((12685)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62192)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((53686)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((55379)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((54962)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((58640)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((18380)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56737)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((47291)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((49047)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((58017)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((28289)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((36648)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((44422)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((16770)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((10888)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((3684)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59306)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9126)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((20652)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((49027)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((4304)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((35514)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((26890)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((827)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((53888)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((5558)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((42173)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((953)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((20761)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((11324)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((10547)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((3101)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((14052)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((26816)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37119)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((31734)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((17622)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((18431)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((12084)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((38123)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((9833)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((6526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((9495)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((57292)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((42943)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((25327)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((7708)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((14036)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((38239)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((24091)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((42745)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((30704)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((36331)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((35993)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((8165)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((10942)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9416)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((21003)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((37162)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37576)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((45755)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((47936)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((32776)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((23815)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((11054)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((45771)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37037)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((45933)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((2325)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((65423)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((30525)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((26189)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((30802)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((56498)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((31686)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((27088)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((6351)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((60329)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((36789)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59483)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((5634)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((34050)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((6546)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((7024)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((12685)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((62192)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((53686)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((55379)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((54962)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((58640)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((18380)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((56737)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((47291)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((49047)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((58017)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((28289)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((36648)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((44422)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((16770)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((10888)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((3684)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((59306)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9126)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((20652)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((49027)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((4304)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((35514)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((26890)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((827)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((53888)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((5558)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((42173)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((953)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((20761)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((11324)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((10547)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((3101)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((14052)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((26816)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37119)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((31734)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((17622)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((18431)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((12084)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((38123)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((9833)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((6526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((9495)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((57292)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((42943)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((25327)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((7708)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((14036)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((38239)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((24091)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((42745)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((30704)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((36331)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((35993)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((8165)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((10942)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9416)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((21003)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((37162)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37576)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((45755)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((47936)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((9369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((32776)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((23815)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((11054)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((45771)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((37037)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt16?)model[5], Is.EqualTo((45933)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((2325)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((65423)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((30525)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.UInt16)model[3], Is.EqualTo((26189)));//InnerModel.Value

                Assert.That((System.UInt16?)model[4], Is.EqualTo((30802)));//InnerModel.NullableValue

                Assert.That((System.UInt16?)model[5], Is.EqualTo((56498)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.UInt16)model[1], Is.EqualTo((31686)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


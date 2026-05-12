

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
    internal partial interface IUInt32SingleTypeint_UNSIGNED
    {
    }
    
    internal partial class UInt32SingleTypeint_UNSIGNED : IUInt32SingleTypeint_UNSIGNED
    {


#region TestData

        private readonly UInt32int_UNSIGNEDE0M[] _testData = new UInt32int_UNSIGNEDE0M[]
        {
            new UInt32int_UNSIGNEDE0M
{
    Id = 7,
    Value = 2015747477,
    ModelInner = null,
    NullableValue = 4114142413,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 14,
    Value = 244668702,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 4,
    Value = 3252824654,
    NullableValue = null,
},
    NullableValue = 2122453742,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 20,
    Value = 3731792081,
    ModelInner = null,
    NullableValue = 2664352527,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 28,
    Value = 3586406589,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 13,
    Value = 1609732265,
    NullableValue = null,
},
    NullableValue = 821777542,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 29,
    Value = 2076257330,
    ModelInner = null,
    NullableValue = 1724776794,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 32,
    Value = 3932447913,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 14,
    Value = 3274904372,
    NullableValue = 2711128573,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 34,
    Value = 501919019,
    ModelInner = null,
    NullableValue = 1837683134,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 42,
    Value = 2289421639,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 17,
    Value = 2554855997,
    NullableValue = 958328624,
},
    NullableValue = 3624525778,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 49,
    Value = 2814922899,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 52,
    Value = 1366741078,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 25,
    Value = 3139678390,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 55,
    Value = 3084284150,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 62,
    Value = 2935927672,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 28,
    Value = 3931189760,
    NullableValue = 286412563,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 68,
    Value = 2857805907,
    ModelInner = null,
    NullableValue = 4231464846,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 76,
    Value = 4221820717,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 35,
    Value = 2637138512,
    NullableValue = null,
},
    NullableValue = 3353117439,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 79,
    Value = 2277266144,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 81,
    Value = 2738508829,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 38,
    Value = 783244152,
    NullableValue = 2085629981,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 84,
    Value = 1964520240,
    ModelInner = null,
    NullableValue = 2792654233,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 88,
    Value = 719654830,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 40,
    Value = 355582093,
    NullableValue = 2942582610,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 93,
    Value = 1127374521,
    ModelInner = null,
    NullableValue = 4238700122,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 101,
    Value = 177643329,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 42,
    Value = 2655616215,
    NullableValue = null,
},
    NullableValue = 2908080274,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 102,
    Value = 1260015912,
    ModelInner = null,
    NullableValue = 3411755900,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 105,
    Value = 2264477166,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 49,
    Value = 3889506836,
    NullableValue = 3864021189,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 111,
    Value = 3680082706,
    ModelInner = null,
    NullableValue = 513339886,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 118,
    Value = 345443683,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 57,
    Value = 822627048,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 122,
    Value = 1845129527,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 131,
    Value = 2097238626,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 62,
    Value = 846751782,
    NullableValue = 2981906636,
},
    NullableValue = 1228785203,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 135,
    Value = 974682063,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 138,
    Value = 3025932401,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 68,
    Value = 3688016069,
    NullableValue = null,
},
    NullableValue = 1486200956,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 140,
    Value = 2901095864,
    ModelInner = null,
    NullableValue = 3600977201,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 146,
    Value = 2328782079,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 77,
    Value = 2588299520,
    NullableValue = 2060265940,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 152,
    Value = 3632940217,
    ModelInner = null,
    NullableValue = 2411199523,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 155,
    Value = 4242541305,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 81,
    Value = 1813229350,
    NullableValue = null,
},
    NullableValue = 1460225920,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 156,
    Value = 159269220,
    ModelInner = null,
    NullableValue = 1132359272,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 157,
    Value = 1484028327,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 84,
    Value = 4240640761,
    NullableValue = 413633308,
},
    NullableValue = 124301829,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 166,
    Value = 274361237,
    ModelInner = null,
    NullableValue = 1694179398,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32int_unsignede0mi(
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt32),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(503)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(503))]
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

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32int_unsignede0mi(
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(19)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(19), 
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

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32int_unsignede0m(
	id,
    value,
    nullablevalue,
    uint32int_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @uint32int_unsignede0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(503)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(503),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "uint32int_unsignede0mi_id", 
                methodParametrName: "uint32int_unsignede0mi_id", 
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

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32int_unsignede0m(
	id,
    value,
    nullablevalue,
    uint32int_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @uint32int_unsignede0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.UInt32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(19)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(19),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "uint32int_unsignede0mi_id", 
                methodParametrName: "uint32int_unsignede0mi_id", 
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

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M), typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await((IUInt32SingleTypeint_UNSIGNED)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                ((IUInt32SingleTypeint_UNSIGNED)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
LEFT JOIN gedaqtests.uint32int_unsignede0mi mi ON mi.id = m.uint32int_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(UInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M), typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await((IUInt32SingleTypeint_UNSIGNED)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                ((IUInt32SingleTypeint_UNSIGNED)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
LEFT JOIN gedaqtests.uint32int_unsignede0mi mi ON mi.id = m.uint32int_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(UInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M), typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
LEFT JOIN gedaqtests.uint32int_unsignede0mi mi ON mi.id = m.uint32int_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(UInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[6], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[7], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[8], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[9], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[10], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[11], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[12], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[9], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[10], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[11], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[12], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[11], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[12], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M), typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 152, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 156, query1, 49, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
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
FROM gedaqtests.uint32int_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt32int_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt32int_UNSIGNEDE0M>();
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 155, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
LEFT JOIN gedaqtests.uint32int_unsignede0mi mi ON mi.id = m.uint32int_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(UInt32int_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED)),
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
                var models = await((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 156))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[5], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[6], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[7], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[8], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[9], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[10], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[11], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[12], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt32int_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 146, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((IUInt32SingleTypeint_UNSIGNED)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IUInt32SingleTypeint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((IUInt32SingleTypeint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[17], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[18], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[19], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[20], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[21], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[22], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[23], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[24], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[25], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[26], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[27], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[28], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[29], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[30], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[31], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[32], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[33], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IUInt32SingleTypeint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IUInt32SingleTypeint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((IUInt32SingleTypeint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[3], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[4], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[5], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[6], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[7], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[8], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[9], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[10], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[11], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[12], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[13], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[14], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[15], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[16], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[17], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[18], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[19], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[20], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[21], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[22], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[23], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[24], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[25], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[26], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[27], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[28], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[29], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[30], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[31], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[29],_testData[32], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[30],_testData[33], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[31],_testData[34], false);
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
FROM gedaqtests.uint32int_unsignede0m m
LEFT JOIN gedaqtests.uint32int_unsignede0mi mi ON mi.id = m.uint32int_unsignede0mi_id
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
            asPartInterface: typeof(IUInt32SingleTypeint_UNSIGNED))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2015747477)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4114142413)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((244668702)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3252824654)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2122453742)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3731792081)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2664352527)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3586406589)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1609732265)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((821777542)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2076257330)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1724776794)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3932447913)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3274904372)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2711128573)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((501919019)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1837683134)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2289421639)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2554855997)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((958328624)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3624525778)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2814922899)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1366741078)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3139678390)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3084284150)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2935927672)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3931189760)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((286412563)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2857805907)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4231464846)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((4221820717)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2637138512)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3353117439)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2277266144)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2738508829)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((783244152)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2085629981)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1964520240)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2792654233)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((719654830)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((355582093)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2942582610)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1127374521)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4238700122)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((177643329)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2655616215)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2908080274)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1260015912)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3411755900)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2264477166)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3889506836)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((3864021189)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3680082706)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((513339886)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((345443683)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((822627048)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1845129527)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2097238626)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((846751782)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2981906636)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1228785203)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((974682063)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3025932401)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3688016069)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1486200956)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2901095864)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3600977201)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2328782079)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2588299520)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2060265940)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3632940217)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2411199523)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((4242541305)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1813229350)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1460225920)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((159269220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1132359272)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1484028327)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4240640761)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((413633308)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((124301829)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((274361237)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1694179398)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2015747477)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4114142413)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((244668702)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3252824654)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2122453742)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3731792081)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2664352527)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3586406589)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1609732265)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((821777542)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2076257330)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1724776794)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3932447913)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3274904372)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2711128573)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((501919019)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1837683134)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2289421639)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2554855997)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((958328624)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3624525778)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2814922899)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1366741078)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3139678390)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3084284150)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2935927672)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3931189760)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((286412563)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2857805907)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4231464846)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((4221820717)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2637138512)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3353117439)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2277266144)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2738508829)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((783244152)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2085629981)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1964520240)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2792654233)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((719654830)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((355582093)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2942582610)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1127374521)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4238700122)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((177643329)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2655616215)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2908080274)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1260015912)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3411755900)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2264477166)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3889506836)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((3864021189)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3680082706)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((513339886)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((345443683)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((822627048)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1845129527)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2097238626)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((846751782)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2981906636)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1228785203)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((974682063)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3025932401)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3688016069)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1486200956)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2901095864)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3600977201)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2328782079)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2588299520)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((2060265940)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3632940217)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2411199523)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((4242541305)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1813229350)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1460225920)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((159269220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1132359272)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1484028327)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4240640761)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((413633308)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((124301829)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((274361237)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1694179398)));

            }
        }

#endregion

    }
}


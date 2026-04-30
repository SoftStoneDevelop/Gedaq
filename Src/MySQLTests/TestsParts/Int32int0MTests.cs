

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
    internal partial interface IInt32SingleTypeint
    {
    }
    
    internal partial class Int32SingleTypeint : IInt32SingleTypeint
    {


#region TestData

        private readonly Int32int0M[] _testData = new Int32int0M[]
        {
            new Int32int0M
{
    Id = 1,
    Value = 1644445343,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 8,
    Value = 1864728598,
    ModelInner = new Int32int0MI
{
    Id = 9,
    Value = 616445561,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 10,
    Value = 178476368,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 11,
    Value = 1260778144,
    ModelInner = new Int32int0MI
{
    Id = 14,
    Value = 169983134,
    NullableValue = 921769123,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 15,
    Value = 80885577,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 23,
    Value = 507661212,
    ModelInner = new Int32int0MI
{
    Id = 19,
    Value = 570731016,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 32,
    Value = 963975661,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 39,
    Value = 1629060364,
    ModelInner = new Int32int0MI
{
    Id = 27,
    Value = 863538025,
    NullableValue = null,
},
    NullableValue = 12888778,
},
            new Int32int0M
{
    Id = 42,
    Value = 1469970415,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 45,
    Value = 955107023,
    ModelInner = new Int32int0MI
{
    Id = 33,
    Value = 920795331,
    NullableValue = 1386054358,
},
    NullableValue = 125423294,
},
            new Int32int0M
{
    Id = 47,
    Value = 94363345,
    ModelInner = null,
    NullableValue = 43911496,
},
            new Int32int0M
{
    Id = 54,
    Value = 546628454,
    ModelInner = new Int32int0MI
{
    Id = 42,
    Value = 1514786524,
    NullableValue = null,
},
    NullableValue = 1614185691,
},
            new Int32int0M
{
    Id = 63,
    Value = 1453900438,
    ModelInner = null,
    NullableValue = 657014260,
},
            new Int32int0M
{
    Id = 65,
    Value = 49642205,
    ModelInner = new Int32int0MI
{
    Id = 50,
    Value = 266126214,
    NullableValue = 674151335,
},
    NullableValue = 1834469366,
},
            new Int32int0M
{
    Id = 69,
    Value = 1046424526,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 73,
    Value = 1902235846,
    ModelInner = new Int32int0MI
{
    Id = 55,
    Value = 942605982,
    NullableValue = 553367535,
},
    NullableValue = 1409556532,
},
            new Int32int0M
{
    Id = 82,
    Value = 835267492,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 84,
    Value = 670082574,
    ModelInner = new Int32int0MI
{
    Id = 59,
    Value = 1375174465,
    NullableValue = null,
},
    NullableValue = 706311127,
},
            new Int32int0M
{
    Id = 88,
    Value = 998270392,
    ModelInner = null,
    NullableValue = 1486669341,
},
            new Int32int0M
{
    Id = 92,
    Value = 1847721863,
    ModelInner = new Int32int0MI
{
    Id = 61,
    Value = 864777903,
    NullableValue = null,
},
    NullableValue = 1986397381,
},
            new Int32int0M
{
    Id = 98,
    Value = 537258933,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 99,
    Value = 22604294,
    ModelInner = new Int32int0MI
{
    Id = 69,
    Value = 1875802235,
    NullableValue = 1410833015,
},
    NullableValue = 891296002,
},
            new Int32int0M
{
    Id = 103,
    Value = 1714907813,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 108,
    Value = 1526255129,
    ModelInner = new Int32int0MI
{
    Id = 75,
    Value = 257937113,
    NullableValue = 1524451229,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 112,
    Value = 1657036142,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 114,
    Value = 1291776001,
    ModelInner = new Int32int0MI
{
    Id = 77,
    Value = 1745795857,
    NullableValue = 563559070,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 120,
    Value = 1759764585,
    ModelInner = null,
    NullableValue = 703611396,
},
            new Int32int0M
{
    Id = 128,
    Value = 2146393812,
    ModelInner = new Int32int0MI
{
    Id = 80,
    Value = 914002713,
    NullableValue = 1252096881,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 129,
    Value = 107152715,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 134,
    Value = 1835529537,
    ModelInner = new Int32int0MI
{
    Id = 87,
    Value = 176035228,
    NullableValue = null,
},
    NullableValue = 1003392079,
},
            new Int32int0M
{
    Id = 136,
    Value = 122874061,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 142,
    Value = 664262555,
    ModelInner = new Int32int0MI
{
    Id = 92,
    Value = 613086219,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 151,
    Value = 455160602,
    ModelInner = null,
    NullableValue = 536550490,
},
            new Int32int0M
{
    Id = 157,
    Value = 1348252382,
    ModelInner = new Int32int0MI
{
    Id = 97,
    Value = 1405318658,
    NullableValue = 1708836973,
},
    NullableValue = 624214968,
},
            new Int32int0M
{
    Id = 164,
    Value = 2070977781,
    ModelInner = null,
    NullableValue = 225267260,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(3))]
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11), 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32SingleTypeint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32SingleTypeint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 11;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32int0M.AssertModel(models[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32int0M.AssertModel(models[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32int0M.AssertModel(models[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32int0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32int0M.AssertModel(models[0],_testData[27], false);
                        Int32int0M.AssertModel(models[1],_testData[28], false);
                        Int32int0M.AssertModel(models[2],_testData[29], false);
                        Int32int0M.AssertModel(models[3],_testData[30], false);
                        Int32int0M.AssertModel(models[4],_testData[31], false);
                        Int32int0M.AssertModel(models[5],_testData[32], false);
                        Int32int0M.AssertModel(models[6],_testData[33], false);
                        Int32int0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32int0M.AssertModel(models[0],_testData[25], false);
                        Int32int0M.AssertModel(models[1],_testData[26], false);
                        Int32int0M.AssertModel(models[2],_testData[27], false);
                        Int32int0M.AssertModel(models[3],_testData[28], false);
                        Int32int0M.AssertModel(models[4],_testData[29], false);
                        Int32int0M.AssertModel(models[5],_testData[30], false);
                        Int32int0M.AssertModel(models[6],_testData[31], false);
                        Int32int0M.AssertModel(models[7],_testData[32], false);
                        Int32int0M.AssertModel(models[8],_testData[33], false);
                        Int32int0M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IInt32SingleTypeint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32int0M.AssertModel(models[0],_testData[23], false);
                        Int32int0M.AssertModel(models[1],_testData[24], false);
                        Int32int0M.AssertModel(models[2],_testData[25], false);
                        Int32int0M.AssertModel(models[3],_testData[26], false);
                        Int32int0M.AssertModel(models[4],_testData[27], false);
                        Int32int0M.AssertModel(models[5],_testData[28], false);
                        Int32int0M.AssertModel(models[6],_testData[29], false);
                        Int32int0M.AssertModel(models[7],_testData[30], false);
                        Int32int0M.AssertModel(models[8],_testData[31], false);
                        Int32int0M.AssertModel(models[9],_testData[32], false);
                        Int32int0M.AssertModel(models[10],_testData[33], false);
                        Int32int0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32int0M.AssertModel(models[0],_testData[7], false);
                        Int32int0M.AssertModel(models[1],_testData[8], false);
                        Int32int0M.AssertModel(models[2],_testData[9], false);
                        Int32int0M.AssertModel(models[3],_testData[10], false);
                        Int32int0M.AssertModel(models[4],_testData[11], false);
                        Int32int0M.AssertModel(models[5],_testData[12], false);
                        Int32int0M.AssertModel(models[6],_testData[13], false);
                        Int32int0M.AssertModel(models[7],_testData[14], false);
                        Int32int0M.AssertModel(models[8],_testData[15], false);
                        Int32int0M.AssertModel(models[9],_testData[16], false);
                        Int32int0M.AssertModel(models[10],_testData[17], false);
                        Int32int0M.AssertModel(models[11],_testData[18], false);
                        Int32int0M.AssertModel(models[12],_testData[19], false);
                        Int32int0M.AssertModel(models[13],_testData[20], false);
                        Int32int0M.AssertModel(models[14],_testData[21], false);
                        Int32int0M.AssertModel(models[15],_testData[22], false);
                        Int32int0M.AssertModel(models[16],_testData[23], false);
                        Int32int0M.AssertModel(models[17],_testData[24], false);
                        Int32int0M.AssertModel(models[18],_testData[25], false);
                        Int32int0M.AssertModel(models[19],_testData[26], false);
                        Int32int0M.AssertModel(models[20],_testData[27], false);
                        Int32int0M.AssertModel(models[21],_testData[28], false);
                        Int32int0M.AssertModel(models[22],_testData[29], false);
                        Int32int0M.AssertModel(models[23],_testData[30], false);
                        Int32int0M.AssertModel(models[24],_testData[31], false);
                        Int32int0M.AssertModel(models[25],_testData[32], false);
                        Int32int0M.AssertModel(models[26],_testData[33], false);
                        Int32int0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 32, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 112, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 23, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32int0M.AssertModel(models[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32int0M.AssertModel(models[0],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32int0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32int0M.AssertModel(models[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 134, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32int0M.AssertModel(models[0],_testData[30], false);
                        Int32int0M.AssertModel(models[1],_testData[31], false);
                        Int32int0M.AssertModel(models[2],_testData[32], false);
                        Int32int0M.AssertModel(models[3],_testData[33], false);
                        Int32int0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32int0M.AssertModel(models[0],_testData[20], false);
                        Int32int0M.AssertModel(models[1],_testData[21], false);
                        Int32int0M.AssertModel(models[2],_testData[22], false);
                        Int32int0M.AssertModel(models[3],_testData[23], false);
                        Int32int0M.AssertModel(models[4],_testData[24], false);
                        Int32int0M.AssertModel(models[5],_testData[25], false);
                        Int32int0M.AssertModel(models[6],_testData[26], false);
                        Int32int0M.AssertModel(models[7],_testData[27], false);
                        Int32int0M.AssertModel(models[8],_testData[28], false);
                        Int32int0M.AssertModel(models[9],_testData[29], false);
                        Int32int0M.AssertModel(models[10],_testData[30], false);
                        Int32int0M.AssertModel(models[11],_testData[31], false);
                        Int32int0M.AssertModel(models[12],_testData[32], false);
                        Int32int0M.AssertModel(models[13],_testData[33], false);
                        Int32int0M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IInt32SingleTypeint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 84, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32int0M.AssertModel(models[0],_testData[18], false);
                        Int32int0M.AssertModel(models[1],_testData[19], false);
                        Int32int0M.AssertModel(models[2],_testData[20], false);
                        Int32int0M.AssertModel(models[3],_testData[21], false);
                        Int32int0M.AssertModel(models[4],_testData[22], false);
                        Int32int0M.AssertModel(models[5],_testData[23], false);
                        Int32int0M.AssertModel(models[6],_testData[24], false);
                        Int32int0M.AssertModel(models[7],_testData[25], false);
                        Int32int0M.AssertModel(models[8],_testData[26], false);
                        Int32int0M.AssertModel(models[9],_testData[27], false);
                        Int32int0M.AssertModel(models[10],_testData[28], false);
                        Int32int0M.AssertModel(models[11],_testData[29], false);
                        Int32int0M.AssertModel(models[12],_testData[30], false);
                        Int32int0M.AssertModel(models[13],_testData[31], false);
                        Int32int0M.AssertModel(models[14],_testData[32], false);
                        Int32int0M.AssertModel(models[15],_testData[33], false);
                        Int32int0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32int0M.AssertModel(models[0],_testData[32], false);
                        Int32int0M.AssertModel(models[1],_testData[33], false);
                        Int32int0M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Int32int0M.AssertModel(models[0],_testData[16], false);Int32int0M.AssertModel(models[1],_testData[17], false);Int32int0M.AssertModel(models[2],_testData[18], false);Int32int0M.AssertModel(models[3],_testData[19], false);Int32int0M.AssertModel(models[4],_testData[20], false);Int32int0M.AssertModel(models[5],_testData[21], false);Int32int0M.AssertModel(models[6],_testData[22], false);Int32int0M.AssertModel(models[7],_testData[23], false);Int32int0M.AssertModel(models[8],_testData[24], false);Int32int0M.AssertModel(models[9],_testData[25], false);Int32int0M.AssertModel(models[10],_testData[26], false);Int32int0M.AssertModel(models[11],_testData[27], false);Int32int0M.AssertModel(models[12],_testData[28], false);Int32int0M.AssertModel(models[13],_testData[29], false);Int32int0M.AssertModel(models[14],_testData[30], false);Int32int0M.AssertModel(models[15],_testData[31], false);Int32int0M.AssertModel(models[16],_testData[32], false);Int32int0M.AssertModel(models[17],_testData[33], false);Int32int0M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int32int0M.AssertModel(models[0],_testData[19], false);Int32int0M.AssertModel(models[1],_testData[20], false);Int32int0M.AssertModel(models[2],_testData[21], false);Int32int0M.AssertModel(models[3],_testData[22], false);Int32int0M.AssertModel(models[4],_testData[23], false);Int32int0M.AssertModel(models[5],_testData[24], false);Int32int0M.AssertModel(models[6],_testData[25], false);Int32int0M.AssertModel(models[7],_testData[26], false);Int32int0M.AssertModel(models[8],_testData[27], false);Int32int0M.AssertModel(models[9],_testData[28], false);Int32int0M.AssertModel(models[10],_testData[29], false);Int32int0M.AssertModel(models[11],_testData[30], false);Int32int0M.AssertModel(models[12],_testData[31], false);Int32int0M.AssertModel(models[13],_testData[32], false);Int32int0M.AssertModel(models[14],_testData[33], false);Int32int0M.AssertModel(models[15],_testData[34], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1644445343)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1864728598)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((616445561)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((178476368)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1260778144)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((169983134)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((921769123)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((80885577)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((507661212)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((570731016)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((963975661)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1629060364)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((863538025)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((12888778)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1469970415)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((955107023)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((920795331)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1386054358)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((125423294)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((94363345)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((43911496)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((546628454)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1514786524)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1614185691)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1453900438)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((657014260)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((49642205)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((266126214)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((674151335)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1834469366)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1046424526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1902235846)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((942605982)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((553367535)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1409556532)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((835267492)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((670082574)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1375174465)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((706311127)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((998270392)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1486669341)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1847721863)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((864777903)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1986397381)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((537258933)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((22604294)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1875802235)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1410833015)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((891296002)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1714907813)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1526255129)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((257937113)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1524451229)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1657036142)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1291776001)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1745795857)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((563559070)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1759764585)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((703611396)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2146393812)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((914002713)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1252096881)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((107152715)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1835529537)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((176035228)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1003392079)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((122874061)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((664262555)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((613086219)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((455160602)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((536550490)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1348252382)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1405318658)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1708836973)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((624214968)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2070977781)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((225267260)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1644445343)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1864728598)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((616445561)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((178476368)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1260778144)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((169983134)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((921769123)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((80885577)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((507661212)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((570731016)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((963975661)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1629060364)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((863538025)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((12888778)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1469970415)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((955107023)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((920795331)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1386054358)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((125423294)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((94363345)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((43911496)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((546628454)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1514786524)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1614185691)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1453900438)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((657014260)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((49642205)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((266126214)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((674151335)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1834469366)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1046424526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1902235846)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((942605982)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((553367535)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1409556532)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((835267492)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((670082574)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1375174465)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((706311127)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((998270392)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1486669341)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1847721863)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((864777903)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1986397381)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((537258933)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((22604294)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1875802235)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1410833015)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((891296002)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1714907813)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1526255129)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((257937113)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1524451229)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1657036142)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1291776001)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1745795857)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((563559070)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1759764585)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((703611396)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2146393812)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((914002713)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1252096881)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((107152715)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1835529537)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((176035228)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1003392079)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((122874061)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((664262555)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((613086219)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((455160602)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((536550490)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1348252382)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1405318658)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1708836973)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((624214968)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2070977781)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((225267260)));

            }
        }

#endregion

    }
}


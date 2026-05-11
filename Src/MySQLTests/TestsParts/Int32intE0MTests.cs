

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

        private readonly Int32intE0M[] _testData = new Int32intE0M[]
        {
            new Int32intE0M
{
    Id = 7,
    Value = 930436088,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 14,
    Value = 2110064483,
    ModelInner = new Int32intE0MI
{
    Id = 6,
    Value = 146081451,
    NullableValue = 1641785265,
},
    NullableValue = 1792945935,
},
            new Int32intE0M
{
    Id = 22,
    Value = 879443713,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 24,
    Value = 1353271238,
    ModelInner = new Int32intE0MI
{
    Id = 15,
    Value = 1626604542,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 30,
    Value = 689187714,
    ModelInner = null,
    NullableValue = 1283548992,
},
            new Int32intE0M
{
    Id = 39,
    Value = 443339339,
    ModelInner = new Int32intE0MI
{
    Id = 19,
    Value = 1838779231,
    NullableValue = 1524387112,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 48,
    Value = 478016694,
    ModelInner = null,
    NullableValue = 478555471,
},
            new Int32intE0M
{
    Id = 51,
    Value = 1676192877,
    ModelInner = new Int32intE0MI
{
    Id = 24,
    Value = 1457151433,
    NullableValue = null,
},
    NullableValue = 209850785,
},
            new Int32intE0M
{
    Id = 54,
    Value = 2030074412,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 57,
    Value = 1321559890,
    ModelInner = new Int32intE0MI
{
    Id = 33,
    Value = 550273030,
    NullableValue = 1359740928,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 60,
    Value = 1223805647,
    ModelInner = null,
    NullableValue = 1133054199,
},
            new Int32intE0M
{
    Id = 62,
    Value = 1273851223,
    ModelInner = new Int32intE0MI
{
    Id = 38,
    Value = 232109039,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 69,
    Value = 178920386,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 75,
    Value = 1367248847,
    ModelInner = new Int32intE0MI
{
    Id = 47,
    Value = 1195812725,
    NullableValue = 1859280925,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 76,
    Value = 2008996010,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 82,
    Value = 199721640,
    ModelInner = new Int32intE0MI
{
    Id = 51,
    Value = 349203096,
    NullableValue = 708075849,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 87,
    Value = 396610071,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 92,
    Value = 137321923,
    ModelInner = new Int32intE0MI
{
    Id = 54,
    Value = 639732877,
    NullableValue = 1217068227,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 93,
    Value = 126449558,
    ModelInner = null,
    NullableValue = 877721059,
},
            new Int32intE0M
{
    Id = 101,
    Value = 472049611,
    ModelInner = new Int32intE0MI
{
    Id = 63,
    Value = 1270214506,
    NullableValue = null,
},
    NullableValue = 2042923382,
},
            new Int32intE0M
{
    Id = 107,
    Value = 1611681843,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 110,
    Value = 1423428480,
    ModelInner = new Int32intE0MI
{
    Id = 70,
    Value = 1203070457,
    NullableValue = 1690830365,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 117,
    Value = 2067924928,
    ModelInner = null,
    NullableValue = 652734164,
},
            new Int32intE0M
{
    Id = 123,
    Value = 1184259467,
    ModelInner = new Int32intE0MI
{
    Id = 78,
    Value = 38813368,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 131,
    Value = 905690560,
    ModelInner = null,
    NullableValue = 19334828,
},
            new Int32intE0M
{
    Id = 135,
    Value = 2088651646,
    ModelInner = new Int32intE0MI
{
    Id = 84,
    Value = 81086657,
    NullableValue = 873201117,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 136,
    Value = 385515667,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 137,
    Value = 1942531070,
    ModelInner = new Int32intE0MI
{
    Id = 91,
    Value = 1316339407,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 142,
    Value = 1088416650,
    ModelInner = null,
    NullableValue = 1108056940,
},
            new Int32intE0M
{
    Id = 147,
    Value = 1299190298,
    ModelInner = new Int32intE0MI
{
    Id = 98,
    Value = 617329054,
    NullableValue = null,
},
    NullableValue = 668817741,
},
            new Int32intE0M
{
    Id = 155,
    Value = 1336241309,
    ModelInner = null,
    NullableValue = 1594827234,
},
            new Int32intE0M
{
    Id = 156,
    Value = 2117443881,
    ModelInner = new Int32intE0MI
{
    Id = 100,
    Value = 892350261,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 158,
    Value = 377231625,
    ModelInner = null,
    NullableValue = 1801240376,
},
            new Int32intE0M
{
    Id = 166,
    Value = 1148984561,
    ModelInner = new Int32intE0MI
{
    Id = 108,
    Value = 2099572954,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 167,
    Value = 466290152,
    ModelInner = null,
    NullableValue = 446407320,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32inte0mi(
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
INSERT INTO gedaqtests.int32inte0mi(
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
INSERT INTO gedaqtests.int32inte0m(
	id,
    value,
    nullablevalue,
    int32inte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32inte0mi_id
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
                parametrName: "int32inte0mi_id", 
                methodParametrName: "int32inte0mi_id", 
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
INSERT INTO gedaqtests.int32inte0m(
	id,
    value,
    nullablevalue,
    int32inte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32inte0mi_id
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
                parametrName: "int32inte0mi_id", 
                methodParametrName: "int32inte0mi_id", 
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
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
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
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
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
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
LEFT JOIN gedaqtests.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32intE0M)],
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
LEFT JOIN gedaqtests.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32intE0M)],
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 30;
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
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
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
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

                        FlatInt32intE0M.AssertModel(models[0],_testData[6], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[7], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[27],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32intE0M.AssertModel(models[0],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
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
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32intE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt32intE0M.AssertModel(models[0],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
LEFT JOIN gedaqtests.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32intE0M)],
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32intE0M.AssertModel(models[0],_testData[33], false);
                        Int32intE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32intE0M.AssertModel(models[0],_testData[30], false);
                        Int32intE0M.AssertModel(models[1],_testData[31], false);
                        Int32intE0M.AssertModel(models[2],_testData[32], false);
                        Int32intE0M.AssertModel(models[3],_testData[33], false);
                        Int32intE0M.AssertModel(models[4],_testData[34], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32intE0M.AssertModel(models[0],_testData[1], false);
                        Int32intE0M.AssertModel(models[1],_testData[2], false);
                        Int32intE0M.AssertModel(models[2],_testData[3], false);
                        Int32intE0M.AssertModel(models[3],_testData[4], false);
                        Int32intE0M.AssertModel(models[4],_testData[5], false);
                        Int32intE0M.AssertModel(models[5],_testData[6], false);
                        Int32intE0M.AssertModel(models[6],_testData[7], false);
                        Int32intE0M.AssertModel(models[7],_testData[8], false);
                        Int32intE0M.AssertModel(models[8],_testData[9], false);
                        Int32intE0M.AssertModel(models[9],_testData[10], false);
                        Int32intE0M.AssertModel(models[10],_testData[11], false);
                        Int32intE0M.AssertModel(models[11],_testData[12], false);
                        Int32intE0M.AssertModel(models[12],_testData[13], false);
                        Int32intE0M.AssertModel(models[13],_testData[14], false);
                        Int32intE0M.AssertModel(models[14],_testData[15], false);
                        Int32intE0M.AssertModel(models[15],_testData[16], false);
                        Int32intE0M.AssertModel(models[16],_testData[17], false);
                        Int32intE0M.AssertModel(models[17],_testData[18], false);
                        Int32intE0M.AssertModel(models[18],_testData[19], false);
                        Int32intE0M.AssertModel(models[19],_testData[20], false);
                        Int32intE0M.AssertModel(models[20],_testData[21], false);
                        Int32intE0M.AssertModel(models[21],_testData[22], false);
                        Int32intE0M.AssertModel(models[22],_testData[23], false);
                        Int32intE0M.AssertModel(models[23],_testData[24], false);
                        Int32intE0M.AssertModel(models[24],_testData[25], false);
                        Int32intE0M.AssertModel(models[25],_testData[26], false);
                        Int32intE0M.AssertModel(models[26],_testData[27], false);
                        Int32intE0M.AssertModel(models[27],_testData[28], false);
                        Int32intE0M.AssertModel(models[28],_testData[29], false);
                        Int32intE0M.AssertModel(models[29],_testData[30], false);
                        Int32intE0M.AssertModel(models[30],_testData[31], false);
                        Int32intE0M.AssertModel(models[31],_testData[32], false);
                        Int32intE0M.AssertModel(models[32],_testData[33], false);
                        Int32intE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int32intE0M.AssertModel(models[0],_testData[10], false);
                        Int32intE0M.AssertModel(models[1],_testData[11], false);
                        Int32intE0M.AssertModel(models[2],_testData[12], false);
                        Int32intE0M.AssertModel(models[3],_testData[13], false);
                        Int32intE0M.AssertModel(models[4],_testData[14], false);
                        Int32intE0M.AssertModel(models[5],_testData[15], false);
                        Int32intE0M.AssertModel(models[6],_testData[16], false);
                        Int32intE0M.AssertModel(models[7],_testData[17], false);
                        Int32intE0M.AssertModel(models[8],_testData[18], false);
                        Int32intE0M.AssertModel(models[9],_testData[19], false);
                        Int32intE0M.AssertModel(models[10],_testData[20], false);
                        Int32intE0M.AssertModel(models[11],_testData[21], false);
                        Int32intE0M.AssertModel(models[12],_testData[22], false);
                        Int32intE0M.AssertModel(models[13],_testData[23], false);
                        Int32intE0M.AssertModel(models[14],_testData[24], false);
                        Int32intE0M.AssertModel(models[15],_testData[25], false);
                        Int32intE0M.AssertModel(models[16],_testData[26], false);
                        Int32intE0M.AssertModel(models[17],_testData[27], false);
                        Int32intE0M.AssertModel(models[18],_testData[28], false);
                        Int32intE0M.AssertModel(models[19],_testData[29], false);
                        Int32intE0M.AssertModel(models[20],_testData[30], false);
                        Int32intE0M.AssertModel(models[21],_testData[31], false);
                        Int32intE0M.AssertModel(models[22],_testData[32], false);
                        Int32intE0M.AssertModel(models[23],_testData[33], false);
                        Int32intE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 54, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 142, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M)],
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32intE0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32intE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[32],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 136, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 57, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32intE0M.AssertModel(models[0],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt32intE0M.AssertModel(models[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
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
FROM gedaqtests.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
LEFT JOIN gedaqtests.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32intE0M)],
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 87, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32intE0M.AssertModel(models[0],_testData[17], false);
                        Int32intE0M.AssertModel(models[1],_testData[18], false);
                        Int32intE0M.AssertModel(models[2],_testData[19], false);
                        Int32intE0M.AssertModel(models[3],_testData[20], false);
                        Int32intE0M.AssertModel(models[4],_testData[21], false);
                        Int32intE0M.AssertModel(models[5],_testData[22], false);
                        Int32intE0M.AssertModel(models[6],_testData[23], false);
                        Int32intE0M.AssertModel(models[7],_testData[24], false);
                        Int32intE0M.AssertModel(models[8],_testData[25], false);
                        Int32intE0M.AssertModel(models[9],_testData[26], false);
                        Int32intE0M.AssertModel(models[10],_testData[27], false);
                        Int32intE0M.AssertModel(models[11],_testData[28], false);
                        Int32intE0M.AssertModel(models[12],_testData[29], false);
                        Int32intE0M.AssertModel(models[13],_testData[30], false);
                        Int32intE0M.AssertModel(models[14],_testData[31], false);
                        Int32intE0M.AssertModel(models[15],_testData[32], false);
                        Int32intE0M.AssertModel(models[16],_testData[33], false);
                        Int32intE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32intE0M.AssertModel(models[0],_testData[23], false);
                        Int32intE0M.AssertModel(models[1],_testData[24], false);
                        Int32intE0M.AssertModel(models[2],_testData[25], false);
                        Int32intE0M.AssertModel(models[3],_testData[26], false);
                        Int32intE0M.AssertModel(models[4],_testData[27], false);
                        Int32intE0M.AssertModel(models[5],_testData[28], false);
                        Int32intE0M.AssertModel(models[6],_testData[29], false);
                        Int32intE0M.AssertModel(models[7],_testData[30], false);
                        Int32intE0M.AssertModel(models[8],_testData[31], false);
                        Int32intE0M.AssertModel(models[9],_testData[32], false);
                        Int32intE0M.AssertModel(models[10],_testData[33], false);
                        Int32intE0M.AssertModel(models[11],_testData[34], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 123, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32intE0M.AssertModel(models[0],_testData[24], false);
                        Int32intE0M.AssertModel(models[1],_testData[25], false);
                        Int32intE0M.AssertModel(models[2],_testData[26], false);
                        Int32intE0M.AssertModel(models[3],_testData[27], false);
                        Int32intE0M.AssertModel(models[4],_testData[28], false);
                        Int32intE0M.AssertModel(models[5],_testData[29], false);
                        Int32intE0M.AssertModel(models[6],_testData[30], false);
                        Int32intE0M.AssertModel(models[7],_testData[31], false);
                        Int32intE0M.AssertModel(models[8],_testData[32], false);
                        Int32intE0M.AssertModel(models[9],_testData[33], false);
                        Int32intE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32intE0M.AssertModel(models[0],_testData[22], false);
                        Int32intE0M.AssertModel(models[1],_testData[23], false);
                        Int32intE0M.AssertModel(models[2],_testData[24], false);
                        Int32intE0M.AssertModel(models[3],_testData[25], false);
                        Int32intE0M.AssertModel(models[4],_testData[26], false);
                        Int32intE0M.AssertModel(models[5],_testData[27], false);
                        Int32intE0M.AssertModel(models[6],_testData[28], false);
                        Int32intE0M.AssertModel(models[7],_testData[29], false);
                        Int32intE0M.AssertModel(models[8],_testData[30], false);
                        Int32intE0M.AssertModel(models[9],_testData[31], false);
                        Int32intE0M.AssertModel(models[10],_testData[32], false);
                        Int32intE0M.AssertModel(models[11],_testData[33], false);
                        Int32intE0M.AssertModel(models[12],_testData[34], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int32intE0M.AssertModel(models[0],_testData[1], false);
                Int32intE0M.AssertModel(models[1],_testData[2], false);
                Int32intE0M.AssertModel(models[2],_testData[3], false);
                Int32intE0M.AssertModel(models[3],_testData[4], false);
                Int32intE0M.AssertModel(models[4],_testData[5], false);
                Int32intE0M.AssertModel(models[5],_testData[6], false);
                Int32intE0M.AssertModel(models[6],_testData[7], false);
                Int32intE0M.AssertModel(models[7],_testData[8], false);
                Int32intE0M.AssertModel(models[8],_testData[9], false);
                Int32intE0M.AssertModel(models[9],_testData[10], false);
                Int32intE0M.AssertModel(models[10],_testData[11], false);
                Int32intE0M.AssertModel(models[11],_testData[12], false);
                Int32intE0M.AssertModel(models[12],_testData[13], false);
                Int32intE0M.AssertModel(models[13],_testData[14], false);
                Int32intE0M.AssertModel(models[14],_testData[15], false);
                Int32intE0M.AssertModel(models[15],_testData[16], false);
                Int32intE0M.AssertModel(models[16],_testData[17], false);
                Int32intE0M.AssertModel(models[17],_testData[18], false);
                Int32intE0M.AssertModel(models[18],_testData[19], false);
                Int32intE0M.AssertModel(models[19],_testData[20], false);
                Int32intE0M.AssertModel(models[20],_testData[21], false);
                Int32intE0M.AssertModel(models[21],_testData[22], false);
                Int32intE0M.AssertModel(models[22],_testData[23], false);
                Int32intE0M.AssertModel(models[23],_testData[24], false);
                Int32intE0M.AssertModel(models[24],_testData[25], false);
                Int32intE0M.AssertModel(models[25],_testData[26], false);
                Int32intE0M.AssertModel(models[26],_testData[27], false);
                Int32intE0M.AssertModel(models[27],_testData[28], false);
                Int32intE0M.AssertModel(models[28],_testData[29], false);
                Int32intE0M.AssertModel(models[29],_testData[30], false);
                Int32intE0M.AssertModel(models[30],_testData[31], false);
                Int32intE0M.AssertModel(models[31],_testData[32], false);
                Int32intE0M.AssertModel(models[32],_testData[33], false);
                Int32intE0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Int32intE0M.AssertModel(models[0],_testData[19], false);
                Int32intE0M.AssertModel(models[1],_testData[20], false);
                Int32intE0M.AssertModel(models[2],_testData[21], false);
                Int32intE0M.AssertModel(models[3],_testData[22], false);
                Int32intE0M.AssertModel(models[4],_testData[23], false);
                Int32intE0M.AssertModel(models[5],_testData[24], false);
                Int32intE0M.AssertModel(models[6],_testData[25], false);
                Int32intE0M.AssertModel(models[7],_testData[26], false);
                Int32intE0M.AssertModel(models[8],_testData[27], false);
                Int32intE0M.AssertModel(models[9],_testData[28], false);
                Int32intE0M.AssertModel(models[10],_testData[29], false);
                Int32intE0M.AssertModel(models[11],_testData[30], false);
                Int32intE0M.AssertModel(models[12],_testData[31], false);
                Int32intE0M.AssertModel(models[13],_testData[32], false);
                Int32intE0M.AssertModel(models[14],_testData[33], false);
                Int32intE0M.AssertModel(models[15],_testData[34], false);
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
FROM gedaqtests.int32inte0m m
LEFT JOIN gedaqtests.int32inte0mi mi ON mi.id = m.int32inte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((930436088)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2110064483)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((146081451)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1641785265)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1792945935)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((879443713)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1353271238)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1626604542)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((689187714)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1283548992)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((443339339)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1838779231)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1524387112)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((478016694)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((478555471)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1676192877)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1457151433)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((209850785)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2030074412)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1321559890)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((550273030)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1359740928)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1223805647)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1133054199)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1273851223)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((232109039)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((178920386)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1367248847)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1195812725)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1859280925)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2008996010)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((199721640)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((349203096)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((708075849)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((396610071)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((137321923)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((639732877)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1217068227)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((126449558)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((877721059)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((472049611)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1270214506)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((2042923382)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1611681843)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1423428480)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1203070457)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1690830365)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2067924928)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((652734164)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1184259467)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((38813368)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((905690560)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((19334828)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2088651646)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((81086657)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((873201117)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((385515667)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1942531070)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1316339407)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1088416650)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1108056940)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1299190298)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((617329054)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((668817741)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1336241309)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1594827234)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2117443881)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((892350261)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((377231625)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1801240376)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1148984561)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((108)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2099572954)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((466290152)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((446407320)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((930436088)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2110064483)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((146081451)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1641785265)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1792945935)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((879443713)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1353271238)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1626604542)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((689187714)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1283548992)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((443339339)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1838779231)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1524387112)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((478016694)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((478555471)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1676192877)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1457151433)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((209850785)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2030074412)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1321559890)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((550273030)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1359740928)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1223805647)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1133054199)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1273851223)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((232109039)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((178920386)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1367248847)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1195812725)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1859280925)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2008996010)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((199721640)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((349203096)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((708075849)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((396610071)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((137321923)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((639732877)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1217068227)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((126449558)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((877721059)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((472049611)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1270214506)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((2042923382)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1611681843)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1423428480)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1203070457)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1690830365)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2067924928)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((652734164)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1184259467)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((38813368)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((905690560)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((19334828)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2088651646)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((81086657)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((873201117)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((385515667)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1942531070)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1316339407)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1088416650)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1108056940)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1299190298)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((617329054)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((668817741)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1336241309)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1594827234)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2117443881)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((892350261)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((377231625)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1801240376)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1148984561)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((108)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2099572954)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((466290152)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((446407320)));

            }
        }

#endregion

    }
}


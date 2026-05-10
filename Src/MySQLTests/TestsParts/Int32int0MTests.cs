

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
    Value = 1663743908,
    ModelInner = null,
    NullableValue = 1474887667,
},
            new Int32int0M
{
    Id = 4,
    Value = 1101698405,
    ModelInner = new Int32int0MI
{
    Id = 1,
    Value = 1211137900,
    NullableValue = null,
},
    NullableValue = 763036957,
},
            new Int32int0M
{
    Id = 10,
    Value = 1548503503,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 18,
    Value = 829915246,
    ModelInner = new Int32int0MI
{
    Id = 2,
    Value = 1833521249,
    NullableValue = null,
},
    NullableValue = 649026619,
},
            new Int32int0M
{
    Id = 25,
    Value = 678567934,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 32,
    Value = 586269157,
    ModelInner = new Int32int0MI
{
    Id = 6,
    Value = 2125054200,
    NullableValue = null,
},
    NullableValue = 808622474,
},
            new Int32int0M
{
    Id = 39,
    Value = 1032580190,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 44,
    Value = 1532954773,
    ModelInner = new Int32int0MI
{
    Id = 10,
    Value = 1134174121,
    NullableValue = 516903054,
},
    NullableValue = 422322865,
},
            new Int32int0M
{
    Id = 47,
    Value = 1217940844,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 52,
    Value = 1708097729,
    ModelInner = new Int32int0MI
{
    Id = 15,
    Value = 66168038,
    NullableValue = null,
},
    NullableValue = 1892207166,
},
            new Int32int0M
{
    Id = 53,
    Value = 1334738074,
    ModelInner = null,
    NullableValue = 150148049,
},
            new Int32int0M
{
    Id = 61,
    Value = 1446995642,
    ModelInner = new Int32int0MI
{
    Id = 23,
    Value = 1840386758,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 62,
    Value = 214566984,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 64,
    Value = 2064428706,
    ModelInner = new Int32int0MI
{
    Id = 29,
    Value = 900855597,
    NullableValue = 326216481,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 73,
    Value = 1605928184,
    ModelInner = null,
    NullableValue = 442471140,
},
            new Int32int0M
{
    Id = 82,
    Value = 594519774,
    ModelInner = new Int32int0MI
{
    Id = 34,
    Value = 205532248,
    NullableValue = 468549181,
},
    NullableValue = 1665645489,
},
            new Int32int0M
{
    Id = 91,
    Value = 346381700,
    ModelInner = null,
    NullableValue = 815916530,
},
            new Int32int0M
{
    Id = 99,
    Value = 145926833,
    ModelInner = new Int32int0MI
{
    Id = 42,
    Value = 46501965,
    NullableValue = 1946205187,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 106,
    Value = 1008718191,
    ModelInner = null,
    NullableValue = 1811394948,
},
            new Int32int0M
{
    Id = 108,
    Value = 243775314,
    ModelInner = new Int32int0MI
{
    Id = 49,
    Value = 72730151,
    NullableValue = 623176607,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 115,
    Value = 633204055,
    ModelInner = null,
    NullableValue = 476957200,
},
            new Int32int0M
{
    Id = 120,
    Value = 289971121,
    ModelInner = new Int32int0MI
{
    Id = 54,
    Value = 1711834719,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 127,
    Value = 970310603,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 134,
    Value = 1260581112,
    ModelInner = new Int32int0MI
{
    Id = 58,
    Value = 1422322754,
    NullableValue = 899086158,
},
    NullableValue = 1337703544,
},
            new Int32int0M
{
    Id = 136,
    Value = 615793599,
    ModelInner = null,
    NullableValue = 392117939,
},
            new Int32int0M
{
    Id = 143,
    Value = 250464585,
    ModelInner = new Int32int0MI
{
    Id = 60,
    Value = 442648360,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 147,
    Value = 1693028391,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 150,
    Value = 362016820,
    ModelInner = new Int32int0MI
{
    Id = 64,
    Value = 1359563504,
    NullableValue = 1077322607,
},
    NullableValue = 1691694645,
},
            new Int32int0M
{
    Id = 159,
    Value = 2065666126,
    ModelInner = null,
    NullableValue = 2137892740,
},
            new Int32int0M
{
    Id = 167,
    Value = 1865169968,
    ModelInner = new Int32int0MI
{
    Id = 71,
    Value = 1907798711,
    NullableValue = 365228312,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 173,
    Value = 637527079,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 176,
    Value = 266804704,
    ModelInner = new Int32int0MI
{
    Id = 73,
    Value = 138029032,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 181,
    Value = 511113848,
    ModelInner = null,
    NullableValue = 845913348,
},
            new Int32int0M
{
    Id = 187,
    Value = 1916541736,
    ModelInner = new Int32int0MI
{
    Id = 82,
    Value = 997315123,
    NullableValue = 20402434,
},
    NullableValue = 1810678066,
},
            new Int32int0M
{
    Id = 194,
    Value = 2020614117,
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32int0M.AssertModel(models[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32int0M.AssertModel(models[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 181;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32int0M.AssertModel(models[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32int0M.AssertModel(models[0],_testData[11], false);
                        Int32int0M.AssertModel(models[1],_testData[12], false);
                        Int32int0M.AssertModel(models[2],_testData[13], false);
                        Int32int0M.AssertModel(models[3],_testData[14], false);
                        Int32int0M.AssertModel(models[4],_testData[15], false);
                        Int32int0M.AssertModel(models[5],_testData[16], false);
                        Int32int0M.AssertModel(models[6],_testData[17], false);
                        Int32int0M.AssertModel(models[7],_testData[18], false);
                        Int32int0M.AssertModel(models[8],_testData[19], false);
                        Int32int0M.AssertModel(models[9],_testData[20], false);
                        Int32int0M.AssertModel(models[10],_testData[21], false);
                        Int32int0M.AssertModel(models[11],_testData[22], false);
                        Int32int0M.AssertModel(models[12],_testData[23], false);
                        Int32int0M.AssertModel(models[13],_testData[24], false);
                        Int32int0M.AssertModel(models[14],_testData[25], false);
                        Int32int0M.AssertModel(models[15],_testData[26], false);
                        Int32int0M.AssertModel(models[16],_testData[27], false);
                        Int32int0M.AssertModel(models[17],_testData[28], false);
                        Int32int0M.AssertModel(models[18],_testData[29], false);
                        Int32int0M.AssertModel(models[19],_testData[30], false);
                        Int32int0M.AssertModel(models[20],_testData[31], false);
                        Int32int0M.AssertModel(models[21],_testData[32], false);
                        Int32int0M.AssertModel(models[22],_testData[33], false);
                        Int32int0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32int0M.AssertModel(models[0],_testData[22], false);
                        Int32int0M.AssertModel(models[1],_testData[23], false);
                        Int32int0M.AssertModel(models[2],_testData[24], false);
                        Int32int0M.AssertModel(models[3],_testData[25], false);
                        Int32int0M.AssertModel(models[4],_testData[26], false);
                        Int32int0M.AssertModel(models[5],_testData[27], false);
                        Int32int0M.AssertModel(models[6],_testData[28], false);
                        Int32int0M.AssertModel(models[7],_testData[29], false);
                        Int32int0M.AssertModel(models[8],_testData[30], false);
                        Int32int0M.AssertModel(models[9],_testData[31], false);
                        Int32int0M.AssertModel(models[10],_testData[32], false);
                        Int32int0M.AssertModel(models[11],_testData[33], false);
                        Int32int0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 52, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 25, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[29],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt32int0M.AssertModel(models[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt32int0M.AssertModel(models[0],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 181, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 47, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32int0M.AssertModel(models[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt32int0M.AssertModel(models[0],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 134, query1, 64, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 115, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32int0M.AssertModel(models[0],_testData[21], false);
                        Int32int0M.AssertModel(models[1],_testData[22], false);
                        Int32int0M.AssertModel(models[2],_testData[23], false);
                        Int32int0M.AssertModel(models[3],_testData[24], false);
                        Int32int0M.AssertModel(models[4],_testData[25], false);
                        Int32int0M.AssertModel(models[5],_testData[26], false);
                        Int32int0M.AssertModel(models[6],_testData[27], false);
                        Int32int0M.AssertModel(models[7],_testData[28], false);
                        Int32int0M.AssertModel(models[8],_testData[29], false);
                        Int32int0M.AssertModel(models[9],_testData[30], false);
                        Int32int0M.AssertModel(models[10],_testData[31], false);
                        Int32int0M.AssertModel(models[11],_testData[32], false);
                        Int32int0M.AssertModel(models[12],_testData[33], false);
                        Int32int0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32int0M.AssertModel(models[0],_testData[26], false);
                        Int32int0M.AssertModel(models[1],_testData[27], false);
                        Int32int0M.AssertModel(models[2],_testData[28], false);
                        Int32int0M.AssertModel(models[3],_testData[29], false);
                        Int32int0M.AssertModel(models[4],_testData[30], false);
                        Int32int0M.AssertModel(models[5],_testData[31], false);
                        Int32int0M.AssertModel(models[6],_testData[32], false);
                        Int32int0M.AssertModel(models[7],_testData[33], false);
                        Int32int0M.AssertModel(models[8],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 173, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int32int0M.AssertModel(models[0],_testData[31], false);
                        Int32int0M.AssertModel(models[1],_testData[32], false);
                        Int32int0M.AssertModel(models[2],_testData[33], false);
                        Int32int0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32int0M.AssertModel(models[0],_testData[26], false);
                        Int32int0M.AssertModel(models[1],_testData[27], false);
                        Int32int0M.AssertModel(models[2],_testData[28], false);
                        Int32int0M.AssertModel(models[3],_testData[29], false);
                        Int32int0M.AssertModel(models[4],_testData[30], false);
                        Int32int0M.AssertModel(models[5],_testData[31], false);
                        Int32int0M.AssertModel(models[6],_testData[32], false);
                        Int32int0M.AssertModel(models[7],_testData[33], false);
                        Int32int0M.AssertModel(models[8],_testData[34], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Int32int0M.AssertModel(models[0],_testData[22], false);
                Int32int0M.AssertModel(models[1],_testData[23], false);
                Int32int0M.AssertModel(models[2],_testData[24], false);
                Int32int0M.AssertModel(models[3],_testData[25], false);
                Int32int0M.AssertModel(models[4],_testData[26], false);
                Int32int0M.AssertModel(models[5],_testData[27], false);
                Int32int0M.AssertModel(models[6],_testData[28], false);
                Int32int0M.AssertModel(models[7],_testData[29], false);
                Int32int0M.AssertModel(models[8],_testData[30], false);
                Int32int0M.AssertModel(models[9],_testData[31], false);
                Int32int0M.AssertModel(models[10],_testData[32], false);
                Int32int0M.AssertModel(models[11],_testData[33], false);
                Int32int0M.AssertModel(models[12],_testData[34], false);
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
                Assert.That((System.Int32)model[1], Is.EqualTo((1663743908)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1474887667)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1101698405)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1211137900)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((763036957)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1548503503)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((829915246)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1833521249)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((649026619)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((678567934)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((586269157)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2125054200)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((808622474)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1032580190)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1532954773)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1134174121)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((516903054)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((422322865)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1217940844)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1708097729)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((66168038)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1892207166)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1334738074)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((150148049)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1446995642)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1840386758)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((214566984)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2064428706)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((900855597)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((326216481)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1605928184)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((442471140)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((594519774)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((205532248)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((468549181)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1665645489)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((346381700)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((815916530)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((145926833)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((46501965)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1946205187)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1008718191)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1811394948)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((243775314)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((72730151)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((623176607)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((633204055)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((476957200)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((289971121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1711834719)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((970310603)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1260581112)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1422322754)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((899086158)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1337703544)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((615793599)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((392117939)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((250464585)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((442648360)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1693028391)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((362016820)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1359563504)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1077322607)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1691694645)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2065666126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2137892740)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1865169968)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1907798711)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((365228312)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((637527079)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((266804704)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((138029032)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((511113848)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((845913348)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1916541736)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((997315123)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((20402434)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1810678066)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2020614117)));//Value

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
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1663743908)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1474887667)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1101698405)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1211137900)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((763036957)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1548503503)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((829915246)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1833521249)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((649026619)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((678567934)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((586269157)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2125054200)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((808622474)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1032580190)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1532954773)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1134174121)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((516903054)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((422322865)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1217940844)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1708097729)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((66168038)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1892207166)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1334738074)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((150148049)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1446995642)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1840386758)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((214566984)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2064428706)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((900855597)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((326216481)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1605928184)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((442471140)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((594519774)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((205532248)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((468549181)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1665645489)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((346381700)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((815916530)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((145926833)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((46501965)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1946205187)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1008718191)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1811394948)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((243775314)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((72730151)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((623176607)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((633204055)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((476957200)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((289971121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1711834719)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((970310603)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1260581112)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1422322754)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((899086158)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1337703544)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((615793599)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((392117939)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((250464585)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((442648360)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1693028391)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((362016820)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1359563504)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1077322607)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1691694645)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2065666126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2137892740)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1865169968)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1907798711)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((365228312)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((637527079)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((266804704)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((138029032)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((511113848)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((845913348)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1916541736)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((997315123)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((20402434)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1810678066)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2020614117)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


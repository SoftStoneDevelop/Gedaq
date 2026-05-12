

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
    Value = 505381716,
    ModelInner = null,
    NullableValue = 3734238466,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 15,
    Value = 1564784003,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 3,
    Value = 1526214390,
    NullableValue = null,
},
    NullableValue = 341538487,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 20,
    Value = 3457115222,
    ModelInner = null,
    NullableValue = 3170741809,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 22,
    Value = 2489333852,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 8,
    Value = 4699057,
    NullableValue = null,
},
    NullableValue = 3780620560,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 24,
    Value = 2734085307,
    ModelInner = null,
    NullableValue = 1225468976,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 28,
    Value = 2617827211,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 9,
    Value = 1908472550,
    NullableValue = 1511205071,
},
    NullableValue = 2341542599,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 31,
    Value = 2816796718,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 40,
    Value = 1716167417,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 13,
    Value = 4125624965,
    NullableValue = null,
},
    NullableValue = 3099994700,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 44,
    Value = 2551091013,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 52,
    Value = 450436158,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 15,
    Value = 2576158682,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 55,
    Value = 3181280053,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 59,
    Value = 737705027,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 17,
    Value = 3018115411,
    NullableValue = 1163889944,
},
    NullableValue = 4270395408,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 64,
    Value = 3547088899,
    ModelInner = null,
    NullableValue = 1031473748,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 72,
    Value = 3514465910,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 19,
    Value = 1437427875,
    NullableValue = 232756800,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 76,
    Value = 568937373,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 79,
    Value = 2735107615,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 20,
    Value = 1220266567,
    NullableValue = null,
},
    NullableValue = 1938901276,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 88,
    Value = 255326672,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 97,
    Value = 3297947688,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 22,
    Value = 1388156664,
    NullableValue = null,
},
    NullableValue = 4213369687,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 100,
    Value = 516422583,
    ModelInner = null,
    NullableValue = 3437608640,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 105,
    Value = 571013969,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 25,
    Value = 837934308,
    NullableValue = 4042093458,
},
    NullableValue = 3172827672,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 106,
    Value = 4010738400,
    ModelInner = null,
    NullableValue = 1591972396,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 113,
    Value = 150952484,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 32,
    Value = 2592610346,
    NullableValue = 3155310439,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 119,
    Value = 167789661,
    ModelInner = null,
    NullableValue = 165987257,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 128,
    Value = 1211219977,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 41,
    Value = 1262624682,
    NullableValue = null,
},
    NullableValue = 2523723839,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 136,
    Value = 2509088526,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 138,
    Value = 744805365,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 43,
    Value = 2538721937,
    NullableValue = 1562155287,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 145,
    Value = 3894813694,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 149,
    Value = 3063296560,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 50,
    Value = 3917861016,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 155,
    Value = 3802903721,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 159,
    Value = 3853957305,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 59,
    Value = 4226436763,
    NullableValue = 118155196,
},
    NullableValue = 723921478,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 165,
    Value = 1534990418,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 169,
    Value = 312406320,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 62,
    Value = 406404303,
    NullableValue = 3848290147,
},
    NullableValue = 4179891729,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 178,
    Value = 3943869932,
    ModelInner = null,
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 186,
    Value = 2318902271,
    ModelInner = new UInt32int_UNSIGNEDE0MI
{
    Id = 70,
    Value = 2774796717,
    NullableValue = 1856433249,
},
    NullableValue = null,
},
            new UInt32int_UNSIGNEDE0M
{
    Id = 188,
    Value = 1883192426,
    ModelInner = null,
    NullableValue = 1815704950,
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 169;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[2], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[3], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[4], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[5], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[6], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[7], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[8], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[9], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[10], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[11], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[12], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[29],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[30],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[31],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[32],_testData[34], false);
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
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 178, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[34], false);
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
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 44, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[34], false);
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
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 15, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[2], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[3], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[29],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[30],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[31],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[34], false);
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
                await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[4], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[29],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[5], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[6], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[7], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[8], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[9], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[10], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[11], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[12], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[13], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[14], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[15], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[16], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[17], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[18], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[19], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[20], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[21], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[28],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(models[29],_testData[34], false);
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
                 ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 113, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatUInt32int_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in await ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 44, 31))
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[7], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[8], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[9], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[10], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[11], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[12], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[13], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[14], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[15], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[16], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[17], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[18], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[21],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[22],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[23],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[24],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[25],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[26],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[27],_testData[34], false);
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
                foreach(var batchResult in  ((IUInt32SingleTypeint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 113, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[19], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[20], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[21], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[22], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[23], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[24], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[25], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[26], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[27], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[28], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[29], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[30], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[31], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[32], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[33], false);
                        UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[34], false);
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
                ((IUInt32SingleTypeint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models = await ((IUInt32SingleTypeint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IUInt32SingleTypeint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IUInt32SingleTypeint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models =  ((IUInt32SingleTypeint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                UInt32int_UNSIGNEDE0M.AssertModel(models[0],_testData[14], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[1],_testData[15], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[2],_testData[16], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[3],_testData[17], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[4],_testData[18], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[5],_testData[19], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[6],_testData[20], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[7],_testData[21], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[8],_testData[22], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[9],_testData[23], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[10],_testData[24], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[11],_testData[25], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[12],_testData[26], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[13],_testData[27], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[14],_testData[28], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[15],_testData[29], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[16],_testData[30], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[17],_testData[31], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[18],_testData[32], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[19],_testData[33], false);
                UInt32int_UNSIGNEDE0M.AssertModel(models[20],_testData[34], false);
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
                Assert.That((System.UInt32)model[1], Is.EqualTo((505381716)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3734238466)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1564784003)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1526214390)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((341538487)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3457115222)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3170741809)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2489333852)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4699057)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3780620560)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2734085307)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1225468976)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2617827211)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1908472550)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1511205071)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2341542599)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2816796718)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1716167417)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4125624965)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3099994700)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2551091013)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((450436158)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2576158682)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3181280053)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((737705027)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3018115411)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1163889944)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4270395408)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3547088899)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1031473748)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3514465910)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1437427875)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((232756800)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((568937373)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2735107615)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1220266567)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1938901276)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((255326672)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3297947688)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1388156664)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4213369687)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((516422583)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3437608640)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((571013969)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((837934308)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((4042093458)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3172827672)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((4010738400)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1591972396)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((150952484)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2592610346)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((3155310439)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((167789661)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((165987257)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1211219977)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1262624682)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2523723839)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2509088526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((744805365)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2538721937)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1562155287)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3894813694)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3063296560)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3917861016)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3802903721)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3853957305)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4226436763)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((118155196)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((723921478)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1534990418)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((312406320)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((406404303)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((3848290147)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4179891729)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3943869932)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2318902271)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2774796717)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1856433249)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1883192426)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1815704950)));

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
                Assert.That((System.UInt32)model[1], Is.EqualTo((505381716)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3734238466)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1564784003)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1526214390)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((341538487)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3457115222)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3170741809)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2489333852)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4699057)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3780620560)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2734085307)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1225468976)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2617827211)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1908472550)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1511205071)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2341542599)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2816796718)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1716167417)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4125624965)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3099994700)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2551091013)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((450436158)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2576158682)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3181280053)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((737705027)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3018115411)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1163889944)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4270395408)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3547088899)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1031473748)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3514465910)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1437427875)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((232756800)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((568937373)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2735107615)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1220266567)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1938901276)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((255326672)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3297947688)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1388156664)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4213369687)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((516422583)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3437608640)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((571013969)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((837934308)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((4042093458)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((3172827672)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((4010738400)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1591972396)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((150952484)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2592610346)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((3155310439)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((167789661)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((165987257)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1211219977)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((1262624682)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt32?)model[5], Is.EqualTo((2523723839)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2509088526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((744805365)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2538721937)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1562155287)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3894813694)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3063296560)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((3917861016)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3802903721)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3853957305)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((4226436763)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((118155196)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((723921478)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1534990418)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((312406320)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((406404303)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((3848290147)));//InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((4179891729)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((3943869932)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((2318902271)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.UInt32)model[3], Is.EqualTo((2774796717)));//InnerModel.Value

                Assert.That((System.UInt32?)model[4], Is.EqualTo((1856433249)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.UInt32)model[1], Is.EqualTo((1883192426)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt32?)model[5], Is.EqualTo((1815704950)));

            }
        }

#endregion

    }
}


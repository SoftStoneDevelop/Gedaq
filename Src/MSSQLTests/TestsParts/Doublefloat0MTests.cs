

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDoubleSingleTypefloat
    {
    }
    
    internal partial class DoubleSingleTypefloat : IDoubleSingleTypefloat
    {


#region TestData

        private readonly Doublefloat0M[] _testData = new Doublefloat0M[]
        {
            new Doublefloat0M
{
    Id = 7,
    Value = 0.3045788904812724d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 10,
    Value = 0.27091480206465146d,
    ModelInner = new Doublefloat0MI
{
    Id = 5,
    Value = 0.3167643454902511d,
    NullableValue = 0.7144164583747474d,
},
    NullableValue = 0.3461410178862435d,
},
            new Doublefloat0M
{
    Id = 17,
    Value = 0.6500128242693199d,
    ModelInner = null,
    NullableValue = 0.4411021970220427d,
},
            new Doublefloat0M
{
    Id = 18,
    Value = 0.210832365366164d,
    ModelInner = new Doublefloat0MI
{
    Id = 11,
    Value = 0.7335980590078562d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 24,
    Value = 0.8455441120831628d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 31,
    Value = 0.4469026837183462d,
    ModelInner = new Doublefloat0MI
{
    Id = 15,
    Value = 0.08484348825422916d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 33,
    Value = 0.20164965012490466d,
    ModelInner = null,
    NullableValue = 0.004719058347499083d,
},
            new Doublefloat0M
{
    Id = 41,
    Value = 0.49238994805797354d,
    ModelInner = new Doublefloat0MI
{
    Id = 23,
    Value = 0.9050095786852046d,
    NullableValue = 0.2126770142001726d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 48,
    Value = 0.6533485617353614d,
    ModelInner = null,
    NullableValue = 0.500611222070279d,
},
            new Doublefloat0M
{
    Id = 53,
    Value = 0.4823741482265892d,
    ModelInner = new Doublefloat0MI
{
    Id = 31,
    Value = 0.3087708835096854d,
    NullableValue = 0.9973731812298601d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 58,
    Value = 0.46786402971545804d,
    ModelInner = null,
    NullableValue = 0.7083624106233367d,
},
            new Doublefloat0M
{
    Id = 64,
    Value = 0.7391511859527682d,
    ModelInner = new Doublefloat0MI
{
    Id = 33,
    Value = 0.8907208039622471d,
    NullableValue = 0.2858798517439666d,
},
    NullableValue = 0.36093941636387794d,
},
            new Doublefloat0M
{
    Id = 66,
    Value = 0.9011154958328579d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 67,
    Value = 0.44245684427801846d,
    ModelInner = new Doublefloat0MI
{
    Id = 41,
    Value = 0.20152473921851954d,
    NullableValue = 0.03261776760470214d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 76,
    Value = 0.47505964354763996d,
    ModelInner = null,
    NullableValue = 0.5536487494377093d,
},
            new Doublefloat0M
{
    Id = 80,
    Value = 0.7101387882836673d,
    ModelInner = new Doublefloat0MI
{
    Id = 45,
    Value = 0.05034163795134272d,
    NullableValue = 0.49506220840681014d,
},
    NullableValue = 0.633298304648538d,
},
            new Doublefloat0M
{
    Id = 88,
    Value = 0.447137599885973d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 91,
    Value = 0.4067619372613708d,
    ModelInner = new Doublefloat0MI
{
    Id = 53,
    Value = 0.29658939112908733d,
    NullableValue = 0.7134021071709901d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 95,
    Value = 0.4897153412389369d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 98,
    Value = 0.2856208180716613d,
    ModelInner = new Doublefloat0MI
{
    Id = 55,
    Value = 0.5128974417997757d,
    NullableValue = 0.27328046457493205d,
},
    NullableValue = 0.058114426328790825d,
},
            new Doublefloat0M
{
    Id = 103,
    Value = 0.3567264346298359d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 109,
    Value = 0.3923061537642991d,
    ModelInner = new Doublefloat0MI
{
    Id = 61,
    Value = 0.2830151567414233d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 114,
    Value = 0.49782161636130473d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 122,
    Value = 0.428868002823262d,
    ModelInner = new Doublefloat0MI
{
    Id = 69,
    Value = 0.6765790995136443d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 123,
    Value = 0.25483918982724474d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 130,
    Value = 0.8686721208290937d,
    ModelInner = new Doublefloat0MI
{
    Id = 78,
    Value = 0.4498515077761698d,
    NullableValue = 0.0056180860473079575d,
},
    NullableValue = 0.6011956168623015d,
},
            new Doublefloat0M
{
    Id = 138,
    Value = 0.695441161269926d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 147,
    Value = 0.5206938597213566d,
    ModelInner = new Doublefloat0MI
{
    Id = 87,
    Value = 0.281116444227445d,
    NullableValue = 0.33708244208442373d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 155,
    Value = 0.6201505926776274d,
    ModelInner = null,
    NullableValue = 0.810407519769224d,
},
            new Doublefloat0M
{
    Id = 161,
    Value = 0.8509463143572412d,
    ModelInner = new Doublefloat0MI
{
    Id = 93,
    Value = 0.9445079672732668d,
    NullableValue = 0.7434939694524778d,
},
    NullableValue = 0.45232833882825396d,
},
            new Doublefloat0M
{
    Id = 162,
    Value = 0.6631759412016828d,
    ModelInner = null,
    NullableValue = 0.35075757387214845d,
},
            new Doublefloat0M
{
    Id = 164,
    Value = 0.9841504364643099d,
    ModelInner = new Doublefloat0MI
{
    Id = 97,
    Value = 0.2643235511902481d,
    NullableValue = 0.21706053141253845d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 170,
    Value = 0.3615100332665141d,
    ModelInner = null,
    NullableValue = 0.7667273563845676d,
},
            new Doublefloat0M
{
    Id = 175,
    Value = 0.9363619358180706d,
    ModelInner = new Doublefloat0MI
{
    Id = 104,
    Value = 0.06070762565913623d,
    NullableValue = 0.7575204694975922d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 177,
    Value = 0.8655940074338322d,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(6))
            ]
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

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0mi(
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
            asPartInterface: typeof(IDoubleSingleTypefloat)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)8),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)8, 
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

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0m(
	id,
    value,
    nullablevalue,
    doublefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doublefloat0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(6),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0m(
	id,
    value,
    nullablevalue,
    doublefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doublefloat0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)8),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)8,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
                dbType: (System.Data.DbType)11,
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

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypefloat)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypefloat)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypefloat)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypefloat)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleSingleTypefloat)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypefloat)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
                var models = await((IDoubleSingleTypefloat)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doublefloat0M.AssertModel(models[0],_testData[29], false);
                        Doublefloat0M.AssertModel(models[1],_testData[30], false);
                        Doublefloat0M.AssertModel(models[2],_testData[31], false);
                        Doublefloat0M.AssertModel(models[3],_testData[32], false);
                        Doublefloat0M.AssertModel(models[4],_testData[33], false);
                        Doublefloat0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doublefloat0M.AssertModel(models[0],_testData[24], false);
                        Doublefloat0M.AssertModel(models[1],_testData[25], false);
                        Doublefloat0M.AssertModel(models[2],_testData[26], false);
                        Doublefloat0M.AssertModel(models[3],_testData[27], false);
                        Doublefloat0M.AssertModel(models[4],_testData[28], false);
                        Doublefloat0M.AssertModel(models[5],_testData[29], false);
                        Doublefloat0M.AssertModel(models[6],_testData[30], false);
                        Doublefloat0M.AssertModel(models[7],_testData[31], false);
                        Doublefloat0M.AssertModel(models[8],_testData[32], false);
                        Doublefloat0M.AssertModel(models[9],_testData[33], false);
                        Doublefloat0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IDoubleSingleTypefloat)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doublefloat0M.AssertModel(models[0],_testData[32], false);
                        Doublefloat0M.AssertModel(models[1],_testData[33], false);
                        Doublefloat0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Doublefloat0M.AssertModel(models[0],_testData[8], false);
                        Doublefloat0M.AssertModel(models[1],_testData[9], false);
                        Doublefloat0M.AssertModel(models[2],_testData[10], false);
                        Doublefloat0M.AssertModel(models[3],_testData[11], false);
                        Doublefloat0M.AssertModel(models[4],_testData[12], false);
                        Doublefloat0M.AssertModel(models[5],_testData[13], false);
                        Doublefloat0M.AssertModel(models[6],_testData[14], false);
                        Doublefloat0M.AssertModel(models[7],_testData[15], false);
                        Doublefloat0M.AssertModel(models[8],_testData[16], false);
                        Doublefloat0M.AssertModel(models[9],_testData[17], false);
                        Doublefloat0M.AssertModel(models[10],_testData[18], false);
                        Doublefloat0M.AssertModel(models[11],_testData[19], false);
                        Doublefloat0M.AssertModel(models[12],_testData[20], false);
                        Doublefloat0M.AssertModel(models[13],_testData[21], false);
                        Doublefloat0M.AssertModel(models[14],_testData[22], false);
                        Doublefloat0M.AssertModel(models[15],_testData[23], false);
                        Doublefloat0M.AssertModel(models[16],_testData[24], false);
                        Doublefloat0M.AssertModel(models[17],_testData[25], false);
                        Doublefloat0M.AssertModel(models[18],_testData[26], false);
                        Doublefloat0M.AssertModel(models[19],_testData[27], false);
                        Doublefloat0M.AssertModel(models[20],_testData[28], false);
                        Doublefloat0M.AssertModel(models[21],_testData[29], false);
                        Doublefloat0M.AssertModel(models[22],_testData[30], false);
                        Doublefloat0M.AssertModel(models[23],_testData[31], false);
                        Doublefloat0M.AssertModel(models[24],_testData[32], false);
                        Doublefloat0M.AssertModel(models[25],_testData[33], false);
                        Doublefloat0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 164, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 162, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 17, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[34], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 109, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[34], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 91, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doublefloat0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
                var models = await((IDoubleSingleTypefloat)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doublefloat0M.AssertModel(models[0],_testData[2], false);
                        Doublefloat0M.AssertModel(models[1],_testData[3], false);
                        Doublefloat0M.AssertModel(models[2],_testData[4], false);
                        Doublefloat0M.AssertModel(models[3],_testData[5], false);
                        Doublefloat0M.AssertModel(models[4],_testData[6], false);
                        Doublefloat0M.AssertModel(models[5],_testData[7], false);
                        Doublefloat0M.AssertModel(models[6],_testData[8], false);
                        Doublefloat0M.AssertModel(models[7],_testData[9], false);
                        Doublefloat0M.AssertModel(models[8],_testData[10], false);
                        Doublefloat0M.AssertModel(models[9],_testData[11], false);
                        Doublefloat0M.AssertModel(models[10],_testData[12], false);
                        Doublefloat0M.AssertModel(models[11],_testData[13], false);
                        Doublefloat0M.AssertModel(models[12],_testData[14], false);
                        Doublefloat0M.AssertModel(models[13],_testData[15], false);
                        Doublefloat0M.AssertModel(models[14],_testData[16], false);
                        Doublefloat0M.AssertModel(models[15],_testData[17], false);
                        Doublefloat0M.AssertModel(models[16],_testData[18], false);
                        Doublefloat0M.AssertModel(models[17],_testData[19], false);
                        Doublefloat0M.AssertModel(models[18],_testData[20], false);
                        Doublefloat0M.AssertModel(models[19],_testData[21], false);
                        Doublefloat0M.AssertModel(models[20],_testData[22], false);
                        Doublefloat0M.AssertModel(models[21],_testData[23], false);
                        Doublefloat0M.AssertModel(models[22],_testData[24], false);
                        Doublefloat0M.AssertModel(models[23],_testData[25], false);
                        Doublefloat0M.AssertModel(models[24],_testData[26], false);
                        Doublefloat0M.AssertModel(models[25],_testData[27], false);
                        Doublefloat0M.AssertModel(models[26],_testData[28], false);
                        Doublefloat0M.AssertModel(models[27],_testData[29], false);
                        Doublefloat0M.AssertModel(models[28],_testData[30], false);
                        Doublefloat0M.AssertModel(models[29],_testData[31], false);
                        Doublefloat0M.AssertModel(models[30],_testData[32], false);
                        Doublefloat0M.AssertModel(models[31],_testData[33], false);
                        Doublefloat0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doublefloat0M.AssertModel(models[0],_testData[31], false);
                        Doublefloat0M.AssertModel(models[1],_testData[32], false);
                        Doublefloat0M.AssertModel(models[2],_testData[33], false);
                        Doublefloat0M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IDoubleSingleTypefloat)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 138, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doublefloat0M.AssertModel(models[0],_testData[27], false);
                        Doublefloat0M.AssertModel(models[1],_testData[28], false);
                        Doublefloat0M.AssertModel(models[2],_testData[29], false);
                        Doublefloat0M.AssertModel(models[3],_testData[30], false);
                        Doublefloat0M.AssertModel(models[4],_testData[31], false);
                        Doublefloat0M.AssertModel(models[5],_testData[32], false);
                        Doublefloat0M.AssertModel(models[6],_testData[33], false);
                        Doublefloat0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doublefloat0M.AssertModel(models[0],_testData[1], false);
                        Doublefloat0M.AssertModel(models[1],_testData[2], false);
                        Doublefloat0M.AssertModel(models[2],_testData[3], false);
                        Doublefloat0M.AssertModel(models[3],_testData[4], false);
                        Doublefloat0M.AssertModel(models[4],_testData[5], false);
                        Doublefloat0M.AssertModel(models[5],_testData[6], false);
                        Doublefloat0M.AssertModel(models[6],_testData[7], false);
                        Doublefloat0M.AssertModel(models[7],_testData[8], false);
                        Doublefloat0M.AssertModel(models[8],_testData[9], false);
                        Doublefloat0M.AssertModel(models[9],_testData[10], false);
                        Doublefloat0M.AssertModel(models[10],_testData[11], false);
                        Doublefloat0M.AssertModel(models[11],_testData[12], false);
                        Doublefloat0M.AssertModel(models[12],_testData[13], false);
                        Doublefloat0M.AssertModel(models[13],_testData[14], false);
                        Doublefloat0M.AssertModel(models[14],_testData[15], false);
                        Doublefloat0M.AssertModel(models[15],_testData[16], false);
                        Doublefloat0M.AssertModel(models[16],_testData[17], false);
                        Doublefloat0M.AssertModel(models[17],_testData[18], false);
                        Doublefloat0M.AssertModel(models[18],_testData[19], false);
                        Doublefloat0M.AssertModel(models[19],_testData[20], false);
                        Doublefloat0M.AssertModel(models[20],_testData[21], false);
                        Doublefloat0M.AssertModel(models[21],_testData[22], false);
                        Doublefloat0M.AssertModel(models[22],_testData[23], false);
                        Doublefloat0M.AssertModel(models[23],_testData[24], false);
                        Doublefloat0M.AssertModel(models[24],_testData[25], false);
                        Doublefloat0M.AssertModel(models[25],_testData[26], false);
                        Doublefloat0M.AssertModel(models[26],_testData[27], false);
                        Doublefloat0M.AssertModel(models[27],_testData[28], false);
                        Doublefloat0M.AssertModel(models[28],_testData[29], false);
                        Doublefloat0M.AssertModel(models[29],_testData[30], false);
                        Doublefloat0M.AssertModel(models[30],_testData[31], false);
                        Doublefloat0M.AssertModel(models[31],_testData[32], false);
                        Doublefloat0M.AssertModel(models[32],_testData[33], false);
                        Doublefloat0M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Doublefloat0M.AssertModel(models[0],_testData[7], false);
                Doublefloat0M.AssertModel(models[1],_testData[8], false);
                Doublefloat0M.AssertModel(models[2],_testData[9], false);
                Doublefloat0M.AssertModel(models[3],_testData[10], false);
                Doublefloat0M.AssertModel(models[4],_testData[11], false);
                Doublefloat0M.AssertModel(models[5],_testData[12], false);
                Doublefloat0M.AssertModel(models[6],_testData[13], false);
                Doublefloat0M.AssertModel(models[7],_testData[14], false);
                Doublefloat0M.AssertModel(models[8],_testData[15], false);
                Doublefloat0M.AssertModel(models[9],_testData[16], false);
                Doublefloat0M.AssertModel(models[10],_testData[17], false);
                Doublefloat0M.AssertModel(models[11],_testData[18], false);
                Doublefloat0M.AssertModel(models[12],_testData[19], false);
                Doublefloat0M.AssertModel(models[13],_testData[20], false);
                Doublefloat0M.AssertModel(models[14],_testData[21], false);
                Doublefloat0M.AssertModel(models[15],_testData[22], false);
                Doublefloat0M.AssertModel(models[16],_testData[23], false);
                Doublefloat0M.AssertModel(models[17],_testData[24], false);
                Doublefloat0M.AssertModel(models[18],_testData[25], false);
                Doublefloat0M.AssertModel(models[19],_testData[26], false);
                Doublefloat0M.AssertModel(models[20],_testData[27], false);
                Doublefloat0M.AssertModel(models[21],_testData[28], false);
                Doublefloat0M.AssertModel(models[22],_testData[29], false);
                Doublefloat0M.AssertModel(models[23],_testData[30], false);
                Doublefloat0M.AssertModel(models[24],_testData[31], false);
                Doublefloat0M.AssertModel(models[25],_testData[32], false);
                Doublefloat0M.AssertModel(models[26],_testData[33], false);
                Doublefloat0M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Doublefloat0M.AssertModel(models[0],_testData[11], false);
                Doublefloat0M.AssertModel(models[1],_testData[12], false);
                Doublefloat0M.AssertModel(models[2],_testData[13], false);
                Doublefloat0M.AssertModel(models[3],_testData[14], false);
                Doublefloat0M.AssertModel(models[4],_testData[15], false);
                Doublefloat0M.AssertModel(models[5],_testData[16], false);
                Doublefloat0M.AssertModel(models[6],_testData[17], false);
                Doublefloat0M.AssertModel(models[7],_testData[18], false);
                Doublefloat0M.AssertModel(models[8],_testData[19], false);
                Doublefloat0M.AssertModel(models[9],_testData[20], false);
                Doublefloat0M.AssertModel(models[10],_testData[21], false);
                Doublefloat0M.AssertModel(models[11],_testData[22], false);
                Doublefloat0M.AssertModel(models[12],_testData[23], false);
                Doublefloat0M.AssertModel(models[13],_testData[24], false);
                Doublefloat0M.AssertModel(models[14],_testData[25], false);
                Doublefloat0M.AssertModel(models[15],_testData[26], false);
                Doublefloat0M.AssertModel(models[16],_testData[27], false);
                Doublefloat0M.AssertModel(models[17],_testData[28], false);
                Doublefloat0M.AssertModel(models[18],_testData[29], false);
                Doublefloat0M.AssertModel(models[19],_testData[30], false);
                Doublefloat0M.AssertModel(models[20],_testData[31], false);
                Doublefloat0M.AssertModel(models[21],_testData[32], false);
                Doublefloat0M.AssertModel(models[22],_testData[33], false);
                Doublefloat0M.AssertModel(models[23],_testData[34], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypefloat))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3045788904812724d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27091480206465146d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3167643454902511d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7144164583747474d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3461410178862435d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6500128242693199d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4411021970220427d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.210832365366164d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7335980590078562d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8455441120831628d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4469026837183462d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08484348825422916d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20164965012490466d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.004719058347499083d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49238994805797354d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9050095786852046d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2126770142001726d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6533485617353614d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.500611222070279d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4823741482265892d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3087708835096854d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9973731812298601d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46786402971545804d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7083624106233367d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7391511859527682d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8907208039622471d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2858798517439666d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36093941636387794d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9011154958328579d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.44245684427801846d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.20152473921851954d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.03261776760470214d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47505964354763996d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5536487494377093d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7101387882836673d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05034163795134272d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.49506220840681014d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.633298304648538d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.447137599885973d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4067619372613708d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.29658939112908733d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7134021071709901d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4897153412389369d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2856208180716613d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5128974417997757d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.27328046457493205d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.058114426328790825d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3567264346298359d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3923061537642991d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2830151567414233d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49782161636130473d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.428868002823262d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6765790995136443d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.25483918982724474d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8686721208290937d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4498515077761698d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.0056180860473079575d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6011956168623015d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.695441161269926d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5206938597213566d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.281116444227445d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.33708244208442373d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6201505926776274d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.810407519769224d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8509463143572412d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9445079672732668d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7434939694524778d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45232833882825396d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6631759412016828d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.35075757387214845d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9841504364643099d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2643235511902481d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.21706053141253845d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3615100332665141d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7667273563845676d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9363619358180706d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((104)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06070762565913623d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7575204694975922d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8655940074338322d)));//Value

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
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3045788904812724d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27091480206465146d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3167643454902511d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7144164583747474d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3461410178862435d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6500128242693199d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4411021970220427d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.210832365366164d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7335980590078562d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8455441120831628d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4469026837183462d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08484348825422916d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20164965012490466d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.004719058347499083d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49238994805797354d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9050095786852046d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2126770142001726d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6533485617353614d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.500611222070279d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4823741482265892d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3087708835096854d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9973731812298601d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46786402971545804d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7083624106233367d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7391511859527682d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8907208039622471d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2858798517439666d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36093941636387794d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9011154958328579d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.44245684427801846d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.20152473921851954d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.03261776760470214d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47505964354763996d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5536487494377093d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7101387882836673d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05034163795134272d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.49506220840681014d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.633298304648538d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.447137599885973d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4067619372613708d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.29658939112908733d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7134021071709901d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4897153412389369d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2856208180716613d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5128974417997757d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.27328046457493205d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.058114426328790825d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3567264346298359d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3923061537642991d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2830151567414233d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49782161636130473d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.428868002823262d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6765790995136443d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.25483918982724474d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8686721208290937d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4498515077761698d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.0056180860473079575d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6011956168623015d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.695441161269926d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5206938597213566d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.281116444227445d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.33708244208442373d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6201505926776274d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.810407519769224d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8509463143572412d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9445079672732668d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7434939694524778d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45232833882825396d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6631759412016828d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.35075757387214845d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9841504364643099d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2643235511902481d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.21706053141253845d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3615100332665141d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7667273563845676d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9363619358180706d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((104)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06070762565913623d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7575204694975922d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8655940074338322d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


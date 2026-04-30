

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
    Value = 0.3250494126720779d,
    ModelInner = null,
    NullableValue = 0.8058256288763236d,
},
            new Doublefloat0M
{
    Id = 8,
    Value = 0.4371563187643822d,
    ModelInner = new Doublefloat0MI
{
    Id = 1,
    Value = 0.9483141307842582d,
    NullableValue = 0.5146990329377006d,
},
    NullableValue = 0.6764456062335586d,
},
            new Doublefloat0M
{
    Id = 16,
    Value = 0.08989804716490535d,
    ModelInner = null,
    NullableValue = 0.6221825514356292d,
},
            new Doublefloat0M
{
    Id = 22,
    Value = 0.6399111602597196d,
    ModelInner = new Doublefloat0MI
{
    Id = 2,
    Value = 0.07075781393362823d,
    NullableValue = null,
},
    NullableValue = 0.7230785010120705d,
},
            new Doublefloat0M
{
    Id = 23,
    Value = 0.485312094212931d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 27,
    Value = 0.6222262247867963d,
    ModelInner = new Doublefloat0MI
{
    Id = 10,
    Value = 0.2486594371696066d,
    NullableValue = null,
},
    NullableValue = 0.5650855924522615d,
},
            new Doublefloat0M
{
    Id = 30,
    Value = 0.43553791511794016d,
    ModelInner = null,
    NullableValue = 0.32343148242111985d,
},
            new Doublefloat0M
{
    Id = 39,
    Value = 0.8180447705619877d,
    ModelInner = new Doublefloat0MI
{
    Id = 11,
    Value = 0.5962929248839598d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 45,
    Value = 0.7021827215610242d,
    ModelInner = null,
    NullableValue = 0.6984065571053032d,
},
            new Doublefloat0M
{
    Id = 48,
    Value = 0.3675686934593061d,
    ModelInner = new Doublefloat0MI
{
    Id = 13,
    Value = 0.9713253507457158d,
    NullableValue = 0.23708176231319644d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 52,
    Value = 0.728047417614527d,
    ModelInner = null,
    NullableValue = 0.4188311854657807d,
},
            new Doublefloat0M
{
    Id = 54,
    Value = 0.4230651114335182d,
    ModelInner = new Doublefloat0MI
{
    Id = 21,
    Value = 0.5622112447869243d,
    NullableValue = 0.3680405285341354d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 57,
    Value = 0.8842212492269063d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 66,
    Value = 0.7772051656803436d,
    ModelInner = new Doublefloat0MI
{
    Id = 27,
    Value = 0.7755132162044464d,
    NullableValue = 0.47622575667589107d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 73,
    Value = 0.15929543633058751d,
    ModelInner = null,
    NullableValue = 0.022472063293519584d,
},
            new Doublefloat0M
{
    Id = 82,
    Value = 0.9104852882838698d,
    ModelInner = new Doublefloat0MI
{
    Id = 35,
    Value = 0.3484285680608137d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 90,
    Value = 0.19414748103574164d,
    ModelInner = null,
    NullableValue = 0.8205975217208965d,
},
            new Doublefloat0M
{
    Id = 93,
    Value = 0.6267835282683045d,
    ModelInner = new Doublefloat0MI
{
    Id = 39,
    Value = 0.9131433696108713d,
    NullableValue = 0.6725829227630339d,
},
    NullableValue = 0.707096714966846d,
},
            new Doublefloat0M
{
    Id = 94,
    Value = 0.21995662730762866d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 102,
    Value = 0.3965476604184921d,
    ModelInner = new Doublefloat0MI
{
    Id = 41,
    Value = 0.47241733023814647d,
    NullableValue = null,
},
    NullableValue = 0.3311212460792381d,
},
            new Doublefloat0M
{
    Id = 105,
    Value = 0.38252305352822225d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 113,
    Value = 0.6859830491930892d,
    ModelInner = new Doublefloat0MI
{
    Id = 50,
    Value = 0.2635454464685074d,
    NullableValue = 0.15579237618734476d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 115,
    Value = 0.5486601922279627d,
    ModelInner = null,
    NullableValue = 0.8517809989823393d,
},
            new Doublefloat0M
{
    Id = 117,
    Value = 0.5371722783020464d,
    ModelInner = new Doublefloat0MI
{
    Id = 56,
    Value = 0.5317423655781222d,
    NullableValue = null,
},
    NullableValue = 0.2702358436879492d,
},
            new Doublefloat0M
{
    Id = 122,
    Value = 0.541277564841374d,
    ModelInner = null,
    NullableValue = 0.5777439835579846d,
},
            new Doublefloat0M
{
    Id = 127,
    Value = 0.7864939478909085d,
    ModelInner = new Doublefloat0MI
{
    Id = 63,
    Value = 0.38146618779828667d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 132,
    Value = 0.5406996713287369d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 140,
    Value = 0.04590980061333649d,
    ModelInner = new Doublefloat0MI
{
    Id = 69,
    Value = 0.93459815152819d,
    NullableValue = 0.34617600039118523d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 147,
    Value = 0.3083986956747662d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 152,
    Value = 0.40454597649180213d,
    ModelInner = new Doublefloat0MI
{
    Id = 70,
    Value = 0.3825665052931244d,
    NullableValue = null,
},
    NullableValue = 0.8712556874430814d,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 113;
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
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 93;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[29], false);
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
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doublefloat0M.AssertModel(models[0],_testData[4], false);
                        Doublefloat0M.AssertModel(models[1],_testData[5], false);
                        Doublefloat0M.AssertModel(models[2],_testData[6], false);
                        Doublefloat0M.AssertModel(models[3],_testData[7], false);
                        Doublefloat0M.AssertModel(models[4],_testData[8], false);
                        Doublefloat0M.AssertModel(models[5],_testData[9], false);
                        Doublefloat0M.AssertModel(models[6],_testData[10], false);
                        Doublefloat0M.AssertModel(models[7],_testData[11], false);
                        Doublefloat0M.AssertModel(models[8],_testData[12], false);
                        Doublefloat0M.AssertModel(models[9],_testData[13], false);
                        Doublefloat0M.AssertModel(models[10],_testData[14], false);
                        Doublefloat0M.AssertModel(models[11],_testData[15], false);
                        Doublefloat0M.AssertModel(models[12],_testData[16], false);
                        Doublefloat0M.AssertModel(models[13],_testData[17], false);
                        Doublefloat0M.AssertModel(models[14],_testData[18], false);
                        Doublefloat0M.AssertModel(models[15],_testData[19], false);
                        Doublefloat0M.AssertModel(models[16],_testData[20], false);
                        Doublefloat0M.AssertModel(models[17],_testData[21], false);
                        Doublefloat0M.AssertModel(models[18],_testData[22], false);
                        Doublefloat0M.AssertModel(models[19],_testData[23], false);
                        Doublefloat0M.AssertModel(models[20],_testData[24], false);
                        Doublefloat0M.AssertModel(models[21],_testData[25], false);
                        Doublefloat0M.AssertModel(models[22],_testData[26], false);
                        Doublefloat0M.AssertModel(models[23],_testData[27], false);
                        Doublefloat0M.AssertModel(models[24],_testData[28], false);
                        Doublefloat0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doublefloat0M.AssertModel(models[0],_testData[13], false);
                        Doublefloat0M.AssertModel(models[1],_testData[14], false);
                        Doublefloat0M.AssertModel(models[2],_testData[15], false);
                        Doublefloat0M.AssertModel(models[3],_testData[16], false);
                        Doublefloat0M.AssertModel(models[4],_testData[17], false);
                        Doublefloat0M.AssertModel(models[5],_testData[18], false);
                        Doublefloat0M.AssertModel(models[6],_testData[19], false);
                        Doublefloat0M.AssertModel(models[7],_testData[20], false);
                        Doublefloat0M.AssertModel(models[8],_testData[21], false);
                        Doublefloat0M.AssertModel(models[9],_testData[22], false);
                        Doublefloat0M.AssertModel(models[10],_testData[23], false);
                        Doublefloat0M.AssertModel(models[11],_testData[24], false);
                        Doublefloat0M.AssertModel(models[12],_testData[25], false);
                        Doublefloat0M.AssertModel(models[13],_testData[26], false);
                        Doublefloat0M.AssertModel(models[14],_testData[27], false);
                        Doublefloat0M.AssertModel(models[15],_testData[28], false);
                        Doublefloat0M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doublefloat0M.AssertModel(models[0],_testData[15], false);
                        Doublefloat0M.AssertModel(models[1],_testData[16], false);
                        Doublefloat0M.AssertModel(models[2],_testData[17], false);
                        Doublefloat0M.AssertModel(models[3],_testData[18], false);
                        Doublefloat0M.AssertModel(models[4],_testData[19], false);
                        Doublefloat0M.AssertModel(models[5],_testData[20], false);
                        Doublefloat0M.AssertModel(models[6],_testData[21], false);
                        Doublefloat0M.AssertModel(models[7],_testData[22], false);
                        Doublefloat0M.AssertModel(models[8],_testData[23], false);
                        Doublefloat0M.AssertModel(models[9],_testData[24], false);
                        Doublefloat0M.AssertModel(models[10],_testData[25], false);
                        Doublefloat0M.AssertModel(models[11],_testData[26], false);
                        Doublefloat0M.AssertModel(models[12],_testData[27], false);
                        Doublefloat0M.AssertModel(models[13],_testData[28], false);
                        Doublefloat0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doublefloat0M.AssertModel(models[0],_testData[13], false);
                        Doublefloat0M.AssertModel(models[1],_testData[14], false);
                        Doublefloat0M.AssertModel(models[2],_testData[15], false);
                        Doublefloat0M.AssertModel(models[3],_testData[16], false);
                        Doublefloat0M.AssertModel(models[4],_testData[17], false);
                        Doublefloat0M.AssertModel(models[5],_testData[18], false);
                        Doublefloat0M.AssertModel(models[6],_testData[19], false);
                        Doublefloat0M.AssertModel(models[7],_testData[20], false);
                        Doublefloat0M.AssertModel(models[8],_testData[21], false);
                        Doublefloat0M.AssertModel(models[9],_testData[22], false);
                        Doublefloat0M.AssertModel(models[10],_testData[23], false);
                        Doublefloat0M.AssertModel(models[11],_testData[24], false);
                        Doublefloat0M.AssertModel(models[12],_testData[25], false);
                        Doublefloat0M.AssertModel(models[13],_testData[26], false);
                        Doublefloat0M.AssertModel(models[14],_testData[27], false);
                        Doublefloat0M.AssertModel(models[15],_testData[28], false);
                        Doublefloat0M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[29], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 57, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[29], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[29], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[29], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 113, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doublefloat0M.AssertModel(models[0],_testData[22], false);
                        Doublefloat0M.AssertModel(models[1],_testData[23], false);
                        Doublefloat0M.AssertModel(models[2],_testData[24], false);
                        Doublefloat0M.AssertModel(models[3],_testData[25], false);
                        Doublefloat0M.AssertModel(models[4],_testData[26], false);
                        Doublefloat0M.AssertModel(models[5],_testData[27], false);
                        Doublefloat0M.AssertModel(models[6],_testData[28], false);
                        Doublefloat0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doublefloat0M.AssertModel(models[0],_testData[9], false);
                        Doublefloat0M.AssertModel(models[1],_testData[10], false);
                        Doublefloat0M.AssertModel(models[2],_testData[11], false);
                        Doublefloat0M.AssertModel(models[3],_testData[12], false);
                        Doublefloat0M.AssertModel(models[4],_testData[13], false);
                        Doublefloat0M.AssertModel(models[5],_testData[14], false);
                        Doublefloat0M.AssertModel(models[6],_testData[15], false);
                        Doublefloat0M.AssertModel(models[7],_testData[16], false);
                        Doublefloat0M.AssertModel(models[8],_testData[17], false);
                        Doublefloat0M.AssertModel(models[9],_testData[18], false);
                        Doublefloat0M.AssertModel(models[10],_testData[19], false);
                        Doublefloat0M.AssertModel(models[11],_testData[20], false);
                        Doublefloat0M.AssertModel(models[12],_testData[21], false);
                        Doublefloat0M.AssertModel(models[13],_testData[22], false);
                        Doublefloat0M.AssertModel(models[14],_testData[23], false);
                        Doublefloat0M.AssertModel(models[15],_testData[24], false);
                        Doublefloat0M.AssertModel(models[16],_testData[25], false);
                        Doublefloat0M.AssertModel(models[17],_testData[26], false);
                        Doublefloat0M.AssertModel(models[18],_testData[27], false);
                        Doublefloat0M.AssertModel(models[19],_testData[28], false);
                        Doublefloat0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 73, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doublefloat0M.AssertModel(models[0],_testData[15], false);
                        Doublefloat0M.AssertModel(models[1],_testData[16], false);
                        Doublefloat0M.AssertModel(models[2],_testData[17], false);
                        Doublefloat0M.AssertModel(models[3],_testData[18], false);
                        Doublefloat0M.AssertModel(models[4],_testData[19], false);
                        Doublefloat0M.AssertModel(models[5],_testData[20], false);
                        Doublefloat0M.AssertModel(models[6],_testData[21], false);
                        Doublefloat0M.AssertModel(models[7],_testData[22], false);
                        Doublefloat0M.AssertModel(models[8],_testData[23], false);
                        Doublefloat0M.AssertModel(models[9],_testData[24], false);
                        Doublefloat0M.AssertModel(models[10],_testData[25], false);
                        Doublefloat0M.AssertModel(models[11],_testData[26], false);
                        Doublefloat0M.AssertModel(models[12],_testData[27], false);
                        Doublefloat0M.AssertModel(models[13],_testData[28], false);
                        Doublefloat0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doublefloat0M.AssertModel(models[0],_testData[9], false);
                        Doublefloat0M.AssertModel(models[1],_testData[10], false);
                        Doublefloat0M.AssertModel(models[2],_testData[11], false);
                        Doublefloat0M.AssertModel(models[3],_testData[12], false);
                        Doublefloat0M.AssertModel(models[4],_testData[13], false);
                        Doublefloat0M.AssertModel(models[5],_testData[14], false);
                        Doublefloat0M.AssertModel(models[6],_testData[15], false);
                        Doublefloat0M.AssertModel(models[7],_testData[16], false);
                        Doublefloat0M.AssertModel(models[8],_testData[17], false);
                        Doublefloat0M.AssertModel(models[9],_testData[18], false);
                        Doublefloat0M.AssertModel(models[10],_testData[19], false);
                        Doublefloat0M.AssertModel(models[11],_testData[20], false);
                        Doublefloat0M.AssertModel(models[12],_testData[21], false);
                        Doublefloat0M.AssertModel(models[13],_testData[22], false);
                        Doublefloat0M.AssertModel(models[14],_testData[23], false);
                        Doublefloat0M.AssertModel(models[15],_testData[24], false);
                        Doublefloat0M.AssertModel(models[16],_testData[25], false);
                        Doublefloat0M.AssertModel(models[17],_testData[26], false);
                        Doublefloat0M.AssertModel(models[18],_testData[27], false);
                        Doublefloat0M.AssertModel(models[19],_testData[28], false);
                        Doublefloat0M.AssertModel(models[20],_testData[29], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Doublefloat0M.AssertModel(models[0],_testData[28], false);Doublefloat0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Doublefloat0M.AssertModel(models[0],_testData[27], false);Doublefloat0M.AssertModel(models[1],_testData[28], false);Doublefloat0M.AssertModel(models[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3250494126720779d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8058256288763236d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4371563187643822d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9483141307842582d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5146990329377006d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6764456062335586d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08989804716490535d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6221825514356292d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6399111602597196d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07075781393362823d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7230785010120705d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.485312094212931d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6222262247867963d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2486594371696066d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5650855924522615d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43553791511794016d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32343148242111985d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8180447705619877d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5962929248839598d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7021827215610242d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6984065571053032d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3675686934593061d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9713253507457158d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.23708176231319644d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.728047417614527d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4188311854657807d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4230651114335182d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5622112447869243d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3680405285341354d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8842212492269063d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7772051656803436d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7755132162044464d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.47622575667589107d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15929543633058751d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.022472063293519584d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9104852882838698d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3484285680608137d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19414748103574164d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8205975217208965d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6267835282683045d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9131433696108713d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6725829227630339d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.707096714966846d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21995662730762866d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3965476604184921d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.47241733023814647d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3311212460792381d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.38252305352822225d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6859830491930892d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2635454464685074d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15579237618734476d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5486601922279627d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8517809989823393d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5371722783020464d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5317423655781222d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2702358436879492d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.541277564841374d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5777439835579846d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7864939478909085d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.38146618779828667d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5406996713287369d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.04590980061333649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.93459815152819d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.34617600039118523d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3083986956747662d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40454597649180213d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3825665052931244d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8712556874430814d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3250494126720779d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8058256288763236d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4371563187643822d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9483141307842582d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5146990329377006d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6764456062335586d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08989804716490535d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6221825514356292d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6399111602597196d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07075781393362823d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7230785010120705d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.485312094212931d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6222262247867963d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2486594371696066d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5650855924522615d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43553791511794016d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32343148242111985d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8180447705619877d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5962929248839598d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7021827215610242d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6984065571053032d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3675686934593061d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9713253507457158d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.23708176231319644d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.728047417614527d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4188311854657807d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4230651114335182d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5622112447869243d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3680405285341354d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8842212492269063d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7772051656803436d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7755132162044464d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.47622575667589107d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15929543633058751d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.022472063293519584d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9104852882838698d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3484285680608137d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19414748103574164d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8205975217208965d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6267835282683045d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9131433696108713d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6725829227630339d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.707096714966846d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21995662730762866d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3965476604184921d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.47241733023814647d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3311212460792381d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.38252305352822225d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6859830491930892d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2635454464685074d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15579237618734476d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5486601922279627d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8517809989823393d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5371722783020464d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5317423655781222d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2702358436879492d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.541277564841374d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5777439835579846d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7864939478909085d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.38146618779828667d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5406996713287369d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.04590980061333649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.93459815152819d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.34617600039118523d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3083986956747662d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40454597649180213d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3825665052931244d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8712556874430814d)));

            }
        }

#endregion

    }
}


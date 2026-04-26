

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
    Id = 9,
    Value = 0.43991026027880653d,
    ModelInner = null,
    NullableValue = 0.20186006599955364d,
},
            new Doublefloat0M
{
    Id = 10,
    Value = 0.5712570158379908d,
    ModelInner = new Doublefloat0MI
{
    Id = 5,
    Value = 0.7681727660767752d,
    NullableValue = 0.611731994951593d,
},
    NullableValue = 0.8300338361647598d,
},
            new Doublefloat0M
{
    Id = 13,
    Value = 0.10305172256074102d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 19,
    Value = 0.07245431771604016d,
    ModelInner = new Doublefloat0MI
{
    Id = 9,
    Value = 0.08693400145658248d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 20,
    Value = 0.338223836609859d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 24,
    Value = 0.7928819884742517d,
    ModelInner = new Doublefloat0MI
{
    Id = 18,
    Value = 0.8553447498591549d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 25,
    Value = 0.36531314692671524d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 29,
    Value = 0.1619708339197109d,
    ModelInner = new Doublefloat0MI
{
    Id = 26,
    Value = 0.8083938696428252d,
    NullableValue = 0.2376456142969512d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 38,
    Value = 0.504051742492556d,
    ModelInner = null,
    NullableValue = 0.2972376543276224d,
},
            new Doublefloat0M
{
    Id = 44,
    Value = 0.40197632629194857d,
    ModelInner = new Doublefloat0MI
{
    Id = 34,
    Value = 0.8948491005147632d,
    NullableValue = null,
},
    NullableValue = 0.6002967299471985d,
},
            new Doublefloat0M
{
    Id = 53,
    Value = 0.009302237224867449d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 62,
    Value = 0.8631249420806897d,
    ModelInner = new Doublefloat0MI
{
    Id = 37,
    Value = 0.20493569855451055d,
    NullableValue = null,
},
    NullableValue = 0.16704454334367536d,
},
            new Doublefloat0M
{
    Id = 64,
    Value = 0.23293609678309657d,
    ModelInner = null,
    NullableValue = 0.2579146520905047d,
},
            new Doublefloat0M
{
    Id = 66,
    Value = 0.3259010799231028d,
    ModelInner = new Doublefloat0MI
{
    Id = 40,
    Value = 0.5706230579624534d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 72,
    Value = 0.7942753748064659d,
    ModelInner = null,
    NullableValue = 0.4479279418503125d,
},
            new Doublefloat0M
{
    Id = 79,
    Value = 0.2028931112287613d,
    ModelInner = new Doublefloat0MI
{
    Id = 49,
    Value = 0.22583267146255215d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 82,
    Value = 0.9286189301548204d,
    ModelInner = null,
    NullableValue = 0.8887187398726283d,
},
            new Doublefloat0M
{
    Id = 84,
    Value = 0.7451842036699718d,
    ModelInner = new Doublefloat0MI
{
    Id = 50,
    Value = 0.30335057443684876d,
    NullableValue = 0.8114567387487897d,
},
    NullableValue = 0.8283173547976265d,
},
            new Doublefloat0M
{
    Id = 89,
    Value = 0.4678410504701018d,
    ModelInner = null,
    NullableValue = 0.08562645348614217d,
},
            new Doublefloat0M
{
    Id = 95,
    Value = 0.2710586926836537d,
    ModelInner = new Doublefloat0MI
{
    Id = 55,
    Value = 0.1739046963459674d,
    NullableValue = 0.458207104954637d,
},
    NullableValue = 0.17445133737755514d,
},
            new Doublefloat0M
{
    Id = 97,
    Value = 0.17106229314004007d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 104,
    Value = 0.5898007371441223d,
    ModelInner = new Doublefloat0MI
{
    Id = 63,
    Value = 0.43127820433969666d,
    NullableValue = 0.3633959727213252d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 109,
    Value = 0.6106223095683392d,
    ModelInner = null,
    NullableValue = 0.9333190639114474d,
},
            new Doublefloat0M
{
    Id = 115,
    Value = 0.6879288230176425d,
    ModelInner = new Doublefloat0MI
{
    Id = 64,
    Value = 0.6802025127158114d,
    NullableValue = 0.5122925792527097d,
},
    NullableValue = 0.4007632455103449d,
},
            new Doublefloat0M
{
    Id = 117,
    Value = 0.9542091285654414d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 121,
    Value = 0.2554211002157718d,
    ModelInner = new Doublefloat0MI
{
    Id = 71,
    Value = 0.3451481952134896d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 129,
    Value = 0.4356364916063069d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 130,
    Value = 0.05632179646846236d,
    ModelInner = new Doublefloat0MI
{
    Id = 73,
    Value = 0.6618997144759701d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 133,
    Value = 0.4757762355929612d,
    ModelInner = null,
    NullableValue = 0.2672332807815784d,
},
            new Doublefloat0M
{
    Id = 135,
    Value = 0.27191156642826475d,
    ModelInner = new Doublefloat0MI
{
    Id = 77,
    Value = 0.4291414251554335d,
    NullableValue = null,
},
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(6))
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(6),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doublefloat0M.AssertModel(models[0],_testData[17], false);
                        Doublefloat0M.AssertModel(models[1],_testData[18], false);
                        Doublefloat0M.AssertModel(models[2],_testData[19], false);
                        Doublefloat0M.AssertModel(models[3],_testData[20], false);
                        Doublefloat0M.AssertModel(models[4],_testData[21], false);
                        Doublefloat0M.AssertModel(models[5],_testData[22], false);
                        Doublefloat0M.AssertModel(models[6],_testData[23], false);
                        Doublefloat0M.AssertModel(models[7],_testData[24], false);
                        Doublefloat0M.AssertModel(models[8],_testData[25], false);
                        Doublefloat0M.AssertModel(models[9],_testData[26], false);
                        Doublefloat0M.AssertModel(models[10],_testData[27], false);
                        Doublefloat0M.AssertModel(models[11],_testData[28], false);
                        Doublefloat0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(29));

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
                int resultIndex = 0;
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 115, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 115, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 24, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 121, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[30], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 84, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doublefloat0M.AssertModel(models[0],_testData[18], false);
                        Doublefloat0M.AssertModel(models[1],_testData[19], false);
                        Doublefloat0M.AssertModel(models[2],_testData[20], false);
                        Doublefloat0M.AssertModel(models[3],_testData[21], false);
                        Doublefloat0M.AssertModel(models[4],_testData[22], false);
                        Doublefloat0M.AssertModel(models[5],_testData[23], false);
                        Doublefloat0M.AssertModel(models[6],_testData[24], false);
                        Doublefloat0M.AssertModel(models[7],_testData[25], false);
                        Doublefloat0M.AssertModel(models[8],_testData[26], false);
                        Doublefloat0M.AssertModel(models[9],_testData[27], false);
                        Doublefloat0M.AssertModel(models[10],_testData[28], false);
                        Doublefloat0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doublefloat0M.AssertModel(models[0],_testData[10], false);
                        Doublefloat0M.AssertModel(models[1],_testData[11], false);
                        Doublefloat0M.AssertModel(models[2],_testData[12], false);
                        Doublefloat0M.AssertModel(models[3],_testData[13], false);
                        Doublefloat0M.AssertModel(models[4],_testData[14], false);
                        Doublefloat0M.AssertModel(models[5],_testData[15], false);
                        Doublefloat0M.AssertModel(models[6],_testData[16], false);
                        Doublefloat0M.AssertModel(models[7],_testData[17], false);
                        Doublefloat0M.AssertModel(models[8],_testData[18], false);
                        Doublefloat0M.AssertModel(models[9],_testData[19], false);
                        Doublefloat0M.AssertModel(models[10],_testData[20], false);
                        Doublefloat0M.AssertModel(models[11],_testData[21], false);
                        Doublefloat0M.AssertModel(models[12],_testData[22], false);
                        Doublefloat0M.AssertModel(models[13],_testData[23], false);
                        Doublefloat0M.AssertModel(models[14],_testData[24], false);
                        Doublefloat0M.AssertModel(models[15],_testData[25], false);
                        Doublefloat0M.AssertModel(models[16],_testData[26], false);
                        Doublefloat0M.AssertModel(models[17],_testData[27], false);
                        Doublefloat0M.AssertModel(models[18],_testData[28], false);
                        Doublefloat0M.AssertModel(models[19],_testData[29], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 19, 121))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doublefloat0M.AssertModel(models[0],_testData[26], false);
                        Doublefloat0M.AssertModel(models[1],_testData[27], false);
                        Doublefloat0M.AssertModel(models[2],_testData[28], false);
                        Doublefloat0M.AssertModel(models[3],_testData[29], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Doublefloat0M.AssertModel(models[0],_testData[7], false);Doublefloat0M.AssertModel(models[1],_testData[8], false);Doublefloat0M.AssertModel(models[2],_testData[9], false);Doublefloat0M.AssertModel(models[3],_testData[10], false);Doublefloat0M.AssertModel(models[4],_testData[11], false);Doublefloat0M.AssertModel(models[5],_testData[12], false);Doublefloat0M.AssertModel(models[6],_testData[13], false);Doublefloat0M.AssertModel(models[7],_testData[14], false);Doublefloat0M.AssertModel(models[8],_testData[15], false);Doublefloat0M.AssertModel(models[9],_testData[16], false);Doublefloat0M.AssertModel(models[10],_testData[17], false);Doublefloat0M.AssertModel(models[11],_testData[18], false);Doublefloat0M.AssertModel(models[12],_testData[19], false);Doublefloat0M.AssertModel(models[13],_testData[20], false);Doublefloat0M.AssertModel(models[14],_testData[21], false);Doublefloat0M.AssertModel(models[15],_testData[22], false);Doublefloat0M.AssertModel(models[16],_testData[23], false);Doublefloat0M.AssertModel(models[17],_testData[24], false);Doublefloat0M.AssertModel(models[18],_testData[25], false);Doublefloat0M.AssertModel(models[19],_testData[26], false);Doublefloat0M.AssertModel(models[20],_testData[27], false);Doublefloat0M.AssertModel(models[21],_testData[28], false);Doublefloat0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Doublefloat0M.AssertModel(models[0],_testData[18], false);Doublefloat0M.AssertModel(models[1],_testData[19], false);Doublefloat0M.AssertModel(models[2],_testData[20], false);Doublefloat0M.AssertModel(models[3],_testData[21], false);Doublefloat0M.AssertModel(models[4],_testData[22], false);Doublefloat0M.AssertModel(models[5],_testData[23], false);Doublefloat0M.AssertModel(models[6],_testData[24], false);Doublefloat0M.AssertModel(models[7],_testData[25], false);Doublefloat0M.AssertModel(models[8],_testData[26], false);Doublefloat0M.AssertModel(models[9],_testData[27], false);Doublefloat0M.AssertModel(models[10],_testData[28], false);Doublefloat0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43991026027880653d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.20186006599955364d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5712570158379908d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7681727660767752d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.611731994951593d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8300338361647598d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10305172256074102d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07245431771604016d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08693400145658248d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.338223836609859d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7928819884742517d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8553447498591549d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36531314692671524d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1619708339197109d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8083938696428252d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2376456142969512d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.504051742492556d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2972376543276224d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40197632629194857d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8948491005147632d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6002967299471985d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.009302237224867449d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8631249420806897d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.20493569855451055d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16704454334367536d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23293609678309657d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2579146520905047d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3259010799231028d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5706230579624534d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7942753748064659d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4479279418503125d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2028931112287613d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.22583267146255215d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9286189301548204d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8887187398726283d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7451842036699718d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.30335057443684876d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8114567387487897d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8283173547976265d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4678410504701018d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.08562645348614217d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2710586926836537d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1739046963459674d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.458207104954637d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.17445133737755514d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17106229314004007d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5898007371441223d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.43127820433969666d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3633959727213252d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6106223095683392d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9333190639114474d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6879288230176425d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6802025127158114d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5122925792527097d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4007632455103449d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9542091285654414d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2554211002157718d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3451481952134896d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4356364916063069d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05632179646846236d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6618997144759701d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4757762355929612d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2672332807815784d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27191156642826475d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4291414251554335d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43991026027880653d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.20186006599955364d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5712570158379908d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7681727660767752d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.611731994951593d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8300338361647598d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10305172256074102d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07245431771604016d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08693400145658248d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.338223836609859d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7928819884742517d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8553447498591549d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36531314692671524d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1619708339197109d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8083938696428252d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2376456142969512d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.504051742492556d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2972376543276224d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40197632629194857d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8948491005147632d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6002967299471985d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.009302237224867449d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8631249420806897d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.20493569855451055d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16704454334367536d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23293609678309657d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2579146520905047d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3259010799231028d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5706230579624534d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7942753748064659d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4479279418503125d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2028931112287613d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.22583267146255215d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9286189301548204d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8887187398726283d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7451842036699718d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.30335057443684876d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8114567387487897d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8283173547976265d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4678410504701018d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.08562645348614217d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2710586926836537d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1739046963459674d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.458207104954637d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.17445133737755514d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17106229314004007d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5898007371441223d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.43127820433969666d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3633959727213252d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6106223095683392d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9333190639114474d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6879288230176425d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6802025127158114d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5122925792527097d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4007632455103449d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9542091285654414d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2554211002157718d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3451481952134896d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4356364916063069d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05632179646846236d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6618997144759701d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4757762355929612d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2672332807815784d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27191156642826475d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4291414251554335d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}




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
    internal partial interface ISingleSingleTypereal
    {
    }
    
    internal partial class SingleSingleTypereal : ISingleSingleTypereal
    {


#region TestData

        private readonly SinglerealE0M[] _testData = new SinglerealE0M[]
        {
            new SinglerealE0M
{
    Id = 4,
    Value = 0.8640857f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 6,
    Value = 0.06729275f,
    ModelInner = new SinglerealE0MI
{
    Id = 4,
    Value = 0.9949629f,
    NullableValue = 0.36931723f,
},
    NullableValue = 0.41898668f,
},
            new SinglerealE0M
{
    Id = 12,
    Value = 0.34189653f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 20,
    Value = 0.2688657f,
    ModelInner = new SinglerealE0MI
{
    Id = 13,
    Value = 0.5937731f,
    NullableValue = 0.66306543f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 24,
    Value = 0.03314346f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 27,
    Value = 0.08426231f,
    ModelInner = new SinglerealE0MI
{
    Id = 15,
    Value = 0.10595763f,
    NullableValue = 0.5994637f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 29,
    Value = 0.62634325f,
    ModelInner = null,
    NullableValue = 0.8051458f,
},
            new SinglerealE0M
{
    Id = 30,
    Value = 0.2884124f,
    ModelInner = new SinglerealE0MI
{
    Id = 16,
    Value = 0.56800747f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 37,
    Value = 0.281626f,
    ModelInner = null,
    NullableValue = 0.6440158f,
},
            new SinglerealE0M
{
    Id = 45,
    Value = 0.51519275f,
    ModelInner = new SinglerealE0MI
{
    Id = 21,
    Value = 0.5759473f,
    NullableValue = 0.97180426f,
},
    NullableValue = 0.17044532f,
},
            new SinglerealE0M
{
    Id = 53,
    Value = 0.669005f,
    ModelInner = null,
    NullableValue = 0.94520473f,
},
            new SinglerealE0M
{
    Id = 62,
    Value = 0.13834184f,
    ModelInner = new SinglerealE0MI
{
    Id = 25,
    Value = 0.2671088f,
    NullableValue = 0.58361346f,
},
    NullableValue = 0.07338959f,
},
            new SinglerealE0M
{
    Id = 64,
    Value = 0.8334889f,
    ModelInner = null,
    NullableValue = 0.38203222f,
},
            new SinglerealE0M
{
    Id = 66,
    Value = 0.8045831f,
    ModelInner = new SinglerealE0MI
{
    Id = 29,
    Value = 0.39054692f,
    NullableValue = null,
},
    NullableValue = 0.12501186f,
},
            new SinglerealE0M
{
    Id = 72,
    Value = 0.4246385f,
    ModelInner = null,
    NullableValue = 0.28794962f,
},
            new SinglerealE0M
{
    Id = 81,
    Value = 0.374035f,
    ModelInner = new SinglerealE0MI
{
    Id = 31,
    Value = 0.33093548f,
    NullableValue = 0.9907802f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 89,
    Value = 0.46991056f,
    ModelInner = null,
    NullableValue = 0.5842469f,
},
            new SinglerealE0M
{
    Id = 96,
    Value = 0.233603f,
    ModelInner = new SinglerealE0MI
{
    Id = 38,
    Value = 0.707056f,
    NullableValue = null,
},
    NullableValue = 0.29106772f,
},
            new SinglerealE0M
{
    Id = 97,
    Value = 0.2014795f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 102,
    Value = 0.5049812f,
    ModelInner = new SinglerealE0MI
{
    Id = 46,
    Value = 0.21931356f,
    NullableValue = 0.08521724f,
},
    NullableValue = 0.36951375f,
},
            new SinglerealE0M
{
    Id = 104,
    Value = 0.0065294504f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 108,
    Value = 0.15929013f,
    ModelInner = new SinglerealE0MI
{
    Id = 54,
    Value = 0.8555534f,
    NullableValue = 0.13455123f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 112,
    Value = 0.6098638f,
    ModelInner = null,
    NullableValue = 0.69646394f,
},
            new SinglerealE0M
{
    Id = 116,
    Value = 0.5667826f,
    ModelInner = new SinglerealE0MI
{
    Id = 58,
    Value = 0.34362584f,
    NullableValue = 0.5690013f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 117,
    Value = 0.48667914f,
    ModelInner = null,
    NullableValue = 0.42946416f,
},
            new SinglerealE0M
{
    Id = 123,
    Value = 0.52249974f,
    ModelInner = new SinglerealE0MI
{
    Id = 59,
    Value = 0.7887537f,
    NullableValue = 0.6223958f,
},
    NullableValue = 0.793086f,
},
            new SinglerealE0M
{
    Id = 125,
    Value = 0.65931064f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 130,
    Value = 0.75599694f,
    ModelInner = new SinglerealE0MI
{
    Id = 61,
    Value = 0.8275061f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 138,
    Value = 0.3746224f,
    ModelInner = null,
    NullableValue = 0.29212135f,
},
            new SinglerealE0M
{
    Id = 140,
    Value = 0.71872294f,
    ModelInner = new SinglerealE0MI
{
    Id = 67,
    Value = 0.9345877f,
    NullableValue = 0.5572674f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 142,
    Value = 0.11047059f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 148,
    Value = 0.66265345f,
    ModelInner = new SinglerealE0MI
{
    Id = 74,
    Value = 0.7016124f,
    NullableValue = null,
},
    NullableValue = 0.5489903f,
},
            new SinglerealE0M
{
    Id = 157,
    Value = 0.102827966f,
    ModelInner = null,
    NullableValue = 0.98705596f,
},
            new SinglerealE0M
{
    Id = 160,
    Value = 0.6598185f,
    ModelInner = new SinglerealE0MI
{
    Id = 83,
    Value = 0.3759722f,
    NullableValue = null,
},
    NullableValue = 0.6208914f,
},
            new SinglerealE0M
{
    Id = 168,
    Value = 0.7237207f,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereale0mi(
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
            asPartInterface: typeof(ISingleSingleTypereal)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(13)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(13))
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereale0mi(
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
            asPartInterface: typeof(ISingleSingleTypereal)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)15),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)15, 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereale0m(
	id,
    value,
    nullablevalue,
    singlereale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereale0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(13)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(13),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlereale0mi_id", 
                methodParametrName: "singlereale0mi_id", 
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereale0m(
	id,
    value,
    nullablevalue,
    singlereale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereale0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Single), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)15),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)15,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlereale0mi_id", 
                methodParametrName: "singlereale0mi_id", 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealE0M), typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                await((ISingleSingleTypereal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                ((ISingleSingleTypereal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((ISingleSingleTypereal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((ISingleSingleTypereal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereale0m m
LEFT JOIN dbo.singlereale0mi mi ON mi.id = m.singlereale0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await((ISingleSingleTypereal)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleSingleTypereal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealE0M), typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                await((ISingleSingleTypereal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                ((ISingleSingleTypereal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypereal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypereal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereale0m m
LEFT JOIN dbo.singlereale0mi mi ON mi.id = m.singlereale0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await((ISingleSingleTypereal)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleSingleTypereal)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealE0M), typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                await((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[24],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[25],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[26],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[27],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[28],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.singlereale0m m
LEFT JOIN dbo.singlereale0mi mi ON mi.id = m.singlereale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await((ISingleSingleTypereal)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealE0M.AssertModel(models[0],_testData[13], false);
                        SinglerealE0M.AssertModel(models[1],_testData[14], false);
                        SinglerealE0M.AssertModel(models[2],_testData[15], false);
                        SinglerealE0M.AssertModel(models[3],_testData[16], false);
                        SinglerealE0M.AssertModel(models[4],_testData[17], false);
                        SinglerealE0M.AssertModel(models[5],_testData[18], false);
                        SinglerealE0M.AssertModel(models[6],_testData[19], false);
                        SinglerealE0M.AssertModel(models[7],_testData[20], false);
                        SinglerealE0M.AssertModel(models[8],_testData[21], false);
                        SinglerealE0M.AssertModel(models[9],_testData[22], false);
                        SinglerealE0M.AssertModel(models[10],_testData[23], false);
                        SinglerealE0M.AssertModel(models[11],_testData[24], false);
                        SinglerealE0M.AssertModel(models[12],_testData[25], false);
                        SinglerealE0M.AssertModel(models[13],_testData[26], false);
                        SinglerealE0M.AssertModel(models[14],_testData[27], false);
                        SinglerealE0M.AssertModel(models[15],_testData[28], false);
                        SinglerealE0M.AssertModel(models[16],_testData[29], false);
                        SinglerealE0M.AssertModel(models[17],_testData[30], false);
                        SinglerealE0M.AssertModel(models[18],_testData[31], false);
                        SinglerealE0M.AssertModel(models[19],_testData[32], false);
                        SinglerealE0M.AssertModel(models[20],_testData[33], false);
                        SinglerealE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SinglerealE0M.AssertModel(models[0],_testData[12], false);
                        SinglerealE0M.AssertModel(models[1],_testData[13], false);
                        SinglerealE0M.AssertModel(models[2],_testData[14], false);
                        SinglerealE0M.AssertModel(models[3],_testData[15], false);
                        SinglerealE0M.AssertModel(models[4],_testData[16], false);
                        SinglerealE0M.AssertModel(models[5],_testData[17], false);
                        SinglerealE0M.AssertModel(models[6],_testData[18], false);
                        SinglerealE0M.AssertModel(models[7],_testData[19], false);
                        SinglerealE0M.AssertModel(models[8],_testData[20], false);
                        SinglerealE0M.AssertModel(models[9],_testData[21], false);
                        SinglerealE0M.AssertModel(models[10],_testData[22], false);
                        SinglerealE0M.AssertModel(models[11],_testData[23], false);
                        SinglerealE0M.AssertModel(models[12],_testData[24], false);
                        SinglerealE0M.AssertModel(models[13],_testData[25], false);
                        SinglerealE0M.AssertModel(models[14],_testData[26], false);
                        SinglerealE0M.AssertModel(models[15],_testData[27], false);
                        SinglerealE0M.AssertModel(models[16],_testData[28], false);
                        SinglerealE0M.AssertModel(models[17],_testData[29], false);
                        SinglerealE0M.AssertModel(models[18],_testData[30], false);
                        SinglerealE0M.AssertModel(models[19],_testData[31], false);
                        SinglerealE0M.AssertModel(models[20],_testData[32], false);
                        SinglerealE0M.AssertModel(models[21],_testData[33], false);
                        SinglerealE0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((ISingleSingleTypereal)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        SinglerealE0M.AssertModel(models[0],_testData[2], false);
                        SinglerealE0M.AssertModel(models[1],_testData[3], false);
                        SinglerealE0M.AssertModel(models[2],_testData[4], false);
                        SinglerealE0M.AssertModel(models[3],_testData[5], false);
                        SinglerealE0M.AssertModel(models[4],_testData[6], false);
                        SinglerealE0M.AssertModel(models[5],_testData[7], false);
                        SinglerealE0M.AssertModel(models[6],_testData[8], false);
                        SinglerealE0M.AssertModel(models[7],_testData[9], false);
                        SinglerealE0M.AssertModel(models[8],_testData[10], false);
                        SinglerealE0M.AssertModel(models[9],_testData[11], false);
                        SinglerealE0M.AssertModel(models[10],_testData[12], false);
                        SinglerealE0M.AssertModel(models[11],_testData[13], false);
                        SinglerealE0M.AssertModel(models[12],_testData[14], false);
                        SinglerealE0M.AssertModel(models[13],_testData[15], false);
                        SinglerealE0M.AssertModel(models[14],_testData[16], false);
                        SinglerealE0M.AssertModel(models[15],_testData[17], false);
                        SinglerealE0M.AssertModel(models[16],_testData[18], false);
                        SinglerealE0M.AssertModel(models[17],_testData[19], false);
                        SinglerealE0M.AssertModel(models[18],_testData[20], false);
                        SinglerealE0M.AssertModel(models[19],_testData[21], false);
                        SinglerealE0M.AssertModel(models[20],_testData[22], false);
                        SinglerealE0M.AssertModel(models[21],_testData[23], false);
                        SinglerealE0M.AssertModel(models[22],_testData[24], false);
                        SinglerealE0M.AssertModel(models[23],_testData[25], false);
                        SinglerealE0M.AssertModel(models[24],_testData[26], false);
                        SinglerealE0M.AssertModel(models[25],_testData[27], false);
                        SinglerealE0M.AssertModel(models[26],_testData[28], false);
                        SinglerealE0M.AssertModel(models[27],_testData[29], false);
                        SinglerealE0M.AssertModel(models[28],_testData[30], false);
                        SinglerealE0M.AssertModel(models[29],_testData[31], false);
                        SinglerealE0M.AssertModel(models[30],_testData[32], false);
                        SinglerealE0M.AssertModel(models[31],_testData[33], false);
                        SinglerealE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealE0M.AssertModel(models[0],_testData[23], false);
                        SinglerealE0M.AssertModel(models[1],_testData[24], false);
                        SinglerealE0M.AssertModel(models[2],_testData[25], false);
                        SinglerealE0M.AssertModel(models[3],_testData[26], false);
                        SinglerealE0M.AssertModel(models[4],_testData[27], false);
                        SinglerealE0M.AssertModel(models[5],_testData[28], false);
                        SinglerealE0M.AssertModel(models[6],_testData[29], false);
                        SinglerealE0M.AssertModel(models[7],_testData[30], false);
                        SinglerealE0M.AssertModel(models[8],_testData[31], false);
                        SinglerealE0M.AssertModel(models[9],_testData[32], false);
                        SinglerealE0M.AssertModel(models[10],_testData[33], false);
                        SinglerealE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealE0M), typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                await((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealE0M>();
                var models2 = new List<FlatSinglerealE0M>();
                ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 89, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var firstItems2 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 6, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 116, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[26],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[27],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[28],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[29],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[30],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[31],_testData[34], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 64, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 6, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[2], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[23],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[24],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[25],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[26],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[27],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[28],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[29],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[30],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[31],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[23],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[24],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[25],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[26],_testData[34], false);
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
FROM dbo.singlereale0m m
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
FROM dbo.singlereale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealE0M>();
                var secondItems1 = new List<FlatSinglerealE0M>();
                var secondItems2 = new List<FlatSinglerealE0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 96, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM dbo.singlereale0m m
LEFT JOIN dbo.singlereale0mi mi ON mi.id = m.singlereale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await((ISingleSingleTypereal)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 108, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SinglerealE0M.AssertModel(models[0],_testData[22], false);
                        SinglerealE0M.AssertModel(models[1],_testData[23], false);
                        SinglerealE0M.AssertModel(models[2],_testData[24], false);
                        SinglerealE0M.AssertModel(models[3],_testData[25], false);
                        SinglerealE0M.AssertModel(models[4],_testData[26], false);
                        SinglerealE0M.AssertModel(models[5],_testData[27], false);
                        SinglerealE0M.AssertModel(models[6],_testData[28], false);
                        SinglerealE0M.AssertModel(models[7],_testData[29], false);
                        SinglerealE0M.AssertModel(models[8],_testData[30], false);
                        SinglerealE0M.AssertModel(models[9],_testData[31], false);
                        SinglerealE0M.AssertModel(models[10],_testData[32], false);
                        SinglerealE0M.AssertModel(models[11],_testData[33], false);
                        SinglerealE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealE0M.AssertModel(models[0],_testData[15], false);
                        SinglerealE0M.AssertModel(models[1],_testData[16], false);
                        SinglerealE0M.AssertModel(models[2],_testData[17], false);
                        SinglerealE0M.AssertModel(models[3],_testData[18], false);
                        SinglerealE0M.AssertModel(models[4],_testData[19], false);
                        SinglerealE0M.AssertModel(models[5],_testData[20], false);
                        SinglerealE0M.AssertModel(models[6],_testData[21], false);
                        SinglerealE0M.AssertModel(models[7],_testData[22], false);
                        SinglerealE0M.AssertModel(models[8],_testData[23], false);
                        SinglerealE0M.AssertModel(models[9],_testData[24], false);
                        SinglerealE0M.AssertModel(models[10],_testData[25], false);
                        SinglerealE0M.AssertModel(models[11],_testData[26], false);
                        SinglerealE0M.AssertModel(models[12],_testData[27], false);
                        SinglerealE0M.AssertModel(models[13],_testData[28], false);
                        SinglerealE0M.AssertModel(models[14],_testData[29], false);
                        SinglerealE0M.AssertModel(models[15],_testData[30], false);
                        SinglerealE0M.AssertModel(models[16],_testData[31], false);
                        SinglerealE0M.AssertModel(models[17],_testData[32], false);
                        SinglerealE0M.AssertModel(models[18],_testData[33], false);
                        SinglerealE0M.AssertModel(models[19],_testData[34], false);
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
                var models = ((ISingleSingleTypereal)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 12, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SinglerealE0M.AssertModel(models[0],_testData[3], false);
                        SinglerealE0M.AssertModel(models[1],_testData[4], false);
                        SinglerealE0M.AssertModel(models[2],_testData[5], false);
                        SinglerealE0M.AssertModel(models[3],_testData[6], false);
                        SinglerealE0M.AssertModel(models[4],_testData[7], false);
                        SinglerealE0M.AssertModel(models[5],_testData[8], false);
                        SinglerealE0M.AssertModel(models[6],_testData[9], false);
                        SinglerealE0M.AssertModel(models[7],_testData[10], false);
                        SinglerealE0M.AssertModel(models[8],_testData[11], false);
                        SinglerealE0M.AssertModel(models[9],_testData[12], false);
                        SinglerealE0M.AssertModel(models[10],_testData[13], false);
                        SinglerealE0M.AssertModel(models[11],_testData[14], false);
                        SinglerealE0M.AssertModel(models[12],_testData[15], false);
                        SinglerealE0M.AssertModel(models[13],_testData[16], false);
                        SinglerealE0M.AssertModel(models[14],_testData[17], false);
                        SinglerealE0M.AssertModel(models[15],_testData[18], false);
                        SinglerealE0M.AssertModel(models[16],_testData[19], false);
                        SinglerealE0M.AssertModel(models[17],_testData[20], false);
                        SinglerealE0M.AssertModel(models[18],_testData[21], false);
                        SinglerealE0M.AssertModel(models[19],_testData[22], false);
                        SinglerealE0M.AssertModel(models[20],_testData[23], false);
                        SinglerealE0M.AssertModel(models[21],_testData[24], false);
                        SinglerealE0M.AssertModel(models[22],_testData[25], false);
                        SinglerealE0M.AssertModel(models[23],_testData[26], false);
                        SinglerealE0M.AssertModel(models[24],_testData[27], false);
                        SinglerealE0M.AssertModel(models[25],_testData[28], false);
                        SinglerealE0M.AssertModel(models[26],_testData[29], false);
                        SinglerealE0M.AssertModel(models[27],_testData[30], false);
                        SinglerealE0M.AssertModel(models[28],_testData[31], false);
                        SinglerealE0M.AssertModel(models[29],_testData[32], false);
                        SinglerealE0M.AssertModel(models[30],_testData[33], false);
                        SinglerealE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealE0M.AssertModel(models[0],_testData[28], false);
                        SinglerealE0M.AssertModel(models[1],_testData[29], false);
                        SinglerealE0M.AssertModel(models[2],_testData[30], false);
                        SinglerealE0M.AssertModel(models[3],_testData[31], false);
                        SinglerealE0M.AssertModel(models[4],_testData[32], false);
                        SinglerealE0M.AssertModel(models[5],_testData[33], false);
                        SinglerealE0M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                SinglerealE0M.AssertModel(models[0],_testData[14], false);
                SinglerealE0M.AssertModel(models[1],_testData[15], false);
                SinglerealE0M.AssertModel(models[2],_testData[16], false);
                SinglerealE0M.AssertModel(models[3],_testData[17], false);
                SinglerealE0M.AssertModel(models[4],_testData[18], false);
                SinglerealE0M.AssertModel(models[5],_testData[19], false);
                SinglerealE0M.AssertModel(models[6],_testData[20], false);
                SinglerealE0M.AssertModel(models[7],_testData[21], false);
                SinglerealE0M.AssertModel(models[8],_testData[22], false);
                SinglerealE0M.AssertModel(models[9],_testData[23], false);
                SinglerealE0M.AssertModel(models[10],_testData[24], false);
                SinglerealE0M.AssertModel(models[11],_testData[25], false);
                SinglerealE0M.AssertModel(models[12],_testData[26], false);
                SinglerealE0M.AssertModel(models[13],_testData[27], false);
                SinglerealE0M.AssertModel(models[14],_testData[28], false);
                SinglerealE0M.AssertModel(models[15],_testData[29], false);
                SinglerealE0M.AssertModel(models[16],_testData[30], false);
                SinglerealE0M.AssertModel(models[17],_testData[31], false);
                SinglerealE0M.AssertModel(models[18],_testData[32], false);
                SinglerealE0M.AssertModel(models[19],_testData[33], false);
                SinglerealE0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                SinglerealE0M.AssertModel(models[0],_testData[17], false);
                SinglerealE0M.AssertModel(models[1],_testData[18], false);
                SinglerealE0M.AssertModel(models[2],_testData[19], false);
                SinglerealE0M.AssertModel(models[3],_testData[20], false);
                SinglerealE0M.AssertModel(models[4],_testData[21], false);
                SinglerealE0M.AssertModel(models[5],_testData[22], false);
                SinglerealE0M.AssertModel(models[6],_testData[23], false);
                SinglerealE0M.AssertModel(models[7],_testData[24], false);
                SinglerealE0M.AssertModel(models[8],_testData[25], false);
                SinglerealE0M.AssertModel(models[9],_testData[26], false);
                SinglerealE0M.AssertModel(models[10],_testData[27], false);
                SinglerealE0M.AssertModel(models[11],_testData[28], false);
                SinglerealE0M.AssertModel(models[12],_testData[29], false);
                SinglerealE0M.AssertModel(models[13],_testData[30], false);
                SinglerealE0M.AssertModel(models[14],_testData[31], false);
                SinglerealE0M.AssertModel(models[15],_testData[32], false);
                SinglerealE0M.AssertModel(models[16],_testData[33], false);
                SinglerealE0M.AssertModel(models[17],_testData[34], false);
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
FROM dbo.singlereale0m m
LEFT JOIN dbo.singlereale0mi mi ON mi.id = m.singlereale0mi_id
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
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8640857f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06729275f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9949629f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.36931723f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41898668f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.34189653f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2688657f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5937731f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.66306543f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.03314346f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08426231f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.10595763f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5994637f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.62634325f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8051458f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2884124f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.56800747f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.281626f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6440158f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.51519275f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5759473f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.97180426f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.17044532f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.669005f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94520473f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13834184f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2671088f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.58361346f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.07338959f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8334889f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38203222f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8045831f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.39054692f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12501186f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4246385f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.28794962f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.374035f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.33093548f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9907802f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46991056f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5842469f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.233603f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.707056f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.29106772f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2014795f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5049812f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.21931356f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.08521724f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.36951375f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0065294504f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15929013f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8555534f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.13455123f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6098638f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.69646394f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5667826f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.34362584f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5690013f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48667914f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42946416f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.52249974f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7887537f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6223958f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.793086f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.65931064f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.75599694f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8275061f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3746224f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.29212135f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.71872294f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9345877f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5572674f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.11047059f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.66265345f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7016124f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5489903f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.102827966f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.98705596f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6598185f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3759722f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6208914f)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7237207f)));//Value

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
                var models =  ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8640857f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06729275f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9949629f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.36931723f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41898668f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.34189653f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2688657f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5937731f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.66306543f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.03314346f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08426231f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.10595763f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5994637f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.62634325f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8051458f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2884124f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.56800747f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.281626f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6440158f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.51519275f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5759473f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.97180426f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.17044532f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.669005f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94520473f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13834184f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2671088f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.58361346f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.07338959f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8334889f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38203222f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8045831f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.39054692f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12501186f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4246385f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.28794962f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.374035f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.33093548f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9907802f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46991056f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5842469f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.233603f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.707056f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.29106772f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2014795f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5049812f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.21931356f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.08521724f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.36951375f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0065294504f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15929013f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8555534f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.13455123f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6098638f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.69646394f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5667826f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.34362584f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5690013f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48667914f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42946416f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.52249974f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7887537f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6223958f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.793086f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.65931064f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.75599694f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8275061f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3746224f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.29212135f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.71872294f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9345877f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5572674f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.11047059f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.66265345f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7016124f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5489903f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.102827966f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.98705596f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6598185f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3759722f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6208914f)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7237207f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


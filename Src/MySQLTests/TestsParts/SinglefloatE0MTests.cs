

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
    internal partial interface ISingleSingleTypefloat
    {
    }
    
    internal partial class SingleSingleTypefloat : ISingleSingleTypefloat
    {


#region TestData

        private readonly SinglefloatE0M[] _testData = new SinglefloatE0M[]
        {
            new SinglefloatE0M
{
    Id = 3,
    Value = 0.20912719f,
    ModelInner = null,
    NullableValue = 0.18358934f,
},
            new SinglefloatE0M
{
    Id = 4,
    Value = 0.05682534f,
    ModelInner = new SinglefloatE0MI
{
    Id = 9,
    Value = 0.73285604f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 13,
    Value = 0.58971477f,
    ModelInner = null,
    NullableValue = 0.42326003f,
},
            new SinglefloatE0M
{
    Id = 21,
    Value = 0.68940187f,
    ModelInner = new SinglefloatE0MI
{
    Id = 17,
    Value = 0.26897126f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 25,
    Value = 0.85424f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 33,
    Value = 0.6084818f,
    ModelInner = new SinglefloatE0MI
{
    Id = 24,
    Value = 0.15790951f,
    NullableValue = 0.77894837f,
},
    NullableValue = 0.56953853f,
},
            new SinglefloatE0M
{
    Id = 36,
    Value = 0.604486f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 37,
    Value = 0.22293878f,
    ModelInner = new SinglefloatE0MI
{
    Id = 29,
    Value = 0.8017827f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 46,
    Value = 0.7682682f,
    ModelInner = null,
    NullableValue = 0.5931566f,
},
            new SinglefloatE0M
{
    Id = 51,
    Value = 0.67115355f,
    ModelInner = new SinglefloatE0MI
{
    Id = 37,
    Value = 0.08789778f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 59,
    Value = 0.3294046f,
    ModelInner = null,
    NullableValue = 0.4150173f,
},
            new SinglefloatE0M
{
    Id = 67,
    Value = 0.9997283f,
    ModelInner = new SinglefloatE0MI
{
    Id = 41,
    Value = 0.55210054f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 76,
    Value = 0.2572474f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 82,
    Value = 0.8016603f,
    ModelInner = new SinglefloatE0MI
{
    Id = 49,
    Value = 0.63448405f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 86,
    Value = 0.2852208f,
    ModelInner = null,
    NullableValue = 0.6071997f,
},
            new SinglefloatE0M
{
    Id = 95,
    Value = 0.84672034f,
    ModelInner = new SinglefloatE0MI
{
    Id = 50,
    Value = 0.7124983f,
    NullableValue = null,
},
    NullableValue = 0.17340213f,
},
            new SinglefloatE0M
{
    Id = 103,
    Value = 0.33370692f,
    ModelInner = null,
    NullableValue = 0.87548596f,
},
            new SinglefloatE0M
{
    Id = 107,
    Value = 0.15514857f,
    ModelInner = new SinglefloatE0MI
{
    Id = 56,
    Value = 0.15163803f,
    NullableValue = 0.39621544f,
},
    NullableValue = 0.09515154f,
},
            new SinglefloatE0M
{
    Id = 112,
    Value = 0.9274999f,
    ModelInner = null,
    NullableValue = 0.2300942f,
},
            new SinglefloatE0M
{
    Id = 119,
    Value = 0.80680406f,
    ModelInner = new SinglefloatE0MI
{
    Id = 64,
    Value = 0.44617945f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 124,
    Value = 0.49711978f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 128,
    Value = 0.9204808f,
    ModelInner = new SinglefloatE0MI
{
    Id = 70,
    Value = 0.20714635f,
    NullableValue = 0.303676f,
},
    NullableValue = 0.17330533f,
},
            new SinglefloatE0M
{
    Id = 137,
    Value = 0.3117662f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 140,
    Value = 0.6403593f,
    ModelInner = new SinglefloatE0MI
{
    Id = 75,
    Value = 0.29427707f,
    NullableValue = 0.76306105f,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 147,
    Value = 0.7928514f,
    ModelInner = null,
    NullableValue = 0.83831996f,
},
            new SinglefloatE0M
{
    Id = 149,
    Value = 0.9408689f,
    ModelInner = new SinglefloatE0MI
{
    Id = 81,
    Value = 0.13258314f,
    NullableValue = 0.6412766f,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 150,
    Value = 0.22271764f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 154,
    Value = 0.1359393f,
    ModelInner = new SinglefloatE0MI
{
    Id = 88,
    Value = 0.6761729f,
    NullableValue = 0.7148313f,
},
    NullableValue = 0.51976603f,
},
            new SinglefloatE0M
{
    Id = 162,
    Value = 0.28046727f,
    ModelInner = null,
    NullableValue = 0.42305726f,
},
            new SinglefloatE0M
{
    Id = 170,
    Value = 0.15777326f,
    ModelInner = new SinglefloatE0MI
{
    Id = 90,
    Value = 0.5974579f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 174,
    Value = 0.6830942f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 179,
    Value = 0.4481662f,
    ModelInner = new SinglefloatE0MI
{
    Id = 93,
    Value = 0.8942369f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 183,
    Value = 0.09286231f,
    ModelInner = null,
    NullableValue = 0.75574017f,
},
            new SinglefloatE0M
{
    Id = 191,
    Value = 0.080015f,
    ModelInner = new SinglefloatE0MI
{
    Id = 95,
    Value = 0.9280364f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 199,
    Value = 0.102708936f,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloate0mi(
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(4)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(4))]
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

                changedRows =  ((ISingleSingleTypefloat)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypefloat)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloate0mi(
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
            asPartInterface: typeof(ISingleSingleTypefloat)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(15)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15), 
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

                changedRows =  ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloate0m(
	id,
    value,
    nullablevalue,
    singlefloate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlefloate0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(4)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(4),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlefloate0mi_id", 
                methodParametrName: "singlefloate0mi_id", 
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

                changedRows =  ((ISingleSingleTypefloat)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypefloat)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloate0m(
	id,
    value,
    nullablevalue,
    singlefloate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlefloate0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Single), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(15)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlefloate0mi_id", 
                methodParametrName: "singlefloate0mi_id", 
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

                changedRows =  ((ISingleSingleTypefloat)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypefloat)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloatE0M), typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                await((ISingleSingleTypefloat)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                ((ISingleSingleTypefloat)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((ISingleSingleTypefloat)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((ISingleSingleTypefloat)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
LEFT JOIN gedaqtests.singlefloate0mi mi ON mi.id = m.singlefloate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
                var models = await((ISingleSingleTypefloat)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleSingleTypefloat)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloatE0M), typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                await((ISingleSingleTypefloat)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                ((ISingleSingleTypefloat)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypefloat)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypefloat)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
LEFT JOIN gedaqtests.singlefloate0mi mi ON mi.id = m.singlefloate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
                var models = await((ISingleSingleTypefloat)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleSingleTypefloat)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloatE0M), typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                await((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[24],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[25],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[26],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[27],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
LEFT JOIN gedaqtests.singlefloate0mi mi ON mi.id = m.singlefloate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
                var models = await((ISingleSingleTypefloat)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglefloatE0M.AssertModel(models[0],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglefloatE0M.AssertModel(models[0],_testData[8], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[9], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[10], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[11], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[12], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[22],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[23],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[24],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[25],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((ISingleSingleTypefloat)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglefloatE0M.AssertModel(models[0],_testData[9], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[10], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[11], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[12], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[22],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[23],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[24],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        SinglefloatE0M.AssertModel(models[0],_testData[2], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[3], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[4], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[5], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[6], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[7], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[8], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[9], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[10], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[11], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[12], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[22],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[23],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[24],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[25],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[26],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[27],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[28],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[29],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[30],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[31],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloatE0M), typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                await((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 174, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloatE0M>();
                var models2 = new List<FlatSinglefloatE0M>();
                ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 149, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var firstItems2 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 149, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 3, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[1], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[2], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[3], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[4], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[24],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[25],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[26],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[27],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[28],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[29],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[30],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[31],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[32],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 137, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[1], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[2], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[3], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[4], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[24],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[25],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[26],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[27],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[28],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[29],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[30],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[31],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[32],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[24],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
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
FROM gedaqtests.singlefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloatE0M>();
                var secondItems1 = new List<FlatSinglefloatE0M>();
                var secondItems2 = new List<FlatSinglefloatE0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 150, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
LEFT JOIN gedaqtests.singlefloate0mi mi ON mi.id = m.singlefloate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
            asPartInterface: typeof(ISingleSingleTypefloat)),
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
                var models = await((ISingleSingleTypefloat)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        SinglefloatE0M.AssertModel(models[0],_testData[7], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[8], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[9], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[10], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[11], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[12], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[22],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[23],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[24],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[25],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[26],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglefloatE0M.AssertModel(models[0],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[34], false);
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
                var models = ((ISingleSingleTypefloat)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglefloatE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 76, 179))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglefloatE0M.AssertModel(models[0],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglefloatE0M.AssertModel(models[0],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                SinglefloatE0M.AssertModel(models[0],_testData[8], false);
                SinglefloatE0M.AssertModel(models[1],_testData[9], false);
                SinglefloatE0M.AssertModel(models[2],_testData[10], false);
                SinglefloatE0M.AssertModel(models[3],_testData[11], false);
                SinglefloatE0M.AssertModel(models[4],_testData[12], false);
                SinglefloatE0M.AssertModel(models[5],_testData[13], false);
                SinglefloatE0M.AssertModel(models[6],_testData[14], false);
                SinglefloatE0M.AssertModel(models[7],_testData[15], false);
                SinglefloatE0M.AssertModel(models[8],_testData[16], false);
                SinglefloatE0M.AssertModel(models[9],_testData[17], false);
                SinglefloatE0M.AssertModel(models[10],_testData[18], false);
                SinglefloatE0M.AssertModel(models[11],_testData[19], false);
                SinglefloatE0M.AssertModel(models[12],_testData[20], false);
                SinglefloatE0M.AssertModel(models[13],_testData[21], false);
                SinglefloatE0M.AssertModel(models[14],_testData[22], false);
                SinglefloatE0M.AssertModel(models[15],_testData[23], false);
                SinglefloatE0M.AssertModel(models[16],_testData[24], false);
                SinglefloatE0M.AssertModel(models[17],_testData[25], false);
                SinglefloatE0M.AssertModel(models[18],_testData[26], false);
                SinglefloatE0M.AssertModel(models[19],_testData[27], false);
                SinglefloatE0M.AssertModel(models[20],_testData[28], false);
                SinglefloatE0M.AssertModel(models[21],_testData[29], false);
                SinglefloatE0M.AssertModel(models[22],_testData[30], false);
                SinglefloatE0M.AssertModel(models[23],_testData[31], false);
                SinglefloatE0M.AssertModel(models[24],_testData[32], false);
                SinglefloatE0M.AssertModel(models[25],_testData[33], false);
                SinglefloatE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models =  ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                SinglefloatE0M.AssertModel(models[0],_testData[16], false);
                SinglefloatE0M.AssertModel(models[1],_testData[17], false);
                SinglefloatE0M.AssertModel(models[2],_testData[18], false);
                SinglefloatE0M.AssertModel(models[3],_testData[19], false);
                SinglefloatE0M.AssertModel(models[4],_testData[20], false);
                SinglefloatE0M.AssertModel(models[5],_testData[21], false);
                SinglefloatE0M.AssertModel(models[6],_testData[22], false);
                SinglefloatE0M.AssertModel(models[7],_testData[23], false);
                SinglefloatE0M.AssertModel(models[8],_testData[24], false);
                SinglefloatE0M.AssertModel(models[9],_testData[25], false);
                SinglefloatE0M.AssertModel(models[10],_testData[26], false);
                SinglefloatE0M.AssertModel(models[11],_testData[27], false);
                SinglefloatE0M.AssertModel(models[12],_testData[28], false);
                SinglefloatE0M.AssertModel(models[13],_testData[29], false);
                SinglefloatE0M.AssertModel(models[14],_testData[30], false);
                SinglefloatE0M.AssertModel(models[15],_testData[31], false);
                SinglefloatE0M.AssertModel(models[16],_testData[32], false);
                SinglefloatE0M.AssertModel(models[17],_testData[33], false);
                SinglefloatE0M.AssertModel(models[18],_testData[34], false);
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
FROM gedaqtests.singlefloate0m m
LEFT JOIN gedaqtests.singlefloate0mi mi ON mi.id = m.singlefloate0mi_id
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
            asPartInterface: typeof(ISingleSingleTypefloat))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypefloat)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20912719f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18358934f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.05682534f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.73285604f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.58971477f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42326003f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.68940187f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.26897126f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.85424f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6084818f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.15790951f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.77894837f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.56953853f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.604486f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22293878f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8017827f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7682682f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5931566f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.67115355f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08789778f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3294046f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4150173f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9997283f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.55210054f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2572474f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8016603f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.63448405f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2852208f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6071997f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.84672034f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7124983f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.17340213f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.33370692f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.87548596f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15514857f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.15163803f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.39621544f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.09515154f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9274999f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2300942f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.80680406f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.44617945f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.49711978f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9204808f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20714635f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.303676f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.17330533f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3117662f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6403593f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.29427707f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.76306105f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7928514f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.83831996f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9408689f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.13258314f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6412766f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22271764f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1359393f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6761729f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7148313f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.51976603f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.28046727f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42305726f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15777326f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5974579f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6830942f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4481662f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8942369f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09286231f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75574017f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.080015f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9280364f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.102708936f)));//Value

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
                var models =  ((ISingleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20912719f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18358934f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.05682534f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.73285604f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.58971477f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42326003f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.68940187f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.26897126f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.85424f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6084818f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.15790951f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.77894837f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.56953853f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.604486f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22293878f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8017827f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7682682f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5931566f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.67115355f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08789778f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3294046f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4150173f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9997283f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.55210054f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2572474f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8016603f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.63448405f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2852208f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6071997f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.84672034f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7124983f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.17340213f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.33370692f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.87548596f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15514857f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.15163803f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.39621544f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.09515154f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9274999f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2300942f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.80680406f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.44617945f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.49711978f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9204808f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20714635f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.303676f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.17330533f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3117662f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6403593f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.29427707f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.76306105f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7928514f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.83831996f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9408689f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.13258314f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6412766f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22271764f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1359393f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6761729f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7148313f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.51976603f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.28046727f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42305726f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15777326f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5974579f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6830942f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4481662f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8942369f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09286231f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75574017f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.080015f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9280364f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.102708936f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


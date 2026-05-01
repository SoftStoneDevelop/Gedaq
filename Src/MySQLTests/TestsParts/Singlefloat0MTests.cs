

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

        private readonly Singlefloat0M[] _testData = new Singlefloat0M[]
        {
            new Singlefloat0M
{
    Id = 7,
    Value = 0.41521013f,
    ModelInner = null,
    NullableValue = 0.15861237f,
},
            new Singlefloat0M
{
    Id = 13,
    Value = 0.036828876f,
    ModelInner = new Singlefloat0MI
{
    Id = 8,
    Value = 0.49914795f,
    NullableValue = 0.5104283f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 18,
    Value = 0.8990024f,
    ModelInner = null,
    NullableValue = 0.48887426f,
},
            new Singlefloat0M
{
    Id = 22,
    Value = 0.57850885f,
    ModelInner = new Singlefloat0MI
{
    Id = 9,
    Value = 0.61379236f,
    NullableValue = 0.39077336f,
},
    NullableValue = 0.7275231f,
},
            new Singlefloat0M
{
    Id = 24,
    Value = 0.46564472f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 31,
    Value = 0.6842761f,
    ModelInner = new Singlefloat0MI
{
    Id = 18,
    Value = 0.21147132f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 39,
    Value = 0.748369f,
    ModelInner = null,
    NullableValue = 0.3935907f,
},
            new Singlefloat0M
{
    Id = 41,
    Value = 0.74566525f,
    ModelInner = new Singlefloat0MI
{
    Id = 27,
    Value = 0.70826614f,
    NullableValue = null,
},
    NullableValue = 0.3890428f,
},
            new Singlefloat0M
{
    Id = 43,
    Value = 0.066119075f,
    ModelInner = null,
    NullableValue = 0.43429697f,
},
            new Singlefloat0M
{
    Id = 47,
    Value = 0.86304915f,
    ModelInner = new Singlefloat0MI
{
    Id = 29,
    Value = 0.8866553f,
    NullableValue = null,
},
    NullableValue = 0.67353714f,
},
            new Singlefloat0M
{
    Id = 54,
    Value = 0.8035684f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 57,
    Value = 0.7870803f,
    ModelInner = new Singlefloat0MI
{
    Id = 36,
    Value = 0.51521635f,
    NullableValue = 0.5933701f,
},
    NullableValue = 0.76396704f,
},
            new Singlefloat0M
{
    Id = 66,
    Value = 0.77121866f,
    ModelInner = null,
    NullableValue = 0.6237665f,
},
            new Singlefloat0M
{
    Id = 68,
    Value = 0.08273476f,
    ModelInner = new Singlefloat0MI
{
    Id = 44,
    Value = 0.47424924f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 74,
    Value = 0.6309135f,
    ModelInner = null,
    NullableValue = 0.3746881f,
},
            new Singlefloat0M
{
    Id = 77,
    Value = 0.2857585f,
    ModelInner = new Singlefloat0MI
{
    Id = 53,
    Value = 0.337147f,
    NullableValue = 0.016536117f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 85,
    Value = 0.7887775f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 87,
    Value = 0.4775133f,
    ModelInner = new Singlefloat0MI
{
    Id = 59,
    Value = 0.5011607f,
    NullableValue = null,
},
    NullableValue = 0.34791523f,
},
            new Singlefloat0M
{
    Id = 96,
    Value = 0.9106813f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 98,
    Value = 0.057905257f,
    ModelInner = new Singlefloat0MI
{
    Id = 65,
    Value = 0.5346773f,
    NullableValue = null,
},
    NullableValue = 0.39198923f,
},
            new Singlefloat0M
{
    Id = 103,
    Value = 0.18451309f,
    ModelInner = null,
    NullableValue = 0.94572693f,
},
            new Singlefloat0M
{
    Id = 111,
    Value = 0.6493807f,
    ModelInner = new Singlefloat0MI
{
    Id = 67,
    Value = 0.3105511f,
    NullableValue = 0.5938137f,
},
    NullableValue = 0.10715246f,
},
            new Singlefloat0M
{
    Id = 116,
    Value = 0.8837128f,
    ModelInner = null,
    NullableValue = 0.74565375f,
},
            new Singlefloat0M
{
    Id = 125,
    Value = 0.9872462f,
    ModelInner = new Singlefloat0MI
{
    Id = 71,
    Value = 0.84710276f,
    NullableValue = 0.59743655f,
},
    NullableValue = 0.75242925f,
},
            new Singlefloat0M
{
    Id = 132,
    Value = 0.02195549f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 140,
    Value = 0.8404618f,
    ModelInner = new Singlefloat0MI
{
    Id = 80,
    Value = 0.947306f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 141,
    Value = 0.60200185f,
    ModelInner = null,
    NullableValue = 0.4124177f,
},
            new Singlefloat0M
{
    Id = 149,
    Value = 0.09811741f,
    ModelInner = new Singlefloat0MI
{
    Id = 85,
    Value = 0.5202762f,
    NullableValue = null,
},
    NullableValue = 0.8449235f,
},
            new Singlefloat0M
{
    Id = 152,
    Value = 0.3493967f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 160,
    Value = 0.8297401f,
    ModelInner = new Singlefloat0MI
{
    Id = 87,
    Value = 0.761694f,
    NullableValue = 0.16026103f,
},
    NullableValue = 0.19120592f,
},
            new Singlefloat0M
{
    Id = 162,
    Value = 0.9607457f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 165,
    Value = 0.6137652f,
    ModelInner = new Singlefloat0MI
{
    Id = 96,
    Value = 0.59755945f,
    NullableValue = 0.59764785f,
},
    NullableValue = 0.15600204f,
},
            new Singlefloat0M
{
    Id = 173,
    Value = 0.2790056f,
    ModelInner = null,
    NullableValue = 0.72116584f,
},
            new Singlefloat0M
{
    Id = 175,
    Value = 0.1485619f,
    ModelInner = new Singlefloat0MI
{
    Id = 97,
    Value = 0.86931443f,
    NullableValue = 0.72152805f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 179,
    Value = 0.29657722f,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloat0mi(
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
INSERT INTO gedaqtests.singlefloat0mi(
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
INSERT INTO gedaqtests.singlefloat0m(
	id,
    value,
    nullablevalue,
    singlefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlefloat0mi_id
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
                parametrName: "singlefloat0mi_id", 
                methodParametrName: "singlefloat0mi_id", 
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
INSERT INTO gedaqtests.singlefloat0m(
	id,
    value,
    nullablevalue,
    singlefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlefloat0mi_id
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
                parametrName: "singlefloat0mi_id", 
                methodParametrName: "singlefloat0mi_id", 
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
            queryMapTypes: [typeof(FlatSinglefloat0M), typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                await((ISingleSingleTypefloat)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                ((ISingleSingleTypefloat)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
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
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
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
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Singlefloat0M)],
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloat0M), typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                await((ISingleSingleTypefloat)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                ((ISingleSingleTypefloat)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypefloat)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypefloat)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Singlefloat0M)],
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloat0M), typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                await((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
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
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[1], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[17],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[18],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[19],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[20],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[21],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[22],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[23],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[24],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[25],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[26],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[27],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[28],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[29],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[30],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[31],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[32],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
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
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[17],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[18],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[19],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[20],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[21],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[22],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[23],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[24],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[25],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[26],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[27],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[28],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Singlefloat0M)],
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Singlefloat0M.AssertModel(models[0],_testData[5], false);
                        Singlefloat0M.AssertModel(models[1],_testData[6], false);
                        Singlefloat0M.AssertModel(models[2],_testData[7], false);
                        Singlefloat0M.AssertModel(models[3],_testData[8], false);
                        Singlefloat0M.AssertModel(models[4],_testData[9], false);
                        Singlefloat0M.AssertModel(models[5],_testData[10], false);
                        Singlefloat0M.AssertModel(models[6],_testData[11], false);
                        Singlefloat0M.AssertModel(models[7],_testData[12], false);
                        Singlefloat0M.AssertModel(models[8],_testData[13], false);
                        Singlefloat0M.AssertModel(models[9],_testData[14], false);
                        Singlefloat0M.AssertModel(models[10],_testData[15], false);
                        Singlefloat0M.AssertModel(models[11],_testData[16], false);
                        Singlefloat0M.AssertModel(models[12],_testData[17], false);
                        Singlefloat0M.AssertModel(models[13],_testData[18], false);
                        Singlefloat0M.AssertModel(models[14],_testData[19], false);
                        Singlefloat0M.AssertModel(models[15],_testData[20], false);
                        Singlefloat0M.AssertModel(models[16],_testData[21], false);
                        Singlefloat0M.AssertModel(models[17],_testData[22], false);
                        Singlefloat0M.AssertModel(models[18],_testData[23], false);
                        Singlefloat0M.AssertModel(models[19],_testData[24], false);
                        Singlefloat0M.AssertModel(models[20],_testData[25], false);
                        Singlefloat0M.AssertModel(models[21],_testData[26], false);
                        Singlefloat0M.AssertModel(models[22],_testData[27], false);
                        Singlefloat0M.AssertModel(models[23],_testData[28], false);
                        Singlefloat0M.AssertModel(models[24],_testData[29], false);
                        Singlefloat0M.AssertModel(models[25],_testData[30], false);
                        Singlefloat0M.AssertModel(models[26],_testData[31], false);
                        Singlefloat0M.AssertModel(models[27],_testData[32], false);
                        Singlefloat0M.AssertModel(models[28],_testData[33], false);
                        Singlefloat0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Singlefloat0M.AssertModel(models[0],_testData[22], false);
                        Singlefloat0M.AssertModel(models[1],_testData[23], false);
                        Singlefloat0M.AssertModel(models[2],_testData[24], false);
                        Singlefloat0M.AssertModel(models[3],_testData[25], false);
                        Singlefloat0M.AssertModel(models[4],_testData[26], false);
                        Singlefloat0M.AssertModel(models[5],_testData[27], false);
                        Singlefloat0M.AssertModel(models[6],_testData[28], false);
                        Singlefloat0M.AssertModel(models[7],_testData[29], false);
                        Singlefloat0M.AssertModel(models[8],_testData[30], false);
                        Singlefloat0M.AssertModel(models[9],_testData[31], false);
                        Singlefloat0M.AssertModel(models[10],_testData[32], false);
                        Singlefloat0M.AssertModel(models[11],_testData[33], false);
                        Singlefloat0M.AssertModel(models[12],_testData[34], false);
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Singlefloat0M.AssertModel(models[0],_testData[23], false);
                        Singlefloat0M.AssertModel(models[1],_testData[24], false);
                        Singlefloat0M.AssertModel(models[2],_testData[25], false);
                        Singlefloat0M.AssertModel(models[3],_testData[26], false);
                        Singlefloat0M.AssertModel(models[4],_testData[27], false);
                        Singlefloat0M.AssertModel(models[5],_testData[28], false);
                        Singlefloat0M.AssertModel(models[6],_testData[29], false);
                        Singlefloat0M.AssertModel(models[7],_testData[30], false);
                        Singlefloat0M.AssertModel(models[8],_testData[31], false);
                        Singlefloat0M.AssertModel(models[9],_testData[32], false);
                        Singlefloat0M.AssertModel(models[10],_testData[33], false);
                        Singlefloat0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Singlefloat0M.AssertModel(models[0],_testData[11], false);
                        Singlefloat0M.AssertModel(models[1],_testData[12], false);
                        Singlefloat0M.AssertModel(models[2],_testData[13], false);
                        Singlefloat0M.AssertModel(models[3],_testData[14], false);
                        Singlefloat0M.AssertModel(models[4],_testData[15], false);
                        Singlefloat0M.AssertModel(models[5],_testData[16], false);
                        Singlefloat0M.AssertModel(models[6],_testData[17], false);
                        Singlefloat0M.AssertModel(models[7],_testData[18], false);
                        Singlefloat0M.AssertModel(models[8],_testData[19], false);
                        Singlefloat0M.AssertModel(models[9],_testData[20], false);
                        Singlefloat0M.AssertModel(models[10],_testData[21], false);
                        Singlefloat0M.AssertModel(models[11],_testData[22], false);
                        Singlefloat0M.AssertModel(models[12],_testData[23], false);
                        Singlefloat0M.AssertModel(models[13],_testData[24], false);
                        Singlefloat0M.AssertModel(models[14],_testData[25], false);
                        Singlefloat0M.AssertModel(models[15],_testData[26], false);
                        Singlefloat0M.AssertModel(models[16],_testData[27], false);
                        Singlefloat0M.AssertModel(models[17],_testData[28], false);
                        Singlefloat0M.AssertModel(models[18],_testData[29], false);
                        Singlefloat0M.AssertModel(models[19],_testData[30], false);
                        Singlefloat0M.AssertModel(models[20],_testData[31], false);
                        Singlefloat0M.AssertModel(models[21],_testData[32], false);
                        Singlefloat0M.AssertModel(models[22],_testData[33], false);
                        Singlefloat0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloat0M), typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                await((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 162, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 87, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglefloat0M>();
                var models2 = new List<FlatSinglefloat0M>();
                ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var firstItems2 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglefloat0M)],
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 132, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[17],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[18],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[19],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[20],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[21],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[22],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[23],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 13, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 162, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[17],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[18],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[19],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[20],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[21],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[22],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[23],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[24],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[25],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
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
FROM gedaqtests.singlefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglefloat0M>();
                var secondItems1 = new List<FlatSinglefloat0M>();
                var secondItems2 = new List<FlatSinglefloat0M>();
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Singlefloat0M)],
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 39, 152))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Singlefloat0M.AssertModel(models[0],_testData[7], false);
                        Singlefloat0M.AssertModel(models[1],_testData[8], false);
                        Singlefloat0M.AssertModel(models[2],_testData[9], false);
                        Singlefloat0M.AssertModel(models[3],_testData[10], false);
                        Singlefloat0M.AssertModel(models[4],_testData[11], false);
                        Singlefloat0M.AssertModel(models[5],_testData[12], false);
                        Singlefloat0M.AssertModel(models[6],_testData[13], false);
                        Singlefloat0M.AssertModel(models[7],_testData[14], false);
                        Singlefloat0M.AssertModel(models[8],_testData[15], false);
                        Singlefloat0M.AssertModel(models[9],_testData[16], false);
                        Singlefloat0M.AssertModel(models[10],_testData[17], false);
                        Singlefloat0M.AssertModel(models[11],_testData[18], false);
                        Singlefloat0M.AssertModel(models[12],_testData[19], false);
                        Singlefloat0M.AssertModel(models[13],_testData[20], false);
                        Singlefloat0M.AssertModel(models[14],_testData[21], false);
                        Singlefloat0M.AssertModel(models[15],_testData[22], false);
                        Singlefloat0M.AssertModel(models[16],_testData[23], false);
                        Singlefloat0M.AssertModel(models[17],_testData[24], false);
                        Singlefloat0M.AssertModel(models[18],_testData[25], false);
                        Singlefloat0M.AssertModel(models[19],_testData[26], false);
                        Singlefloat0M.AssertModel(models[20],_testData[27], false);
                        Singlefloat0M.AssertModel(models[21],_testData[28], false);
                        Singlefloat0M.AssertModel(models[22],_testData[29], false);
                        Singlefloat0M.AssertModel(models[23],_testData[30], false);
                        Singlefloat0M.AssertModel(models[24],_testData[31], false);
                        Singlefloat0M.AssertModel(models[25],_testData[32], false);
                        Singlefloat0M.AssertModel(models[26],_testData[33], false);
                        Singlefloat0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Singlefloat0M.AssertModel(models[0],_testData[29], false);
                        Singlefloat0M.AssertModel(models[1],_testData[30], false);
                        Singlefloat0M.AssertModel(models[2],_testData[31], false);
                        Singlefloat0M.AssertModel(models[3],_testData[32], false);
                        Singlefloat0M.AssertModel(models[4],_testData[33], false);
                        Singlefloat0M.AssertModel(models[5],_testData[34], false);
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
                    Singlefloat0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 152, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Singlefloat0M.AssertModel(models[0],_testData[29], false);
                        Singlefloat0M.AssertModel(models[1],_testData[30], false);
                        Singlefloat0M.AssertModel(models[2],_testData[31], false);
                        Singlefloat0M.AssertModel(models[3],_testData[32], false);
                        Singlefloat0M.AssertModel(models[4],_testData[33], false);
                        Singlefloat0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Singlefloat0M.AssertModel(models[0],_testData[18], false);
                        Singlefloat0M.AssertModel(models[1],_testData[19], false);
                        Singlefloat0M.AssertModel(models[2],_testData[20], false);
                        Singlefloat0M.AssertModel(models[3],_testData[21], false);
                        Singlefloat0M.AssertModel(models[4],_testData[22], false);
                        Singlefloat0M.AssertModel(models[5],_testData[23], false);
                        Singlefloat0M.AssertModel(models[6],_testData[24], false);
                        Singlefloat0M.AssertModel(models[7],_testData[25], false);
                        Singlefloat0M.AssertModel(models[8],_testData[26], false);
                        Singlefloat0M.AssertModel(models[9],_testData[27], false);
                        Singlefloat0M.AssertModel(models[10],_testData[28], false);
                        Singlefloat0M.AssertModel(models[11],_testData[29], false);
                        Singlefloat0M.AssertModel(models[12],_testData[30], false);
                        Singlefloat0M.AssertModel(models[13],_testData[31], false);
                        Singlefloat0M.AssertModel(models[14],_testData[32], false);
                        Singlefloat0M.AssertModel(models[15],_testData[33], false);
                        Singlefloat0M.AssertModel(models[16],_testData[34], false);
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
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Singlefloat0M.AssertModel(models[0],_testData[5], false);
                Singlefloat0M.AssertModel(models[1],_testData[6], false);
                Singlefloat0M.AssertModel(models[2],_testData[7], false);
                Singlefloat0M.AssertModel(models[3],_testData[8], false);
                Singlefloat0M.AssertModel(models[4],_testData[9], false);
                Singlefloat0M.AssertModel(models[5],_testData[10], false);
                Singlefloat0M.AssertModel(models[6],_testData[11], false);
                Singlefloat0M.AssertModel(models[7],_testData[12], false);
                Singlefloat0M.AssertModel(models[8],_testData[13], false);
                Singlefloat0M.AssertModel(models[9],_testData[14], false);
                Singlefloat0M.AssertModel(models[10],_testData[15], false);
                Singlefloat0M.AssertModel(models[11],_testData[16], false);
                Singlefloat0M.AssertModel(models[12],_testData[17], false);
                Singlefloat0M.AssertModel(models[13],_testData[18], false);
                Singlefloat0M.AssertModel(models[14],_testData[19], false);
                Singlefloat0M.AssertModel(models[15],_testData[20], false);
                Singlefloat0M.AssertModel(models[16],_testData[21], false);
                Singlefloat0M.AssertModel(models[17],_testData[22], false);
                Singlefloat0M.AssertModel(models[18],_testData[23], false);
                Singlefloat0M.AssertModel(models[19],_testData[24], false);
                Singlefloat0M.AssertModel(models[20],_testData[25], false);
                Singlefloat0M.AssertModel(models[21],_testData[26], false);
                Singlefloat0M.AssertModel(models[22],_testData[27], false);
                Singlefloat0M.AssertModel(models[23],_testData[28], false);
                Singlefloat0M.AssertModel(models[24],_testData[29], false);
                Singlefloat0M.AssertModel(models[25],_testData[30], false);
                Singlefloat0M.AssertModel(models[26],_testData[31], false);
                Singlefloat0M.AssertModel(models[27],_testData[32], false);
                Singlefloat0M.AssertModel(models[28],_testData[33], false);
                Singlefloat0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                Singlefloat0M.AssertModel(models[0],_testData[13], false);
                Singlefloat0M.AssertModel(models[1],_testData[14], false);
                Singlefloat0M.AssertModel(models[2],_testData[15], false);
                Singlefloat0M.AssertModel(models[3],_testData[16], false);
                Singlefloat0M.AssertModel(models[4],_testData[17], false);
                Singlefloat0M.AssertModel(models[5],_testData[18], false);
                Singlefloat0M.AssertModel(models[6],_testData[19], false);
                Singlefloat0M.AssertModel(models[7],_testData[20], false);
                Singlefloat0M.AssertModel(models[8],_testData[21], false);
                Singlefloat0M.AssertModel(models[9],_testData[22], false);
                Singlefloat0M.AssertModel(models[10],_testData[23], false);
                Singlefloat0M.AssertModel(models[11],_testData[24], false);
                Singlefloat0M.AssertModel(models[12],_testData[25], false);
                Singlefloat0M.AssertModel(models[13],_testData[26], false);
                Singlefloat0M.AssertModel(models[14],_testData[27], false);
                Singlefloat0M.AssertModel(models[15],_testData[28], false);
                Singlefloat0M.AssertModel(models[16],_testData[29], false);
                Singlefloat0M.AssertModel(models[17],_testData[30], false);
                Singlefloat0M.AssertModel(models[18],_testData[31], false);
                Singlefloat0M.AssertModel(models[19],_testData[32], false);
                Singlefloat0M.AssertModel(models[20],_testData[33], false);
                Singlefloat0M.AssertModel(models[21],_testData[34], false);
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.41521013f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.15861237f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.036828876f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.49914795f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5104283f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8990024f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48887426f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.57850885f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.61379236f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.39077336f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7275231f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46564472f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6842761f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.21147132f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.748369f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3935907f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74566525f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.70826614f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3890428f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.066119075f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.43429697f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86304915f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8866553f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.67353714f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8035684f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7870803f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.51521635f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5933701f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76396704f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77121866f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6237665f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08273476f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.47424924f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6309135f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3746881f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2857585f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.337147f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.016536117f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7887775f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4775133f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5011607f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.34791523f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9106813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.057905257f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5346773f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.39198923f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18451309f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94572693f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6493807f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3105511f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5938137f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.10715246f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8837128f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.74565375f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9872462f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84710276f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.59743655f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75242925f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.02195549f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8404618f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.947306f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.60200185f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4124177f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09811741f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5202762f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8449235f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3493967f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8297401f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.761694f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.16026103f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.19120592f)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9607457f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6137652f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.59755945f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.59764785f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.15600204f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2790056f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.72116584f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1485619f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.86931443f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.72152805f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29657722f)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.41521013f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.15861237f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.036828876f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.49914795f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5104283f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8990024f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48887426f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.57850885f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.61379236f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.39077336f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7275231f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46564472f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6842761f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.21147132f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.748369f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3935907f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74566525f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.70826614f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3890428f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.066119075f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.43429697f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86304915f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8866553f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.67353714f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8035684f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7870803f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.51521635f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5933701f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76396704f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77121866f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6237665f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08273476f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.47424924f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6309135f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3746881f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2857585f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.337147f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.016536117f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7887775f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4775133f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5011607f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.34791523f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9106813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.057905257f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5346773f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.39198923f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18451309f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94572693f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6493807f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3105511f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5938137f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.10715246f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8837128f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.74565375f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9872462f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84710276f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.59743655f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75242925f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.02195549f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8404618f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.947306f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.60200185f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4124177f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09811741f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5202762f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8449235f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3493967f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8297401f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.761694f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.16026103f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.19120592f)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9607457f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6137652f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.59755945f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.59764785f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.15600204f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2790056f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.72116584f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1485619f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.86931443f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.72152805f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29657722f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


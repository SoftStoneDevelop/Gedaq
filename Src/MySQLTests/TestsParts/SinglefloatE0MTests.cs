

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
    Value = 0.08998436f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 8,
    Value = 0.877164f,
    ModelInner = new SinglefloatE0MI
{
    Id = 7,
    Value = 0.8860548f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 17,
    Value = 0.6652714f,
    ModelInner = null,
    NullableValue = 0.7505934f,
},
            new SinglefloatE0M
{
    Id = 19,
    Value = 0.57007104f,
    ModelInner = new SinglefloatE0MI
{
    Id = 15,
    Value = 0.4865471f,
    NullableValue = 0.55461085f,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 27,
    Value = 0.3479305f,
    ModelInner = null,
    NullableValue = 0.38914597f,
},
            new SinglefloatE0M
{
    Id = 34,
    Value = 0.30761492f,
    ModelInner = new SinglefloatE0MI
{
    Id = 20,
    Value = 0.54457825f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 40,
    Value = 0.6115609f,
    ModelInner = null,
    NullableValue = 0.38784832f,
},
            new SinglefloatE0M
{
    Id = 41,
    Value = 0.38395888f,
    ModelInner = new SinglefloatE0MI
{
    Id = 28,
    Value = 0.23153406f,
    NullableValue = null,
},
    NullableValue = 0.12564838f,
},
            new SinglefloatE0M
{
    Id = 50,
    Value = 0.5873939f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 56,
    Value = 0.8750895f,
    ModelInner = new SinglefloatE0MI
{
    Id = 35,
    Value = 0.36775327f,
    NullableValue = 0.024213135f,
},
    NullableValue = 0.60812366f,
},
            new SinglefloatE0M
{
    Id = 64,
    Value = 0.7151892f,
    ModelInner = null,
    NullableValue = 0.5809605f,
},
            new SinglefloatE0M
{
    Id = 67,
    Value = 0.23635823f,
    ModelInner = new SinglefloatE0MI
{
    Id = 42,
    Value = 0.54779345f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 75,
    Value = 0.32148576f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 81,
    Value = 0.67593104f,
    ModelInner = new SinglefloatE0MI
{
    Id = 47,
    Value = 0.68039507f,
    NullableValue = null,
},
    NullableValue = 0.29373878f,
},
            new SinglefloatE0M
{
    Id = 86,
    Value = 0.3656512f,
    ModelInner = null,
    NullableValue = 0.74861944f,
},
            new SinglefloatE0M
{
    Id = 95,
    Value = 0.86042726f,
    ModelInner = new SinglefloatE0MI
{
    Id = 49,
    Value = 0.0029612184f,
    NullableValue = 0.58503324f,
},
    NullableValue = 0.5252407f,
},
            new SinglefloatE0M
{
    Id = 104,
    Value = 0.47184205f,
    ModelInner = null,
    NullableValue = 0.054210663f,
},
            new SinglefloatE0M
{
    Id = 108,
    Value = 0.1988501f,
    ModelInner = new SinglefloatE0MI
{
    Id = 55,
    Value = 0.63449645f,
    NullableValue = null,
},
    NullableValue = 0.47033036f,
},
            new SinglefloatE0M
{
    Id = 112,
    Value = 0.5003497f,
    ModelInner = null,
    NullableValue = 0.39927477f,
},
            new SinglefloatE0M
{
    Id = 115,
    Value = 0.840683f,
    ModelInner = new SinglefloatE0MI
{
    Id = 61,
    Value = 0.42716384f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 116,
    Value = 0.23787671f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 118,
    Value = 0.93549836f,
    ModelInner = new SinglefloatE0MI
{
    Id = 67,
    Value = 0.7968991f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 124,
    Value = 0.45348698f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 130,
    Value = 0.27404344f,
    ModelInner = new SinglefloatE0MI
{
    Id = 69,
    Value = 0.28620702f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 138,
    Value = 0.5469978f,
    ModelInner = null,
    NullableValue = 0.97664475f,
},
            new SinglefloatE0M
{
    Id = 139,
    Value = 0.41691256f,
    ModelInner = new SinglefloatE0MI
{
    Id = 78,
    Value = 0.2840011f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 140,
    Value = 0.59243673f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 141,
    Value = 0.114460826f,
    ModelInner = new SinglefloatE0MI
{
    Id = 84,
    Value = 0.08203387f,
    NullableValue = null,
},
    NullableValue = 0.23424125f,
},
            new SinglefloatE0M
{
    Id = 150,
    Value = 0.5992492f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 156,
    Value = 0.82703197f,
    ModelInner = new SinglefloatE0MI
{
    Id = 89,
    Value = 0.22074497f,
    NullableValue = 0.3177365f,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 162,
    Value = 0.1267119f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 168,
    Value = 0.468593f,
    ModelInner = new SinglefloatE0MI
{
    Id = 96,
    Value = 0.32900578f,
    NullableValue = null,
},
    NullableValue = 0.84308285f,
},
            new SinglefloatE0M
{
    Id = 170,
    Value = 0.54599494f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 171,
    Value = 0.7970018f,
    ModelInner = new SinglefloatE0MI
{
    Id = 97,
    Value = 0.07578701f,
    NullableValue = 0.71148616f,
},
    NullableValue = null,
},
            new SinglefloatE0M
{
    Id = 173,
    Value = 0.5858476f,
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 112;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 41;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[24],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[25],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        SinglefloatE0M.AssertModel(models[0],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SinglefloatE0M.AssertModel(models[0],_testData[6], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[7], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[8], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[9], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[10], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[11], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[12], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[22],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[23],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[24],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[25],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[26],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[27],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglefloatE0M.AssertModel(models[0],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[34], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 168, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[34], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 170, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(firstItems2[19],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 168, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[34], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 139, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglefloatE0M.AssertModel(models[0],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(models[1],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(models[2],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(models[3],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(models[4],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(models[5],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(models[6],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(models[7],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(models[8],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(models[9],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(models[10],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(models[11],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(models[12],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(models[13],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(models[14],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(models[15],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(models[16],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(models[17],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(models[18],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(models[19],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(models[20],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(models[21],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(models[22],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(models[23],_testData[34], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglefloatE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglefloatE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSinglefloatE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSinglefloatE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglefloatE0M.AssertModel(models[0],_testData[10], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[11], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[12], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[13], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[14], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[15], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[16], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[17], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[18], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[19], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[20], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[21], false);
                        SinglefloatE0M.AssertModel(models[12],_testData[22], false);
                        SinglefloatE0M.AssertModel(models[13],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[14],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[15],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[16],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[17],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[18],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[19],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[20],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[21],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[22],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[23],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[24],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 50, 124))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglefloatE0M.AssertModel(models[0],_testData[23], false);
                        SinglefloatE0M.AssertModel(models[1],_testData[24], false);
                        SinglefloatE0M.AssertModel(models[2],_testData[25], false);
                        SinglefloatE0M.AssertModel(models[3],_testData[26], false);
                        SinglefloatE0M.AssertModel(models[4],_testData[27], false);
                        SinglefloatE0M.AssertModel(models[5],_testData[28], false);
                        SinglefloatE0M.AssertModel(models[6],_testData[29], false);
                        SinglefloatE0M.AssertModel(models[7],_testData[30], false);
                        SinglefloatE0M.AssertModel(models[8],_testData[31], false);
                        SinglefloatE0M.AssertModel(models[9],_testData[32], false);
                        SinglefloatE0M.AssertModel(models[10],_testData[33], false);
                        SinglefloatE0M.AssertModel(models[11],_testData[34], false);
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
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                SinglefloatE0M.AssertModel(models[0],_testData[11], false);
                SinglefloatE0M.AssertModel(models[1],_testData[12], false);
                SinglefloatE0M.AssertModel(models[2],_testData[13], false);
                SinglefloatE0M.AssertModel(models[3],_testData[14], false);
                SinglefloatE0M.AssertModel(models[4],_testData[15], false);
                SinglefloatE0M.AssertModel(models[5],_testData[16], false);
                SinglefloatE0M.AssertModel(models[6],_testData[17], false);
                SinglefloatE0M.AssertModel(models[7],_testData[18], false);
                SinglefloatE0M.AssertModel(models[8],_testData[19], false);
                SinglefloatE0M.AssertModel(models[9],_testData[20], false);
                SinglefloatE0M.AssertModel(models[10],_testData[21], false);
                SinglefloatE0M.AssertModel(models[11],_testData[22], false);
                SinglefloatE0M.AssertModel(models[12],_testData[23], false);
                SinglefloatE0M.AssertModel(models[13],_testData[24], false);
                SinglefloatE0M.AssertModel(models[14],_testData[25], false);
                SinglefloatE0M.AssertModel(models[15],_testData[26], false);
                SinglefloatE0M.AssertModel(models[16],_testData[27], false);
                SinglefloatE0M.AssertModel(models[17],_testData[28], false);
                SinglefloatE0M.AssertModel(models[18],_testData[29], false);
                SinglefloatE0M.AssertModel(models[19],_testData[30], false);
                SinglefloatE0M.AssertModel(models[20],_testData[31], false);
                SinglefloatE0M.AssertModel(models[21],_testData[32], false);
                SinglefloatE0M.AssertModel(models[22],_testData[33], false);
                SinglefloatE0M.AssertModel(models[23],_testData[34], false);
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
                Assert.That((System.Single)model[1], Is.EqualTo((0.08998436f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.877164f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8860548f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6652714f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7505934f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.57007104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4865471f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.55461085f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3479305f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38914597f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30761492f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.54457825f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6115609f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38784832f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38395888f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23153406f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12564838f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5873939f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8750895f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.36775327f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.024213135f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.60812366f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7151892f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5809605f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23635823f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.54779345f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32148576f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.67593104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.68039507f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.29373878f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3656512f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.74861944f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86042726f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.0029612184f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.58503324f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5252407f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.47184205f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.054210663f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1988501f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.63449645f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.47033036f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5003497f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.39927477f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.840683f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42716384f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23787671f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.93549836f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7968991f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.45348698f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27404344f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.28620702f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5469978f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.97664475f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.41691256f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2840011f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59243673f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.114460826f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08203387f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23424125f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5992492f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.82703197f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.22074497f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3177365f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1267119f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.468593f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.32900578f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.84308285f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54599494f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7970018f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.07578701f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.71148616f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5858476f)));//Value

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
                Assert.That((System.Single)model[1], Is.EqualTo((0.08998436f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.877164f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8860548f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6652714f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7505934f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.57007104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4865471f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.55461085f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3479305f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38914597f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30761492f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.54457825f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6115609f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38784832f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38395888f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23153406f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12564838f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5873939f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8750895f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.36775327f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.024213135f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.60812366f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7151892f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5809605f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23635823f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.54779345f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32148576f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.67593104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.68039507f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.29373878f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3656512f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.74861944f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86042726f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.0029612184f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.58503324f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5252407f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.47184205f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.054210663f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1988501f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.63449645f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.47033036f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5003497f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.39927477f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.840683f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42716384f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23787671f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.93549836f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7968991f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.45348698f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27404344f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.28620702f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5469978f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.97664475f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.41691256f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2840011f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59243673f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.114460826f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08203387f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23424125f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5992492f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.82703197f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.22074497f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3177365f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1267119f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.468593f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.32900578f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.84308285f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54599494f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7970018f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.07578701f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.71148616f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5858476f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


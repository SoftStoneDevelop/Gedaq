

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
    Id = 1,
    Value = 0.9723819f,
    ModelInner = null,
    NullableValue = 0.81241494f,
},
            new Singlefloat0M
{
    Id = 10,
    Value = 0.42077994f,
    ModelInner = new Singlefloat0MI
{
    Id = 8,
    Value = 0.51535463f,
    NullableValue = null,
},
    NullableValue = 0.4678973f,
},
            new Singlefloat0M
{
    Id = 13,
    Value = 0.63623315f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 19,
    Value = 0.8851011f,
    ModelInner = new Singlefloat0MI
{
    Id = 9,
    Value = 0.7952743f,
    NullableValue = 0.28678942f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 23,
    Value = 0.446047f,
    ModelInner = null,
    NullableValue = 0.4222365f,
},
            new Singlefloat0M
{
    Id = 26,
    Value = 0.031033576f,
    ModelInner = new Singlefloat0MI
{
    Id = 18,
    Value = 0.7540158f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 29,
    Value = 0.7481861f,
    ModelInner = null,
    NullableValue = 0.84866357f,
},
            new Singlefloat0M
{
    Id = 38,
    Value = 0.9787862f,
    ModelInner = new Singlefloat0MI
{
    Id = 21,
    Value = 0.52621f,
    NullableValue = 0.40237838f,
},
    NullableValue = 0.87736523f,
},
            new Singlefloat0M
{
    Id = 44,
    Value = 0.039843142f,
    ModelInner = null,
    NullableValue = 0.7192585f,
},
            new Singlefloat0M
{
    Id = 51,
    Value = 0.9225176f,
    ModelInner = new Singlefloat0MI
{
    Id = 24,
    Value = 0.3060587f,
    NullableValue = null,
},
    NullableValue = 0.30236185f,
},
            new Singlefloat0M
{
    Id = 52,
    Value = 0.79836076f,
    ModelInner = null,
    NullableValue = 0.18140149f,
},
            new Singlefloat0M
{
    Id = 54,
    Value = 0.4234934f,
    ModelInner = new Singlefloat0MI
{
    Id = 33,
    Value = 0.34783065f,
    NullableValue = null,
},
    NullableValue = 0.8423324f,
},
            new Singlefloat0M
{
    Id = 61,
    Value = 0.1996473f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 67,
    Value = 0.47322273f,
    ModelInner = new Singlefloat0MI
{
    Id = 36,
    Value = 0.45414567f,
    NullableValue = 0.046761394f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 74,
    Value = 0.54583013f,
    ModelInner = null,
    NullableValue = 0.6043127f,
},
            new Singlefloat0M
{
    Id = 77,
    Value = 0.68824464f,
    ModelInner = new Singlefloat0MI
{
    Id = 42,
    Value = 0.23194677f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 86,
    Value = 0.4074368f,
    ModelInner = null,
    NullableValue = 0.7580069f,
},
            new Singlefloat0M
{
    Id = 94,
    Value = 0.83788687f,
    ModelInner = new Singlefloat0MI
{
    Id = 48,
    Value = 0.081676245f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 98,
    Value = 0.24179739f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 105,
    Value = 0.13222456f,
    ModelInner = new Singlefloat0MI
{
    Id = 57,
    Value = 0.7668681f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 110,
    Value = 0.9001862f,
    ModelInner = null,
    NullableValue = 0.0961501f,
},
            new Singlefloat0M
{
    Id = 115,
    Value = 0.15556222f,
    ModelInner = new Singlefloat0MI
{
    Id = 61,
    Value = 0.88429147f,
    NullableValue = null,
},
    NullableValue = 0.38118672f,
},
            new Singlefloat0M
{
    Id = 117,
    Value = 0.999562f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 125,
    Value = 0.32270092f,
    ModelInner = new Singlefloat0MI
{
    Id = 62,
    Value = 0.920897f,
    NullableValue = 0.5113715f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 134,
    Value = 0.76335543f,
    ModelInner = null,
    NullableValue = 0.92226607f,
},
            new Singlefloat0M
{
    Id = 135,
    Value = 0.5256596f,
    ModelInner = new Singlefloat0MI
{
    Id = 67,
    Value = 0.30497187f,
    NullableValue = 0.9477849f,
},
    NullableValue = 0.15001684f,
},
            new Singlefloat0M
{
    Id = 140,
    Value = 0.5167503f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 144,
    Value = 0.34059578f,
    ModelInner = new Singlefloat0MI
{
    Id = 75,
    Value = 0.2162087f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 147,
    Value = 0.29345202f,
    ModelInner = null,
    NullableValue = 0.53265727f,
},
            new Singlefloat0M
{
    Id = 153,
    Value = 0.03379363f,
    ModelInner = new Singlefloat0MI
{
    Id = 77,
    Value = 0.044561446f,
    NullableValue = null,
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[27],_testData[29], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[29], false);
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
                parametr1.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[17],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[18],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[19],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[20],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[21],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[22],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[23],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[24],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[25],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[26],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Singlefloat0M.AssertModel(models[0],_testData[9], false);
                        Singlefloat0M.AssertModel(models[1],_testData[10], false);
                        Singlefloat0M.AssertModel(models[2],_testData[11], false);
                        Singlefloat0M.AssertModel(models[3],_testData[12], false);
                        Singlefloat0M.AssertModel(models[4],_testData[13], false);
                        Singlefloat0M.AssertModel(models[5],_testData[14], false);
                        Singlefloat0M.AssertModel(models[6],_testData[15], false);
                        Singlefloat0M.AssertModel(models[7],_testData[16], false);
                        Singlefloat0M.AssertModel(models[8],_testData[17], false);
                        Singlefloat0M.AssertModel(models[9],_testData[18], false);
                        Singlefloat0M.AssertModel(models[10],_testData[19], false);
                        Singlefloat0M.AssertModel(models[11],_testData[20], false);
                        Singlefloat0M.AssertModel(models[12],_testData[21], false);
                        Singlefloat0M.AssertModel(models[13],_testData[22], false);
                        Singlefloat0M.AssertModel(models[14],_testData[23], false);
                        Singlefloat0M.AssertModel(models[15],_testData[24], false);
                        Singlefloat0M.AssertModel(models[16],_testData[25], false);
                        Singlefloat0M.AssertModel(models[17],_testData[26], false);
                        Singlefloat0M.AssertModel(models[18],_testData[27], false);
                        Singlefloat0M.AssertModel(models[19],_testData[28], false);
                        Singlefloat0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Singlefloat0M.AssertModel(models[0],_testData[8], false);
                        Singlefloat0M.AssertModel(models[1],_testData[9], false);
                        Singlefloat0M.AssertModel(models[2],_testData[10], false);
                        Singlefloat0M.AssertModel(models[3],_testData[11], false);
                        Singlefloat0M.AssertModel(models[4],_testData[12], false);
                        Singlefloat0M.AssertModel(models[5],_testData[13], false);
                        Singlefloat0M.AssertModel(models[6],_testData[14], false);
                        Singlefloat0M.AssertModel(models[7],_testData[15], false);
                        Singlefloat0M.AssertModel(models[8],_testData[16], false);
                        Singlefloat0M.AssertModel(models[9],_testData[17], false);
                        Singlefloat0M.AssertModel(models[10],_testData[18], false);
                        Singlefloat0M.AssertModel(models[11],_testData[19], false);
                        Singlefloat0M.AssertModel(models[12],_testData[20], false);
                        Singlefloat0M.AssertModel(models[13],_testData[21], false);
                        Singlefloat0M.AssertModel(models[14],_testData[22], false);
                        Singlefloat0M.AssertModel(models[15],_testData[23], false);
                        Singlefloat0M.AssertModel(models[16],_testData[24], false);
                        Singlefloat0M.AssertModel(models[17],_testData[25], false);
                        Singlefloat0M.AssertModel(models[18],_testData[26], false);
                        Singlefloat0M.AssertModel(models[19],_testData[27], false);
                        Singlefloat0M.AssertModel(models[20],_testData[28], false);
                        Singlefloat0M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Singlefloat0M.AssertModel(models[0],_testData[26], false);
                        Singlefloat0M.AssertModel(models[1],_testData[27], false);
                        Singlefloat0M.AssertModel(models[2],_testData[28], false);
                        Singlefloat0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[29], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 134, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 94, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[29], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[17],_testData[29], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 1, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[29], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 44, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Singlefloat0M.AssertModel(models[0],_testData[9], false);
                        Singlefloat0M.AssertModel(models[1],_testData[10], false);
                        Singlefloat0M.AssertModel(models[2],_testData[11], false);
                        Singlefloat0M.AssertModel(models[3],_testData[12], false);
                        Singlefloat0M.AssertModel(models[4],_testData[13], false);
                        Singlefloat0M.AssertModel(models[5],_testData[14], false);
                        Singlefloat0M.AssertModel(models[6],_testData[15], false);
                        Singlefloat0M.AssertModel(models[7],_testData[16], false);
                        Singlefloat0M.AssertModel(models[8],_testData[17], false);
                        Singlefloat0M.AssertModel(models[9],_testData[18], false);
                        Singlefloat0M.AssertModel(models[10],_testData[19], false);
                        Singlefloat0M.AssertModel(models[11],_testData[20], false);
                        Singlefloat0M.AssertModel(models[12],_testData[21], false);
                        Singlefloat0M.AssertModel(models[13],_testData[22], false);
                        Singlefloat0M.AssertModel(models[14],_testData[23], false);
                        Singlefloat0M.AssertModel(models[15],_testData[24], false);
                        Singlefloat0M.AssertModel(models[16],_testData[25], false);
                        Singlefloat0M.AssertModel(models[17],_testData[26], false);
                        Singlefloat0M.AssertModel(models[18],_testData[27], false);
                        Singlefloat0M.AssertModel(models[19],_testData[28], false);
                        Singlefloat0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Singlefloat0M.AssertModel(models[0],_testData[24], false);
                        Singlefloat0M.AssertModel(models[1],_testData[25], false);
                        Singlefloat0M.AssertModel(models[2],_testData[26], false);
                        Singlefloat0M.AssertModel(models[3],_testData[27], false);
                        Singlefloat0M.AssertModel(models[4],_testData[28], false);
                        Singlefloat0M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 10, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Singlefloat0M.AssertModel(models[0],_testData[2], false);
                        Singlefloat0M.AssertModel(models[1],_testData[3], false);
                        Singlefloat0M.AssertModel(models[2],_testData[4], false);
                        Singlefloat0M.AssertModel(models[3],_testData[5], false);
                        Singlefloat0M.AssertModel(models[4],_testData[6], false);
                        Singlefloat0M.AssertModel(models[5],_testData[7], false);
                        Singlefloat0M.AssertModel(models[6],_testData[8], false);
                        Singlefloat0M.AssertModel(models[7],_testData[9], false);
                        Singlefloat0M.AssertModel(models[8],_testData[10], false);
                        Singlefloat0M.AssertModel(models[9],_testData[11], false);
                        Singlefloat0M.AssertModel(models[10],_testData[12], false);
                        Singlefloat0M.AssertModel(models[11],_testData[13], false);
                        Singlefloat0M.AssertModel(models[12],_testData[14], false);
                        Singlefloat0M.AssertModel(models[13],_testData[15], false);
                        Singlefloat0M.AssertModel(models[14],_testData[16], false);
                        Singlefloat0M.AssertModel(models[15],_testData[17], false);
                        Singlefloat0M.AssertModel(models[16],_testData[18], false);
                        Singlefloat0M.AssertModel(models[17],_testData[19], false);
                        Singlefloat0M.AssertModel(models[18],_testData[20], false);
                        Singlefloat0M.AssertModel(models[19],_testData[21], false);
                        Singlefloat0M.AssertModel(models[20],_testData[22], false);
                        Singlefloat0M.AssertModel(models[21],_testData[23], false);
                        Singlefloat0M.AssertModel(models[22],_testData[24], false);
                        Singlefloat0M.AssertModel(models[23],_testData[25], false);
                        Singlefloat0M.AssertModel(models[24],_testData[26], false);
                        Singlefloat0M.AssertModel(models[25],_testData[27], false);
                        Singlefloat0M.AssertModel(models[26],_testData[28], false);
                        Singlefloat0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Singlefloat0M.AssertModel(models[0],_testData[27], false);
                        Singlefloat0M.AssertModel(models[1],_testData[28], false);
                        Singlefloat0M.AssertModel(models[2],_testData[29], false);
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
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models = await ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Singlefloat0M.AssertModel(models[0],_testData[17], false);Singlefloat0M.AssertModel(models[1],_testData[18], false);Singlefloat0M.AssertModel(models[2],_testData[19], false);Singlefloat0M.AssertModel(models[3],_testData[20], false);Singlefloat0M.AssertModel(models[4],_testData[21], false);Singlefloat0M.AssertModel(models[5],_testData[22], false);Singlefloat0M.AssertModel(models[6],_testData[23], false);Singlefloat0M.AssertModel(models[7],_testData[24], false);Singlefloat0M.AssertModel(models[8],_testData[25], false);Singlefloat0M.AssertModel(models[9],_testData[26], false);Singlefloat0M.AssertModel(models[10],_testData[27], false);Singlefloat0M.AssertModel(models[11],_testData[28], false);Singlefloat0M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
Singlefloat0M.AssertModel(models[0],_testData[24], false);Singlefloat0M.AssertModel(models[1],_testData[25], false);Singlefloat0M.AssertModel(models[2],_testData[26], false);Singlefloat0M.AssertModel(models[3],_testData[27], false);Singlefloat0M.AssertModel(models[4],_testData[28], false);Singlefloat0M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9723819f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.81241494f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.42077994f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.51535463f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4678973f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.63623315f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8851011f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7952743f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.28678942f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.446047f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4222365f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.031033576f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7540158f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7481861f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.84866357f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9787862f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52621f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.40237838f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.87736523f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.039843142f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7192585f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9225176f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3060587f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.30236185f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.79836076f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18140149f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4234934f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.34783065f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8423324f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1996473f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.47322273f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.45414567f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.046761394f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54583013f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6043127f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.68824464f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23194677f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4074368f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7580069f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.83788687f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.081676245f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.24179739f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13222456f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7668681f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9001862f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.0961501f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15556222f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.88429147f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38118672f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.999562f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32270092f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.920897f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5113715f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.76335543f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.92226607f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5256596f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.30497187f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9477849f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.15001684f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5167503f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.34059578f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2162087f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29345202f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.53265727f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.03379363f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.044561446f)));//InnerModel.Value

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
                var models =  ((ISingleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9723819f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.81241494f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.42077994f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.51535463f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4678973f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.63623315f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8851011f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7952743f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.28678942f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.446047f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4222365f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.031033576f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7540158f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7481861f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.84866357f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9787862f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52621f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.40237838f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.87736523f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.039843142f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7192585f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9225176f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3060587f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.30236185f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.79836076f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18140149f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4234934f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.34783065f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8423324f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1996473f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.47322273f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.45414567f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.046761394f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54583013f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6043127f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.68824464f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23194677f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4074368f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7580069f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.83788687f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.081676245f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.24179739f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13222456f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7668681f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9001862f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.0961501f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15556222f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.88429147f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38118672f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.999562f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32270092f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.920897f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5113715f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.76335543f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.92226607f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5256596f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.30497187f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9477849f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.15001684f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5167503f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.34059578f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2162087f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29345202f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.53265727f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.03379363f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.044561446f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}




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
    Id = 8,
    Value = 0.9711738f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 12,
    Value = 0.75089884f,
    ModelInner = new Singlefloat0MI
{
    Id = 7,
    Value = 0.3197537f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 18,
    Value = 0.21014553f,
    ModelInner = null,
    NullableValue = 0.2563529f,
},
            new Singlefloat0M
{
    Id = 19,
    Value = 0.36355525f,
    ModelInner = new Singlefloat0MI
{
    Id = 15,
    Value = 0.3042692f,
    NullableValue = 0.48156166f,
},
    NullableValue = 0.57399476f,
},
            new Singlefloat0M
{
    Id = 21,
    Value = 0.023498058f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 23,
    Value = 0.31426853f,
    ModelInner = new Singlefloat0MI
{
    Id = 20,
    Value = 0.5902237f,
    NullableValue = 0.21483386f,
},
    NullableValue = 0.6446362f,
},
            new Singlefloat0M
{
    Id = 31,
    Value = 0.7257707f,
    ModelInner = null,
    NullableValue = 0.975f,
},
            new Singlefloat0M
{
    Id = 33,
    Value = 0.45962554f,
    ModelInner = new Singlefloat0MI
{
    Id = 25,
    Value = 0.65384936f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 34,
    Value = 0.8701946f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 40,
    Value = 0.7129633f,
    ModelInner = new Singlefloat0MI
{
    Id = 32,
    Value = 0.8542092f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 49,
    Value = 0.59466815f,
    ModelInner = null,
    NullableValue = 0.41144556f,
},
            new Singlefloat0M
{
    Id = 54,
    Value = 0.15361464f,
    ModelInner = new Singlefloat0MI
{
    Id = 40,
    Value = 0.538908f,
    NullableValue = null,
},
    NullableValue = 0.6574768f,
},
            new Singlefloat0M
{
    Id = 62,
    Value = 0.3881343f,
    ModelInner = null,
    NullableValue = 0.18053317f,
},
            new Singlefloat0M
{
    Id = 63,
    Value = 0.27960718f,
    ModelInner = new Singlefloat0MI
{
    Id = 43,
    Value = 0.017874956f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 70,
    Value = 0.5194818f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 76,
    Value = 0.6078204f,
    ModelInner = new Singlefloat0MI
{
    Id = 52,
    Value = 0.9107392f,
    NullableValue = 0.06326836f,
},
    NullableValue = 0.7721235f,
},
            new Singlefloat0M
{
    Id = 85,
    Value = 0.5759397f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 94,
    Value = 0.7341834f,
    ModelInner = new Singlefloat0MI
{
    Id = 54,
    Value = 0.34953386f,
    NullableValue = 0.34790915f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 97,
    Value = 0.28682846f,
    ModelInner = null,
    NullableValue = 0.42871523f,
},
            new Singlefloat0M
{
    Id = 99,
    Value = 0.59794104f,
    ModelInner = new Singlefloat0MI
{
    Id = 57,
    Value = 0.36062354f,
    NullableValue = null,
},
    NullableValue = 0.14694566f,
},
            new Singlefloat0M
{
    Id = 101,
    Value = 0.30643147f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 106,
    Value = 0.13143641f,
    ModelInner = new Singlefloat0MI
{
    Id = 64,
    Value = 0.5998955f,
    NullableValue = 0.9356916f,
},
    NullableValue = 0.9311335f,
},
            new Singlefloat0M
{
    Id = 112,
    Value = 0.39595515f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 121,
    Value = 0.52903813f,
    ModelInner = new Singlefloat0MI
{
    Id = 68,
    Value = 0.5153869f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 125,
    Value = 0.16002983f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 126,
    Value = 0.566536f,
    ModelInner = new Singlefloat0MI
{
    Id = 75,
    Value = 0.35115367f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 128,
    Value = 0.10929328f,
    ModelInner = null,
    NullableValue = 0.8379189f,
},
            new Singlefloat0M
{
    Id = 132,
    Value = 0.3753922f,
    ModelInner = new Singlefloat0MI
{
    Id = 82,
    Value = 0.87716776f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 133,
    Value = 0.7447567f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 141,
    Value = 0.3531266f,
    ModelInner = new Singlefloat0MI
{
    Id = 87,
    Value = 0.5529424f,
    NullableValue = 0.7057073f,
},
    NullableValue = 0.75830543f,
},
            new Singlefloat0M
{
    Id = 148,
    Value = 0.06603986f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 157,
    Value = 0.8199233f,
    ModelInner = new Singlefloat0MI
{
    Id = 90,
    Value = 0.43967623f,
    NullableValue = null,
},
    NullableValue = 0.9439002f,
},
            new Singlefloat0M
{
    Id = 164,
    Value = 0.068935156f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 166,
    Value = 0.96640676f,
    ModelInner = new Singlefloat0MI
{
    Id = 97,
    Value = 0.16727346f,
    NullableValue = 0.44510144f,
},
    NullableValue = null,
},
            new Singlefloat0M
{
    Id = 171,
    Value = 0.061431587f,
    ModelInner = null,
    NullableValue = 0.18569386f,
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
                parametr1.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[23],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 133;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
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
                        FlatSinglefloat0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Singlefloat0M.AssertModel(models[0],_testData[1], false);
                        Singlefloat0M.AssertModel(models[1],_testData[2], false);
                        Singlefloat0M.AssertModel(models[2],_testData[3], false);
                        Singlefloat0M.AssertModel(models[3],_testData[4], false);
                        Singlefloat0M.AssertModel(models[4],_testData[5], false);
                        Singlefloat0M.AssertModel(models[5],_testData[6], false);
                        Singlefloat0M.AssertModel(models[6],_testData[7], false);
                        Singlefloat0M.AssertModel(models[7],_testData[8], false);
                        Singlefloat0M.AssertModel(models[8],_testData[9], false);
                        Singlefloat0M.AssertModel(models[9],_testData[10], false);
                        Singlefloat0M.AssertModel(models[10],_testData[11], false);
                        Singlefloat0M.AssertModel(models[11],_testData[12], false);
                        Singlefloat0M.AssertModel(models[12],_testData[13], false);
                        Singlefloat0M.AssertModel(models[13],_testData[14], false);
                        Singlefloat0M.AssertModel(models[14],_testData[15], false);
                        Singlefloat0M.AssertModel(models[15],_testData[16], false);
                        Singlefloat0M.AssertModel(models[16],_testData[17], false);
                        Singlefloat0M.AssertModel(models[17],_testData[18], false);
                        Singlefloat0M.AssertModel(models[18],_testData[19], false);
                        Singlefloat0M.AssertModel(models[19],_testData[20], false);
                        Singlefloat0M.AssertModel(models[20],_testData[21], false);
                        Singlefloat0M.AssertModel(models[21],_testData[22], false);
                        Singlefloat0M.AssertModel(models[22],_testData[23], false);
                        Singlefloat0M.AssertModel(models[23],_testData[24], false);
                        Singlefloat0M.AssertModel(models[24],_testData[25], false);
                        Singlefloat0M.AssertModel(models[25],_testData[26], false);
                        Singlefloat0M.AssertModel(models[26],_testData[27], false);
                        Singlefloat0M.AssertModel(models[27],_testData[28], false);
                        Singlefloat0M.AssertModel(models[28],_testData[29], false);
                        Singlefloat0M.AssertModel(models[29],_testData[30], false);
                        Singlefloat0M.AssertModel(models[30],_testData[31], false);
                        Singlefloat0M.AssertModel(models[31],_testData[32], false);
                        Singlefloat0M.AssertModel(models[32],_testData[33], false);
                        Singlefloat0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Singlefloat0M.AssertModel(models[0],_testData[6], false);
                        Singlefloat0M.AssertModel(models[1],_testData[7], false);
                        Singlefloat0M.AssertModel(models[2],_testData[8], false);
                        Singlefloat0M.AssertModel(models[3],_testData[9], false);
                        Singlefloat0M.AssertModel(models[4],_testData[10], false);
                        Singlefloat0M.AssertModel(models[5],_testData[11], false);
                        Singlefloat0M.AssertModel(models[6],_testData[12], false);
                        Singlefloat0M.AssertModel(models[7],_testData[13], false);
                        Singlefloat0M.AssertModel(models[8],_testData[14], false);
                        Singlefloat0M.AssertModel(models[9],_testData[15], false);
                        Singlefloat0M.AssertModel(models[10],_testData[16], false);
                        Singlefloat0M.AssertModel(models[11],_testData[17], false);
                        Singlefloat0M.AssertModel(models[12],_testData[18], false);
                        Singlefloat0M.AssertModel(models[13],_testData[19], false);
                        Singlefloat0M.AssertModel(models[14],_testData[20], false);
                        Singlefloat0M.AssertModel(models[15],_testData[21], false);
                        Singlefloat0M.AssertModel(models[16],_testData[22], false);
                        Singlefloat0M.AssertModel(models[17],_testData[23], false);
                        Singlefloat0M.AssertModel(models[18],_testData[24], false);
                        Singlefloat0M.AssertModel(models[19],_testData[25], false);
                        Singlefloat0M.AssertModel(models[20],_testData[26], false);
                        Singlefloat0M.AssertModel(models[21],_testData[27], false);
                        Singlefloat0M.AssertModel(models[22],_testData[28], false);
                        Singlefloat0M.AssertModel(models[23],_testData[29], false);
                        Singlefloat0M.AssertModel(models[24],_testData[30], false);
                        Singlefloat0M.AssertModel(models[25],_testData[31], false);
                        Singlefloat0M.AssertModel(models[26],_testData[32], false);
                        Singlefloat0M.AssertModel(models[27],_testData[33], false);
                        Singlefloat0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        Singlefloat0M.AssertModel(models[21],_testData[30], false);
                        Singlefloat0M.AssertModel(models[22],_testData[31], false);
                        Singlefloat0M.AssertModel(models[23],_testData[32], false);
                        Singlefloat0M.AssertModel(models[24],_testData[33], false);
                        Singlefloat0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 97, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglefloat0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 148, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 101, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatSinglefloat0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 94, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[11],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[12],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[13],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[14],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[15],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[16],_testData[34], false);
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
                await ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglefloat0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[31],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 121, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglefloat0M.AssertModel(models[0],_testData[24], false);
                        FlatSinglefloat0M.AssertModel(models[1],_testData[25], false);
                        FlatSinglefloat0M.AssertModel(models[2],_testData[26], false);
                        FlatSinglefloat0M.AssertModel(models[3],_testData[27], false);
                        FlatSinglefloat0M.AssertModel(models[4],_testData[28], false);
                        FlatSinglefloat0M.AssertModel(models[5],_testData[29], false);
                        FlatSinglefloat0M.AssertModel(models[6],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[7],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[8],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[9],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatSinglefloat0M.AssertModel(models[18],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(models[19],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(models[20],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(models[21],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(models[22],_testData[34], false);
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
                 ((ISingleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                        FlatSinglefloat0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglefloat0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglefloat0M.AssertModel(secondItems2[13],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 54))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Singlefloat0M.AssertModel(models[0],_testData[12], false);
                        Singlefloat0M.AssertModel(models[1],_testData[13], false);
                        Singlefloat0M.AssertModel(models[2],_testData[14], false);
                        Singlefloat0M.AssertModel(models[3],_testData[15], false);
                        Singlefloat0M.AssertModel(models[4],_testData[16], false);
                        Singlefloat0M.AssertModel(models[5],_testData[17], false);
                        Singlefloat0M.AssertModel(models[6],_testData[18], false);
                        Singlefloat0M.AssertModel(models[7],_testData[19], false);
                        Singlefloat0M.AssertModel(models[8],_testData[20], false);
                        Singlefloat0M.AssertModel(models[9],_testData[21], false);
                        Singlefloat0M.AssertModel(models[10],_testData[22], false);
                        Singlefloat0M.AssertModel(models[11],_testData[23], false);
                        Singlefloat0M.AssertModel(models[12],_testData[24], false);
                        Singlefloat0M.AssertModel(models[13],_testData[25], false);
                        Singlefloat0M.AssertModel(models[14],_testData[26], false);
                        Singlefloat0M.AssertModel(models[15],_testData[27], false);
                        Singlefloat0M.AssertModel(models[16],_testData[28], false);
                        Singlefloat0M.AssertModel(models[17],_testData[29], false);
                        Singlefloat0M.AssertModel(models[18],_testData[30], false);
                        Singlefloat0M.AssertModel(models[19],_testData[31], false);
                        Singlefloat0M.AssertModel(models[20],_testData[32], false);
                        Singlefloat0M.AssertModel(models[21],_testData[33], false);
                        Singlefloat0M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 157, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Singlefloat0M.AssertModel(models[0],_testData[32], false);
                        Singlefloat0M.AssertModel(models[1],_testData[33], false);
                        Singlefloat0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Singlefloat0M.AssertModel(models[0],_testData[27], false);
                        Singlefloat0M.AssertModel(models[1],_testData[28], false);
                        Singlefloat0M.AssertModel(models[2],_testData[29], false);
                        Singlefloat0M.AssertModel(models[3],_testData[30], false);
                        Singlefloat0M.AssertModel(models[4],_testData[31], false);
                        Singlefloat0M.AssertModel(models[5],_testData[32], false);
                        Singlefloat0M.AssertModel(models[6],_testData[33], false);
                        Singlefloat0M.AssertModel(models[7],_testData[34], false);
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
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Singlefloat0M.AssertModel(models[0],_testData[6], false);
                Singlefloat0M.AssertModel(models[1],_testData[7], false);
                Singlefloat0M.AssertModel(models[2],_testData[8], false);
                Singlefloat0M.AssertModel(models[3],_testData[9], false);
                Singlefloat0M.AssertModel(models[4],_testData[10], false);
                Singlefloat0M.AssertModel(models[5],_testData[11], false);
                Singlefloat0M.AssertModel(models[6],_testData[12], false);
                Singlefloat0M.AssertModel(models[7],_testData[13], false);
                Singlefloat0M.AssertModel(models[8],_testData[14], false);
                Singlefloat0M.AssertModel(models[9],_testData[15], false);
                Singlefloat0M.AssertModel(models[10],_testData[16], false);
                Singlefloat0M.AssertModel(models[11],_testData[17], false);
                Singlefloat0M.AssertModel(models[12],_testData[18], false);
                Singlefloat0M.AssertModel(models[13],_testData[19], false);
                Singlefloat0M.AssertModel(models[14],_testData[20], false);
                Singlefloat0M.AssertModel(models[15],_testData[21], false);
                Singlefloat0M.AssertModel(models[16],_testData[22], false);
                Singlefloat0M.AssertModel(models[17],_testData[23], false);
                Singlefloat0M.AssertModel(models[18],_testData[24], false);
                Singlefloat0M.AssertModel(models[19],_testData[25], false);
                Singlefloat0M.AssertModel(models[20],_testData[26], false);
                Singlefloat0M.AssertModel(models[21],_testData[27], false);
                Singlefloat0M.AssertModel(models[22],_testData[28], false);
                Singlefloat0M.AssertModel(models[23],_testData[29], false);
                Singlefloat0M.AssertModel(models[24],_testData[30], false);
                Singlefloat0M.AssertModel(models[25],_testData[31], false);
                Singlefloat0M.AssertModel(models[26],_testData[32], false);
                Singlefloat0M.AssertModel(models[27],_testData[33], false);
                Singlefloat0M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Singlefloat0M.AssertModel(models[0],_testData[14], false);
                Singlefloat0M.AssertModel(models[1],_testData[15], false);
                Singlefloat0M.AssertModel(models[2],_testData[16], false);
                Singlefloat0M.AssertModel(models[3],_testData[17], false);
                Singlefloat0M.AssertModel(models[4],_testData[18], false);
                Singlefloat0M.AssertModel(models[5],_testData[19], false);
                Singlefloat0M.AssertModel(models[6],_testData[20], false);
                Singlefloat0M.AssertModel(models[7],_testData[21], false);
                Singlefloat0M.AssertModel(models[8],_testData[22], false);
                Singlefloat0M.AssertModel(models[9],_testData[23], false);
                Singlefloat0M.AssertModel(models[10],_testData[24], false);
                Singlefloat0M.AssertModel(models[11],_testData[25], false);
                Singlefloat0M.AssertModel(models[12],_testData[26], false);
                Singlefloat0M.AssertModel(models[13],_testData[27], false);
                Singlefloat0M.AssertModel(models[14],_testData[28], false);
                Singlefloat0M.AssertModel(models[15],_testData[29], false);
                Singlefloat0M.AssertModel(models[16],_testData[30], false);
                Singlefloat0M.AssertModel(models[17],_testData[31], false);
                Singlefloat0M.AssertModel(models[18],_testData[32], false);
                Singlefloat0M.AssertModel(models[19],_testData[33], false);
                Singlefloat0M.AssertModel(models[20],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9711738f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.75089884f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3197537f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.21014553f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2563529f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36355525f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3042692f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.48156166f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.57399476f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.023498058f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31426853f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5902237f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.21483386f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6446362f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7257707f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.975f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.45962554f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.65384936f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8701946f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7129633f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8542092f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59466815f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41144556f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15361464f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.538908f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6574768f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3881343f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18053317f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27960718f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.017874956f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5194818f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6078204f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9107392f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.06326836f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7721235f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5759397f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7341834f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.34953386f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.34790915f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.28682846f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42871523f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59794104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.36062354f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.14694566f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30643147f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13143641f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5998955f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9356916f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9311335f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.39595515f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.52903813f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5153869f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16002983f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.566536f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.35115367f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.10929328f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8379189f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3753922f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.87716776f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7447567f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3531266f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5529424f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7057073f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75830543f)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06603986f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8199233f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.43967623f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9439002f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.068935156f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.96640676f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.16727346f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.44510144f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.061431587f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18569386f)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9711738f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.75089884f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3197537f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.21014553f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2563529f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36355525f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.3042692f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.48156166f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.57399476f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.023498058f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31426853f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5902237f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.21483386f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6446362f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7257707f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.975f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.45962554f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.65384936f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8701946f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7129633f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8542092f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59466815f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41144556f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15361464f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.538908f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6574768f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3881343f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18053317f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27960718f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.017874956f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5194818f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6078204f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9107392f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.06326836f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7721235f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5759397f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7341834f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.34953386f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.34790915f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.28682846f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42871523f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59794104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.36062354f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.14694566f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30643147f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13143641f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5998955f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9356916f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9311335f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.39595515f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.52903813f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5153869f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16002983f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.566536f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.35115367f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.10929328f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8379189f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3753922f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.87716776f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7447567f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3531266f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5529424f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7057073f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75830543f)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06603986f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8199233f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.43967623f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9439002f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.068935156f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.96640676f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.16727346f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.44510144f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.061431587f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18569386f)));

            }
        }

#endregion

    }
}


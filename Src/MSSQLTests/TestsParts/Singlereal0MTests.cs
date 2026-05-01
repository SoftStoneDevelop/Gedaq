

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

        private readonly Singlereal0M[] _testData = new Singlereal0M[]
        {
            new Singlereal0M
{
    Id = 9,
    Value = 0.53271127f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 16,
    Value = 0.4060809f,
    ModelInner = new Singlereal0MI
{
    Id = 1,
    Value = 0.60474885f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 21,
    Value = 0.75931996f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 29,
    Value = 0.7959172f,
    ModelInner = new Singlereal0MI
{
    Id = 7,
    Value = 0.2426089f,
    NullableValue = 0.3783363f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 33,
    Value = 0.034394026f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 37,
    Value = 0.20264155f,
    ModelInner = new Singlereal0MI
{
    Id = 12,
    Value = 0.8552041f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 45,
    Value = 0.7212798f,
    ModelInner = null,
    NullableValue = 0.64170855f,
},
            new Singlereal0M
{
    Id = 51,
    Value = 0.010997474f,
    ModelInner = new Singlereal0MI
{
    Id = 20,
    Value = 0.6200142f,
    NullableValue = 0.531285f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 60,
    Value = 0.7142513f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 61,
    Value = 0.29048127f,
    ModelInner = new Singlereal0MI
{
    Id = 25,
    Value = 0.9387946f,
    NullableValue = null,
},
    NullableValue = 0.5103169f,
},
            new Singlereal0M
{
    Id = 64,
    Value = 0.024497628f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 71,
    Value = 0.1406799f,
    ModelInner = new Singlereal0MI
{
    Id = 32,
    Value = 0.09172386f,
    NullableValue = 4.839897E-05f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 76,
    Value = 0.2813638f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 77,
    Value = 0.6948229f,
    ModelInner = new Singlereal0MI
{
    Id = 39,
    Value = 0.46906966f,
    NullableValue = 0.00730443f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 82,
    Value = 0.977443f,
    ModelInner = null,
    NullableValue = 0.012457371f,
},
            new Singlereal0M
{
    Id = 87,
    Value = 0.9142704f,
    ModelInner = new Singlereal0MI
{
    Id = 47,
    Value = 0.16427535f,
    NullableValue = null,
},
    NullableValue = 0.48044437f,
},
            new Singlereal0M
{
    Id = 92,
    Value = 0.86786866f,
    ModelInner = null,
    NullableValue = 0.5947749f,
},
            new Singlereal0M
{
    Id = 95,
    Value = 0.74613214f,
    ModelInner = new Singlereal0MI
{
    Id = 52,
    Value = 0.853f,
    NullableValue = 0.15113848f,
},
    NullableValue = 0.059147477f,
},
            new Singlereal0M
{
    Id = 104,
    Value = 0.89735776f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 105,
    Value = 0.42181826f,
    ModelInner = new Singlereal0MI
{
    Id = 58,
    Value = 0.8760073f,
    NullableValue = 0.08450532f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 113,
    Value = 0.5450048f,
    ModelInner = null,
    NullableValue = 0.22184992f,
},
            new Singlereal0M
{
    Id = 118,
    Value = 0.1869418f,
    ModelInner = new Singlereal0MI
{
    Id = 60,
    Value = 0.40622115f,
    NullableValue = 0.044491827f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 122,
    Value = 0.74043393f,
    ModelInner = null,
    NullableValue = 0.5313602f,
},
            new Singlereal0M
{
    Id = 130,
    Value = 0.55071104f,
    ModelInner = new Singlereal0MI
{
    Id = 64,
    Value = 0.37227f,
    NullableValue = null,
},
    NullableValue = 0.44784552f,
},
            new Singlereal0M
{
    Id = 135,
    Value = 0.15450424f,
    ModelInner = null,
    NullableValue = 0.18989402f,
},
            new Singlereal0M
{
    Id = 141,
    Value = 0.6719239f,
    ModelInner = new Singlereal0MI
{
    Id = 65,
    Value = 0.013811469f,
    NullableValue = 0.7844375f,
},
    NullableValue = 0.27493405f,
},
            new Singlereal0M
{
    Id = 144,
    Value = 0.71984714f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 150,
    Value = 0.7919324f,
    ModelInner = new Singlereal0MI
{
    Id = 66,
    Value = 0.025986135f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 152,
    Value = 0.4468528f,
    ModelInner = null,
    NullableValue = 0.23638862f,
},
            new Singlereal0M
{
    Id = 161,
    Value = 0.5322462f,
    ModelInner = new Singlereal0MI
{
    Id = 67,
    Value = 0.6255199f,
    NullableValue = 0.25440335f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 163,
    Value = 0.6034391f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 168,
    Value = 0.96963507f,
    ModelInner = new Singlereal0MI
{
    Id = 68,
    Value = 0.901553f,
    NullableValue = 0.7941236f,
},
    NullableValue = 0.35104626f,
},
            new Singlereal0M
{
    Id = 171,
    Value = 0.29922622f,
    ModelInner = null,
    NullableValue = 0.2678058f,
},
            new Singlereal0M
{
    Id = 173,
    Value = 0.5408288f,
    ModelInner = new Singlereal0MI
{
    Id = 71,
    Value = 0.4870922f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 174,
    Value = 0.9187325f,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereal0mi(
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
INSERT INTO dbo.singlereal0mi(
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
INSERT INTO dbo.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereal0mi_id
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
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
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
INSERT INTO dbo.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereal0mi_id
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
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
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
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await((ISingleSingleTypereal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
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
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereal0m m
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
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Singlereal0M)],
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await((ISingleSingleTypereal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypereal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypereal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Singlereal0M)],
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
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
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglereal0M.AssertModel(models[0],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglereal0M.AssertModel(models[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[34], false);
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
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM dbo.singlereal0m m
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
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSinglereal0M.AssertModel(models[0],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglereal0M.AssertModel(models[0],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Singlereal0M)],
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Singlereal0M.AssertModel(models[0],_testData[31], false);
                        Singlereal0M.AssertModel(models[1],_testData[32], false);
                        Singlereal0M.AssertModel(models[2],_testData[33], false);
                        Singlereal0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Singlereal0M.AssertModel(models[0],_testData[29], false);
                        Singlereal0M.AssertModel(models[1],_testData[30], false);
                        Singlereal0M.AssertModel(models[2],_testData[31], false);
                        Singlereal0M.AssertModel(models[3],_testData[32], false);
                        Singlereal0M.AssertModel(models[4],_testData[33], false);
                        Singlereal0M.AssertModel(models[5],_testData[34], false);
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Singlereal0M.AssertModel(models[0],_testData[13], false);
                        Singlereal0M.AssertModel(models[1],_testData[14], false);
                        Singlereal0M.AssertModel(models[2],_testData[15], false);
                        Singlereal0M.AssertModel(models[3],_testData[16], false);
                        Singlereal0M.AssertModel(models[4],_testData[17], false);
                        Singlereal0M.AssertModel(models[5],_testData[18], false);
                        Singlereal0M.AssertModel(models[6],_testData[19], false);
                        Singlereal0M.AssertModel(models[7],_testData[20], false);
                        Singlereal0M.AssertModel(models[8],_testData[21], false);
                        Singlereal0M.AssertModel(models[9],_testData[22], false);
                        Singlereal0M.AssertModel(models[10],_testData[23], false);
                        Singlereal0M.AssertModel(models[11],_testData[24], false);
                        Singlereal0M.AssertModel(models[12],_testData[25], false);
                        Singlereal0M.AssertModel(models[13],_testData[26], false);
                        Singlereal0M.AssertModel(models[14],_testData[27], false);
                        Singlereal0M.AssertModel(models[15],_testData[28], false);
                        Singlereal0M.AssertModel(models[16],_testData[29], false);
                        Singlereal0M.AssertModel(models[17],_testData[30], false);
                        Singlereal0M.AssertModel(models[18],_testData[31], false);
                        Singlereal0M.AssertModel(models[19],_testData[32], false);
                        Singlereal0M.AssertModel(models[20],_testData[33], false);
                        Singlereal0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Singlereal0M.AssertModel(models[0],_testData[26], false);
                        Singlereal0M.AssertModel(models[1],_testData[27], false);
                        Singlereal0M.AssertModel(models[2],_testData[28], false);
                        Singlereal0M.AssertModel(models[3],_testData[29], false);
                        Singlereal0M.AssertModel(models[4],_testData[30], false);
                        Singlereal0M.AssertModel(models[5],_testData[31], false);
                        Singlereal0M.AssertModel(models[6],_testData[32], false);
                        Singlereal0M.AssertModel(models[7],_testData[33], false);
                        Singlereal0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 82, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M)],
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglereal0M.AssertModel(models[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglereal0M.AssertModel(models[0],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[34], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglereal0M.AssertModel(models[0],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglereal0M.AssertModel(models[0],_testData[1], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[2], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[3], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[4], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[5], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[6], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[7], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[8], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[9], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[10], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[11], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[23],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[24],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[25],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[26],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[27],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[28],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[29],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[30],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[31],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[32],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[33],_testData[34], false);
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
FROM dbo.singlereal0m m
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
FROM dbo.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Singlereal0M)],
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 171, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Singlereal0M.AssertModel(models[0],_testData[33], false);
                        Singlereal0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Singlereal0M.AssertModel(models[0],_testData[22], false);
                        Singlereal0M.AssertModel(models[1],_testData[23], false);
                        Singlereal0M.AssertModel(models[2],_testData[24], false);
                        Singlereal0M.AssertModel(models[3],_testData[25], false);
                        Singlereal0M.AssertModel(models[4],_testData[26], false);
                        Singlereal0M.AssertModel(models[5],_testData[27], false);
                        Singlereal0M.AssertModel(models[6],_testData[28], false);
                        Singlereal0M.AssertModel(models[7],_testData[29], false);
                        Singlereal0M.AssertModel(models[8],_testData[30], false);
                        Singlereal0M.AssertModel(models[9],_testData[31], false);
                        Singlereal0M.AssertModel(models[10],_testData[32], false);
                        Singlereal0M.AssertModel(models[11],_testData[33], false);
                        Singlereal0M.AssertModel(models[12],_testData[34], false);
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
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 152, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Singlereal0M.AssertModel(models[0],_testData[29], false);
                        Singlereal0M.AssertModel(models[1],_testData[30], false);
                        Singlereal0M.AssertModel(models[2],_testData[31], false);
                        Singlereal0M.AssertModel(models[3],_testData[32], false);
                        Singlereal0M.AssertModel(models[4],_testData[33], false);
                        Singlereal0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Singlereal0M.AssertModel(models[0],_testData[27], false);
                        Singlereal0M.AssertModel(models[1],_testData[28], false);
                        Singlereal0M.AssertModel(models[2],_testData[29], false);
                        Singlereal0M.AssertModel(models[3],_testData[30], false);
                        Singlereal0M.AssertModel(models[4],_testData[31], false);
                        Singlereal0M.AssertModel(models[5],_testData[32], false);
                        Singlereal0M.AssertModel(models[6],_testData[33], false);
                        Singlereal0M.AssertModel(models[7],_testData[34], false);
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
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 60);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
Singlereal0M.AssertModel(models[0],_testData[9], false);Singlereal0M.AssertModel(models[1],_testData[10], false);Singlereal0M.AssertModel(models[2],_testData[11], false);Singlereal0M.AssertModel(models[3],_testData[12], false);Singlereal0M.AssertModel(models[4],_testData[13], false);Singlereal0M.AssertModel(models[5],_testData[14], false);Singlereal0M.AssertModel(models[6],_testData[15], false);Singlereal0M.AssertModel(models[7],_testData[16], false);Singlereal0M.AssertModel(models[8],_testData[17], false);Singlereal0M.AssertModel(models[9],_testData[18], false);Singlereal0M.AssertModel(models[10],_testData[19], false);Singlereal0M.AssertModel(models[11],_testData[20], false);Singlereal0M.AssertModel(models[12],_testData[21], false);Singlereal0M.AssertModel(models[13],_testData[22], false);Singlereal0M.AssertModel(models[14],_testData[23], false);Singlereal0M.AssertModel(models[15],_testData[24], false);Singlereal0M.AssertModel(models[16],_testData[25], false);Singlereal0M.AssertModel(models[17],_testData[26], false);Singlereal0M.AssertModel(models[18],_testData[27], false);Singlereal0M.AssertModel(models[19],_testData[28], false);Singlereal0M.AssertModel(models[20],_testData[29], false);Singlereal0M.AssertModel(models[21],_testData[30], false);Singlereal0M.AssertModel(models[22],_testData[31], false);Singlereal0M.AssertModel(models[23],_testData[32], false);Singlereal0M.AssertModel(models[24],_testData[33], false);Singlereal0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Singlereal0M.AssertModel(models[0],_testData[17], false);Singlereal0M.AssertModel(models[1],_testData[18], false);Singlereal0M.AssertModel(models[2],_testData[19], false);Singlereal0M.AssertModel(models[3],_testData[20], false);Singlereal0M.AssertModel(models[4],_testData[21], false);Singlereal0M.AssertModel(models[5],_testData[22], false);Singlereal0M.AssertModel(models[6],_testData[23], false);Singlereal0M.AssertModel(models[7],_testData[24], false);Singlereal0M.AssertModel(models[8],_testData[25], false);Singlereal0M.AssertModel(models[9],_testData[26], false);Singlereal0M.AssertModel(models[10],_testData[27], false);Singlereal0M.AssertModel(models[11],_testData[28], false);Singlereal0M.AssertModel(models[12],_testData[29], false);Singlereal0M.AssertModel(models[13],_testData[30], false);Singlereal0M.AssertModel(models[14],_testData[31], false);Singlereal0M.AssertModel(models[15],_testData[32], false);Singlereal0M.AssertModel(models[16],_testData[33], false);Singlereal0M.AssertModel(models[17],_testData[34], false);
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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.53271127f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4060809f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.60474885f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.75931996f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7959172f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2426089f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3783363f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.034394026f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20264155f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8552041f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7212798f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.64170855f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.010997474f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6200142f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.531285f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7142513f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29048127f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9387946f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5103169f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.024497628f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1406799f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.09172386f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((4.839897E-05f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2813638f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6948229f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.46906966f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.00730443f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.977443f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.012457371f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9142704f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.16427535f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48044437f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86786866f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5947749f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74613214f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.853f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.15113848f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.059147477f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.89735776f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.42181826f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8760073f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.08450532f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5450048f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.22184992f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1869418f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.40622115f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.044491827f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74043393f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5313602f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.55071104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.37227f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.44784552f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15450424f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18989402f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6719239f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.013811469f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7844375f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.27493405f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.71984714f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7919324f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.025986135f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4468528f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23638862f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5322462f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6255199f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.25440335f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6034391f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.96963507f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.901553f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7941236f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.35104626f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29922622f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2678058f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5408288f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4870922f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9187325f)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.53271127f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4060809f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.60474885f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.75931996f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7959172f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2426089f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3783363f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.034394026f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20264155f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8552041f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7212798f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.64170855f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.010997474f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6200142f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.531285f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7142513f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29048127f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9387946f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5103169f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.024497628f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1406799f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.09172386f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((4.839897E-05f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2813638f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6948229f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.46906966f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.00730443f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.977443f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.012457371f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9142704f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.16427535f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48044437f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86786866f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5947749f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74613214f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.853f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.15113848f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.059147477f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.89735776f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.42181826f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8760073f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.08450532f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5450048f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.22184992f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1869418f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.40622115f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.044491827f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74043393f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5313602f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.55071104f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.37227f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.44784552f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15450424f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.18989402f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6719239f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.013811469f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7844375f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.27493405f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.71984714f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7919324f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.025986135f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4468528f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23638862f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5322462f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6255199f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.25440335f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6034391f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.96963507f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.901553f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7941236f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.35104626f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29922622f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2678058f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5408288f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4870922f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9187325f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}


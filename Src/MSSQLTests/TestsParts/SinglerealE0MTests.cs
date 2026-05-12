

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
    Id = 1,
    Value = 0.3125959f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 3,
    Value = 0.5778044f,
    ModelInner = new SinglerealE0MI
{
    Id = 8,
    Value = 0.11615455f,
    NullableValue = null,
},
    NullableValue = 0.12819028f,
},
            new SinglerealE0M
{
    Id = 5,
    Value = 0.40191877f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 13,
    Value = 0.91188955f,
    ModelInner = new SinglerealE0MI
{
    Id = 14,
    Value = 0.44959778f,
    NullableValue = 0.14577621f,
},
    NullableValue = 1.8298626E-05f,
},
            new SinglerealE0M
{
    Id = 21,
    Value = 0.9247341f,
    ModelInner = null,
    NullableValue = 0.76791155f,
},
            new SinglerealE0M
{
    Id = 26,
    Value = 0.5057187f,
    ModelInner = new SinglerealE0MI
{
    Id = 23,
    Value = 0.43620777f,
    NullableValue = null,
},
    NullableValue = 0.7674601f,
},
            new SinglerealE0M
{
    Id = 29,
    Value = 0.38231766f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 31,
    Value = 0.31124794f,
    ModelInner = new SinglerealE0MI
{
    Id = 25,
    Value = 0.88711023f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 35,
    Value = 0.2109999f,
    ModelInner = null,
    NullableValue = 0.7195481f,
},
            new SinglerealE0M
{
    Id = 40,
    Value = 0.90385604f,
    ModelInner = new SinglerealE0MI
{
    Id = 34,
    Value = 0.006824553f,
    NullableValue = 0.6909227f,
},
    NullableValue = 0.48552585f,
},
            new SinglerealE0M
{
    Id = 41,
    Value = 0.86163664f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 43,
    Value = 0.5228166f,
    ModelInner = new SinglerealE0MI
{
    Id = 43,
    Value = 0.39554387f,
    NullableValue = 0.3466407f,
},
    NullableValue = 0.9040476f,
},
            new SinglerealE0M
{
    Id = 47,
    Value = 0.88793427f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 54,
    Value = 0.6452593f,
    ModelInner = new SinglerealE0MI
{
    Id = 45,
    Value = 0.62826896f,
    NullableValue = 0.77658314f,
},
    NullableValue = 0.2426945f,
},
            new SinglerealE0M
{
    Id = 62,
    Value = 0.8729891f,
    ModelInner = null,
    NullableValue = 0.44993258f,
},
            new SinglerealE0M
{
    Id = 68,
    Value = 0.08208072f,
    ModelInner = new SinglerealE0MI
{
    Id = 53,
    Value = 0.28686392f,
    NullableValue = null,
},
    NullableValue = 0.6717954f,
},
            new SinglerealE0M
{
    Id = 71,
    Value = 0.16746253f,
    ModelInner = null,
    NullableValue = 0.33784032f,
},
            new SinglerealE0M
{
    Id = 80,
    Value = 0.16567093f,
    ModelInner = new SinglerealE0MI
{
    Id = 57,
    Value = 0.43685526f,
    NullableValue = 0.4976436f,
},
    NullableValue = 0.31236637f,
},
            new SinglerealE0M
{
    Id = 84,
    Value = 0.16974676f,
    ModelInner = null,
    NullableValue = 0.052240074f,
},
            new SinglerealE0M
{
    Id = 90,
    Value = 0.43263388f,
    ModelInner = new SinglerealE0MI
{
    Id = 58,
    Value = 0.5124257f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 93,
    Value = 0.5033526f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 99,
    Value = 0.22732794f,
    ModelInner = new SinglerealE0MI
{
    Id = 61,
    Value = 0.271093f,
    NullableValue = 0.05543369f,
},
    NullableValue = 0.47814578f,
},
            new SinglerealE0M
{
    Id = 103,
    Value = 0.72031474f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 106,
    Value = 0.8400799f,
    ModelInner = new SinglerealE0MI
{
    Id = 65,
    Value = 0.44830227f,
    NullableValue = 0.10217476f,
},
    NullableValue = 0.60056984f,
},
            new SinglerealE0M
{
    Id = 112,
    Value = 0.19743699f,
    ModelInner = null,
    NullableValue = 0.029576957f,
},
            new SinglerealE0M
{
    Id = 113,
    Value = 0.29771245f,
    ModelInner = new SinglerealE0MI
{
    Id = 68,
    Value = 0.6444923f,
    NullableValue = null,
},
    NullableValue = 0.40020323f,
},
            new SinglerealE0M
{
    Id = 115,
    Value = 0.6040767f,
    ModelInner = null,
    NullableValue = 0.027341783f,
},
            new SinglerealE0M
{
    Id = 120,
    Value = 0.8774787f,
    ModelInner = new SinglerealE0MI
{
    Id = 71,
    Value = 0.06685507f,
    NullableValue = null,
},
    NullableValue = 0.98076546f,
},
            new SinglerealE0M
{
    Id = 121,
    Value = 0.05367738f,
    ModelInner = null,
    NullableValue = 0.45263296f,
},
            new SinglerealE0M
{
    Id = 126,
    Value = 0.48220128f,
    ModelInner = new SinglerealE0MI
{
    Id = 72,
    Value = 0.9919328f,
    NullableValue = null,
},
    NullableValue = 0.86074287f,
},
            new SinglerealE0M
{
    Id = 134,
    Value = 0.5132749f,
    ModelInner = null,
    NullableValue = 0.683874f,
},
            new SinglerealE0M
{
    Id = 139,
    Value = 0.84186363f,
    ModelInner = new SinglerealE0MI
{
    Id = 81,
    Value = 0.03151357f,
    NullableValue = null,
},
    NullableValue = 0.8710589f,
},
            new SinglerealE0M
{
    Id = 146,
    Value = 0.9281018f,
    ModelInner = null,
    NullableValue = 0.6137263f,
},
            new SinglerealE0M
{
    Id = 155,
    Value = 0.09708005f,
    ModelInner = new SinglerealE0MI
{
    Id = 89,
    Value = 0.9865807f,
    NullableValue = 0.5176064f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 161,
    Value = 0.7990465f,
    ModelInner = null,
    NullableValue = 0.8657975f,
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 3;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[23],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[24],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[25],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[26],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[27],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[28],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[29],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[34], false);
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
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SinglerealE0M.AssertModel(models[0],_testData[26], false);
                        SinglerealE0M.AssertModel(models[1],_testData[27], false);
                        SinglerealE0M.AssertModel(models[2],_testData[28], false);
                        SinglerealE0M.AssertModel(models[3],_testData[29], false);
                        SinglerealE0M.AssertModel(models[4],_testData[30], false);
                        SinglerealE0M.AssertModel(models[5],_testData[31], false);
                        SinglerealE0M.AssertModel(models[6],_testData[32], false);
                        SinglerealE0M.AssertModel(models[7],_testData[33], false);
                        SinglerealE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 5, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[28],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 120, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 112, query1, 112, query2))
                {
                    if(++resultIndex == 1)
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
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 13, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 62, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SinglerealE0M.AssertModel(models[0],_testData[30], false);
                        SinglerealE0M.AssertModel(models[1],_testData[31], false);
                        SinglerealE0M.AssertModel(models[2],_testData[32], false);
                        SinglerealE0M.AssertModel(models[3],_testData[33], false);
                        SinglerealE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SinglerealE0M.AssertModel(models[0],_testData[19], false);
                        SinglerealE0M.AssertModel(models[1],_testData[20], false);
                        SinglerealE0M.AssertModel(models[2],_testData[21], false);
                        SinglerealE0M.AssertModel(models[3],_testData[22], false);
                        SinglerealE0M.AssertModel(models[4],_testData[23], false);
                        SinglerealE0M.AssertModel(models[5],_testData[24], false);
                        SinglerealE0M.AssertModel(models[6],_testData[25], false);
                        SinglerealE0M.AssertModel(models[7],_testData[26], false);
                        SinglerealE0M.AssertModel(models[8],_testData[27], false);
                        SinglerealE0M.AssertModel(models[9],_testData[28], false);
                        SinglerealE0M.AssertModel(models[10],_testData[29], false);
                        SinglerealE0M.AssertModel(models[11],_testData[30], false);
                        SinglerealE0M.AssertModel(models[12],_testData[31], false);
                        SinglerealE0M.AssertModel(models[13],_testData[32], false);
                        SinglerealE0M.AssertModel(models[14],_testData[33], false);
                        SinglerealE0M.AssertModel(models[15],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 26, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SinglerealE0M.AssertModel(models[0],_testData[6], false);
                        SinglerealE0M.AssertModel(models[1],_testData[7], false);
                        SinglerealE0M.AssertModel(models[2],_testData[8], false);
                        SinglerealE0M.AssertModel(models[3],_testData[9], false);
                        SinglerealE0M.AssertModel(models[4],_testData[10], false);
                        SinglerealE0M.AssertModel(models[5],_testData[11], false);
                        SinglerealE0M.AssertModel(models[6],_testData[12], false);
                        SinglerealE0M.AssertModel(models[7],_testData[13], false);
                        SinglerealE0M.AssertModel(models[8],_testData[14], false);
                        SinglerealE0M.AssertModel(models[9],_testData[15], false);
                        SinglerealE0M.AssertModel(models[10],_testData[16], false);
                        SinglerealE0M.AssertModel(models[11],_testData[17], false);
                        SinglerealE0M.AssertModel(models[12],_testData[18], false);
                        SinglerealE0M.AssertModel(models[13],_testData[19], false);
                        SinglerealE0M.AssertModel(models[14],_testData[20], false);
                        SinglerealE0M.AssertModel(models[15],_testData[21], false);
                        SinglerealE0M.AssertModel(models[16],_testData[22], false);
                        SinglerealE0M.AssertModel(models[17],_testData[23], false);
                        SinglerealE0M.AssertModel(models[18],_testData[24], false);
                        SinglerealE0M.AssertModel(models[19],_testData[25], false);
                        SinglerealE0M.AssertModel(models[20],_testData[26], false);
                        SinglerealE0M.AssertModel(models[21],_testData[27], false);
                        SinglerealE0M.AssertModel(models[22],_testData[28], false);
                        SinglerealE0M.AssertModel(models[23],_testData[29], false);
                        SinglerealE0M.AssertModel(models[24],_testData[30], false);
                        SinglerealE0M.AssertModel(models[25],_testData[31], false);
                        SinglerealE0M.AssertModel(models[26],_testData[32], false);
                        SinglerealE0M.AssertModel(models[27],_testData[33], false);
                        SinglerealE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        SinglerealE0M.AssertModel(models[0],_testData[1], false);
                        SinglerealE0M.AssertModel(models[1],_testData[2], false);
                        SinglerealE0M.AssertModel(models[2],_testData[3], false);
                        SinglerealE0M.AssertModel(models[3],_testData[4], false);
                        SinglerealE0M.AssertModel(models[4],_testData[5], false);
                        SinglerealE0M.AssertModel(models[5],_testData[6], false);
                        SinglerealE0M.AssertModel(models[6],_testData[7], false);
                        SinglerealE0M.AssertModel(models[7],_testData[8], false);
                        SinglerealE0M.AssertModel(models[8],_testData[9], false);
                        SinglerealE0M.AssertModel(models[9],_testData[10], false);
                        SinglerealE0M.AssertModel(models[10],_testData[11], false);
                        SinglerealE0M.AssertModel(models[11],_testData[12], false);
                        SinglerealE0M.AssertModel(models[12],_testData[13], false);
                        SinglerealE0M.AssertModel(models[13],_testData[14], false);
                        SinglerealE0M.AssertModel(models[14],_testData[15], false);
                        SinglerealE0M.AssertModel(models[15],_testData[16], false);
                        SinglerealE0M.AssertModel(models[16],_testData[17], false);
                        SinglerealE0M.AssertModel(models[17],_testData[18], false);
                        SinglerealE0M.AssertModel(models[18],_testData[19], false);
                        SinglerealE0M.AssertModel(models[19],_testData[20], false);
                        SinglerealE0M.AssertModel(models[20],_testData[21], false);
                        SinglerealE0M.AssertModel(models[21],_testData[22], false);
                        SinglerealE0M.AssertModel(models[22],_testData[23], false);
                        SinglerealE0M.AssertModel(models[23],_testData[24], false);
                        SinglerealE0M.AssertModel(models[24],_testData[25], false);
                        SinglerealE0M.AssertModel(models[25],_testData[26], false);
                        SinglerealE0M.AssertModel(models[26],_testData[27], false);
                        SinglerealE0M.AssertModel(models[27],_testData[28], false);
                        SinglerealE0M.AssertModel(models[28],_testData[29], false);
                        SinglerealE0M.AssertModel(models[29],_testData[30], false);
                        SinglerealE0M.AssertModel(models[30],_testData[31], false);
                        SinglerealE0M.AssertModel(models[31],_testData[32], false);
                        SinglerealE0M.AssertModel(models[32],_testData[33], false);
                        SinglerealE0M.AssertModel(models[33],_testData[34], false);
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
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                SinglerealE0M.AssertModel(models[0],_testData[25], false);
                SinglerealE0M.AssertModel(models[1],_testData[26], false);
                SinglerealE0M.AssertModel(models[2],_testData[27], false);
                SinglerealE0M.AssertModel(models[3],_testData[28], false);
                SinglerealE0M.AssertModel(models[4],_testData[29], false);
                SinglerealE0M.AssertModel(models[5],_testData[30], false);
                SinglerealE0M.AssertModel(models[6],_testData[31], false);
                SinglerealE0M.AssertModel(models[7],_testData[32], false);
                SinglerealE0M.AssertModel(models[8],_testData[33], false);
                SinglerealE0M.AssertModel(models[9],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3125959f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5778044f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.11615455f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12819028f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.40191877f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91188955f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.44959778f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.14577621f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((1.8298626E-05f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9247341f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76791155f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5057187f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.43620777f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7674601f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38231766f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31124794f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.88711023f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2109999f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7195481f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.90385604f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.006824553f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6909227f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48552585f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86163664f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5228166f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.39554387f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3466407f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9040476f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.88793427f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6452593f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.62826896f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.77658314f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2426945f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8729891f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.44993258f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08208072f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.28686392f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6717954f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16746253f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.33784032f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16567093f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.43685526f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4976436f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.31236637f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16974676f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.052240074f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.43263388f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5124257f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5033526f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22732794f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.271093f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.05543369f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.47814578f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72031474f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8400799f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.44830227f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.10217476f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.60056984f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.19743699f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.029576957f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29771245f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6444923f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.40020323f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6040767f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.027341783f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8774787f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.06685507f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.98076546f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.05367738f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.45263296f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48220128f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9919328f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.86074287f)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5132749f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.683874f)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.84186363f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.03151357f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8710589f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9281018f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6137263f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09708005f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9865807f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5176064f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7990465f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8657975f)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3125959f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5778044f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.11615455f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12819028f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.40191877f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91188955f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.44959778f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.14577621f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((1.8298626E-05f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9247341f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76791155f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5057187f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.43620777f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7674601f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38231766f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31124794f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.88711023f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2109999f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7195481f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.90385604f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.006824553f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6909227f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48552585f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.86163664f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5228166f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.39554387f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3466407f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9040476f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.88793427f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6452593f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.62826896f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.77658314f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.2426945f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8729891f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.44993258f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08208072f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.28686392f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6717954f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16746253f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.33784032f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16567093f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.43685526f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4976436f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.31236637f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16974676f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.052240074f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.43263388f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5124257f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5033526f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22732794f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.271093f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.05543369f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.47814578f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72031474f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8400799f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.44830227f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.10217476f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.60056984f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.19743699f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.029576957f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29771245f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6444923f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.40020323f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6040767f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.027341783f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8774787f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.06685507f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.98076546f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.05367738f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.45263296f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48220128f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9919328f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.86074287f)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5132749f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.683874f)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.84186363f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.03151357f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8710589f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9281018f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6137263f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09708005f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9865807f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5176064f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7990465f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8657975f)));

            }
        }

#endregion

    }
}


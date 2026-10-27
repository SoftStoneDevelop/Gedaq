

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
    Id = 3,
    Value = 0.48089904f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 8,
    Value = 0.46106893f,
    ModelInner = new SinglerealE0MI
{
    Id = 5,
    Value = 0.9435449f,
    NullableValue = 0.3811884f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 16,
    Value = 0.8726029f,
    ModelInner = null,
    NullableValue = 0.7526034f,
},
            new SinglerealE0M
{
    Id = 22,
    Value = 0.22184658f,
    ModelInner = new SinglerealE0MI
{
    Id = 6,
    Value = 0.086942494f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 31,
    Value = 0.3057168f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 38,
    Value = 0.11137682f,
    ModelInner = new SinglerealE0MI
{
    Id = 9,
    Value = 0.14911878f,
    NullableValue = 0.6993476f,
},
    NullableValue = 0.9960117f,
},
            new SinglerealE0M
{
    Id = 47,
    Value = 0.77516407f,
    ModelInner = null,
    NullableValue = 0.219526f,
},
            new SinglerealE0M
{
    Id = 51,
    Value = 0.31151193f,
    ModelInner = new SinglerealE0MI
{
    Id = 16,
    Value = 0.18776202f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 58,
    Value = 0.84030217f,
    ModelInner = null,
    NullableValue = 0.5388997f,
},
            new SinglerealE0M
{
    Id = 66,
    Value = 0.8715337f,
    ModelInner = new SinglerealE0MI
{
    Id = 20,
    Value = 0.4036613f,
    NullableValue = null,
},
    NullableValue = 0.16051334f,
},
            new SinglerealE0M
{
    Id = 73,
    Value = 0.2904929f,
    ModelInner = null,
    NullableValue = 0.6856339f,
},
            new SinglerealE0M
{
    Id = 75,
    Value = 0.20820981f,
    ModelInner = new SinglerealE0MI
{
    Id = 28,
    Value = 0.67702377f,
    NullableValue = 0.06759548f,
},
    NullableValue = 0.5464021f,
},
            new SinglerealE0M
{
    Id = 78,
    Value = 0.5482421f,
    ModelInner = null,
    NullableValue = 0.5034378f,
},
            new SinglerealE0M
{
    Id = 81,
    Value = 0.4685889f,
    ModelInner = new SinglerealE0MI
{
    Id = 36,
    Value = 0.90108734f,
    NullableValue = null,
},
    NullableValue = 0.11599195f,
},
            new SinglerealE0M
{
    Id = 86,
    Value = 0.41803652f,
    ModelInner = null,
    NullableValue = 0.14416361f,
},
            new SinglerealE0M
{
    Id = 92,
    Value = 0.018051028f,
    ModelInner = new SinglerealE0MI
{
    Id = 41,
    Value = 0.35597086f,
    NullableValue = 0.59521633f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 94,
    Value = 0.8002802f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 99,
    Value = 0.4444793f,
    ModelInner = new SinglerealE0MI
{
    Id = 46,
    Value = 0.31526417f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 107,
    Value = 0.31603587f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 113,
    Value = 0.9589759f,
    ModelInner = new SinglerealE0MI
{
    Id = 51,
    Value = 0.034281194f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 120,
    Value = 0.68824834f,
    ModelInner = null,
    NullableValue = 0.94598836f,
},
            new SinglerealE0M
{
    Id = 124,
    Value = 0.8247609f,
    ModelInner = new SinglerealE0MI
{
    Id = 53,
    Value = 0.20870453f,
    NullableValue = 0.5395359f,
},
    NullableValue = 0.43483543f,
},
            new SinglerealE0M
{
    Id = 130,
    Value = 0.44519955f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 136,
    Value = 0.5865654f,
    ModelInner = new SinglerealE0MI
{
    Id = 61,
    Value = 0.23608607f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 141,
    Value = 0.006335318f,
    ModelInner = null,
    NullableValue = 0.9311242f,
},
            new SinglerealE0M
{
    Id = 144,
    Value = 0.72090214f,
    ModelInner = new SinglerealE0MI
{
    Id = 68,
    Value = 0.48965216f,
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 147,
    Value = 0.44582188f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 155,
    Value = 0.74457353f,
    ModelInner = new SinglerealE0MI
{
    Id = 73,
    Value = 0.06586385f,
    NullableValue = null,
},
    NullableValue = 0.75456107f,
},
            new SinglerealE0M
{
    Id = 158,
    Value = 0.44291425f,
    ModelInner = null,
    NullableValue = 0.14114583f,
},
            new SinglerealE0M
{
    Id = 166,
    Value = 0.02123928f,
    ModelInner = new SinglerealE0MI
{
    Id = 76,
    Value = 0.03816712f,
    NullableValue = 0.026319265f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 173,
    Value = 0.6545604f,
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 175,
    Value = 0.17917109f,
    ModelInner = new SinglerealE0MI
{
    Id = 84,
    Value = 0.41582674f,
    NullableValue = 0.96279967f,
},
    NullableValue = 0.12872374f,
},
            new SinglerealE0M
{
    Id = 177,
    Value = 0.0600639f,
    ModelInner = null,
    NullableValue = 0.99981743f,
},
            new SinglerealE0M
{
    Id = 180,
    Value = 0.5616264f,
    ModelInner = new SinglerealE0MI
{
    Id = 86,
    Value = 0.69140863f,
    NullableValue = 0.69032055f,
},
    NullableValue = null,
},
            new SinglerealE0M
{
    Id = 182,
    Value = 0.5962194f,
    ModelInner = null,
    NullableValue = 0.8863053f,
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
                parametr1.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[34], false);
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
                parametr1.Value = 51;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[22],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[23],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealE0M.AssertModel(models[0],_testData[24], false);
                        SinglerealE0M.AssertModel(models[1],_testData[25], false);
                        SinglerealE0M.AssertModel(models[2],_testData[26], false);
                        SinglerealE0M.AssertModel(models[3],_testData[27], false);
                        SinglerealE0M.AssertModel(models[4],_testData[28], false);
                        SinglerealE0M.AssertModel(models[5],_testData[29], false);
                        SinglerealE0M.AssertModel(models[6],_testData[30], false);
                        SinglerealE0M.AssertModel(models[7],_testData[31], false);
                        SinglerealE0M.AssertModel(models[8],_testData[32], false);
                        SinglerealE0M.AssertModel(models[9],_testData[33], false);
                        SinglerealE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SinglerealE0M.AssertModel(models[0],_testData[4], false);
                        SinglerealE0M.AssertModel(models[1],_testData[5], false);
                        SinglerealE0M.AssertModel(models[2],_testData[6], false);
                        SinglerealE0M.AssertModel(models[3],_testData[7], false);
                        SinglerealE0M.AssertModel(models[4],_testData[8], false);
                        SinglerealE0M.AssertModel(models[5],_testData[9], false);
                        SinglerealE0M.AssertModel(models[6],_testData[10], false);
                        SinglerealE0M.AssertModel(models[7],_testData[11], false);
                        SinglerealE0M.AssertModel(models[8],_testData[12], false);
                        SinglerealE0M.AssertModel(models[9],_testData[13], false);
                        SinglerealE0M.AssertModel(models[10],_testData[14], false);
                        SinglerealE0M.AssertModel(models[11],_testData[15], false);
                        SinglerealE0M.AssertModel(models[12],_testData[16], false);
                        SinglerealE0M.AssertModel(models[13],_testData[17], false);
                        SinglerealE0M.AssertModel(models[14],_testData[18], false);
                        SinglerealE0M.AssertModel(models[15],_testData[19], false);
                        SinglerealE0M.AssertModel(models[16],_testData[20], false);
                        SinglerealE0M.AssertModel(models[17],_testData[21], false);
                        SinglerealE0M.AssertModel(models[18],_testData[22], false);
                        SinglerealE0M.AssertModel(models[19],_testData[23], false);
                        SinglerealE0M.AssertModel(models[20],_testData[24], false);
                        SinglerealE0M.AssertModel(models[21],_testData[25], false);
                        SinglerealE0M.AssertModel(models[22],_testData[26], false);
                        SinglerealE0M.AssertModel(models[23],_testData[27], false);
                        SinglerealE0M.AssertModel(models[24],_testData[28], false);
                        SinglerealE0M.AssertModel(models[25],_testData[29], false);
                        SinglerealE0M.AssertModel(models[26],_testData[30], false);
                        SinglerealE0M.AssertModel(models[27],_testData[31], false);
                        SinglerealE0M.AssertModel(models[28],_testData[32], false);
                        SinglerealE0M.AssertModel(models[29],_testData[33], false);
                        SinglerealE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealE0M.AssertModel(models[0],_testData[27], false);
                        SinglerealE0M.AssertModel(models[1],_testData[28], false);
                        SinglerealE0M.AssertModel(models[2],_testData[29], false);
                        SinglerealE0M.AssertModel(models[3],_testData[30], false);
                        SinglerealE0M.AssertModel(models[4],_testData[31], false);
                        SinglerealE0M.AssertModel(models[5],_testData[32], false);
                        SinglerealE0M.AssertModel(models[6],_testData[33], false);
                        SinglerealE0M.AssertModel(models[7],_testData[34], false);
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
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 73, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[23],_testData[34], false);
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
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 94, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 155, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 166, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSinglerealE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealE0M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealE0M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealE0M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealE0M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealE0M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealE0M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealE0M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealE0M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealE0M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealE0M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealE0M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealE0M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealE0M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealE0M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealE0M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(models[16],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(models[17],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(models[18],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(models[19],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(models[20],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(models[21],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 147, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatSinglerealE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealE0M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 173, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SinglerealE0M.AssertModel(models[0],_testData[31], false);
                        SinglerealE0M.AssertModel(models[1],_testData[32], false);
                        SinglerealE0M.AssertModel(models[2],_testData[33], false);
                        SinglerealE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SinglerealE0M.AssertModel(models[0],_testData[11], false);
                        SinglerealE0M.AssertModel(models[1],_testData[12], false);
                        SinglerealE0M.AssertModel(models[2],_testData[13], false);
                        SinglerealE0M.AssertModel(models[3],_testData[14], false);
                        SinglerealE0M.AssertModel(models[4],_testData[15], false);
                        SinglerealE0M.AssertModel(models[5],_testData[16], false);
                        SinglerealE0M.AssertModel(models[6],_testData[17], false);
                        SinglerealE0M.AssertModel(models[7],_testData[18], false);
                        SinglerealE0M.AssertModel(models[8],_testData[19], false);
                        SinglerealE0M.AssertModel(models[9],_testData[20], false);
                        SinglerealE0M.AssertModel(models[10],_testData[21], false);
                        SinglerealE0M.AssertModel(models[11],_testData[22], false);
                        SinglerealE0M.AssertModel(models[12],_testData[23], false);
                        SinglerealE0M.AssertModel(models[13],_testData[24], false);
                        SinglerealE0M.AssertModel(models[14],_testData[25], false);
                        SinglerealE0M.AssertModel(models[15],_testData[26], false);
                        SinglerealE0M.AssertModel(models[16],_testData[27], false);
                        SinglerealE0M.AssertModel(models[17],_testData[28], false);
                        SinglerealE0M.AssertModel(models[18],_testData[29], false);
                        SinglerealE0M.AssertModel(models[19],_testData[30], false);
                        SinglerealE0M.AssertModel(models[20],_testData[31], false);
                        SinglerealE0M.AssertModel(models[21],_testData[32], false);
                        SinglerealE0M.AssertModel(models[22],_testData[33], false);
                        SinglerealE0M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 92, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealE0M.AssertModel(models[0],_testData[16], false);
                        SinglerealE0M.AssertModel(models[1],_testData[17], false);
                        SinglerealE0M.AssertModel(models[2],_testData[18], false);
                        SinglerealE0M.AssertModel(models[3],_testData[19], false);
                        SinglerealE0M.AssertModel(models[4],_testData[20], false);
                        SinglerealE0M.AssertModel(models[5],_testData[21], false);
                        SinglerealE0M.AssertModel(models[6],_testData[22], false);
                        SinglerealE0M.AssertModel(models[7],_testData[23], false);
                        SinglerealE0M.AssertModel(models[8],_testData[24], false);
                        SinglerealE0M.AssertModel(models[9],_testData[25], false);
                        SinglerealE0M.AssertModel(models[10],_testData[26], false);
                        SinglerealE0M.AssertModel(models[11],_testData[27], false);
                        SinglerealE0M.AssertModel(models[12],_testData[28], false);
                        SinglerealE0M.AssertModel(models[13],_testData[29], false);
                        SinglerealE0M.AssertModel(models[14],_testData[30], false);
                        SinglerealE0M.AssertModel(models[15],_testData[31], false);
                        SinglerealE0M.AssertModel(models[16],_testData[32], false);
                        SinglerealE0M.AssertModel(models[17],_testData[33], false);
                        SinglerealE0M.AssertModel(models[18],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 173);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                SinglerealE0M.AssertModel(models[0],_testData[31], false);
                SinglerealE0M.AssertModel(models[1],_testData[32], false);
                SinglerealE0M.AssertModel(models[2],_testData[33], false);
                SinglerealE0M.AssertModel(models[3],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48089904f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46106893f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9435449f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3811884f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8726029f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7526034f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22184658f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.086942494f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3057168f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.11137682f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.14911878f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6993476f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9960117f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77516407f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.219526f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31151193f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.18776202f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.84030217f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5388997f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8715337f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4036613f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.16051334f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2904929f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6856339f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20820981f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.67702377f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.06759548f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5464021f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5482421f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5034378f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4685889f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.90108734f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.11599195f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.41803652f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.14416361f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.018051028f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.35597086f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.59521633f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8002802f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4444793f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.31526417f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31603587f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9589759f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.034281194f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.68824834f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94598836f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8247609f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20870453f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5395359f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.43483543f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.44519955f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5865654f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23608607f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.006335318f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9311242f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72090214f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.48965216f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.44582188f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74457353f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.06586385f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75456107f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.44291425f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.14114583f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.02123928f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.03816712f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.026319265f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6545604f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17917109f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.41582674f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.96279967f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12872374f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0600639f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.99981743f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5616264f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.69140863f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.69032055f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5962194f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8863053f)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48089904f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46106893f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9435449f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3811884f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8726029f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7526034f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22184658f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.086942494f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3057168f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.11137682f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.14911878f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6993476f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9960117f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77516407f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.219526f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31151193f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.18776202f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.84030217f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5388997f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8715337f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4036613f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.16051334f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.2904929f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6856339f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20820981f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.67702377f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.06759548f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5464021f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5482421f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5034378f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4685889f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.90108734f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.11599195f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.41803652f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.14416361f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.018051028f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.35597086f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.59521633f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8002802f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4444793f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.31526417f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31603587f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9589759f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.034281194f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.68824834f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94598836f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8247609f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20870453f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5395359f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.43483543f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.44519955f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5865654f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23608607f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.006335318f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9311242f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72090214f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.48965216f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.44582188f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74457353f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.06586385f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.75456107f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.44291425f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.14114583f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.02123928f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.03816712f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.026319265f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6545604f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17917109f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.41582674f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.96279967f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12872374f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0600639f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.99981743f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5616264f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.69140863f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.69032055f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5962194f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8863053f)));

            }
        }

#endregion

    }
}


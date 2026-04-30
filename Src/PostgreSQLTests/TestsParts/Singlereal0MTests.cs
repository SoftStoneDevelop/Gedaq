

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
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
    Id = 1,
    Value = 0.54616445f,
    ModelInner = null,
    NullableValue = 0.91268045f,
},
            new Singlereal0M
{
    Id = 7,
    Value = 0.83435386f,
    ModelInner = new Singlereal0MI
{
    Id = 9,
    Value = 0.086802304f,
    NullableValue = 0.5064562f,
},
    NullableValue = 0.12085718f,
},
            new Singlereal0M
{
    Id = 8,
    Value = 0.77102154f,
    ModelInner = null,
    NullableValue = 0.07567209f,
},
            new Singlereal0M
{
    Id = 17,
    Value = 0.50611573f,
    ModelInner = new Singlereal0MI
{
    Id = 17,
    Value = 0.5097688f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 22,
    Value = 0.8120797f,
    ModelInner = null,
    NullableValue = 0.7533647f,
},
            new Singlereal0M
{
    Id = 23,
    Value = 0.9726158f,
    ModelInner = new Singlereal0MI
{
    Id = 24,
    Value = 0.14584321f,
    NullableValue = 0.6464556f,
},
    NullableValue = 0.032975316f,
},
            new Singlereal0M
{
    Id = 32,
    Value = 0.6299805f,
    ModelInner = null,
    NullableValue = 0.90349376f,
},
            new Singlereal0M
{
    Id = 33,
    Value = 0.26128066f,
    ModelInner = new Singlereal0MI
{
    Id = 30,
    Value = 0.5543288f,
    NullableValue = 0.43031764f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 40,
    Value = 0.30573392f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 45,
    Value = 0.053378105f,
    ModelInner = new Singlereal0MI
{
    Id = 37,
    Value = 0.48776466f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 46,
    Value = 0.8781595f,
    ModelInner = null,
    NullableValue = 0.22081387f,
},
            new Singlereal0M
{
    Id = 51,
    Value = 0.5500876f,
    ModelInner = new Singlereal0MI
{
    Id = 41,
    Value = 0.7792515f,
    NullableValue = null,
},
    NullableValue = 0.92591745f,
},
            new Singlereal0M
{
    Id = 56,
    Value = 0.83393234f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 61,
    Value = 0.77125394f,
    ModelInner = new Singlereal0MI
{
    Id = 49,
    Value = 0.38974774f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 65,
    Value = 0.5548691f,
    ModelInner = null,
    NullableValue = 0.7706766f,
},
            new Singlereal0M
{
    Id = 74,
    Value = 0.17124784f,
    ModelInner = new Singlereal0MI
{
    Id = 52,
    Value = 0.49800217f,
    NullableValue = 0.20218498f,
},
    NullableValue = 0.04019606f,
},
            new Singlereal0M
{
    Id = 80,
    Value = 0.30923724f,
    ModelInner = null,
    NullableValue = 0.5992935f,
},
            new Singlereal0M
{
    Id = 84,
    Value = 0.70911944f,
    ModelInner = new Singlereal0MI
{
    Id = 55,
    Value = 0.7220331f,
    NullableValue = null,
},
    NullableValue = 0.6608854f,
},
            new Singlereal0M
{
    Id = 90,
    Value = 0.6467964f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 93,
    Value = 0.76247835f,
    ModelInner = new Singlereal0MI
{
    Id = 61,
    Value = 0.68385977f,
    NullableValue = 0.568756f,
},
    NullableValue = 0.7774196f,
},
            new Singlereal0M
{
    Id = 98,
    Value = 0.028828204f,
    ModelInner = null,
    NullableValue = 0.92632914f,
},
            new Singlereal0M
{
    Id = 104,
    Value = 0.91549647f,
    ModelInner = new Singlereal0MI
{
    Id = 68,
    Value = 0.23508173f,
    NullableValue = 0.4978248f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 112,
    Value = 0.5135557f,
    ModelInner = null,
    NullableValue = 0.5378376f,
},
            new Singlereal0M
{
    Id = 114,
    Value = 0.32669312f,
    ModelInner = new Singlereal0MI
{
    Id = 74,
    Value = 0.84410214f,
    NullableValue = 0.63007724f,
},
    NullableValue = 0.7693935f,
},
            new Singlereal0M
{
    Id = 123,
    Value = 0.6219764f,
    ModelInner = null,
    NullableValue = 0.8284761f,
},
            new Singlereal0M
{
    Id = 125,
    Value = 0.70888764f,
    ModelInner = new Singlereal0MI
{
    Id = 75,
    Value = 0.24725926f,
    NullableValue = 0.72910285f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 130,
    Value = 0.20475984f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 131,
    Value = 0.48111773f,
    ModelInner = new Singlereal0MI
{
    Id = 83,
    Value = 0.009648383f,
    NullableValue = 0.25676805f,
},
    NullableValue = 0.07454896f,
},
            new Singlereal0M
{
    Id = 135,
    Value = 0.22339547f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 144,
    Value = 0.4491673f,
    ModelInner = new Singlereal0MI
{
    Id = 91,
    Value = 0.64074886f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 145,
    Value = 0.7520853f,
    ModelInner = null,
    NullableValue = 0.41858536f,
},
            new Singlereal0M
{
    Id = 154,
    Value = 0.5673763f,
    ModelInner = new Singlereal0MI
{
    Id = 95,
    Value = 0.46901637f,
    NullableValue = null,
},
    NullableValue = 0.9843893f,
},
            new Singlereal0M
{
    Id = 163,
    Value = 0.024585426f,
    ModelInner = null,
    NullableValue = 0.84899116f,
},
            new Singlereal0M
{
    Id = 172,
    Value = 0.7060503f,
    ModelInner = new Singlereal0MI
{
    Id = 99,
    Value = 0.177445f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 175,
    Value = 0.24209332f,
    ModelInner = null,
    NullableValue = 0.87204134f,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(Singlereal0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17))]
        public void InsertModelInnerReturningConfig()
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

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((ISingleSingleTypereal)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleSingleTypereal)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ISingleSingleTypereal)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleSingleTypereal)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlereal0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    singlereal0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Singlereal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.7533647f));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.032975316f));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.90349376f));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    singlereal0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Singlereal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlereal0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;
                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;
                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.22081387f));
                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.92591745f));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Singlereal0M> models = null;

                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Singlereal0M> models = null;

                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
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
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleSingleTypereal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleSingleTypereal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Singlereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleSingleTypereal)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleSingleTypereal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleSingleTypereal)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
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

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Singlereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).SelectModelAsync(connection, 0);
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
FROM public.singlereal0m m
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[34], false);
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
FROM public.singlereal0m m
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr2.Value = 23;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.singlereal0m m
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
                parametr1.Value = 22;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatSinglereal0M.AssertModel(models[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglereal0M.AssertModel(models[0],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[34], false);
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
FROM public.singlereal0m m
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
                parametr1.Value = 145;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglereal0M.AssertModel(models[0],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Singlereal0M.AssertModel(models[0],_testData[24], false);
                        Singlereal0M.AssertModel(models[1],_testData[25], false);
                        Singlereal0M.AssertModel(models[2],_testData[26], false);
                        Singlereal0M.AssertModel(models[3],_testData[27], false);
                        Singlereal0M.AssertModel(models[4],_testData[28], false);
                        Singlereal0M.AssertModel(models[5],_testData[29], false);
                        Singlereal0M.AssertModel(models[6],_testData[30], false);
                        Singlereal0M.AssertModel(models[7],_testData[31], false);
                        Singlereal0M.AssertModel(models[8],_testData[32], false);
                        Singlereal0M.AssertModel(models[9],_testData[33], false);
                        Singlereal0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Singlereal0M.AssertModel(models[0],_testData[8], false);
                        Singlereal0M.AssertModel(models[1],_testData[9], false);
                        Singlereal0M.AssertModel(models[2],_testData[10], false);
                        Singlereal0M.AssertModel(models[3],_testData[11], false);
                        Singlereal0M.AssertModel(models[4],_testData[12], false);
                        Singlereal0M.AssertModel(models[5],_testData[13], false);
                        Singlereal0M.AssertModel(models[6],_testData[14], false);
                        Singlereal0M.AssertModel(models[7],_testData[15], false);
                        Singlereal0M.AssertModel(models[8],_testData[16], false);
                        Singlereal0M.AssertModel(models[9],_testData[17], false);
                        Singlereal0M.AssertModel(models[10],_testData[18], false);
                        Singlereal0M.AssertModel(models[11],_testData[19], false);
                        Singlereal0M.AssertModel(models[12],_testData[20], false);
                        Singlereal0M.AssertModel(models[13],_testData[21], false);
                        Singlereal0M.AssertModel(models[14],_testData[22], false);
                        Singlereal0M.AssertModel(models[15],_testData[23], false);
                        Singlereal0M.AssertModel(models[16],_testData[24], false);
                        Singlereal0M.AssertModel(models[17],_testData[25], false);
                        Singlereal0M.AssertModel(models[18],_testData[26], false);
                        Singlereal0M.AssertModel(models[19],_testData[27], false);
                        Singlereal0M.AssertModel(models[20],_testData[28], false);
                        Singlereal0M.AssertModel(models[21],_testData[29], false);
                        Singlereal0M.AssertModel(models[22],_testData[30], false);
                        Singlereal0M.AssertModel(models[23],_testData[31], false);
                        Singlereal0M.AssertModel(models[24],_testData[32], false);
                        Singlereal0M.AssertModel(models[25],_testData[33], false);
                        Singlereal0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Singlereal0M.AssertModel(models[0],_testData[11], false);
                        Singlereal0M.AssertModel(models[1],_testData[12], false);
                        Singlereal0M.AssertModel(models[2],_testData[13], false);
                        Singlereal0M.AssertModel(models[3],_testData[14], false);
                        Singlereal0M.AssertModel(models[4],_testData[15], false);
                        Singlereal0M.AssertModel(models[5],_testData[16], false);
                        Singlereal0M.AssertModel(models[6],_testData[17], false);
                        Singlereal0M.AssertModel(models[7],_testData[18], false);
                        Singlereal0M.AssertModel(models[8],_testData[19], false);
                        Singlereal0M.AssertModel(models[9],_testData[20], false);
                        Singlereal0M.AssertModel(models[10],_testData[21], false);
                        Singlereal0M.AssertModel(models[11],_testData[22], false);
                        Singlereal0M.AssertModel(models[12],_testData[23], false);
                        Singlereal0M.AssertModel(models[13],_testData[24], false);
                        Singlereal0M.AssertModel(models[14],_testData[25], false);
                        Singlereal0M.AssertModel(models[15],_testData[26], false);
                        Singlereal0M.AssertModel(models[16],_testData[27], false);
                        Singlereal0M.AssertModel(models[17],_testData[28], false);
                        Singlereal0M.AssertModel(models[18],_testData[29], false);
                        Singlereal0M.AssertModel(models[19],_testData[30], false);
                        Singlereal0M.AssertModel(models[20],_testData[31], false);
                        Singlereal0M.AssertModel(models[21],_testData[32], false);
                        Singlereal0M.AssertModel(models[22],_testData[33], false);
                        Singlereal0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Singlereal0M.AssertModel(models[0],_testData[12], false);
                        Singlereal0M.AssertModel(models[1],_testData[13], false);
                        Singlereal0M.AssertModel(models[2],_testData[14], false);
                        Singlereal0M.AssertModel(models[3],_testData[15], false);
                        Singlereal0M.AssertModel(models[4],_testData[16], false);
                        Singlereal0M.AssertModel(models[5],_testData[17], false);
                        Singlereal0M.AssertModel(models[6],_testData[18], false);
                        Singlereal0M.AssertModel(models[7],_testData[19], false);
                        Singlereal0M.AssertModel(models[8],_testData[20], false);
                        Singlereal0M.AssertModel(models[9],_testData[21], false);
                        Singlereal0M.AssertModel(models[10],_testData[22], false);
                        Singlereal0M.AssertModel(models[11],_testData[23], false);
                        Singlereal0M.AssertModel(models[12],_testData[24], false);
                        Singlereal0M.AssertModel(models[13],_testData[25], false);
                        Singlereal0M.AssertModel(models[14],_testData[26], false);
                        Singlereal0M.AssertModel(models[15],_testData[27], false);
                        Singlereal0M.AssertModel(models[16],_testData[28], false);
                        Singlereal0M.AssertModel(models[17],_testData[29], false);
                        Singlereal0M.AssertModel(models[18],_testData[30], false);
                        Singlereal0M.AssertModel(models[19],_testData[31], false);
                        Singlereal0M.AssertModel(models[20],_testData[32], false);
                        Singlereal0M.AssertModel(models[21],_testData[33], false);
                        Singlereal0M.AssertModel(models[22],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 46, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 114, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 40, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 135, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[33],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 74, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatSinglereal0M.AssertModel(models[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 154, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglereal0M.AssertModel(models[0],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatSinglereal0M.AssertModel(models[0],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[34], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
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
            dbType: (System.Data.DbType)(11))]
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Singlereal0M.AssertModel(models[0],_testData[7], false);
                        Singlereal0M.AssertModel(models[1],_testData[8], false);
                        Singlereal0M.AssertModel(models[2],_testData[9], false);
                        Singlereal0M.AssertModel(models[3],_testData[10], false);
                        Singlereal0M.AssertModel(models[4],_testData[11], false);
                        Singlereal0M.AssertModel(models[5],_testData[12], false);
                        Singlereal0M.AssertModel(models[6],_testData[13], false);
                        Singlereal0M.AssertModel(models[7],_testData[14], false);
                        Singlereal0M.AssertModel(models[8],_testData[15], false);
                        Singlereal0M.AssertModel(models[9],_testData[16], false);
                        Singlereal0M.AssertModel(models[10],_testData[17], false);
                        Singlereal0M.AssertModel(models[11],_testData[18], false);
                        Singlereal0M.AssertModel(models[12],_testData[19], false);
                        Singlereal0M.AssertModel(models[13],_testData[20], false);
                        Singlereal0M.AssertModel(models[14],_testData[21], false);
                        Singlereal0M.AssertModel(models[15],_testData[22], false);
                        Singlereal0M.AssertModel(models[16],_testData[23], false);
                        Singlereal0M.AssertModel(models[17],_testData[24], false);
                        Singlereal0M.AssertModel(models[18],_testData[25], false);
                        Singlereal0M.AssertModel(models[19],_testData[26], false);
                        Singlereal0M.AssertModel(models[20],_testData[27], false);
                        Singlereal0M.AssertModel(models[21],_testData[28], false);
                        Singlereal0M.AssertModel(models[22],_testData[29], false);
                        Singlereal0M.AssertModel(models[23],_testData[30], false);
                        Singlereal0M.AssertModel(models[24],_testData[31], false);
                        Singlereal0M.AssertModel(models[25],_testData[32], false);
                        Singlereal0M.AssertModel(models[26],_testData[33], false);
                        Singlereal0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Singlereal0M.AssertModel(models[0],_testData[32], false);
                        Singlereal0M.AssertModel(models[1],_testData[33], false);
                        Singlereal0M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 45, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Singlereal0M.AssertModel(models[0],_testData[10], false);
                        Singlereal0M.AssertModel(models[1],_testData[11], false);
                        Singlereal0M.AssertModel(models[2],_testData[12], false);
                        Singlereal0M.AssertModel(models[3],_testData[13], false);
                        Singlereal0M.AssertModel(models[4],_testData[14], false);
                        Singlereal0M.AssertModel(models[5],_testData[15], false);
                        Singlereal0M.AssertModel(models[6],_testData[16], false);
                        Singlereal0M.AssertModel(models[7],_testData[17], false);
                        Singlereal0M.AssertModel(models[8],_testData[18], false);
                        Singlereal0M.AssertModel(models[9],_testData[19], false);
                        Singlereal0M.AssertModel(models[10],_testData[20], false);
                        Singlereal0M.AssertModel(models[11],_testData[21], false);
                        Singlereal0M.AssertModel(models[12],_testData[22], false);
                        Singlereal0M.AssertModel(models[13],_testData[23], false);
                        Singlereal0M.AssertModel(models[14],_testData[24], false);
                        Singlereal0M.AssertModel(models[15],_testData[25], false);
                        Singlereal0M.AssertModel(models[16],_testData[26], false);
                        Singlereal0M.AssertModel(models[17],_testData[27], false);
                        Singlereal0M.AssertModel(models[18],_testData[28], false);
                        Singlereal0M.AssertModel(models[19],_testData[29], false);
                        Singlereal0M.AssertModel(models[20],_testData[30], false);
                        Singlereal0M.AssertModel(models[21],_testData[31], false);
                        Singlereal0M.AssertModel(models[22],_testData[32], false);
                        Singlereal0M.AssertModel(models[23],_testData[33], false);
                        Singlereal0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Singlereal0M.AssertModel(models[0],_testData[20], false);
                        Singlereal0M.AssertModel(models[1],_testData[21], false);
                        Singlereal0M.AssertModel(models[2],_testData[22], false);
                        Singlereal0M.AssertModel(models[3],_testData[23], false);
                        Singlereal0M.AssertModel(models[4],_testData[24], false);
                        Singlereal0M.AssertModel(models[5],_testData[25], false);
                        Singlereal0M.AssertModel(models[6],_testData[26], false);
                        Singlereal0M.AssertModel(models[7],_testData[27], false);
                        Singlereal0M.AssertModel(models[8],_testData[28], false);
                        Singlereal0M.AssertModel(models[9],_testData[29], false);
                        Singlereal0M.AssertModel(models[10],_testData[30], false);
                        Singlereal0M.AssertModel(models[11],_testData[31], false);
                        Singlereal0M.AssertModel(models[12],_testData[32], false);
                        Singlereal0M.AssertModel(models[13],_testData[33], false);
                        Singlereal0M.AssertModel(models[14],_testData[34], false);
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
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Singlereal0M.AssertModel(models[0],_testData[18], false);Singlereal0M.AssertModel(models[1],_testData[19], false);Singlereal0M.AssertModel(models[2],_testData[20], false);Singlereal0M.AssertModel(models[3],_testData[21], false);Singlereal0M.AssertModel(models[4],_testData[22], false);Singlereal0M.AssertModel(models[5],_testData[23], false);Singlereal0M.AssertModel(models[6],_testData[24], false);Singlereal0M.AssertModel(models[7],_testData[25], false);Singlereal0M.AssertModel(models[8],_testData[26], false);Singlereal0M.AssertModel(models[9],_testData[27], false);Singlereal0M.AssertModel(models[10],_testData[28], false);Singlereal0M.AssertModel(models[11],_testData[29], false);Singlereal0M.AssertModel(models[12],_testData[30], false);Singlereal0M.AssertModel(models[13],_testData[31], false);Singlereal0M.AssertModel(models[14],_testData[32], false);Singlereal0M.AssertModel(models[15],_testData[33], false);Singlereal0M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Singlereal0M.AssertModel(models[0],_testData[27], false);Singlereal0M.AssertModel(models[1],_testData[28], false);Singlereal0M.AssertModel(models[2],_testData[29], false);Singlereal0M.AssertModel(models[3],_testData[30], false);Singlereal0M.AssertModel(models[4],_testData[31], false);Singlereal0M.AssertModel(models[5],_testData[32], false);Singlereal0M.AssertModel(models[6],_testData[33], false);Singlereal0M.AssertModel(models[7],_testData[34], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
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
                Assert.That((System.Single)model[1], Is.EqualTo((0.54616445f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.91268045f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.83435386f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.086802304f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5064562f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12085718f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77102154f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.07567209f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.50611573f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5097688f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8120797f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7533647f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9726158f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.14584321f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6464556f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.032975316f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6299805f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.90349376f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.26128066f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5543288f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.43031764f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30573392f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.053378105f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.48776466f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8781595f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.22081387f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5500876f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7792515f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.92591745f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.83393234f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77125394f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.38974774f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5548691f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7706766f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17124784f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.49800217f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.20218498f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.04019606f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30923724f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5992935f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.70911944f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7220331f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6608854f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6467964f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.76247835f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.68385977f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.568756f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7774196f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.028828204f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.92632914f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91549647f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23508173f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4978248f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5135557f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5378376f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32669312f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84410214f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.63007724f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7693935f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6219764f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8284761f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.70888764f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.24725926f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.72910285f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20475984f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48111773f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.009648383f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.25676805f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.07454896f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22339547f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4491673f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.64074886f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7520853f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41858536f)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5673763f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.46901637f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9843893f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.024585426f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.84899116f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7060503f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.177445f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.24209332f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.87204134f)));

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
                Assert.That((System.Single)model[1], Is.EqualTo((0.54616445f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.91268045f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.83435386f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.086802304f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5064562f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.12085718f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77102154f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.07567209f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.50611573f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5097688f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8120797f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7533647f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9726158f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.14584321f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6464556f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.032975316f)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6299805f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.90349376f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.26128066f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5543288f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.43031764f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30573392f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.053378105f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.48776466f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8781595f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.22081387f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5500876f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7792515f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.92591745f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.83393234f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.77125394f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.38974774f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5548691f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7706766f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17124784f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.49800217f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.20218498f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.04019606f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30923724f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5992935f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.70911944f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7220331f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6608854f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6467964f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.76247835f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.68385977f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.568756f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7774196f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.028828204f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.92632914f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91549647f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.23508173f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4978248f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5135557f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5378376f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32669312f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84410214f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.63007724f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7693935f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6219764f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8284761f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.70888764f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.24725926f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.72910285f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.20475984f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.48111773f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.009648383f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.25676805f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.07454896f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.22339547f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4491673f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.64074886f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7520853f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41858536f)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5673763f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.46901637f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9843893f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.024585426f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.84899116f)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7060503f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.177445f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.24209332f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.87204134f)));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_singlereal0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Singlereal0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Singlereal0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Singlereal0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleSingleTypereal)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereal0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleSingleTypereal)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Singlereal0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Singlereal0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleSingleTypereal)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlereal0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleSingleTypereal)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_singlereal0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Singlereal0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Singlereal0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Singlereal0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleSingleTypereal)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereal0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleSingleTypereal)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Singlereal0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Singlereal0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleSingleTypereal)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlereal0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleSingleTypereal)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_singlereal0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Singlereal0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereal0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Singlereal0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Singlereal0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleSingleTypereal)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleSingleTypereal)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Singlereal0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleSingleTypereal)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleSingleTypereal)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_singlereal0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereal0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Singlereal0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Singlereal0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Singlereal0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleSingleTypereal)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleSingleTypereal)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Singlereal0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Singlereal0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleSingleTypereal)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleSingleTypereal)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereal0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlereal0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Singlereal0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ImportModelConfig()
        {
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
FROM public.binary_singlereal0m m
LEFT JOIN public.binary_singlereal0mi mi ON mi.id = m.singlereal0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Singlereal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Singlereal0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleSingleTypereal)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleSingleTypereal)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Singlereal0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Singlereal0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleSingleTypereal)this).ImportModel(connection, importCollection);
                var models = ((ISingleSingleTypereal)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Singlereal0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlereal0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Singlereal0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Singlereal0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Singlereal0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ISingleSingleTypereal)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Singlereal0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ISingleSingleTypereal)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


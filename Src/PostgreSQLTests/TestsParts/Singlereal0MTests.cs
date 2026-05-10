

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
    Value = 0.63497084f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 4,
    Value = 0.9274735f,
    ModelInner = new Singlereal0MI
{
    Id = 1,
    Value = 0.89491224f,
    NullableValue = null,
},
    NullableValue = 0.24702203f,
},
            new Singlereal0M
{
    Id = 8,
    Value = 0.06674105f,
    ModelInner = null,
    NullableValue = 0.1677314f,
},
            new Singlereal0M
{
    Id = 14,
    Value = 0.34726667f,
    ModelInner = new Singlereal0MI
{
    Id = 9,
    Value = 0.788679f,
    NullableValue = 0.4465286f,
},
    NullableValue = 0.05489248f,
},
            new Singlereal0M
{
    Id = 16,
    Value = 0.063711524f,
    ModelInner = null,
    NullableValue = 0.7504789f,
},
            new Singlereal0M
{
    Id = 19,
    Value = 0.4341609f,
    ModelInner = new Singlereal0MI
{
    Id = 10,
    Value = 0.8405717f,
    NullableValue = 0.9223963f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 23,
    Value = 0.07404572f,
    ModelInner = null,
    NullableValue = 0.5040469f,
},
            new Singlereal0M
{
    Id = 30,
    Value = 0.5320481f,
    ModelInner = new Singlereal0MI
{
    Id = 16,
    Value = 0.80981266f,
    NullableValue = 0.4587332f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 34,
    Value = 0.863037f,
    ModelInner = null,
    NullableValue = 0.41287345f,
},
            new Singlereal0M
{
    Id = 35,
    Value = 0.38679153f,
    ModelInner = new Singlereal0MI
{
    Id = 18,
    Value = 0.12460232f,
    NullableValue = 0.48473746f,
},
    NullableValue = 0.7860966f,
},
            new Singlereal0M
{
    Id = 43,
    Value = 0.008852243f,
    ModelInner = null,
    NullableValue = 0.6449713f,
},
            new Singlereal0M
{
    Id = 52,
    Value = 0.1683281f,
    ModelInner = new Singlereal0MI
{
    Id = 25,
    Value = 0.5967293f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 59,
    Value = 0.6287767f,
    ModelInner = null,
    NullableValue = 0.4606774f,
},
            new Singlereal0M
{
    Id = 65,
    Value = 0.79116815f,
    ModelInner = new Singlereal0MI
{
    Id = 27,
    Value = 0.19378531f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 67,
    Value = 0.085733116f,
    ModelInner = null,
    NullableValue = 0.85426116f,
},
            new Singlereal0M
{
    Id = 72,
    Value = 0.47776383f,
    ModelInner = new Singlereal0MI
{
    Id = 28,
    Value = 0.54051304f,
    NullableValue = 0.22961771f,
},
    NullableValue = 0.8179924f,
},
            new Singlereal0M
{
    Id = 75,
    Value = 0.27556938f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 79,
    Value = 0.32696062f,
    ModelInner = new Singlereal0MI
{
    Id = 30,
    Value = 0.8898208f,
    NullableValue = null,
},
    NullableValue = 0.42876554f,
},
            new Singlereal0M
{
    Id = 84,
    Value = 0.31888813f,
    ModelInner = null,
    NullableValue = 0.33282346f,
},
            new Singlereal0M
{
    Id = 85,
    Value = 0.057647824f,
    ModelInner = new Singlereal0MI
{
    Id = 35,
    Value = 0.79862064f,
    NullableValue = 0.4401849f,
},
    NullableValue = 0.45743543f,
},
            new Singlereal0M
{
    Id = 91,
    Value = 0.76021445f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 99,
    Value = 0.671001f,
    ModelInner = new Singlereal0MI
{
    Id = 42,
    Value = 0.99333453f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 102,
    Value = 0.7716018f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 106,
    Value = 0.0026857853f,
    ModelInner = new Singlereal0MI
{
    Id = 49,
    Value = 0.9788704f,
    NullableValue = 0.37898612f,
},
    NullableValue = 0.5977694f,
},
            new Singlereal0M
{
    Id = 108,
    Value = 0.51781434f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 114,
    Value = 0.36925232f,
    ModelInner = new Singlereal0MI
{
    Id = 57,
    Value = 0.42768145f,
    NullableValue = null,
},
    NullableValue = 0.9596017f,
},
            new Singlereal0M
{
    Id = 116,
    Value = 0.25771672f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 121,
    Value = 0.16117746f,
    ModelInner = new Singlereal0MI
{
    Id = 65,
    Value = 0.93063426f,
    NullableValue = null,
},
    NullableValue = 0.8169088f,
},
            new Singlereal0M
{
    Id = 127,
    Value = 0.57553893f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 130,
    Value = 0.9339325f,
    ModelInner = new Singlereal0MI
{
    Id = 69,
    Value = 0.08250946f,
    NullableValue = 0.96470696f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 136,
    Value = 0.9727532f,
    ModelInner = null,
    NullableValue = 0.5825552f,
},
            new Singlereal0M
{
    Id = 145,
    Value = 0.091698766f,
    ModelInner = new Singlereal0MI
{
    Id = 76,
    Value = 0.29750794f,
    NullableValue = 0.25219476f,
},
    NullableValue = 0.76356286f,
},
            new Singlereal0M
{
    Id = 147,
    Value = 0.92251754f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 155,
    Value = 0.09924328f,
    ModelInner = new Singlereal0MI
{
    Id = 83,
    Value = 0.42716044f,
    NullableValue = null,
},
    NullableValue = 0.3243528f,
},
            new Singlereal0M
{
    Id = 157,
    Value = 0.65685695f,
    ModelInner = null,
    NullableValue = 0.219949f,
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
                Assert.That(nullable, Is.EqualTo(0.7504789f));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(0.5040469f));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.41287345f));
                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.7860966f));
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
                Assert.That(nullable, Is.EqualTo(0.6449713f));
                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglereal0M.AssertModel(models[0],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglereal0M.AssertModel(models[0],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Singlereal0M.AssertModel(models[0],_testData[32], false);
                        Singlereal0M.AssertModel(models[1],_testData[33], false);
                        Singlereal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Singlereal0M.AssertModel(models[0],_testData[19], false);
                        Singlereal0M.AssertModel(models[1],_testData[20], false);
                        Singlereal0M.AssertModel(models[2],_testData[21], false);
                        Singlereal0M.AssertModel(models[3],_testData[22], false);
                        Singlereal0M.AssertModel(models[4],_testData[23], false);
                        Singlereal0M.AssertModel(models[5],_testData[24], false);
                        Singlereal0M.AssertModel(models[6],_testData[25], false);
                        Singlereal0M.AssertModel(models[7],_testData[26], false);
                        Singlereal0M.AssertModel(models[8],_testData[27], false);
                        Singlereal0M.AssertModel(models[9],_testData[28], false);
                        Singlereal0M.AssertModel(models[10],_testData[29], false);
                        Singlereal0M.AssertModel(models[11],_testData[30], false);
                        Singlereal0M.AssertModel(models[12],_testData[31], false);
                        Singlereal0M.AssertModel(models[13],_testData[32], false);
                        Singlereal0M.AssertModel(models[14],_testData[33], false);
                        Singlereal0M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 1, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 102, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 127, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglereal0M.AssertModel(models[0],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatSinglereal0M.AssertModel(models[0],_testData[2], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[3], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[4], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[5], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[6], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[7], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[8], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[9], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[10], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[11], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[23],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[24],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[25],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[26],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[27],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[28],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[29],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[30],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[31],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[32],_testData[34], false);
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
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 52, query2))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglereal0M.AssertModel(models[0],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[29], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[30], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[31], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[32], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[33], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[34], false);
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
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Singlereal0M.AssertModel(models[0],_testData[30], false);
                        Singlereal0M.AssertModel(models[1],_testData[31], false);
                        Singlereal0M.AssertModel(models[2],_testData[32], false);
                        Singlereal0M.AssertModel(models[3],_testData[33], false);
                        Singlereal0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Singlereal0M.AssertModel(models[0],_testData[18], false);
                        Singlereal0M.AssertModel(models[1],_testData[19], false);
                        Singlereal0M.AssertModel(models[2],_testData[20], false);
                        Singlereal0M.AssertModel(models[3],_testData[21], false);
                        Singlereal0M.AssertModel(models[4],_testData[22], false);
                        Singlereal0M.AssertModel(models[5],_testData[23], false);
                        Singlereal0M.AssertModel(models[6],_testData[24], false);
                        Singlereal0M.AssertModel(models[7],_testData[25], false);
                        Singlereal0M.AssertModel(models[8],_testData[26], false);
                        Singlereal0M.AssertModel(models[9],_testData[27], false);
                        Singlereal0M.AssertModel(models[10],_testData[28], false);
                        Singlereal0M.AssertModel(models[11],_testData[29], false);
                        Singlereal0M.AssertModel(models[12],_testData[30], false);
                        Singlereal0M.AssertModel(models[13],_testData[31], false);
                        Singlereal0M.AssertModel(models[14],_testData[32], false);
                        Singlereal0M.AssertModel(models[15],_testData[33], false);
                        Singlereal0M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 1, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Singlereal0M.AssertModel(models[0],_testData[1], false);
                        Singlereal0M.AssertModel(models[1],_testData[2], false);
                        Singlereal0M.AssertModel(models[2],_testData[3], false);
                        Singlereal0M.AssertModel(models[3],_testData[4], false);
                        Singlereal0M.AssertModel(models[4],_testData[5], false);
                        Singlereal0M.AssertModel(models[5],_testData[6], false);
                        Singlereal0M.AssertModel(models[6],_testData[7], false);
                        Singlereal0M.AssertModel(models[7],_testData[8], false);
                        Singlereal0M.AssertModel(models[8],_testData[9], false);
                        Singlereal0M.AssertModel(models[9],_testData[10], false);
                        Singlereal0M.AssertModel(models[10],_testData[11], false);
                        Singlereal0M.AssertModel(models[11],_testData[12], false);
                        Singlereal0M.AssertModel(models[12],_testData[13], false);
                        Singlereal0M.AssertModel(models[13],_testData[14], false);
                        Singlereal0M.AssertModel(models[14],_testData[15], false);
                        Singlereal0M.AssertModel(models[15],_testData[16], false);
                        Singlereal0M.AssertModel(models[16],_testData[17], false);
                        Singlereal0M.AssertModel(models[17],_testData[18], false);
                        Singlereal0M.AssertModel(models[18],_testData[19], false);
                        Singlereal0M.AssertModel(models[19],_testData[20], false);
                        Singlereal0M.AssertModel(models[20],_testData[21], false);
                        Singlereal0M.AssertModel(models[21],_testData[22], false);
                        Singlereal0M.AssertModel(models[22],_testData[23], false);
                        Singlereal0M.AssertModel(models[23],_testData[24], false);
                        Singlereal0M.AssertModel(models[24],_testData[25], false);
                        Singlereal0M.AssertModel(models[25],_testData[26], false);
                        Singlereal0M.AssertModel(models[26],_testData[27], false);
                        Singlereal0M.AssertModel(models[27],_testData[28], false);
                        Singlereal0M.AssertModel(models[28],_testData[29], false);
                        Singlereal0M.AssertModel(models[29],_testData[30], false);
                        Singlereal0M.AssertModel(models[30],_testData[31], false);
                        Singlereal0M.AssertModel(models[31],_testData[32], false);
                        Singlereal0M.AssertModel(models[32],_testData[33], false);
                        Singlereal0M.AssertModel(models[33],_testData[34], false);
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
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Singlereal0M.AssertModel(models[0],_testData[27], false);
                Singlereal0M.AssertModel(models[1],_testData[28], false);
                Singlereal0M.AssertModel(models[2],_testData[29], false);
                Singlereal0M.AssertModel(models[3],_testData[30], false);
                Singlereal0M.AssertModel(models[4],_testData[31], false);
                Singlereal0M.AssertModel(models[5],_testData[32], false);
                Singlereal0M.AssertModel(models[6],_testData[33], false);
                Singlereal0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Singlereal0M.AssertModel(models[0],_testData[28], false);
                Singlereal0M.AssertModel(models[1],_testData[29], false);
                Singlereal0M.AssertModel(models[2],_testData[30], false);
                Singlereal0M.AssertModel(models[3],_testData[31], false);
                Singlereal0M.AssertModel(models[4],_testData[32], false);
                Singlereal0M.AssertModel(models[5],_testData[33], false);
                Singlereal0M.AssertModel(models[6],_testData[34], false);
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
                Assert.That((System.Single)model[1], Is.EqualTo((0.63497084f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9274735f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.89491224f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.24702203f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06674105f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.1677314f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.34726667f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.788679f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4465286f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.05489248f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.063711524f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7504789f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4341609f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8405717f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9223963f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.07404572f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5040469f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5320481f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.80981266f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4587332f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.863037f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41287345f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38679153f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.12460232f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.48473746f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7860966f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.008852243f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6449713f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1683281f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5967293f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6287767f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4606774f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.79116815f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.19378531f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.085733116f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.85426116f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.47776383f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.54051304f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.22961771f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8179924f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27556938f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32696062f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8898208f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42876554f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31888813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.33282346f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.057647824f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.79862064f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4401849f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.45743543f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.76021445f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.671001f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.99333453f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7716018f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0026857853f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9788704f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.37898612f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5977694f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.51781434f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36925232f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42768145f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9596017f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.25771672f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16117746f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.93063426f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8169088f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.57553893f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9339325f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08250946f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.96470696f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9727532f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5825552f)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.091698766f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.29750794f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.25219476f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76356286f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.92251754f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09924328f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42716044f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3243528f)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.65685695f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.219949f)));

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
                Assert.That((System.Single)model[1], Is.EqualTo((0.63497084f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9274735f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.89491224f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.24702203f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06674105f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.1677314f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.34726667f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.788679f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4465286f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.05489248f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.063711524f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7504789f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4341609f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8405717f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9223963f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.07404572f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5040469f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5320481f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.80981266f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4587332f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.863037f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41287345f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38679153f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.12460232f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.48473746f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7860966f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.008852243f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6449713f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.1683281f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5967293f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6287767f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.4606774f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.79116815f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.19378531f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.085733116f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.85426116f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.47776383f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.54051304f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.22961771f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8179924f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27556938f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32696062f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8898208f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.42876554f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.31888813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.33282346f)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.057647824f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.79862064f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.4401849f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.45743543f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.76021445f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.671001f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.99333453f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7716018f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.0026857853f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9788704f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.37898612f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5977694f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.51781434f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36925232f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42768145f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9596017f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.25771672f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.16117746f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.93063426f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8169088f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.57553893f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9339325f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08250946f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.96470696f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9727532f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5825552f)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.091698766f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.29750794f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.25219476f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76356286f)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.92251754f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.09924328f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42716044f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.3243528f)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.65685695f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.219949f)));

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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
            })]
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA), typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MIWA>();
                var models2 = new List<Singlereal0MIWA>();
                await ((ISingleSingleTypereal)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereal0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MIWA>();
                var models2 = new List<Singlereal0MIWA>();
                ((ISingleSingleTypereal)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereal0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISingleSingleTypereal)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
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
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleSingleTypereal)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
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
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA), typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MIWA>();
                var models2 = new List<Singlereal0MIWA>();
                await ((ISingleSingleTypereal)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereal0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MIWA>();
                var models2 = new List<Singlereal0MIWA>();
                ((ISingleSingleTypereal)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereal0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISingleSingleTypereal)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleSingleTypereal)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
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
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereal0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Singlereal0MI), typeof(Singlereal0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MI>();
                var models2 = new List<Singlereal0MI>();
                await ((ISingleSingleTypereal)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MI>();
                var models2 = new List<Singlereal0MI>();
                ((ISingleSingleTypereal)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Singlereal0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISingleSingleTypereal)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleSingleTypereal)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereal0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA), typeof(Singlereal0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MIWA>();
                var models2 = new List<Singlereal0MIWA>();
                await ((ISingleSingleTypereal)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Singlereal0MIWA>();
                var models2 = new List<Singlereal0MIWA>();
                ((ISingleSingleTypereal)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Singlereal0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISingleSingleTypereal)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleSingleTypereal)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


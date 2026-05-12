

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
    internal partial interface IBooleanSingleTypeboolean
    {
    }
    
    internal partial class BooleanSingleTypeboolean : IBooleanSingleTypeboolean
    {


#region TestData

        private readonly BooleanbooleanE0M[] _testData = new BooleanbooleanE0M[]
        {
            new BooleanbooleanE0M
{
    Id = 9,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 17,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 4,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 22,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 24,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 6,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 27,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 33,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 10,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 34,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 35,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 14,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 38,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 47,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 22,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 51,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 60,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 30,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 61,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 64,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 39,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 73,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 76,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 40,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 77,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 86,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 49,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 92,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 93,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 52,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 98,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 104,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 61,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 106,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 109,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 63,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 112,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 113,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 66,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 117,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 118,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 74,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 119,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 121,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 80,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 125,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 130,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 84,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 139,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 147,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 88,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 152,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0mi(
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0mi(
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
            queryMapTypes: [typeof(BooleanbooleanE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(2))]
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

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBooleanSingleTypeboolean)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBooleanSingleTypeboolean)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBooleanSingleTypeboolean)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBooleanSingleTypeboolean)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0mi(
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(3)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(3), 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0m(
	id,
    value,
    nullablevalue,
    booleanbooleane0mi_id
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanbooleane0mi_id", 
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
                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0m(
	id,
    value,
    nullablevalue,
    booleanbooleane0mi_id
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
    booleanbooleane0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                System.Boolean? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean>();
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
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

                    nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean>();
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
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

                    nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Boolean? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean>();
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
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

                    nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean>();
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
                    ((NpgsqlParameter<System.Boolean>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(2);
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

                    nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0m(
	id,
    value,
    nullablevalue,
    booleanbooleane0mi_id
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
    booleanbooleane0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanbooleane0mi_id", 
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
                System.Boolean? nullable = null;
                nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
                nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Boolean? nullable = null;
                nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BooleanbooleanE0M> models = null;

                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BooleanbooleanE0M> models = null;

                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleane0m(
	id,
    value,
    nullablevalue,
    booleanbooleane0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanbooleane0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Boolean), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(3)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(3),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "booleanbooleane0mi_id", 
                methodParametrName: "booleanbooleane0mi_id", 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBooleanSingleTypeboolean)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
LEFT JOIN public.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await ((IBooleanSingleTypeboolean)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBooleanSingleTypeboolean)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanSingleTypeboolean)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
LEFT JOIN public.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await ((IBooleanSingleTypeboolean)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBooleanSingleTypeboolean)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 113;
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[23],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[24],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[25],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[26],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[27],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[28],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[29],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[30],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 33;
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.booleanbooleane0m m
LEFT JOIN public.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[6], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[7], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[8], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[9], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[10], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[11], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[12], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[13], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[21],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[22],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[23],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[24],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[25],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[26],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[27],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 47, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 118, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 34, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[34], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[1], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[2], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[23],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[24],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[25],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[26],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[27],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[28],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[29],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[30],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[31],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[32],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[33],_testData[34], false);
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
FROM public.booleanbooleane0m m
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
FROM public.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.booleanbooleane0m m
LEFT JOIN public.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatchAsync(connection, 61, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[13], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[34], false);
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
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatch(connection, 24, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[4], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[5], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[6], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[7], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[8], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[9], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[10], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[11], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[12], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[13], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[21],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[22],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[23],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[24],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[25],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[26],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[27],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[28],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[29],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                BooleanbooleanE0M.AssertModel(models[0],_testData[9], false);
                BooleanbooleanE0M.AssertModel(models[1],_testData[10], false);
                BooleanbooleanE0M.AssertModel(models[2],_testData[11], false);
                BooleanbooleanE0M.AssertModel(models[3],_testData[12], false);
                BooleanbooleanE0M.AssertModel(models[4],_testData[13], false);
                BooleanbooleanE0M.AssertModel(models[5],_testData[14], false);
                BooleanbooleanE0M.AssertModel(models[6],_testData[15], false);
                BooleanbooleanE0M.AssertModel(models[7],_testData[16], false);
                BooleanbooleanE0M.AssertModel(models[8],_testData[17], false);
                BooleanbooleanE0M.AssertModel(models[9],_testData[18], false);
                BooleanbooleanE0M.AssertModel(models[10],_testData[19], false);
                BooleanbooleanE0M.AssertModel(models[11],_testData[20], false);
                BooleanbooleanE0M.AssertModel(models[12],_testData[21], false);
                BooleanbooleanE0M.AssertModel(models[13],_testData[22], false);
                BooleanbooleanE0M.AssertModel(models[14],_testData[23], false);
                BooleanbooleanE0M.AssertModel(models[15],_testData[24], false);
                BooleanbooleanE0M.AssertModel(models[16],_testData[25], false);
                BooleanbooleanE0M.AssertModel(models[17],_testData[26], false);
                BooleanbooleanE0M.AssertModel(models[18],_testData[27], false);
                BooleanbooleanE0M.AssertModel(models[19],_testData[28], false);
                BooleanbooleanE0M.AssertModel(models[20],_testData[29], false);
                BooleanbooleanE0M.AssertModel(models[21],_testData[30], false);
                BooleanbooleanE0M.AssertModel(models[22],_testData[31], false);
                BooleanbooleanE0M.AssertModel(models[23],_testData[32], false);
                BooleanbooleanE0M.AssertModel(models[24],_testData[33], false);
                BooleanbooleanE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                BooleanbooleanE0M.AssertModel(models[0],_testData[22], false);
                BooleanbooleanE0M.AssertModel(models[1],_testData[23], false);
                BooleanbooleanE0M.AssertModel(models[2],_testData[24], false);
                BooleanbooleanE0M.AssertModel(models[3],_testData[25], false);
                BooleanbooleanE0M.AssertModel(models[4],_testData[26], false);
                BooleanbooleanE0M.AssertModel(models[5],_testData[27], false);
                BooleanbooleanE0M.AssertModel(models[6],_testData[28], false);
                BooleanbooleanE0M.AssertModel(models[7],_testData[29], false);
                BooleanbooleanE0M.AssertModel(models[8],_testData[30], false);
                BooleanbooleanE0M.AssertModel(models[9],_testData[31], false);
                BooleanbooleanE0M.AssertModel(models[10],_testData[32], false);
                BooleanbooleanE0M.AssertModel(models[11],_testData[33], false);
                BooleanbooleanE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.booleanbooleane0m m
LEFT JOIN public.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
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
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

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
                var models =  ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_booleanbooleane0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BooleanbooleanE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBooleanSingleTypeboolean)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_booleanbooleane0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBooleanSingleTypeboolean)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBooleanSingleTypeboolean)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_booleanbooleane0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBooleanSingleTypeboolean)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_booleanbooleane0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BooleanbooleanE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBooleanSingleTypeboolean)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_booleanbooleane0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBooleanSingleTypeboolean)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBooleanSingleTypeboolean)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_booleanbooleane0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_booleanbooleane0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleane0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BooleanbooleanE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBooleanSingleTypeboolean)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBooleanSingleTypeboolean)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBooleanSingleTypeboolean)this).WAImportModelInner(connection, importCollection);
                var models = ((IBooleanSingleTypeboolean)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_booleanbooleane0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleane0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BooleanbooleanE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBooleanSingleTypeboolean)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBooleanSingleTypeboolean)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBooleanSingleTypeboolean)this).ImportModelInner(connection, importCollection);
                var models = ((IBooleanSingleTypeboolean)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleane0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
booleanbooleane0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BooleanbooleanE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
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
FROM public.binary_booleanbooleane0m m
LEFT JOIN public.binary_booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBooleanSingleTypeboolean)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBooleanSingleTypeboolean)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BooleanbooleanE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBooleanSingleTypeboolean)this).ImportModel(connection, importCollection);
                var models = ((IBooleanSingleTypeboolean)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BooleanbooleanE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleane0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    booleanbooleane0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
                var models =  ((IBooleanSingleTypeboolean)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BooleanbooleanE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanSingleTypeboolean)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BooleanbooleanE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA), typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
                var models1 = new List<BooleanbooleanE0MIWA>();
                var models2 = new List<BooleanbooleanE0MIWA>();
                await ((IBooleanSingleTypeboolean)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleane0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanE0MIWA>();
                var models2 = new List<BooleanbooleanE0MIWA>();
                ((IBooleanSingleTypeboolean)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleane0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
                var models = await ((IBooleanSingleTypeboolean)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_booleanbooleane0mi
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
                    BooleanbooleanE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanSingleTypeboolean)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_booleanbooleane0mi
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
                    BooleanbooleanE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA), typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
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
                var models1 = new List<BooleanbooleanE0MIWA>();
                var models2 = new List<BooleanbooleanE0MIWA>();
                await ((IBooleanSingleTypeboolean)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleane0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanE0MIWA>();
                var models2 = new List<BooleanbooleanE0MIWA>();
                ((IBooleanSingleTypeboolean)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleane0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
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
                var models = await ((IBooleanSingleTypeboolean)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_booleanbooleane0mi
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
                    BooleanbooleanE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanSingleTypeboolean)this).DynQueryExportModelInner(connection, @"
COPY public.binary_booleanbooleane0mi
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
                    BooleanbooleanE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_booleanbooleane0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MI), typeof(BooleanbooleanE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
                var models1 = new List<BooleanbooleanE0MI>();
                var models2 = new List<BooleanbooleanE0MI>();
                await ((IBooleanSingleTypeboolean)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanE0MI>();
                var models2 = new List<BooleanbooleanE0MI>();
                ((IBooleanSingleTypeboolean)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleane0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(2),
                (NpgsqlTypes.NpgsqlDbType)(2)
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
                var models = await ((IBooleanSingleTypeboolean)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanSingleTypeboolean)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_booleanbooleane0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA), typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
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
                var models1 = new List<BooleanbooleanE0MIWA>();
                var models2 = new List<BooleanbooleanE0MIWA>();
                await ((IBooleanSingleTypeboolean)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanE0MIWA>();
                var models2 = new List<BooleanbooleanE0MIWA>();
                ((IBooleanSingleTypeboolean)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleane0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
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
                var models = await ((IBooleanSingleTypeboolean)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanSingleTypeboolean)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


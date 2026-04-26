

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

        private readonly Booleanboolean0M[] _testData = new Booleanboolean0M[]
        {
            new Booleanboolean0M
{
    Id = 3,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 7,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 2,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 16,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 21,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 11,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 24,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 26,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 17,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 33,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 41,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 18,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 46,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 50,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 26,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 53,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 56,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 31,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 60,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 69,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 33,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 77,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 85,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 42,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 86,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 94,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 45,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 103,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 107,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 51,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 112,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 121,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 59,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 129,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 137,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 63,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 139,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 143,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 69,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 151,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 158,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 76,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 167,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 174,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 81,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0mi(
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
INSERT INTO public.booleanboolean0mi(
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
            queryMapTypes: [typeof(Booleanboolean0MI)],
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
INSERT INTO public.booleanboolean0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
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
                methodParametrName: "booleanboolean0mi_id", 
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
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
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
    booleanboolean0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
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
    booleanboolean0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
                methodParametrName: "booleanboolean0mi_id", 
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(false));
                nullable = await ((IBooleanSingleTypeboolean)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Booleanboolean0M> models = null;

                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[12], true);
                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[13], true);
                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[14], true);
                models =  ((IBooleanSingleTypeboolean)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Booleanboolean0M> models = null;

                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[16], true);
                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[17], true);
                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[18], true);
                models = await ((IBooleanSingleTypeboolean)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Booleanboolean0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanboolean0mi_id
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
                parametrName: "booleanboolean0mi_id", 
                methodParametrName: "booleanboolean0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBooleanSingleTypeboolean)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanSingleTypeboolean)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanboolean0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[29], false);
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 46;
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.booleanboolean0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[27],_testData[29], false);
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
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Booleanboolean0M.AssertModel(models[0],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Booleanboolean0M.AssertModel(models[0],_testData[8], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[9], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[20],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Booleanboolean0M.AssertModel(models[0],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Booleanboolean0M.AssertModel(models[0],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 41, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 94, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatch(connection, 85, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[29], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[29], false);
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
FROM public.booleanboolean0m m
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
FROM public.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatch(connection, 94, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Booleanboolean0M.AssertModel(models[0],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Booleanboolean0M.AssertModel(models[0],_testData[5], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[6], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[7], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[8], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[9], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[20],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[21],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[22],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[23],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatch(connection, 3, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Booleanboolean0M.AssertModel(models[0],_testData[1], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[2], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[3], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[4], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[5], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[6], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[7], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[8], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[9], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[20],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[21],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[22],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[23],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[24],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[25],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[26],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[27],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Booleanboolean0M.AssertModel(models[0],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[29], false);
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
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Booleanboolean0M.AssertModel(models[0],_testData[23], false);Booleanboolean0M.AssertModel(models[1],_testData[24], false);Booleanboolean0M.AssertModel(models[2],_testData[25], false);Booleanboolean0M.AssertModel(models[3],_testData[26], false);Booleanboolean0M.AssertModel(models[4],_testData[27], false);Booleanboolean0M.AssertModel(models[5],_testData[28], false);Booleanboolean0M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models =  ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Booleanboolean0M.AssertModel(models[0],_testData[10], false);Booleanboolean0M.AssertModel(models[1],_testData[11], false);Booleanboolean0M.AssertModel(models[2],_testData[12], false);Booleanboolean0M.AssertModel(models[3],_testData[13], false);Booleanboolean0M.AssertModel(models[4],_testData[14], false);Booleanboolean0M.AssertModel(models[5],_testData[15], false);Booleanboolean0M.AssertModel(models[6],_testData[16], false);Booleanboolean0M.AssertModel(models[7],_testData[17], false);Booleanboolean0M.AssertModel(models[8],_testData[18], false);Booleanboolean0M.AssertModel(models[9],_testData[19], false);Booleanboolean0M.AssertModel(models[10],_testData[20], false);Booleanboolean0M.AssertModel(models[11],_testData[21], false);Booleanboolean0M.AssertModel(models[12],_testData[22], false);Booleanboolean0M.AssertModel(models[13],_testData[23], false);Booleanboolean0M.AssertModel(models[14],_testData[24], false);Booleanboolean0M.AssertModel(models[15],_testData[25], false);Booleanboolean0M.AssertModel(models[16],_testData[26], false);Booleanboolean0M.AssertModel(models[17],_testData[27], false);Booleanboolean0M.AssertModel(models[18],_testData[28], false);Booleanboolean0M.AssertModel(models[19],_testData[29], false);
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
FROM public.booleanboolean0m m
LEFT JOIN public.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanboolean0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Booleanboolean0MI)],
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
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_booleanboolean0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Booleanboolean0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Booleanboolean0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBooleanSingleTypeboolean)this).ImportModelInner(connection, importCollection);
                var models = ((IBooleanSingleTypeboolean)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Booleanboolean0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IBooleanSingleTypeboolean)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBooleanSingleTypeboolean)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Booleanboolean0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanboolean0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
booleanboolean0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
FROM public.binary_booleanboolean0m m
LEFT JOIN public.binary_booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Booleanboolean0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IBooleanSingleTypeboolean)this).ImportModel(connection, importCollection);
                var models = ((IBooleanSingleTypeboolean)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Booleanboolean0M.AssertModel(models[0],_testData[0], false);
                Booleanboolean0M.AssertModel(models[1],_testData[1], false);
                Booleanboolean0M.AssertModel(models[2],_testData[2], false);
                Booleanboolean0M.AssertModel(models[3],_testData[3], false);
                Booleanboolean0M.AssertModel(models[4],_testData[4], false);
                Booleanboolean0M.AssertModel(models[5],_testData[5], false);
                Booleanboolean0M.AssertModel(models[6],_testData[6], false);
                Booleanboolean0M.AssertModel(models[7],_testData[7], false);
                Booleanboolean0M.AssertModel(models[8],_testData[8], false);
                Booleanboolean0M.AssertModel(models[9],_testData[9], false);
                Booleanboolean0M.AssertModel(models[10],_testData[10], false);
                Booleanboolean0M.AssertModel(models[11],_testData[11], false);
                Booleanboolean0M.AssertModel(models[12],_testData[12], false);
                Booleanboolean0M.AssertModel(models[13],_testData[13], false);
                Booleanboolean0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IBooleanSingleTypeboolean)this).ImportModelAsync(connection, importCollection);
                models = await ((IBooleanSingleTypeboolean)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Booleanboolean0M.AssertModel(models[0],_testData[0], false);
                Booleanboolean0M.AssertModel(models[1],_testData[1], false);
                Booleanboolean0M.AssertModel(models[2],_testData[2], false);
                Booleanboolean0M.AssertModel(models[3],_testData[3], false);
                Booleanboolean0M.AssertModel(models[4],_testData[4], false);
                Booleanboolean0M.AssertModel(models[5],_testData[5], false);
                Booleanboolean0M.AssertModel(models[6],_testData[6], false);
                Booleanboolean0M.AssertModel(models[7],_testData[7], false);
                Booleanboolean0M.AssertModel(models[8],_testData[8], false);
                Booleanboolean0M.AssertModel(models[9],_testData[9], false);
                Booleanboolean0M.AssertModel(models[10],_testData[10], false);
                Booleanboolean0M.AssertModel(models[11],_testData[11], false);
                Booleanboolean0M.AssertModel(models[12],_testData[12], false);
                Booleanboolean0M.AssertModel(models[13],_testData[13], false);
                Booleanboolean0M.AssertModel(models[14],_testData[14], false);
                Booleanboolean0M.AssertModel(models[15],_testData[15], false);
                Booleanboolean0M.AssertModel(models[16],_testData[16], false);
                Booleanboolean0M.AssertModel(models[17],_testData[17], false);
                Booleanboolean0M.AssertModel(models[18],_testData[18], false);
                Booleanboolean0M.AssertModel(models[19],_testData[19], false);
                Booleanboolean0M.AssertModel(models[20],_testData[20], false);
                Booleanboolean0M.AssertModel(models[21],_testData[21], false);
                Booleanboolean0M.AssertModel(models[22],_testData[22], false);
                Booleanboolean0M.AssertModel(models[23],_testData[23], false);
                Booleanboolean0M.AssertModel(models[24],_testData[24], false);
                Booleanboolean0M.AssertModel(models[25],_testData[25], false);
                Booleanboolean0M.AssertModel(models[26],_testData[26], false);
                Booleanboolean0M.AssertModel(models[27],_testData[27], false);
                Booleanboolean0M.AssertModel(models[28],_testData[28], false);
                Booleanboolean0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanboolean0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    booleanboolean0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    Booleanboolean0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    Booleanboolean0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanboolean0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Booleanboolean0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanSingleTypeboolean)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Booleanboolean0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanSingleTypeboolean)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Booleanboolean0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


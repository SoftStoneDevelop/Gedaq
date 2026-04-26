

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
    internal partial interface IInt16SingleTypesmallint
    {
    }
    
    internal partial class Int16SingleTypesmallint : IInt16SingleTypesmallint
    {


#region TestData

        private readonly Int16smallint0M[] _testData = new Int16smallint0M[]
        {
            new Int16smallint0M
{
    Id = 4,
    Value = 30410,
    ModelInner = null,
    NullableValue = 2195,
},
            new Int16smallint0M
{
    Id = 6,
    Value = 1080,
    ModelInner = new Int16smallint0MI
{
    Id = 9,
    Value = 10826,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 14,
    Value = 30988,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 21,
    Value = 9961,
    ModelInner = new Int16smallint0MI
{
    Id = 15,
    Value = 32273,
    NullableValue = 30878,
},
    NullableValue = 10067,
},
            new Int16smallint0M
{
    Id = 27,
    Value = 1202,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 33,
    Value = 6063,
    ModelInner = new Int16smallint0MI
{
    Id = 16,
    Value = 18237,
    NullableValue = null,
},
    NullableValue = 32501,
},
            new Int16smallint0M
{
    Id = 36,
    Value = 10716,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 43,
    Value = 17363,
    ModelInner = new Int16smallint0MI
{
    Id = 17,
    Value = 3743,
    NullableValue = 26482,
},
    NullableValue = 30051,
},
            new Int16smallint0M
{
    Id = 52,
    Value = 18475,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 61,
    Value = 27531,
    ModelInner = new Int16smallint0MI
{
    Id = 18,
    Value = 636,
    NullableValue = null,
},
    NullableValue = 1593,
},
            new Int16smallint0M
{
    Id = 62,
    Value = 26945,
    ModelInner = null,
    NullableValue = 3494,
},
            new Int16smallint0M
{
    Id = 64,
    Value = 26188,
    ModelInner = new Int16smallint0MI
{
    Id = 24,
    Value = 15814,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 73,
    Value = 32337,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 74,
    Value = 25743,
    ModelInner = new Int16smallint0MI
{
    Id = 30,
    Value = 9355,
    NullableValue = 28820,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 83,
    Value = 21545,
    ModelInner = null,
    NullableValue = 28849,
},
            new Int16smallint0M
{
    Id = 91,
    Value = 12177,
    ModelInner = new Int16smallint0MI
{
    Id = 33,
    Value = 20576,
    NullableValue = null,
},
    NullableValue = 18779,
},
            new Int16smallint0M
{
    Id = 93,
    Value = 2318,
    ModelInner = null,
    NullableValue = 27694,
},
            new Int16smallint0M
{
    Id = 97,
    Value = 5337,
    ModelInner = new Int16smallint0MI
{
    Id = 40,
    Value = 18892,
    NullableValue = 8303,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 102,
    Value = 32444,
    ModelInner = null,
    NullableValue = 23763,
},
            new Int16smallint0M
{
    Id = 109,
    Value = 22980,
    ModelInner = new Int16smallint0MI
{
    Id = 48,
    Value = 28941,
    NullableValue = 24204,
},
    NullableValue = 13532,
},
            new Int16smallint0M
{
    Id = 115,
    Value = 1258,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 119,
    Value = 4362,
    ModelInner = new Int16smallint0MI
{
    Id = 57,
    Value = 2701,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 121,
    Value = 20730,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 129,
    Value = 32590,
    ModelInner = new Int16smallint0MI
{
    Id = 65,
    Value = 28878,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 131,
    Value = 4621,
    ModelInner = null,
    NullableValue = 12161,
},
            new Int16smallint0M
{
    Id = 135,
    Value = 24848,
    ModelInner = new Int16smallint0MI
{
    Id = 69,
    Value = 17855,
    NullableValue = 11689,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 140,
    Value = 30928,
    ModelInner = null,
    NullableValue = 28889,
},
            new Int16smallint0M
{
    Id = 142,
    Value = 8746,
    ModelInner = new Int16smallint0MI
{
    Id = 71,
    Value = 18575,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 147,
    Value = 7913,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 148,
    Value = 13853,
    ModelInner = new Int16smallint0MI
{
    Id = 76,
    Value = 15095,
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0mi(
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
            queryMapTypes: [typeof(Int16smallint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18))]
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16SingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16SingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16SingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16SingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10), 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallint0mi_id", 
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
                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
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
    int16smallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                System.Int16? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
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

                    nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
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

                    nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(32501));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
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

                    nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
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

                    nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(30051));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
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
    int16smallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallint0mi_id", 
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
                System.Int16? nullable = null;
                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1593));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;
                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3494));
                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallint0M> models = null;

                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallint0M> models = null;

                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallint0mi_id", 
                methodParametrName: "int16smallint0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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

                var models = await ((IInt16SingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16SingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await ((IInt16SingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatInt16smallint0M.AssertModel(models[0],_testData[3], false);FlatInt16smallint0M.AssertModel(models[1],_testData[4], false);FlatInt16smallint0M.AssertModel(models[2],_testData[5], false);FlatInt16smallint0M.AssertModel(models[3],_testData[6], false);FlatInt16smallint0M.AssertModel(models[4],_testData[7], false);FlatInt16smallint0M.AssertModel(models[5],_testData[8], false);FlatInt16smallint0M.AssertModel(models[6],_testData[9], false);FlatInt16smallint0M.AssertModel(models[7],_testData[10], false);FlatInt16smallint0M.AssertModel(models[8],_testData[11], false);FlatInt16smallint0M.AssertModel(models[9],_testData[12], false);FlatInt16smallint0M.AssertModel(models[10],_testData[13], false);FlatInt16smallint0M.AssertModel(models[11],_testData[14], false);FlatInt16smallint0M.AssertModel(models[12],_testData[15], false);FlatInt16smallint0M.AssertModel(models[13],_testData[16], false);FlatInt16smallint0M.AssertModel(models[14],_testData[17], false);FlatInt16smallint0M.AssertModel(models[15],_testData[18], false);FlatInt16smallint0M.AssertModel(models[16],_testData[19], false);FlatInt16smallint0M.AssertModel(models[17],_testData[20], false);FlatInt16smallint0M.AssertModel(models[18],_testData[21], false);FlatInt16smallint0M.AssertModel(models[19],_testData[22], false);FlatInt16smallint0M.AssertModel(models[20],_testData[23], false);FlatInt16smallint0M.AssertModel(models[21],_testData[24], false);FlatInt16smallint0M.AssertModel(models[22],_testData[25], false);FlatInt16smallint0M.AssertModel(models[23],_testData[26], false);FlatInt16smallint0M.AssertModel(models[24],_testData[27], false);FlatInt16smallint0M.AssertModel(models[25],_testData[28], false);FlatInt16smallint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt16smallint0M.AssertModel(models[0],_testData[1], false);FlatInt16smallint0M.AssertModel(models[1],_testData[2], false);FlatInt16smallint0M.AssertModel(models[2],_testData[3], false);FlatInt16smallint0M.AssertModel(models[3],_testData[4], false);FlatInt16smallint0M.AssertModel(models[4],_testData[5], false);FlatInt16smallint0M.AssertModel(models[5],_testData[6], false);FlatInt16smallint0M.AssertModel(models[6],_testData[7], false);FlatInt16smallint0M.AssertModel(models[7],_testData[8], false);FlatInt16smallint0M.AssertModel(models[8],_testData[9], false);FlatInt16smallint0M.AssertModel(models[9],_testData[10], false);FlatInt16smallint0M.AssertModel(models[10],_testData[11], false);FlatInt16smallint0M.AssertModel(models[11],_testData[12], false);FlatInt16smallint0M.AssertModel(models[12],_testData[13], false);FlatInt16smallint0M.AssertModel(models[13],_testData[14], false);FlatInt16smallint0M.AssertModel(models[14],_testData[15], false);FlatInt16smallint0M.AssertModel(models[15],_testData[16], false);FlatInt16smallint0M.AssertModel(models[16],_testData[17], false);FlatInt16smallint0M.AssertModel(models[17],_testData[18], false);FlatInt16smallint0M.AssertModel(models[18],_testData[19], false);FlatInt16smallint0M.AssertModel(models[19],_testData[20], false);FlatInt16smallint0M.AssertModel(models[20],_testData[21], false);FlatInt16smallint0M.AssertModel(models[21],_testData[22], false);FlatInt16smallint0M.AssertModel(models[22],_testData[23], false);FlatInt16smallint0M.AssertModel(models[23],_testData[24], false);FlatInt16smallint0M.AssertModel(models[24],_testData[25], false);FlatInt16smallint0M.AssertModel(models[25],_testData[26], false);FlatInt16smallint0M.AssertModel(models[26],_testData[27], false);FlatInt16smallint0M.AssertModel(models[27],_testData[28], false);FlatInt16smallint0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatInt16smallint0M.AssertModel(models[0],_testData[19], false);FlatInt16smallint0M.AssertModel(models[1],_testData[20], false);FlatInt16smallint0M.AssertModel(models[2],_testData[21], false);FlatInt16smallint0M.AssertModel(models[3],_testData[22], false);FlatInt16smallint0M.AssertModel(models[4],_testData[23], false);FlatInt16smallint0M.AssertModel(models[5],_testData[24], false);FlatInt16smallint0M.AssertModel(models[6],_testData[25], false);FlatInt16smallint0M.AssertModel(models[7],_testData[26], false);FlatInt16smallint0M.AssertModel(models[8],_testData[27], false);FlatInt16smallint0M.AssertModel(models[9],_testData[28], false);FlatInt16smallint0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatInt16smallint0M.AssertModel(models[0],_testData[14], false);FlatInt16smallint0M.AssertModel(models[1],_testData[15], false);FlatInt16smallint0M.AssertModel(models[2],_testData[16], false);FlatInt16smallint0M.AssertModel(models[3],_testData[17], false);FlatInt16smallint0M.AssertModel(models[4],_testData[18], false);FlatInt16smallint0M.AssertModel(models[5],_testData[19], false);FlatInt16smallint0M.AssertModel(models[6],_testData[20], false);FlatInt16smallint0M.AssertModel(models[7],_testData[21], false);FlatInt16smallint0M.AssertModel(models[8],_testData[22], false);FlatInt16smallint0M.AssertModel(models[9],_testData[23], false);FlatInt16smallint0M.AssertModel(models[10],_testData[24], false);FlatInt16smallint0M.AssertModel(models[11],_testData[25], false);FlatInt16smallint0M.AssertModel(models[12],_testData[26], false);FlatInt16smallint0M.AssertModel(models[13],_testData[27], false);FlatInt16smallint0M.AssertModel(models[14],_testData[28], false);FlatInt16smallint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
Int16smallint0M.AssertModel(models[0],_testData[25], false);Int16smallint0M.AssertModel(models[1],_testData[26], false);Int16smallint0M.AssertModel(models[2],_testData[27], false);Int16smallint0M.AssertModel(models[3],_testData[28], false);Int16smallint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Int16smallint0M.AssertModel(models[0],_testData[23], false);Int16smallint0M.AssertModel(models[1],_testData[24], false);Int16smallint0M.AssertModel(models[2],_testData[25], false);Int16smallint0M.AssertModel(models[3],_testData[26], false);Int16smallint0M.AssertModel(models[4],_testData[27], false);Int16smallint0M.AssertModel(models[5],_testData[28], false);Int16smallint0M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
Int16smallint0M.AssertModel(models[0],_testData[15], false);Int16smallint0M.AssertModel(models[1],_testData[16], false);Int16smallint0M.AssertModel(models[2],_testData[17], false);Int16smallint0M.AssertModel(models[3],_testData[18], false);Int16smallint0M.AssertModel(models[4],_testData[19], false);Int16smallint0M.AssertModel(models[5],_testData[20], false);Int16smallint0M.AssertModel(models[6],_testData[21], false);Int16smallint0M.AssertModel(models[7],_testData[22], false);Int16smallint0M.AssertModel(models[8],_testData[23], false);Int16smallint0M.AssertModel(models[9],_testData[24], false);Int16smallint0M.AssertModel(models[10],_testData[25], false);Int16smallint0M.AssertModel(models[11],_testData[26], false);Int16smallint0M.AssertModel(models[12],_testData[27], false);Int16smallint0M.AssertModel(models[13],_testData[28], false);Int16smallint0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
Int16smallint0M.AssertModel(models[0],_testData[3], false);Int16smallint0M.AssertModel(models[1],_testData[4], false);Int16smallint0M.AssertModel(models[2],_testData[5], false);Int16smallint0M.AssertModel(models[3],_testData[6], false);Int16smallint0M.AssertModel(models[4],_testData[7], false);Int16smallint0M.AssertModel(models[5],_testData[8], false);Int16smallint0M.AssertModel(models[6],_testData[9], false);Int16smallint0M.AssertModel(models[7],_testData[10], false);Int16smallint0M.AssertModel(models[8],_testData[11], false);Int16smallint0M.AssertModel(models[9],_testData[12], false);Int16smallint0M.AssertModel(models[10],_testData[13], false);Int16smallint0M.AssertModel(models[11],_testData[14], false);Int16smallint0M.AssertModel(models[12],_testData[15], false);Int16smallint0M.AssertModel(models[13],_testData[16], false);Int16smallint0M.AssertModel(models[14],_testData[17], false);Int16smallint0M.AssertModel(models[15],_testData[18], false);Int16smallint0M.AssertModel(models[16],_testData[19], false);Int16smallint0M.AssertModel(models[17],_testData[20], false);Int16smallint0M.AssertModel(models[18],_testData[21], false);Int16smallint0M.AssertModel(models[19],_testData[22], false);Int16smallint0M.AssertModel(models[20],_testData[23], false);Int16smallint0M.AssertModel(models[21],_testData[24], false);Int16smallint0M.AssertModel(models[22],_testData[25], false);Int16smallint0M.AssertModel(models[23],_testData[26], false);Int16smallint0M.AssertModel(models[24],_testData[27], false);Int16smallint0M.AssertModel(models[25],_testData[28], false);Int16smallint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatInt16smallint0M.AssertModel(models[0],_testData[6], false);FlatInt16smallint0M.AssertModel(models[1],_testData[7], false);FlatInt16smallint0M.AssertModel(models[2],_testData[8], false);FlatInt16smallint0M.AssertModel(models[3],_testData[9], false);FlatInt16smallint0M.AssertModel(models[4],_testData[10], false);FlatInt16smallint0M.AssertModel(models[5],_testData[11], false);FlatInt16smallint0M.AssertModel(models[6],_testData[12], false);FlatInt16smallint0M.AssertModel(models[7],_testData[13], false);FlatInt16smallint0M.AssertModel(models[8],_testData[14], false);FlatInt16smallint0M.AssertModel(models[9],_testData[15], false);FlatInt16smallint0M.AssertModel(models[10],_testData[16], false);FlatInt16smallint0M.AssertModel(models[11],_testData[17], false);FlatInt16smallint0M.AssertModel(models[12],_testData[18], false);FlatInt16smallint0M.AssertModel(models[13],_testData[19], false);FlatInt16smallint0M.AssertModel(models[14],_testData[20], false);FlatInt16smallint0M.AssertModel(models[15],_testData[21], false);FlatInt16smallint0M.AssertModel(models[16],_testData[22], false);FlatInt16smallint0M.AssertModel(models[17],_testData[23], false);FlatInt16smallint0M.AssertModel(models[18],_testData[24], false);FlatInt16smallint0M.AssertModel(models[19],_testData[25], false);FlatInt16smallint0M.AssertModel(models[20],_testData[26], false);FlatInt16smallint0M.AssertModel(models[21],_testData[27], false);FlatInt16smallint0M.AssertModel(models[22],_testData[28], false);FlatInt16smallint0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatInt16smallint0M.AssertModel(models[0],_testData[19], false);FlatInt16smallint0M.AssertModel(models[1],_testData[20], false);FlatInt16smallint0M.AssertModel(models[2],_testData[21], false);FlatInt16smallint0M.AssertModel(models[3],_testData[22], false);FlatInt16smallint0M.AssertModel(models[4],_testData[23], false);FlatInt16smallint0M.AssertModel(models[5],_testData[24], false);FlatInt16smallint0M.AssertModel(models[6],_testData[25], false);FlatInt16smallint0M.AssertModel(models[7],_testData[26], false);FlatInt16smallint0M.AssertModel(models[8],_testData[27], false);FlatInt16smallint0M.AssertModel(models[9],_testData[28], false);FlatInt16smallint0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatInt16smallint0M.AssertModel(models[0],_testData[11], false);FlatInt16smallint0M.AssertModel(models[1],_testData[12], false);FlatInt16smallint0M.AssertModel(models[2],_testData[13], false);FlatInt16smallint0M.AssertModel(models[3],_testData[14], false);FlatInt16smallint0M.AssertModel(models[4],_testData[15], false);FlatInt16smallint0M.AssertModel(models[5],_testData[16], false);FlatInt16smallint0M.AssertModel(models[6],_testData[17], false);FlatInt16smallint0M.AssertModel(models[7],_testData[18], false);FlatInt16smallint0M.AssertModel(models[8],_testData[19], false);FlatInt16smallint0M.AssertModel(models[9],_testData[20], false);FlatInt16smallint0M.AssertModel(models[10],_testData[21], false);FlatInt16smallint0M.AssertModel(models[11],_testData[22], false);FlatInt16smallint0M.AssertModel(models[12],_testData[23], false);FlatInt16smallint0M.AssertModel(models[13],_testData[24], false);FlatInt16smallint0M.AssertModel(models[14],_testData[25], false);FlatInt16smallint0M.AssertModel(models[15],_testData[26], false);FlatInt16smallint0M.AssertModel(models[16],_testData[27], false);FlatInt16smallint0M.AssertModel(models[17],_testData[28], false);FlatInt16smallint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt16smallint0M.AssertModel(models[0],_testData[9], false);FlatInt16smallint0M.AssertModel(models[1],_testData[10], false);FlatInt16smallint0M.AssertModel(models[2],_testData[11], false);FlatInt16smallint0M.AssertModel(models[3],_testData[12], false);FlatInt16smallint0M.AssertModel(models[4],_testData[13], false);FlatInt16smallint0M.AssertModel(models[5],_testData[14], false);FlatInt16smallint0M.AssertModel(models[6],_testData[15], false);FlatInt16smallint0M.AssertModel(models[7],_testData[16], false);FlatInt16smallint0M.AssertModel(models[8],_testData[17], false);FlatInt16smallint0M.AssertModel(models[9],_testData[18], false);FlatInt16smallint0M.AssertModel(models[10],_testData[19], false);FlatInt16smallint0M.AssertModel(models[11],_testData[20], false);FlatInt16smallint0M.AssertModel(models[12],_testData[21], false);FlatInt16smallint0M.AssertModel(models[13],_testData[22], false);FlatInt16smallint0M.AssertModel(models[14],_testData[23], false);FlatInt16smallint0M.AssertModel(models[15],_testData[24], false);FlatInt16smallint0M.AssertModel(models[16],_testData[25], false);FlatInt16smallint0M.AssertModel(models[17],_testData[26], false);FlatInt16smallint0M.AssertModel(models[18],_testData[27], false);FlatInt16smallint0M.AssertModel(models[19],_testData[28], false);FlatInt16smallint0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelBatchAsync(connection, 62, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
Int16smallint0M.AssertModel(models[0],_testData[11], false);Int16smallint0M.AssertModel(models[1],_testData[12], false);Int16smallint0M.AssertModel(models[2],_testData[13], false);Int16smallint0M.AssertModel(models[3],_testData[14], false);Int16smallint0M.AssertModel(models[4],_testData[15], false);Int16smallint0M.AssertModel(models[5],_testData[16], false);Int16smallint0M.AssertModel(models[6],_testData[17], false);Int16smallint0M.AssertModel(models[7],_testData[18], false);Int16smallint0M.AssertModel(models[8],_testData[19], false);Int16smallint0M.AssertModel(models[9],_testData[20], false);Int16smallint0M.AssertModel(models[10],_testData[21], false);Int16smallint0M.AssertModel(models[11],_testData[22], false);Int16smallint0M.AssertModel(models[12],_testData[23], false);Int16smallint0M.AssertModel(models[13],_testData[24], false);Int16smallint0M.AssertModel(models[14],_testData[25], false);Int16smallint0M.AssertModel(models[15],_testData[26], false);Int16smallint0M.AssertModel(models[16],_testData[27], false);Int16smallint0M.AssertModel(models[17],_testData[28], false);Int16smallint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
Int16smallint0M.AssertModel(models[0],_testData[21], false);Int16smallint0M.AssertModel(models[1],_testData[22], false);Int16smallint0M.AssertModel(models[2],_testData[23], false);Int16smallint0M.AssertModel(models[3],_testData[24], false);Int16smallint0M.AssertModel(models[4],_testData[25], false);Int16smallint0M.AssertModel(models[5],_testData[26], false);Int16smallint0M.AssertModel(models[6],_testData[27], false);Int16smallint0M.AssertModel(models[7],_testData[28], false);Int16smallint0M.AssertModel(models[8],_testData[29], false);
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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelBatch(connection, 74, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Int16smallint0M.AssertModel(models[0],_testData[14], false);Int16smallint0M.AssertModel(models[1],_testData[15], false);Int16smallint0M.AssertModel(models[2],_testData[16], false);Int16smallint0M.AssertModel(models[3],_testData[17], false);Int16smallint0M.AssertModel(models[4],_testData[18], false);Int16smallint0M.AssertModel(models[5],_testData[19], false);Int16smallint0M.AssertModel(models[6],_testData[20], false);Int16smallint0M.AssertModel(models[7],_testData[21], false);Int16smallint0M.AssertModel(models[8],_testData[22], false);Int16smallint0M.AssertModel(models[9],_testData[23], false);Int16smallint0M.AssertModel(models[10],_testData[24], false);Int16smallint0M.AssertModel(models[11],_testData[25], false);Int16smallint0M.AssertModel(models[12],_testData[26], false);Int16smallint0M.AssertModel(models[13],_testData[27], false);Int16smallint0M.AssertModel(models[14],_testData[28], false);Int16smallint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
Int16smallint0M.AssertModel(models[0],_testData[12], false);Int16smallint0M.AssertModel(models[1],_testData[13], false);Int16smallint0M.AssertModel(models[2],_testData[14], false);Int16smallint0M.AssertModel(models[3],_testData[15], false);Int16smallint0M.AssertModel(models[4],_testData[16], false);Int16smallint0M.AssertModel(models[5],_testData[17], false);Int16smallint0M.AssertModel(models[6],_testData[18], false);Int16smallint0M.AssertModel(models[7],_testData[19], false);Int16smallint0M.AssertModel(models[8],_testData[20], false);Int16smallint0M.AssertModel(models[9],_testData[21], false);Int16smallint0M.AssertModel(models[10],_testData[22], false);Int16smallint0M.AssertModel(models[11],_testData[23], false);Int16smallint0M.AssertModel(models[12],_testData[24], false);Int16smallint0M.AssertModel(models[13],_testData[25], false);Int16smallint0M.AssertModel(models[14],_testData[26], false);Int16smallint0M.AssertModel(models[15],_testData[27], false);Int16smallint0M.AssertModel(models[16],_testData[28], false);Int16smallint0M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Int16smallint0M.AssertModel(models[0],_testData[5], false);Int16smallint0M.AssertModel(models[1],_testData[6], false);Int16smallint0M.AssertModel(models[2],_testData[7], false);Int16smallint0M.AssertModel(models[3],_testData[8], false);Int16smallint0M.AssertModel(models[4],_testData[9], false);Int16smallint0M.AssertModel(models[5],_testData[10], false);Int16smallint0M.AssertModel(models[6],_testData[11], false);Int16smallint0M.AssertModel(models[7],_testData[12], false);Int16smallint0M.AssertModel(models[8],_testData[13], false);Int16smallint0M.AssertModel(models[9],_testData[14], false);Int16smallint0M.AssertModel(models[10],_testData[15], false);Int16smallint0M.AssertModel(models[11],_testData[16], false);Int16smallint0M.AssertModel(models[12],_testData[17], false);Int16smallint0M.AssertModel(models[13],_testData[18], false);Int16smallint0M.AssertModel(models[14],_testData[19], false);Int16smallint0M.AssertModel(models[15],_testData[20], false);Int16smallint0M.AssertModel(models[16],_testData[21], false);Int16smallint0M.AssertModel(models[17],_testData[22], false);Int16smallint0M.AssertModel(models[18],_testData[23], false);Int16smallint0M.AssertModel(models[19],_testData[24], false);Int16smallint0M.AssertModel(models[20],_testData[25], false);Int16smallint0M.AssertModel(models[21],_testData[26], false);Int16smallint0M.AssertModel(models[22],_testData[27], false);Int16smallint0M.AssertModel(models[23],_testData[28], false);Int16smallint0M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int16smallint0M.AssertModel(models[0],_testData[1], false);Int16smallint0M.AssertModel(models[1],_testData[2], false);Int16smallint0M.AssertModel(models[2],_testData[3], false);Int16smallint0M.AssertModel(models[3],_testData[4], false);Int16smallint0M.AssertModel(models[4],_testData[5], false);Int16smallint0M.AssertModel(models[5],_testData[6], false);Int16smallint0M.AssertModel(models[6],_testData[7], false);Int16smallint0M.AssertModel(models[7],_testData[8], false);Int16smallint0M.AssertModel(models[8],_testData[9], false);Int16smallint0M.AssertModel(models[9],_testData[10], false);Int16smallint0M.AssertModel(models[10],_testData[11], false);Int16smallint0M.AssertModel(models[11],_testData[12], false);Int16smallint0M.AssertModel(models[12],_testData[13], false);Int16smallint0M.AssertModel(models[13],_testData[14], false);Int16smallint0M.AssertModel(models[14],_testData[15], false);Int16smallint0M.AssertModel(models[15],_testData[16], false);Int16smallint0M.AssertModel(models[16],_testData[17], false);Int16smallint0M.AssertModel(models[17],_testData[18], false);Int16smallint0M.AssertModel(models[18],_testData[19], false);Int16smallint0M.AssertModel(models[19],_testData[20], false);Int16smallint0M.AssertModel(models[20],_testData[21], false);Int16smallint0M.AssertModel(models[21],_testData[22], false);Int16smallint0M.AssertModel(models[22],_testData[23], false);Int16smallint0M.AssertModel(models[23],_testData[24], false);Int16smallint0M.AssertModel(models[24],_testData[25], false);Int16smallint0M.AssertModel(models[25],_testData[26], false);Int16smallint0M.AssertModel(models[26],_testData[27], false);Int16smallint0M.AssertModel(models[27],_testData[28], false);Int16smallint0M.AssertModel(models[28],_testData[29], false);
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
FROM public.int16smallint0m m
LEFT JOIN public.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30410)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((2195)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1080)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10826)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30988)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9961)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32273)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((30878)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10067)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1202)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6063)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18237)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((32501)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10716)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17363)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3743)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26482)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((30051)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18475)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27531)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((636)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((1593)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26945)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3494)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15814)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32337)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25743)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9355)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((28820)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21545)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28849)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12177)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20576)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18779)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2318)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((27694)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5337)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18892)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8303)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32444)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((23763)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22980)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28941)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((24204)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((13532)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1258)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4362)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2701)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20730)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32590)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28878)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4621)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12161)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24848)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17855)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((11689)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30928)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28889)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8746)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18575)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7913)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13853)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15095)));//InnerModel.Value

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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30410)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((2195)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1080)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10826)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30988)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9961)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32273)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((30878)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10067)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1202)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6063)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18237)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((32501)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10716)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17363)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3743)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26482)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((30051)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18475)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27531)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((636)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((1593)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26945)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3494)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15814)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32337)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25743)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9355)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((28820)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21545)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28849)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12177)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((20576)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18779)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2318)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((27694)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5337)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18892)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8303)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32444)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((23763)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22980)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28941)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((24204)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((13532)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1258)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4362)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2701)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20730)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32590)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28878)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4621)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12161)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24848)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17855)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((11689)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((30928)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28889)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8746)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18575)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7913)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13853)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15095)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Int16smallint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
FROM public.binary_int16smallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int16smallint0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt16SingleTypesmallint)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16SingleTypesmallint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallint0MI.AssertModel(actual, expect, false);
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
                await ((IInt16SingleTypesmallint)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt16SingleTypesmallint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Int16smallint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
FROM public.binary_int16smallint0m m
LEFT JOIN public.binary_int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int16smallint0M>(15);

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
                ((IInt16SingleTypesmallint)this).ImportModel(connection, importCollection);
                var models = ((IInt16SingleTypesmallint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int16smallint0M.AssertModel(models[0],_testData[0], false);
                Int16smallint0M.AssertModel(models[1],_testData[1], false);
                Int16smallint0M.AssertModel(models[2],_testData[2], false);
                Int16smallint0M.AssertModel(models[3],_testData[3], false);
                Int16smallint0M.AssertModel(models[4],_testData[4], false);
                Int16smallint0M.AssertModel(models[5],_testData[5], false);
                Int16smallint0M.AssertModel(models[6],_testData[6], false);
                Int16smallint0M.AssertModel(models[7],_testData[7], false);
                Int16smallint0M.AssertModel(models[8],_testData[8], false);
                Int16smallint0M.AssertModel(models[9],_testData[9], false);
                Int16smallint0M.AssertModel(models[10],_testData[10], false);
                Int16smallint0M.AssertModel(models[11],_testData[11], false);
                Int16smallint0M.AssertModel(models[12],_testData[12], false);
                Int16smallint0M.AssertModel(models[13],_testData[13], false);
                Int16smallint0M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt16SingleTypesmallint)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt16SingleTypesmallint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int16smallint0M.AssertModel(models[0],_testData[0], false);
                Int16smallint0M.AssertModel(models[1],_testData[1], false);
                Int16smallint0M.AssertModel(models[2],_testData[2], false);
                Int16smallint0M.AssertModel(models[3],_testData[3], false);
                Int16smallint0M.AssertModel(models[4],_testData[4], false);
                Int16smallint0M.AssertModel(models[5],_testData[5], false);
                Int16smallint0M.AssertModel(models[6],_testData[6], false);
                Int16smallint0M.AssertModel(models[7],_testData[7], false);
                Int16smallint0M.AssertModel(models[8],_testData[8], false);
                Int16smallint0M.AssertModel(models[9],_testData[9], false);
                Int16smallint0M.AssertModel(models[10],_testData[10], false);
                Int16smallint0M.AssertModel(models[11],_testData[11], false);
                Int16smallint0M.AssertModel(models[12],_testData[12], false);
                Int16smallint0M.AssertModel(models[13],_testData[13], false);
                Int16smallint0M.AssertModel(models[14],_testData[14], false);
                Int16smallint0M.AssertModel(models[15],_testData[15], false);
                Int16smallint0M.AssertModel(models[16],_testData[16], false);
                Int16smallint0M.AssertModel(models[17],_testData[17], false);
                Int16smallint0M.AssertModel(models[18],_testData[18], false);
                Int16smallint0M.AssertModel(models[19],_testData[19], false);
                Int16smallint0M.AssertModel(models[20],_testData[20], false);
                Int16smallint0M.AssertModel(models[21],_testData[21], false);
                Int16smallint0M.AssertModel(models[22],_testData[22], false);
                Int16smallint0M.AssertModel(models[23],_testData[23], false);
                Int16smallint0M.AssertModel(models[24],_testData[24], false);
                Int16smallint0M.AssertModel(models[25],_testData[25], false);
                Int16smallint0M.AssertModel(models[26],_testData[26], false);
                Int16smallint0M.AssertModel(models[27],_testData[27], false);
                Int16smallint0M.AssertModel(models[28],_testData[28], false);
                Int16smallint0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}




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
    Id = 3,
    Value = 19690,
    ModelInner = null,
    NullableValue = 10008,
},
            new Int16smallint0M
{
    Id = 5,
    Value = 11176,
    ModelInner = new Int16smallint0MI
{
    Id = 2,
    Value = 22818,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 10,
    Value = 19521,
    ModelInner = null,
    NullableValue = 20508,
},
            new Int16smallint0M
{
    Id = 17,
    Value = 25128,
    ModelInner = new Int16smallint0MI
{
    Id = 6,
    Value = 13497,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 25,
    Value = 24080,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 30,
    Value = 13218,
    ModelInner = new Int16smallint0MI
{
    Id = 10,
    Value = 28850,
    NullableValue = null,
},
    NullableValue = 19682,
},
            new Int16smallint0M
{
    Id = 32,
    Value = 23799,
    ModelInner = null,
    NullableValue = 3732,
},
            new Int16smallint0M
{
    Id = 34,
    Value = 13379,
    ModelInner = new Int16smallint0MI
{
    Id = 13,
    Value = 29078,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 38,
    Value = 1590,
    ModelInner = null,
    NullableValue = 1349,
},
            new Int16smallint0M
{
    Id = 42,
    Value = 21188,
    ModelInner = new Int16smallint0MI
{
    Id = 20,
    Value = 8314,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 49,
    Value = 15486,
    ModelInner = null,
    NullableValue = 19425,
},
            new Int16smallint0M
{
    Id = 50,
    Value = 19628,
    ModelInner = new Int16smallint0MI
{
    Id = 22,
    Value = 24048,
    NullableValue = null,
},
    NullableValue = 3465,
},
            new Int16smallint0M
{
    Id = 53,
    Value = 18514,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 55,
    Value = 21689,
    ModelInner = new Int16smallint0MI
{
    Id = 29,
    Value = 18267,
    NullableValue = 15147,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 59,
    Value = 20115,
    ModelInner = null,
    NullableValue = 17370,
},
            new Int16smallint0M
{
    Id = 64,
    Value = 16492,
    ModelInner = new Int16smallint0MI
{
    Id = 34,
    Value = 19632,
    NullableValue = null,
},
    NullableValue = 11011,
},
            new Int16smallint0M
{
    Id = 71,
    Value = 20423,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 77,
    Value = 9804,
    ModelInner = new Int16smallint0MI
{
    Id = 43,
    Value = 24237,
    NullableValue = 13038,
},
    NullableValue = 18027,
},
            new Int16smallint0M
{
    Id = 79,
    Value = 18955,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 85,
    Value = 26613,
    ModelInner = new Int16smallint0MI
{
    Id = 51,
    Value = 10086,
    NullableValue = null,
},
    NullableValue = 17857,
},
            new Int16smallint0M
{
    Id = 90,
    Value = 13555,
    ModelInner = null,
    NullableValue = 3401,
},
            new Int16smallint0M
{
    Id = 93,
    Value = 8356,
    ModelInner = new Int16smallint0MI
{
    Id = 52,
    Value = 32216,
    NullableValue = 1215,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 102,
    Value = 19938,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 107,
    Value = 15128,
    ModelInner = new Int16smallint0MI
{
    Id = 54,
    Value = 2403,
    NullableValue = 18600,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 114,
    Value = 22511,
    ModelInner = null,
    NullableValue = 25379,
},
            new Int16smallint0M
{
    Id = 120,
    Value = 13644,
    ModelInner = new Int16smallint0MI
{
    Id = 59,
    Value = 12361,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 122,
    Value = 26028,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 126,
    Value = 1117,
    ModelInner = new Int16smallint0MI
{
    Id = 60,
    Value = 29856,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 131,
    Value = 14246,
    ModelInner = null,
    NullableValue = 16344,
},
            new Int16smallint0M
{
    Id = 133,
    Value = 1781,
    ModelInner = new Int16smallint0MI
{
    Id = 65,
    Value = 5168,
    NullableValue = 3208,
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
                Assert.That(nullable, Is.EqualTo(19682));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3732));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1349));
                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(19425));
                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3465));
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.int16smallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((IInt16SingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
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
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
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
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[24],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallint0M.AssertModel(models[0],_testData[23], false);
                        Int16smallint0M.AssertModel(models[1],_testData[24], false);
                        Int16smallint0M.AssertModel(models[2],_testData[25], false);
                        Int16smallint0M.AssertModel(models[3],_testData[26], false);
                        Int16smallint0M.AssertModel(models[4],_testData[27], false);
                        Int16smallint0M.AssertModel(models[5],_testData[28], false);
                        Int16smallint0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int16smallint0M.AssertModel(models[0],_testData[10], false);
                        Int16smallint0M.AssertModel(models[1],_testData[11], false);
                        Int16smallint0M.AssertModel(models[2],_testData[12], false);
                        Int16smallint0M.AssertModel(models[3],_testData[13], false);
                        Int16smallint0M.AssertModel(models[4],_testData[14], false);
                        Int16smallint0M.AssertModel(models[5],_testData[15], false);
                        Int16smallint0M.AssertModel(models[6],_testData[16], false);
                        Int16smallint0M.AssertModel(models[7],_testData[17], false);
                        Int16smallint0M.AssertModel(models[8],_testData[18], false);
                        Int16smallint0M.AssertModel(models[9],_testData[19], false);
                        Int16smallint0M.AssertModel(models[10],_testData[20], false);
                        Int16smallint0M.AssertModel(models[11],_testData[21], false);
                        Int16smallint0M.AssertModel(models[12],_testData[22], false);
                        Int16smallint0M.AssertModel(models[13],_testData[23], false);
                        Int16smallint0M.AssertModel(models[14],_testData[24], false);
                        Int16smallint0M.AssertModel(models[15],_testData[25], false);
                        Int16smallint0M.AssertModel(models[16],_testData[26], false);
                        Int16smallint0M.AssertModel(models[17],_testData[27], false);
                        Int16smallint0M.AssertModel(models[18],_testData[28], false);
                        Int16smallint0M.AssertModel(models[19],_testData[29], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int16smallint0M.AssertModel(models[0],_testData[26], false);
                        Int16smallint0M.AssertModel(models[1],_testData[27], false);
                        Int16smallint0M.AssertModel(models[2],_testData[28], false);
                        Int16smallint0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int16smallint0M.AssertModel(models[0],_testData[15], false);
                        Int16smallint0M.AssertModel(models[1],_testData[16], false);
                        Int16smallint0M.AssertModel(models[2],_testData[17], false);
                        Int16smallint0M.AssertModel(models[3],_testData[18], false);
                        Int16smallint0M.AssertModel(models[4],_testData[19], false);
                        Int16smallint0M.AssertModel(models[5],_testData[20], false);
                        Int16smallint0M.AssertModel(models[6],_testData[21], false);
                        Int16smallint0M.AssertModel(models[7],_testData[22], false);
                        Int16smallint0M.AssertModel(models[8],_testData[23], false);
                        Int16smallint0M.AssertModel(models[9],_testData[24], false);
                        Int16smallint0M.AssertModel(models[10],_testData[25], false);
                        Int16smallint0M.AssertModel(models[11],_testData[26], false);
                        Int16smallint0M.AssertModel(models[12],_testData[27], false);
                        Int16smallint0M.AssertModel(models[13],_testData[28], false);
                        Int16smallint0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 38, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 25, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 64, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 5, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[29], false);
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
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 17, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[25],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallint0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 50, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[22],_testData[29], false);
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
FROM public.int16smallint0m m
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
FROM public.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[22],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 42, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int16smallint0M.AssertModel(models[0],_testData[10], false);
                        Int16smallint0M.AssertModel(models[1],_testData[11], false);
                        Int16smallint0M.AssertModel(models[2],_testData[12], false);
                        Int16smallint0M.AssertModel(models[3],_testData[13], false);
                        Int16smallint0M.AssertModel(models[4],_testData[14], false);
                        Int16smallint0M.AssertModel(models[5],_testData[15], false);
                        Int16smallint0M.AssertModel(models[6],_testData[16], false);
                        Int16smallint0M.AssertModel(models[7],_testData[17], false);
                        Int16smallint0M.AssertModel(models[8],_testData[18], false);
                        Int16smallint0M.AssertModel(models[9],_testData[19], false);
                        Int16smallint0M.AssertModel(models[10],_testData[20], false);
                        Int16smallint0M.AssertModel(models[11],_testData[21], false);
                        Int16smallint0M.AssertModel(models[12],_testData[22], false);
                        Int16smallint0M.AssertModel(models[13],_testData[23], false);
                        Int16smallint0M.AssertModel(models[14],_testData[24], false);
                        Int16smallint0M.AssertModel(models[15],_testData[25], false);
                        Int16smallint0M.AssertModel(models[16],_testData[26], false);
                        Int16smallint0M.AssertModel(models[17],_testData[27], false);
                        Int16smallint0M.AssertModel(models[18],_testData[28], false);
                        Int16smallint0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int16smallint0M.AssertModel(models[0],_testData[26], false);
                        Int16smallint0M.AssertModel(models[1],_testData[27], false);
                        Int16smallint0M.AssertModel(models[2],_testData[28], false);
                        Int16smallint0M.AssertModel(models[3],_testData[29], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 5, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int16smallint0M.AssertModel(models[0],_testData[2], false);
                        Int16smallint0M.AssertModel(models[1],_testData[3], false);
                        Int16smallint0M.AssertModel(models[2],_testData[4], false);
                        Int16smallint0M.AssertModel(models[3],_testData[5], false);
                        Int16smallint0M.AssertModel(models[4],_testData[6], false);
                        Int16smallint0M.AssertModel(models[5],_testData[7], false);
                        Int16smallint0M.AssertModel(models[6],_testData[8], false);
                        Int16smallint0M.AssertModel(models[7],_testData[9], false);
                        Int16smallint0M.AssertModel(models[8],_testData[10], false);
                        Int16smallint0M.AssertModel(models[9],_testData[11], false);
                        Int16smallint0M.AssertModel(models[10],_testData[12], false);
                        Int16smallint0M.AssertModel(models[11],_testData[13], false);
                        Int16smallint0M.AssertModel(models[12],_testData[14], false);
                        Int16smallint0M.AssertModel(models[13],_testData[15], false);
                        Int16smallint0M.AssertModel(models[14],_testData[16], false);
                        Int16smallint0M.AssertModel(models[15],_testData[17], false);
                        Int16smallint0M.AssertModel(models[16],_testData[18], false);
                        Int16smallint0M.AssertModel(models[17],_testData[19], false);
                        Int16smallint0M.AssertModel(models[18],_testData[20], false);
                        Int16smallint0M.AssertModel(models[19],_testData[21], false);
                        Int16smallint0M.AssertModel(models[20],_testData[22], false);
                        Int16smallint0M.AssertModel(models[21],_testData[23], false);
                        Int16smallint0M.AssertModel(models[22],_testData[24], false);
                        Int16smallint0M.AssertModel(models[23],_testData[25], false);
                        Int16smallint0M.AssertModel(models[24],_testData[26], false);
                        Int16smallint0M.AssertModel(models[25],_testData[27], false);
                        Int16smallint0M.AssertModel(models[26],_testData[28], false);
                        Int16smallint0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallint0M.AssertModel(models[0],_testData[24], false);
                        Int16smallint0M.AssertModel(models[1],_testData[25], false);
                        Int16smallint0M.AssertModel(models[2],_testData[26], false);
                        Int16smallint0M.AssertModel(models[3],_testData[27], false);
                        Int16smallint0M.AssertModel(models[4],_testData[28], false);
                        Int16smallint0M.AssertModel(models[5],_testData[29], false);
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
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
Int16smallint0M.AssertModel(models[0],_testData[4], false);Int16smallint0M.AssertModel(models[1],_testData[5], false);Int16smallint0M.AssertModel(models[2],_testData[6], false);Int16smallint0M.AssertModel(models[3],_testData[7], false);Int16smallint0M.AssertModel(models[4],_testData[8], false);Int16smallint0M.AssertModel(models[5],_testData[9], false);Int16smallint0M.AssertModel(models[6],_testData[10], false);Int16smallint0M.AssertModel(models[7],_testData[11], false);Int16smallint0M.AssertModel(models[8],_testData[12], false);Int16smallint0M.AssertModel(models[9],_testData[13], false);Int16smallint0M.AssertModel(models[10],_testData[14], false);Int16smallint0M.AssertModel(models[11],_testData[15], false);Int16smallint0M.AssertModel(models[12],_testData[16], false);Int16smallint0M.AssertModel(models[13],_testData[17], false);Int16smallint0M.AssertModel(models[14],_testData[18], false);Int16smallint0M.AssertModel(models[15],_testData[19], false);Int16smallint0M.AssertModel(models[16],_testData[20], false);Int16smallint0M.AssertModel(models[17],_testData[21], false);Int16smallint0M.AssertModel(models[18],_testData[22], false);Int16smallint0M.AssertModel(models[19],_testData[23], false);Int16smallint0M.AssertModel(models[20],_testData[24], false);Int16smallint0M.AssertModel(models[21],_testData[25], false);Int16smallint0M.AssertModel(models[22],_testData[26], false);Int16smallint0M.AssertModel(models[23],_testData[27], false);Int16smallint0M.AssertModel(models[24],_testData[28], false);Int16smallint0M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
Int16smallint0M.AssertModel(models[0],_testData[19], false);Int16smallint0M.AssertModel(models[1],_testData[20], false);Int16smallint0M.AssertModel(models[2],_testData[21], false);Int16smallint0M.AssertModel(models[3],_testData[22], false);Int16smallint0M.AssertModel(models[4],_testData[23], false);Int16smallint0M.AssertModel(models[5],_testData[24], false);Int16smallint0M.AssertModel(models[6],_testData[25], false);Int16smallint0M.AssertModel(models[7],_testData[26], false);Int16smallint0M.AssertModel(models[8],_testData[27], false);Int16smallint0M.AssertModel(models[9],_testData[28], false);Int16smallint0M.AssertModel(models[10],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19690)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10008)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11176)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((22818)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19521)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((20508)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25128)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13497)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24080)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13218)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28850)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19682)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23799)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3732)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13379)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((29078)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1590)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1349)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8314)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15486)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19425)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19628)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24048)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((3465)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18514)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21689)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18267)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15147)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20115)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((17370)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16492)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19632)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((11011)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20423)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9804)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24237)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((13038)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((18027)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18955)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26613)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10086)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17857)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13555)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3401)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8356)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32216)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((1215)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19938)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15128)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2403)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((18600)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22511)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25379)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13644)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((12361)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26028)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1117)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((29856)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14246)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16344)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1781)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5168)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((3208)));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19690)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10008)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11176)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((22818)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19521)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((20508)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25128)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13497)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24080)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13218)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28850)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19682)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23799)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3732)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13379)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((29078)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1590)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1349)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8314)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15486)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19425)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19628)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24048)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((3465)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18514)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21689)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18267)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15147)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20115)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((17370)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16492)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19632)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((11011)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20423)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9804)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24237)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((13038)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((18027)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18955)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26613)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10086)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17857)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13555)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3401)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8356)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32216)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((1215)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19938)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15128)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2403)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((18600)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22511)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25379)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13644)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((12361)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26028)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1117)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((29856)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14246)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16344)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1781)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5168)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((3208)));//InnerModel.NullableValue

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
            queryMapType: typeof(Int16smallint0MI),
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
            queryMapType: typeof(Int16smallint0M),
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


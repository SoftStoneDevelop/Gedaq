

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
    internal partial interface IInt32SingleTypeinteger
    {
    }
    
    internal partial class Int32SingleTypeinteger : IInt32SingleTypeinteger
    {


#region TestData

        private readonly Int32integer0M[] _testData = new Int32integer0M[]
        {
            new Int32integer0M
{
    Id = 8,
    Value = 662664127,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 17,
    Value = 1218039253,
    ModelInner = new Int32integer0MI
{
    Id = 3,
    Value = 1285936385,
    NullableValue = 1296565642,
},
    NullableValue = 321792144,
},
            new Int32integer0M
{
    Id = 23,
    Value = 938653906,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 28,
    Value = 1183618973,
    ModelInner = new Int32integer0MI
{
    Id = 4,
    Value = 369047542,
    NullableValue = 2094700014,
},
    NullableValue = 220264980,
},
            new Int32integer0M
{
    Id = 34,
    Value = 904178267,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 37,
    Value = 887999660,
    ModelInner = new Int32integer0MI
{
    Id = 5,
    Value = 2065758311,
    NullableValue = 40881608,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 39,
    Value = 1370261294,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 41,
    Value = 58301634,
    ModelInner = new Int32integer0MI
{
    Id = 10,
    Value = 1105911150,
    NullableValue = 1057779891,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 46,
    Value = 926360094,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 54,
    Value = 1035652535,
    ModelInner = new Int32integer0MI
{
    Id = 12,
    Value = 2030771592,
    NullableValue = 768771990,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 59,
    Value = 1629750409,
    ModelInner = null,
    NullableValue = 1094113611,
},
            new Int32integer0M
{
    Id = 63,
    Value = 1332408368,
    ModelInner = new Int32integer0MI
{
    Id = 16,
    Value = 21027065,
    NullableValue = null,
},
    NullableValue = 1956785949,
},
            new Int32integer0M
{
    Id = 71,
    Value = 1115114894,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 72,
    Value = 1438133118,
    ModelInner = new Int32integer0MI
{
    Id = 23,
    Value = 1452905276,
    NullableValue = null,
},
    NullableValue = 779612912,
},
            new Int32integer0M
{
    Id = 79,
    Value = 1892723476,
    ModelInner = null,
    NullableValue = 958376609,
},
            new Int32integer0M
{
    Id = 83,
    Value = 398632077,
    ModelInner = new Int32integer0MI
{
    Id = 31,
    Value = 14981610,
    NullableValue = 389962345,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 85,
    Value = 739814973,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 86,
    Value = 1679646772,
    ModelInner = new Int32integer0MI
{
    Id = 37,
    Value = 868041953,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 90,
    Value = 800446002,
    ModelInner = null,
    NullableValue = 1433356483,
},
            new Int32integer0M
{
    Id = 98,
    Value = 1593050702,
    ModelInner = new Int32integer0MI
{
    Id = 45,
    Value = 142376001,
    NullableValue = 861588361,
},
    NullableValue = 204602044,
},
            new Int32integer0M
{
    Id = 107,
    Value = 834953712,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 109,
    Value = 784335596,
    ModelInner = new Int32integer0MI
{
    Id = 48,
    Value = 1974036307,
    NullableValue = null,
},
    NullableValue = 1189405025,
},
            new Int32integer0M
{
    Id = 118,
    Value = 2112646618,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 126,
    Value = 1732605005,
    ModelInner = new Int32integer0MI
{
    Id = 49,
    Value = 116700245,
    NullableValue = null,
},
    NullableValue = 605552876,
},
            new Int32integer0M
{
    Id = 130,
    Value = 481729385,
    ModelInner = null,
    NullableValue = 838106609,
},
            new Int32integer0M
{
    Id = 134,
    Value = 256116796,
    ModelInner = new Int32integer0MI
{
    Id = 52,
    Value = 1548077373,
    NullableValue = 831681387,
},
    NullableValue = 1480644056,
},
            new Int32integer0M
{
    Id = 140,
    Value = 1337934293,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 149,
    Value = 2053286743,
    ModelInner = new Int32integer0MI
{
    Id = 59,
    Value = 1989325140,
    NullableValue = 355435516,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 156,
    Value = 30058970,
    ModelInner = null,
    NullableValue = 1015636337,
},
            new Int32integer0M
{
    Id = 159,
    Value = 698477093,
    ModelInner = new Int32integer0MI
{
    Id = 61,
    Value = 1349235228,
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            queryMapTypes: [typeof(Int32integer0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32SingleTypeinteger)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32SingleTypeinteger)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32SingleTypeinteger)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32SingleTypeinteger)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            asPartInterface: typeof(IInt32SingleTypeinteger)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11), 
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

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeinteger)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integer0mi_id", 
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
                changedRows =  ((IInt32SingleTypeinteger)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32SingleTypeinteger)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
    int32integer0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                System.Int32? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int32? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
    int32integer0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integer0mi_id", 
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
                System.Int32? nullable = null;
                nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32? nullable = null;
                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1094113611));
                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1956785949));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integer0M> models = null;

                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integer0M> models = null;

                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32integer0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32integer0mi_id", 
                methodParametrName: "int32integer0mi_id", 
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

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32SingleTypeinteger)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32SingleTypeinteger)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await ((IInt32SingleTypeinteger)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32SingleTypeinteger)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32SingleTypeinteger)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeinteger)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await ((IInt32SingleTypeinteger)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32SingleTypeinteger)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt32integer0M.AssertModel(models[0],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integer0M.AssertModel(models[0],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integer0M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integer0M.AssertModel(models[0],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await((IInt32SingleTypeinteger)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integer0M.AssertModel(models[0],_testData[6], false);
                        Int32integer0M.AssertModel(models[1],_testData[7], false);
                        Int32integer0M.AssertModel(models[2],_testData[8], false);
                        Int32integer0M.AssertModel(models[3],_testData[9], false);
                        Int32integer0M.AssertModel(models[4],_testData[10], false);
                        Int32integer0M.AssertModel(models[5],_testData[11], false);
                        Int32integer0M.AssertModel(models[6],_testData[12], false);
                        Int32integer0M.AssertModel(models[7],_testData[13], false);
                        Int32integer0M.AssertModel(models[8],_testData[14], false);
                        Int32integer0M.AssertModel(models[9],_testData[15], false);
                        Int32integer0M.AssertModel(models[10],_testData[16], false);
                        Int32integer0M.AssertModel(models[11],_testData[17], false);
                        Int32integer0M.AssertModel(models[12],_testData[18], false);
                        Int32integer0M.AssertModel(models[13],_testData[19], false);
                        Int32integer0M.AssertModel(models[14],_testData[20], false);
                        Int32integer0M.AssertModel(models[15],_testData[21], false);
                        Int32integer0M.AssertModel(models[16],_testData[22], false);
                        Int32integer0M.AssertModel(models[17],_testData[23], false);
                        Int32integer0M.AssertModel(models[18],_testData[24], false);
                        Int32integer0M.AssertModel(models[19],_testData[25], false);
                        Int32integer0M.AssertModel(models[20],_testData[26], false);
                        Int32integer0M.AssertModel(models[21],_testData[27], false);
                        Int32integer0M.AssertModel(models[22],_testData[28], false);
                        Int32integer0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32integer0M.AssertModel(models[0],_testData[18], false);
                        Int32integer0M.AssertModel(models[1],_testData[19], false);
                        Int32integer0M.AssertModel(models[2],_testData[20], false);
                        Int32integer0M.AssertModel(models[3],_testData[21], false);
                        Int32integer0M.AssertModel(models[4],_testData[22], false);
                        Int32integer0M.AssertModel(models[5],_testData[23], false);
                        Int32integer0M.AssertModel(models[6],_testData[24], false);
                        Int32integer0M.AssertModel(models[7],_testData[25], false);
                        Int32integer0M.AssertModel(models[8],_testData[26], false);
                        Int32integer0M.AssertModel(models[9],_testData[27], false);
                        Int32integer0M.AssertModel(models[10],_testData[28], false);
                        Int32integer0M.AssertModel(models[11],_testData[29], false);
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
                var models = ((IInt32SingleTypeinteger)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integer0M.AssertModel(models[0],_testData[21], false);
                        Int32integer0M.AssertModel(models[1],_testData[22], false);
                        Int32integer0M.AssertModel(models[2],_testData[23], false);
                        Int32integer0M.AssertModel(models[3],_testData[24], false);
                        Int32integer0M.AssertModel(models[4],_testData[25], false);
                        Int32integer0M.AssertModel(models[5],_testData[26], false);
                        Int32integer0M.AssertModel(models[6],_testData[27], false);
                        Int32integer0M.AssertModel(models[7],_testData[28], false);
                        Int32integer0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32integer0M.AssertModel(models[0],_testData[2], false);
                        Int32integer0M.AssertModel(models[1],_testData[3], false);
                        Int32integer0M.AssertModel(models[2],_testData[4], false);
                        Int32integer0M.AssertModel(models[3],_testData[5], false);
                        Int32integer0M.AssertModel(models[4],_testData[6], false);
                        Int32integer0M.AssertModel(models[5],_testData[7], false);
                        Int32integer0M.AssertModel(models[6],_testData[8], false);
                        Int32integer0M.AssertModel(models[7],_testData[9], false);
                        Int32integer0M.AssertModel(models[8],_testData[10], false);
                        Int32integer0M.AssertModel(models[9],_testData[11], false);
                        Int32integer0M.AssertModel(models[10],_testData[12], false);
                        Int32integer0M.AssertModel(models[11],_testData[13], false);
                        Int32integer0M.AssertModel(models[12],_testData[14], false);
                        Int32integer0M.AssertModel(models[13],_testData[15], false);
                        Int32integer0M.AssertModel(models[14],_testData[16], false);
                        Int32integer0M.AssertModel(models[15],_testData[17], false);
                        Int32integer0M.AssertModel(models[16],_testData[18], false);
                        Int32integer0M.AssertModel(models[17],_testData[19], false);
                        Int32integer0M.AssertModel(models[18],_testData[20], false);
                        Int32integer0M.AssertModel(models[19],_testData[21], false);
                        Int32integer0M.AssertModel(models[20],_testData[22], false);
                        Int32integer0M.AssertModel(models[21],_testData[23], false);
                        Int32integer0M.AssertModel(models[22],_testData[24], false);
                        Int32integer0M.AssertModel(models[23],_testData[25], false);
                        Int32integer0M.AssertModel(models[24],_testData[26], false);
                        Int32integer0M.AssertModel(models[25],_testData[27], false);
                        Int32integer0M.AssertModel(models[26],_testData[28], false);
                        Int32integer0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integer0M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integer0M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 90, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt32integer0M.AssertModel(models[0],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integer0M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await((IInt32SingleTypeinteger)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32integer0M.AssertModel(models[0],_testData[8], false);
                        Int32integer0M.AssertModel(models[1],_testData[9], false);
                        Int32integer0M.AssertModel(models[2],_testData[10], false);
                        Int32integer0M.AssertModel(models[3],_testData[11], false);
                        Int32integer0M.AssertModel(models[4],_testData[12], false);
                        Int32integer0M.AssertModel(models[5],_testData[13], false);
                        Int32integer0M.AssertModel(models[6],_testData[14], false);
                        Int32integer0M.AssertModel(models[7],_testData[15], false);
                        Int32integer0M.AssertModel(models[8],_testData[16], false);
                        Int32integer0M.AssertModel(models[9],_testData[17], false);
                        Int32integer0M.AssertModel(models[10],_testData[18], false);
                        Int32integer0M.AssertModel(models[11],_testData[19], false);
                        Int32integer0M.AssertModel(models[12],_testData[20], false);
                        Int32integer0M.AssertModel(models[13],_testData[21], false);
                        Int32integer0M.AssertModel(models[14],_testData[22], false);
                        Int32integer0M.AssertModel(models[15],_testData[23], false);
                        Int32integer0M.AssertModel(models[16],_testData[24], false);
                        Int32integer0M.AssertModel(models[17],_testData[25], false);
                        Int32integer0M.AssertModel(models[18],_testData[26], false);
                        Int32integer0M.AssertModel(models[19],_testData[27], false);
                        Int32integer0M.AssertModel(models[20],_testData[28], false);
                        Int32integer0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32integer0M.AssertModel(models[0],_testData[19], false);
                        Int32integer0M.AssertModel(models[1],_testData[20], false);
                        Int32integer0M.AssertModel(models[2],_testData[21], false);
                        Int32integer0M.AssertModel(models[3],_testData[22], false);
                        Int32integer0M.AssertModel(models[4],_testData[23], false);
                        Int32integer0M.AssertModel(models[5],_testData[24], false);
                        Int32integer0M.AssertModel(models[6],_testData[25], false);
                        Int32integer0M.AssertModel(models[7],_testData[26], false);
                        Int32integer0M.AssertModel(models[8],_testData[27], false);
                        Int32integer0M.AssertModel(models[9],_testData[28], false);
                        Int32integer0M.AssertModel(models[10],_testData[29], false);
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
                var models = ((IInt32SingleTypeinteger)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelBatch(connection, 37, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integer0M.AssertModel(models[0],_testData[6], false);
                        Int32integer0M.AssertModel(models[1],_testData[7], false);
                        Int32integer0M.AssertModel(models[2],_testData[8], false);
                        Int32integer0M.AssertModel(models[3],_testData[9], false);
                        Int32integer0M.AssertModel(models[4],_testData[10], false);
                        Int32integer0M.AssertModel(models[5],_testData[11], false);
                        Int32integer0M.AssertModel(models[6],_testData[12], false);
                        Int32integer0M.AssertModel(models[7],_testData[13], false);
                        Int32integer0M.AssertModel(models[8],_testData[14], false);
                        Int32integer0M.AssertModel(models[9],_testData[15], false);
                        Int32integer0M.AssertModel(models[10],_testData[16], false);
                        Int32integer0M.AssertModel(models[11],_testData[17], false);
                        Int32integer0M.AssertModel(models[12],_testData[18], false);
                        Int32integer0M.AssertModel(models[13],_testData[19], false);
                        Int32integer0M.AssertModel(models[14],_testData[20], false);
                        Int32integer0M.AssertModel(models[15],_testData[21], false);
                        Int32integer0M.AssertModel(models[16],_testData[22], false);
                        Int32integer0M.AssertModel(models[17],_testData[23], false);
                        Int32integer0M.AssertModel(models[18],_testData[24], false);
                        Int32integer0M.AssertModel(models[19],_testData[25], false);
                        Int32integer0M.AssertModel(models[20],_testData[26], false);
                        Int32integer0M.AssertModel(models[21],_testData[27], false);
                        Int32integer0M.AssertModel(models[22],_testData[28], false);
                        Int32integer0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32integer0M.AssertModel(models[0],_testData[20], false);
                        Int32integer0M.AssertModel(models[1],_testData[21], false);
                        Int32integer0M.AssertModel(models[2],_testData[22], false);
                        Int32integer0M.AssertModel(models[3],_testData[23], false);
                        Int32integer0M.AssertModel(models[4],_testData[24], false);
                        Int32integer0M.AssertModel(models[5],_testData[25], false);
                        Int32integer0M.AssertModel(models[6],_testData[26], false);
                        Int32integer0M.AssertModel(models[7],_testData[27], false);
                        Int32integer0M.AssertModel(models[8],_testData[28], false);
                        Int32integer0M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models = await ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Int32integer0M.AssertModel(models[0],_testData[17], false);Int32integer0M.AssertModel(models[1],_testData[18], false);Int32integer0M.AssertModel(models[2],_testData[19], false);Int32integer0M.AssertModel(models[3],_testData[20], false);Int32integer0M.AssertModel(models[4],_testData[21], false);Int32integer0M.AssertModel(models[5],_testData[22], false);Int32integer0M.AssertModel(models[6],_testData[23], false);Int32integer0M.AssertModel(models[7],_testData[24], false);Int32integer0M.AssertModel(models[8],_testData[25], false);Int32integer0M.AssertModel(models[9],_testData[26], false);Int32integer0M.AssertModel(models[10],_testData[27], false);Int32integer0M.AssertModel(models[11],_testData[28], false);Int32integer0M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models =  ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
Int32integer0M.AssertModel(models[0],_testData[24], false);Int32integer0M.AssertModel(models[1],_testData[25], false);Int32integer0M.AssertModel(models[2],_testData[26], false);Int32integer0M.AssertModel(models[3],_testData[27], false);Int32integer0M.AssertModel(models[4],_testData[28], false);Int32integer0M.AssertModel(models[5],_testData[29], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeinteger)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((662664127)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1218039253)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1285936385)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1296565642)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((321792144)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((938653906)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1183618973)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((369047542)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2094700014)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((220264980)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((904178267)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((887999660)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2065758311)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((40881608)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1370261294)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((58301634)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1105911150)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1057779891)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((926360094)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1035652535)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2030771592)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((768771990)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1629750409)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1094113611)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1332408368)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((21027065)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1956785949)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1115114894)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1438133118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1452905276)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((779612912)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1892723476)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((958376609)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((398632077)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((14981610)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((389962345)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((739814973)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1679646772)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((868041953)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((800446002)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1433356483)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1593050702)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((142376001)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((861588361)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((204602044)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((834953712)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((784335596)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1974036307)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1189405025)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2112646618)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1732605005)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((116700245)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((605552876)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((481729385)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((838106609)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((256116796)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1548077373)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((831681387)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1480644056)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1337934293)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2053286743)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1989325140)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((355435516)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((30058970)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1015636337)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((698477093)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1349235228)));//InnerModel.Value

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
                var models =  ((IInt32SingleTypeinteger)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((662664127)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1218039253)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1285936385)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1296565642)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((321792144)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((938653906)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1183618973)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((369047542)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2094700014)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((220264980)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((904178267)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((887999660)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2065758311)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((40881608)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1370261294)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((58301634)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1105911150)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1057779891)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((926360094)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1035652535)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2030771592)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((768771990)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1629750409)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1094113611)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1332408368)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((21027065)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1956785949)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1115114894)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1438133118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1452905276)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((779612912)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1892723476)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((958376609)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((398632077)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((14981610)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((389962345)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((739814973)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1679646772)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((868041953)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((800446002)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1433356483)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1593050702)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((142376001)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((861588361)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((204602044)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((834953712)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((784335596)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1974036307)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1189405025)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2112646618)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1732605005)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((116700245)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((605552876)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((481729385)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((838106609)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((256116796)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1548077373)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((831681387)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1480644056)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1337934293)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2053286743)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1989325140)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((355435516)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((30058970)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1015636337)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((698477093)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1349235228)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Int32integer0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
FROM public.binary_int32integer0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integer0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integer0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt32SingleTypeinteger)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32SingleTypeinteger)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MI.AssertModel(actual, expect, false);
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
                await ((IInt32SingleTypeinteger)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt32SingleTypeinteger)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integer0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Int32integer0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
FROM public.binary_int32integer0m m
LEFT JOIN public.binary_int32integer0mi mi ON mi.id = m.int32integer0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integer0M>(15);

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
                ((IInt32SingleTypeinteger)this).ImportModel(connection, importCollection);
                var models = ((IInt32SingleTypeinteger)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int32integer0M.AssertModel(models[0],_testData[0], false);
                Int32integer0M.AssertModel(models[1],_testData[1], false);
                Int32integer0M.AssertModel(models[2],_testData[2], false);
                Int32integer0M.AssertModel(models[3],_testData[3], false);
                Int32integer0M.AssertModel(models[4],_testData[4], false);
                Int32integer0M.AssertModel(models[5],_testData[5], false);
                Int32integer0M.AssertModel(models[6],_testData[6], false);
                Int32integer0M.AssertModel(models[7],_testData[7], false);
                Int32integer0M.AssertModel(models[8],_testData[8], false);
                Int32integer0M.AssertModel(models[9],_testData[9], false);
                Int32integer0M.AssertModel(models[10],_testData[10], false);
                Int32integer0M.AssertModel(models[11],_testData[11], false);
                Int32integer0M.AssertModel(models[12],_testData[12], false);
                Int32integer0M.AssertModel(models[13],_testData[13], false);
                Int32integer0M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt32SingleTypeinteger)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt32SingleTypeinteger)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int32integer0M.AssertModel(models[0],_testData[0], false);
                Int32integer0M.AssertModel(models[1],_testData[1], false);
                Int32integer0M.AssertModel(models[2],_testData[2], false);
                Int32integer0M.AssertModel(models[3],_testData[3], false);
                Int32integer0M.AssertModel(models[4],_testData[4], false);
                Int32integer0M.AssertModel(models[5],_testData[5], false);
                Int32integer0M.AssertModel(models[6],_testData[6], false);
                Int32integer0M.AssertModel(models[7],_testData[7], false);
                Int32integer0M.AssertModel(models[8],_testData[8], false);
                Int32integer0M.AssertModel(models[9],_testData[9], false);
                Int32integer0M.AssertModel(models[10],_testData[10], false);
                Int32integer0M.AssertModel(models[11],_testData[11], false);
                Int32integer0M.AssertModel(models[12],_testData[12], false);
                Int32integer0M.AssertModel(models[13],_testData[13], false);
                Int32integer0M.AssertModel(models[14],_testData[14], false);
                Int32integer0M.AssertModel(models[15],_testData[15], false);
                Int32integer0M.AssertModel(models[16],_testData[16], false);
                Int32integer0M.AssertModel(models[17],_testData[17], false);
                Int32integer0M.AssertModel(models[18],_testData[18], false);
                Int32integer0M.AssertModel(models[19],_testData[19], false);
                Int32integer0M.AssertModel(models[20],_testData[20], false);
                Int32integer0M.AssertModel(models[21],_testData[21], false);
                Int32integer0M.AssertModel(models[22],_testData[22], false);
                Int32integer0M.AssertModel(models[23],_testData[23], false);
                Int32integer0M.AssertModel(models[24],_testData[24], false);
                Int32integer0M.AssertModel(models[25],_testData[25], false);
                Int32integer0M.AssertModel(models[26],_testData[26], false);
                Int32integer0M.AssertModel(models[27],_testData[27], false);
                Int32integer0M.AssertModel(models[28],_testData[28], false);
                Int32integer0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integer0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integer0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeinteger)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integer0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeinteger)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integer0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integer0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeinteger)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integer0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeinteger)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integer0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


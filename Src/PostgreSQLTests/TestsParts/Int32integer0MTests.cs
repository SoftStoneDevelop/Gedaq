

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
    Id = 3,
    Value = 1322170730,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 12,
    Value = 1521534039,
    ModelInner = new Int32integer0MI
{
    Id = 5,
    Value = 1329490287,
    NullableValue = 292467538,
},
    NullableValue = 305827629,
},
            new Int32integer0M
{
    Id = 20,
    Value = 930523068,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 22,
    Value = 1622073637,
    ModelInner = new Int32integer0MI
{
    Id = 7,
    Value = 1967808247,
    NullableValue = 753818470,
},
    NullableValue = 2144606863,
},
            new Int32integer0M
{
    Id = 29,
    Value = 1777567691,
    ModelInner = null,
    NullableValue = 1819374222,
},
            new Int32integer0M
{
    Id = 30,
    Value = 1751807803,
    ModelInner = new Int32integer0MI
{
    Id = 9,
    Value = 1469684546,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 37,
    Value = 1274542899,
    ModelInner = null,
    NullableValue = 452253508,
},
            new Int32integer0M
{
    Id = 40,
    Value = 1669569998,
    ModelInner = new Int32integer0MI
{
    Id = 13,
    Value = 482890411,
    NullableValue = 1444163157,
},
    NullableValue = 1660233116,
},
            new Int32integer0M
{
    Id = 48,
    Value = 1166919007,
    ModelInner = null,
    NullableValue = 178332891,
},
            new Int32integer0M
{
    Id = 51,
    Value = 376254188,
    ModelInner = new Int32integer0MI
{
    Id = 16,
    Value = 865967725,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 60,
    Value = 1927270563,
    ModelInner = null,
    NullableValue = 2132800315,
},
            new Int32integer0M
{
    Id = 61,
    Value = 833745437,
    ModelInner = new Int32integer0MI
{
    Id = 23,
    Value = 633316696,
    NullableValue = 1810454559,
},
    NullableValue = 42503210,
},
            new Int32integer0M
{
    Id = 66,
    Value = 252645673,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 75,
    Value = 962212761,
    ModelInner = new Int32integer0MI
{
    Id = 30,
    Value = 1396039158,
    NullableValue = 1511068631,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 81,
    Value = 1075066456,
    ModelInner = null,
    NullableValue = 523459059,
},
            new Int32integer0M
{
    Id = 86,
    Value = 487744927,
    ModelInner = new Int32integer0MI
{
    Id = 33,
    Value = 911194749,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 91,
    Value = 108737043,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 95,
    Value = 505790809,
    ModelInner = new Int32integer0MI
{
    Id = 41,
    Value = 276484503,
    NullableValue = 1463024895,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 104,
    Value = 1265863954,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 111,
    Value = 924356328,
    ModelInner = new Int32integer0MI
{
    Id = 46,
    Value = 1608480199,
    NullableValue = null,
},
    NullableValue = 550379913,
},
            new Int32integer0M
{
    Id = 119,
    Value = 1211001203,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 123,
    Value = 500743408,
    ModelInner = new Int32integer0MI
{
    Id = 55,
    Value = 1508813172,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 127,
    Value = 687705965,
    ModelInner = null,
    NullableValue = 1240895910,
},
            new Int32integer0M
{
    Id = 128,
    Value = 1773253842,
    ModelInner = new Int32integer0MI
{
    Id = 58,
    Value = 1968505106,
    NullableValue = 599444650,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 135,
    Value = 1247265138,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 138,
    Value = 1715342141,
    ModelInner = new Int32integer0MI
{
    Id = 61,
    Value = 2115238493,
    NullableValue = 1420357802,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 141,
    Value = 575272298,
    ModelInner = null,
    NullableValue = 1088761175,
},
            new Int32integer0M
{
    Id = 143,
    Value = 1381816870,
    ModelInner = new Int32integer0MI
{
    Id = 68,
    Value = 2139435785,
    NullableValue = 2047200589,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 150,
    Value = 1594988978,
    ModelInner = null,
    NullableValue = 500136092,
},
            new Int32integer0M
{
    Id = 159,
    Value = 118332291,
    ModelInner = new Int32integer0MI
{
    Id = 69,
    Value = 1939702394,
    NullableValue = 1049903841,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1819374222));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(452253508));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1660233116));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(178332891));
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
                Assert.That(nullable, Is.EqualTo(2132800315));
                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(42503210));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt32integer0M.AssertModel(models[0],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt32integer0M.AssertModel(models[0],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[28],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integer0M.AssertModel(models[0],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt32integer0M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int32integer0M.AssertModel(models[0],_testData[9], false);
                        Int32integer0M.AssertModel(models[1],_testData[10], false);
                        Int32integer0M.AssertModel(models[2],_testData[11], false);
                        Int32integer0M.AssertModel(models[3],_testData[12], false);
                        Int32integer0M.AssertModel(models[4],_testData[13], false);
                        Int32integer0M.AssertModel(models[5],_testData[14], false);
                        Int32integer0M.AssertModel(models[6],_testData[15], false);
                        Int32integer0M.AssertModel(models[7],_testData[16], false);
                        Int32integer0M.AssertModel(models[8],_testData[17], false);
                        Int32integer0M.AssertModel(models[9],_testData[18], false);
                        Int32integer0M.AssertModel(models[10],_testData[19], false);
                        Int32integer0M.AssertModel(models[11],_testData[20], false);
                        Int32integer0M.AssertModel(models[12],_testData[21], false);
                        Int32integer0M.AssertModel(models[13],_testData[22], false);
                        Int32integer0M.AssertModel(models[14],_testData[23], false);
                        Int32integer0M.AssertModel(models[15],_testData[24], false);
                        Int32integer0M.AssertModel(models[16],_testData[25], false);
                        Int32integer0M.AssertModel(models[17],_testData[26], false);
                        Int32integer0M.AssertModel(models[18],_testData[27], false);
                        Int32integer0M.AssertModel(models[19],_testData[28], false);
                        Int32integer0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32integer0M.AssertModel(models[0],_testData[12], false);
                        Int32integer0M.AssertModel(models[1],_testData[13], false);
                        Int32integer0M.AssertModel(models[2],_testData[14], false);
                        Int32integer0M.AssertModel(models[3],_testData[15], false);
                        Int32integer0M.AssertModel(models[4],_testData[16], false);
                        Int32integer0M.AssertModel(models[5],_testData[17], false);
                        Int32integer0M.AssertModel(models[6],_testData[18], false);
                        Int32integer0M.AssertModel(models[7],_testData[19], false);
                        Int32integer0M.AssertModel(models[8],_testData[20], false);
                        Int32integer0M.AssertModel(models[9],_testData[21], false);
                        Int32integer0M.AssertModel(models[10],_testData[22], false);
                        Int32integer0M.AssertModel(models[11],_testData[23], false);
                        Int32integer0M.AssertModel(models[12],_testData[24], false);
                        Int32integer0M.AssertModel(models[13],_testData[25], false);
                        Int32integer0M.AssertModel(models[14],_testData[26], false);
                        Int32integer0M.AssertModel(models[15],_testData[27], false);
                        Int32integer0M.AssertModel(models[16],_testData[28], false);
                        Int32integer0M.AssertModel(models[17],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32integer0M.AssertModel(models[0],_testData[13], false);
                        Int32integer0M.AssertModel(models[1],_testData[14], false);
                        Int32integer0M.AssertModel(models[2],_testData[15], false);
                        Int32integer0M.AssertModel(models[3],_testData[16], false);
                        Int32integer0M.AssertModel(models[4],_testData[17], false);
                        Int32integer0M.AssertModel(models[5],_testData[18], false);
                        Int32integer0M.AssertModel(models[6],_testData[19], false);
                        Int32integer0M.AssertModel(models[7],_testData[20], false);
                        Int32integer0M.AssertModel(models[8],_testData[21], false);
                        Int32integer0M.AssertModel(models[9],_testData[22], false);
                        Int32integer0M.AssertModel(models[10],_testData[23], false);
                        Int32integer0M.AssertModel(models[11],_testData[24], false);
                        Int32integer0M.AssertModel(models[12],_testData[25], false);
                        Int32integer0M.AssertModel(models[13],_testData[26], false);
                        Int32integer0M.AssertModel(models[14],_testData[27], false);
                        Int32integer0M.AssertModel(models[15],_testData[28], false);
                        Int32integer0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integer0M.AssertModel(models[0],_testData[10], false);
                        Int32integer0M.AssertModel(models[1],_testData[11], false);
                        Int32integer0M.AssertModel(models[2],_testData[12], false);
                        Int32integer0M.AssertModel(models[3],_testData[13], false);
                        Int32integer0M.AssertModel(models[4],_testData[14], false);
                        Int32integer0M.AssertModel(models[5],_testData[15], false);
                        Int32integer0M.AssertModel(models[6],_testData[16], false);
                        Int32integer0M.AssertModel(models[7],_testData[17], false);
                        Int32integer0M.AssertModel(models[8],_testData[18], false);
                        Int32integer0M.AssertModel(models[9],_testData[19], false);
                        Int32integer0M.AssertModel(models[10],_testData[20], false);
                        Int32integer0M.AssertModel(models[11],_testData[21], false);
                        Int32integer0M.AssertModel(models[12],_testData[22], false);
                        Int32integer0M.AssertModel(models[13],_testData[23], false);
                        Int32integer0M.AssertModel(models[14],_testData[24], false);
                        Int32integer0M.AssertModel(models[15],_testData[25], false);
                        Int32integer0M.AssertModel(models[16],_testData[26], false);
                        Int32integer0M.AssertModel(models[17],_testData[27], false);
                        Int32integer0M.AssertModel(models[18],_testData[28], false);
                        Int32integer0M.AssertModel(models[19],_testData[29], false);
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
                await ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[25],_testData[29], false);
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
                await ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 30, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[28],_testData[29], false);
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
                 ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[29], false);
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
                 ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[27],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 91, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32integer0M.AssertModel(models[0],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integer0M.AssertModel(models[0],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[29], false);
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
                await ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt32integer0M.AssertModel(models[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32integer0M.AssertModel(models[0],_testData[7], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[29], false);
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
                 ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelBatchAsync(connection, 128, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32integer0M.AssertModel(models[0],_testData[24], false);
                        Int32integer0M.AssertModel(models[1],_testData[25], false);
                        Int32integer0M.AssertModel(models[2],_testData[26], false);
                        Int32integer0M.AssertModel(models[3],_testData[27], false);
                        Int32integer0M.AssertModel(models[4],_testData[28], false);
                        Int32integer0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32integer0M.AssertModel(models[0],_testData[25], false);
                        Int32integer0M.AssertModel(models[1],_testData[26], false);
                        Int32integer0M.AssertModel(models[2],_testData[27], false);
                        Int32integer0M.AssertModel(models[3],_testData[28], false);
                        Int32integer0M.AssertModel(models[4],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelBatch(connection, 104, 143))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integer0M.AssertModel(models[0],_testData[28], false);
                        Int32integer0M.AssertModel(models[1],_testData[29], false);
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
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int32integer0M.AssertModel(models[0],_testData[14], false);Int32integer0M.AssertModel(models[1],_testData[15], false);Int32integer0M.AssertModel(models[2],_testData[16], false);Int32integer0M.AssertModel(models[3],_testData[17], false);Int32integer0M.AssertModel(models[4],_testData[18], false);Int32integer0M.AssertModel(models[5],_testData[19], false);Int32integer0M.AssertModel(models[6],_testData[20], false);Int32integer0M.AssertModel(models[7],_testData[21], false);Int32integer0M.AssertModel(models[8],_testData[22], false);Int32integer0M.AssertModel(models[9],_testData[23], false);Int32integer0M.AssertModel(models[10],_testData[24], false);Int32integer0M.AssertModel(models[11],_testData[25], false);Int32integer0M.AssertModel(models[12],_testData[26], false);Int32integer0M.AssertModel(models[13],_testData[27], false);Int32integer0M.AssertModel(models[14],_testData[28], false);Int32integer0M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models =  ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Int32integer0M.AssertModel(models[0],_testData[10], false);Int32integer0M.AssertModel(models[1],_testData[11], false);Int32integer0M.AssertModel(models[2],_testData[12], false);Int32integer0M.AssertModel(models[3],_testData[13], false);Int32integer0M.AssertModel(models[4],_testData[14], false);Int32integer0M.AssertModel(models[5],_testData[15], false);Int32integer0M.AssertModel(models[6],_testData[16], false);Int32integer0M.AssertModel(models[7],_testData[17], false);Int32integer0M.AssertModel(models[8],_testData[18], false);Int32integer0M.AssertModel(models[9],_testData[19], false);Int32integer0M.AssertModel(models[10],_testData[20], false);Int32integer0M.AssertModel(models[11],_testData[21], false);Int32integer0M.AssertModel(models[12],_testData[22], false);Int32integer0M.AssertModel(models[13],_testData[23], false);Int32integer0M.AssertModel(models[14],_testData[24], false);Int32integer0M.AssertModel(models[15],_testData[25], false);Int32integer0M.AssertModel(models[16],_testData[26], false);Int32integer0M.AssertModel(models[17],_testData[27], false);Int32integer0M.AssertModel(models[18],_testData[28], false);Int32integer0M.AssertModel(models[19],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1322170730)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1521534039)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1329490287)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((292467538)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((305827629)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((930523068)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1622073637)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1967808247)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((753818470)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2144606863)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1777567691)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1819374222)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1751807803)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1469684546)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1274542899)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((452253508)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1669569998)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((482890411)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1444163157)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1660233116)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1166919007)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((178332891)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((376254188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((865967725)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1927270563)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2132800315)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((833745437)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((633316696)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1810454559)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((42503210)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((252645673)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((962212761)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1396039158)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1511068631)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1075066456)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((523459059)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((487744927)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((911194749)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((108737043)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((505790809)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((276484503)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1463024895)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1265863954)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((924356328)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1608480199)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((550379913)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1211001203)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((500743408)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1508813172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((687705965)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1240895910)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1773253842)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1968505106)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((599444650)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1247265138)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1715342141)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2115238493)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1420357802)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((575272298)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1088761175)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1381816870)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2139435785)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2047200589)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1594988978)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((500136092)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((118332291)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1939702394)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1049903841)));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1322170730)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1521534039)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1329490287)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((292467538)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((305827629)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((930523068)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1622073637)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1967808247)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((753818470)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2144606863)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1777567691)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1819374222)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1751807803)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1469684546)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1274542899)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((452253508)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1669569998)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((482890411)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1444163157)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1660233116)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1166919007)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((178332891)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((376254188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((865967725)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1927270563)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2132800315)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((833745437)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((633316696)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1810454559)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((42503210)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((252645673)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((962212761)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1396039158)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1511068631)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1075066456)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((523459059)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((487744927)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((911194749)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((108737043)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((505790809)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((276484503)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1463024895)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1265863954)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((924356328)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1608480199)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((550379913)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1211001203)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((500743408)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1508813172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((687705965)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1240895910)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1773253842)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1968505106)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((599444650)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1247265138)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1715342141)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2115238493)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1420357802)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((575272298)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1088761175)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1381816870)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2139435785)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2047200589)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1594988978)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((500136092)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((118332291)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1939702394)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1049903841)));//InnerModel.NullableValue

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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integer0MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((IInt32SingleTypeinteger)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integer0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((IInt32SingleTypeinteger)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integer0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(Int32integer0MI),
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
            queryMapType: typeof(Int32integer0M),
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


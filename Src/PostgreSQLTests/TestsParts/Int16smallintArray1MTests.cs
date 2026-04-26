

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
    internal partial interface IInt16ArraysmallintArray
    {
    }
    
    internal partial class Int16ArraysmallintArray : IInt16ArraysmallintArray
    {


#region TestData

        private readonly Int16smallintArray1M[] _testData = new Int16smallintArray1M[]
        {
            new Int16smallintArray1M
{
    Id = 2,
    Value = 
new System.Int16[4]
{
26619,
7391,
6832,
29594,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 3,
    Value = 
new System.Int16[4]
{
13605,
16627,
16545,
6027,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 8,
    Value = 
new System.Int16[3]
{
17141,
26637,
27735,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
31579,
11703,
11563,
6377,
},
},
            new Int16smallintArray1M
{
    Id = 12,
    Value = 
new System.Int16[3]
{
16597,
21661,
29243,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
24800,
20548,
16634,
1395,
},
},
            new Int16smallintArray1M
{
    Id = 19,
    Value = 
new System.Int16[4]
{
25031,
31501,
20632,
15207,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 12,
    Value = 
new System.Int16[3]
{
27215,
28785,
27460,
},
    NullableValue = 
new System.Int16[4]
{
17215,
2239,
30123,
31174,
},
},
    NullableValue = 
new System.Int16[3]
{
30890,
22465,
8947,
},
},
            new Int16smallintArray1M
{
    Id = 21,
    Value = 
new System.Int16[4]
{
6329,
16295,
29657,
17659,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 28,
    Value = 
new System.Int16[3]
{
19494,
8586,
7182,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 16,
    Value = 
new System.Int16[3]
{
17011,
4566,
12272,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 35,
    Value = 
new System.Int16[4]
{
21465,
14354,
27629,
27100,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 40,
    Value = 
new System.Int16[4]
{
2686,
28737,
9891,
2722,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 19,
    Value = 
new System.Int16[4]
{
25871,
20813,
20746,
8484,
},
    NullableValue = 
new System.Int16[3]
{
2144,
4011,
3348,
},
},
    NullableValue = 
new System.Int16[4]
{
9908,
3704,
744,
24486,
},
},
            new Int16smallintArray1M
{
    Id = 47,
    Value = 
new System.Int16[4]
{
3550,
17550,
14557,
12895,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
14124,
3477,
27519,
12424,
},
},
            new Int16smallintArray1M
{
    Id = 56,
    Value = 
new System.Int16[4]
{
14393,
3603,
30829,
15626,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 28,
    Value = 
new System.Int16[4]
{
9683,
3800,
2763,
31335,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 62,
    Value = 
new System.Int16[3]
{
28075,
14164,
22566,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 67,
    Value = 
new System.Int16[3]
{
21892,
2393,
3397,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 32,
    Value = 
new System.Int16[3]
{
16252,
18088,
25961,
},
    NullableValue = 
new System.Int16[3]
{
9356,
12635,
5429,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 71,
    Value = 
new System.Int16[3]
{
9643,
6854,
22900,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 76,
    Value = 
new System.Int16[4]
{
2013,
6017,
12018,
3892,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 41,
    Value = 
new System.Int16[4]
{
16882,
25253,
31982,
15031,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
27518,
3749,
15484,
},
},
            new Int16smallintArray1M
{
    Id = 77,
    Value = 
new System.Int16[3]
{
19072,
16028,
11542,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
12181,
7177,
18860,
},
},
            new Int16smallintArray1M
{
    Id = 82,
    Value = 
new System.Int16[4]
{
1441,
3739,
5768,
28440,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 48,
    Value = 
new System.Int16[4]
{
18337,
25029,
1172,
7239,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
31344,
12020,
8708,
20820,
},
},
            new Int16smallintArray1M
{
    Id = 88,
    Value = 
new System.Int16[3]
{
28000,
2633,
4686,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
19393,
22808,
27638,
1748,
},
},
            new Int16smallintArray1M
{
    Id = 92,
    Value = 
new System.Int16[3]
{
18855,
22472,
11628,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 56,
    Value = 
new System.Int16[4]
{
27879,
5401,
22415,
24860,
},
    NullableValue = 
new System.Int16[4]
{
12323,
19627,
25369,
18157,
},
},
    NullableValue = 
new System.Int16[3]
{
15788,
1704,
15404,
},
},
            new Int16smallintArray1M
{
    Id = 100,
    Value = 
new System.Int16[3]
{
10497,
17168,
19857,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 106,
    Value = 
new System.Int16[3]
{
25491,
1619,
8679,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 57,
    Value = 
new System.Int16[3]
{
5711,
26534,
10487,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 112,
    Value = 
new System.Int16[3]
{
12626,
5273,
22859,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 114,
    Value = 
new System.Int16[3]
{
4595,
19020,
11250,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 59,
    Value = 
new System.Int16[4]
{
7112,
30592,
28436,
27554,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 117,
    Value = 
new System.Int16[4]
{
14233,
21028,
3005,
27908,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 123,
    Value = 
new System.Int16[4]
{
31140,
32616,
4662,
1171,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 61,
    Value = 
new System.Int16[3]
{
4000,
15740,
16544,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
2826,
21210,
30174,
},
},
            new Int16smallintArray1M
{
    Id = 132,
    Value = 
new System.Int16[4]
{
18575,
21697,
30008,
14005,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 137,
    Value = 
new System.Int16[3]
{
11488,
4565,
11854,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 68,
    Value = 
new System.Int16[3]
{
9674,
23783,
24379,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 141,
    Value = 
new System.Int16[3]
{
17608,
4583,
32395,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 145,
    Value = 
new System.Int16[3]
{
26565,
5,
24619,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 75,
    Value = 
new System.Int16[4]
{
20856,
8266,
2011,
3997,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 153,
    Value = 
new System.Int16[3]
{
17381,
16269,
3310,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 160,
    Value = 
new System.Int16[3]
{
31333,
25514,
1257,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 80,
    Value = 
new System.Int16[3]
{
10023,
14610,
5763,
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray1mi(
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray1mi(
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
            queryMapTypes: [typeof(Int16smallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
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

                changedRows =  ((IInt16ArraysmallintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16ArraysmallintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16ArraysmallintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16ArraysmallintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16ArraysmallintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16ArraysmallintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray1m(
	id,
    value,
    nullablevalue,
    int16smallintarray1mi_id
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
            asPartInterface: typeof(IInt16ArraysmallintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintarray1mi_id", 
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
                changedRows =  ((IInt16ArraysmallintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16ArraysmallintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16ArraysmallintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16ArraysmallintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray1m(
	id,
    value,
    nullablevalue,
    int16smallintarray1mi_id
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
    int16smallintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                System.Int16[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[]>();
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable =  ((IInt16ArraysmallintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[]>();
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable =  ((IInt16ArraysmallintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int16[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[]>();
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable = await ((IInt16ArraysmallintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16[]>();
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
                    ((NpgsqlParameter<System.Int16[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483630);
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

                    nullable = await ((IInt16ArraysmallintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
9908,
3704,
744,
24486,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray1m(
	id,
    value,
    nullablevalue,
    int16smallintarray1mi_id
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
    int16smallintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintarray1mi_id", 
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
                System.Int16[] nullable = null;
                nullable =  ((IInt16ArraysmallintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
14124,
3477,
27519,
12424,
}));
                nullable =  ((IInt16ArraysmallintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16[] nullable = null;
                nullable = await ((IInt16ArraysmallintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt16ArraysmallintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintArray1M> models = null;

                models =  ((IInt16ArraysmallintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt16ArraysmallintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt16ArraysmallintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt16ArraysmallintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintArray1M> models = null;

                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray1M), typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                ((IInt16ArraysmallintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt16ArraysmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16ArraysmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models = await ((IInt16ArraysmallintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16ArraysmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray1M), typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                ((IInt16ArraysmallintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16ArraysmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16ArraysmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models = await ((IInt16ArraysmallintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16ArraysmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray1M), typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                await((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[30], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                 ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[25],_testData[30], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                 ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[25],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[26],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                 ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[30], false);
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
FROM public.int16smallintarray1m m
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models = await((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int16smallintArray1M.AssertModel(models[0],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int16smallintArray1M.AssertModel(models[0],_testData[2], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[3], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[4], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[5], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[6], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[7], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[8], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[9], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[10], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[11], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[19],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[20],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[21],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[22],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[23],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[24],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[25],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[26],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintArray1M.AssertModel(models[0],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int16smallintArray1M.AssertModel(models[0],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray1M), typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                await((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[30], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray1M>();
                var models2 = new List<FlatInt16smallintArray1M>();
                ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                 ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var firstItems2 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                 ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 28, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[30], false);
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.int16smallintarray1m m
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
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems1 = new List<FlatInt16smallintArray1M>();
                var secondItems2 = new List<FlatInt16smallintArray1M>();
                 ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[30], false);
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
FROM public.int16smallintarray1m m
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models = await((IInt16ArraysmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintArray1M.AssertModel(models[0],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintArray1M.AssertModel(models[0],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[29], false);
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
                var models = ((IInt16ArraysmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 71, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintArray1M.AssertModel(models[0],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int16smallintArray1M.AssertModel(models[0],_testData[9], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[10], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[11], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[19],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 2);
                var models = await ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int16smallintArray1M.AssertModel(models[0],_testData[1], false);Int16smallintArray1M.AssertModel(models[1],_testData[2], false);Int16smallintArray1M.AssertModel(models[2],_testData[3], false);Int16smallintArray1M.AssertModel(models[3],_testData[4], false);Int16smallintArray1M.AssertModel(models[4],_testData[5], false);Int16smallintArray1M.AssertModel(models[5],_testData[6], false);Int16smallintArray1M.AssertModel(models[6],_testData[7], false);Int16smallintArray1M.AssertModel(models[7],_testData[8], false);Int16smallintArray1M.AssertModel(models[8],_testData[9], false);Int16smallintArray1M.AssertModel(models[9],_testData[10], false);Int16smallintArray1M.AssertModel(models[10],_testData[11], false);Int16smallintArray1M.AssertModel(models[11],_testData[12], false);Int16smallintArray1M.AssertModel(models[12],_testData[13], false);Int16smallintArray1M.AssertModel(models[13],_testData[14], false);Int16smallintArray1M.AssertModel(models[14],_testData[15], false);Int16smallintArray1M.AssertModel(models[15],_testData[16], false);Int16smallintArray1M.AssertModel(models[16],_testData[17], false);Int16smallintArray1M.AssertModel(models[17],_testData[18], false);Int16smallintArray1M.AssertModel(models[18],_testData[19], false);Int16smallintArray1M.AssertModel(models[19],_testData[20], false);Int16smallintArray1M.AssertModel(models[20],_testData[21], false);Int16smallintArray1M.AssertModel(models[21],_testData[22], false);Int16smallintArray1M.AssertModel(models[22],_testData[23], false);Int16smallintArray1M.AssertModel(models[23],_testData[24], false);Int16smallintArray1M.AssertModel(models[24],_testData[25], false);Int16smallintArray1M.AssertModel(models[25],_testData[26], false);Int16smallintArray1M.AssertModel(models[26],_testData[27], false);Int16smallintArray1M.AssertModel(models[27],_testData[28], false);Int16smallintArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int16smallintArray1M.AssertModel(models[0],_testData[3], false);Int16smallintArray1M.AssertModel(models[1],_testData[4], false);Int16smallintArray1M.AssertModel(models[2],_testData[5], false);Int16smallintArray1M.AssertModel(models[3],_testData[6], false);Int16smallintArray1M.AssertModel(models[4],_testData[7], false);Int16smallintArray1M.AssertModel(models[5],_testData[8], false);Int16smallintArray1M.AssertModel(models[6],_testData[9], false);Int16smallintArray1M.AssertModel(models[7],_testData[10], false);Int16smallintArray1M.AssertModel(models[8],_testData[11], false);Int16smallintArray1M.AssertModel(models[9],_testData[12], false);Int16smallintArray1M.AssertModel(models[10],_testData[13], false);Int16smallintArray1M.AssertModel(models[11],_testData[14], false);Int16smallintArray1M.AssertModel(models[12],_testData[15], false);Int16smallintArray1M.AssertModel(models[13],_testData[16], false);Int16smallintArray1M.AssertModel(models[14],_testData[17], false);Int16smallintArray1M.AssertModel(models[15],_testData[18], false);Int16smallintArray1M.AssertModel(models[16],_testData[19], false);Int16smallintArray1M.AssertModel(models[17],_testData[20], false);Int16smallintArray1M.AssertModel(models[18],_testData[21], false);Int16smallintArray1M.AssertModel(models[19],_testData[22], false);Int16smallintArray1M.AssertModel(models[20],_testData[23], false);Int16smallintArray1M.AssertModel(models[21],_testData[24], false);Int16smallintArray1M.AssertModel(models[22],_testData[25], false);Int16smallintArray1M.AssertModel(models[23],_testData[26], false);Int16smallintArray1M.AssertModel(models[24],_testData[27], false);Int16smallintArray1M.AssertModel(models[25],_testData[28], false);Int16smallintArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
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
FROM public.binary_int16smallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int16smallintArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt16ArraysmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16ArraysmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(actual, expect, false);
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
                await ((IInt16ArraysmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt16ArraysmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
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
FROM public.binary_int16smallintarray1m m
LEFT JOIN public.binary_int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int16smallintArray1M>(15);

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
                ((IInt16ArraysmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt16ArraysmallintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int16smallintArray1M.AssertModel(models[0],_testData[0], false);
                Int16smallintArray1M.AssertModel(models[1],_testData[1], false);
                Int16smallintArray1M.AssertModel(models[2],_testData[2], false);
                Int16smallintArray1M.AssertModel(models[3],_testData[3], false);
                Int16smallintArray1M.AssertModel(models[4],_testData[4], false);
                Int16smallintArray1M.AssertModel(models[5],_testData[5], false);
                Int16smallintArray1M.AssertModel(models[6],_testData[6], false);
                Int16smallintArray1M.AssertModel(models[7],_testData[7], false);
                Int16smallintArray1M.AssertModel(models[8],_testData[8], false);
                Int16smallintArray1M.AssertModel(models[9],_testData[9], false);
                Int16smallintArray1M.AssertModel(models[10],_testData[10], false);
                Int16smallintArray1M.AssertModel(models[11],_testData[11], false);
                Int16smallintArray1M.AssertModel(models[12],_testData[12], false);
                Int16smallintArray1M.AssertModel(models[13],_testData[13], false);
                Int16smallintArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt16ArraysmallintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt16ArraysmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int16smallintArray1M.AssertModel(models[0],_testData[0], false);
                Int16smallintArray1M.AssertModel(models[1],_testData[1], false);
                Int16smallintArray1M.AssertModel(models[2],_testData[2], false);
                Int16smallintArray1M.AssertModel(models[3],_testData[3], false);
                Int16smallintArray1M.AssertModel(models[4],_testData[4], false);
                Int16smallintArray1M.AssertModel(models[5],_testData[5], false);
                Int16smallintArray1M.AssertModel(models[6],_testData[6], false);
                Int16smallintArray1M.AssertModel(models[7],_testData[7], false);
                Int16smallintArray1M.AssertModel(models[8],_testData[8], false);
                Int16smallintArray1M.AssertModel(models[9],_testData[9], false);
                Int16smallintArray1M.AssertModel(models[10],_testData[10], false);
                Int16smallintArray1M.AssertModel(models[11],_testData[11], false);
                Int16smallintArray1M.AssertModel(models[12],_testData[12], false);
                Int16smallintArray1M.AssertModel(models[13],_testData[13], false);
                Int16smallintArray1M.AssertModel(models[14],_testData[14], false);
                Int16smallintArray1M.AssertModel(models[15],_testData[15], false);
                Int16smallintArray1M.AssertModel(models[16],_testData[16], false);
                Int16smallintArray1M.AssertModel(models[17],_testData[17], false);
                Int16smallintArray1M.AssertModel(models[18],_testData[18], false);
                Int16smallintArray1M.AssertModel(models[19],_testData[19], false);
                Int16smallintArray1M.AssertModel(models[20],_testData[20], false);
                Int16smallintArray1M.AssertModel(models[21],_testData[21], false);
                Int16smallintArray1M.AssertModel(models[22],_testData[22], false);
                Int16smallintArray1M.AssertModel(models[23],_testData[23], false);
                Int16smallintArray1M.AssertModel(models[24],_testData[24], false);
                Int16smallintArray1M.AssertModel(models[25],_testData[25], false);
                Int16smallintArray1M.AssertModel(models[26],_testData[26], false);
                Int16smallintArray1M.AssertModel(models[27],_testData[27], false);
                Int16smallintArray1M.AssertModel(models[28],_testData[28], false);
                Int16smallintArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallintArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16ArraysmallintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16ArraysmallintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16ArraysmallintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16ArraysmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


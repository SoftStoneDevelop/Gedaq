

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
25313,
5087,
12941,
30032,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
10613,
20238,
2762,
32303,
},
},
            new Int16smallintArray1M
{
    Id = 11,
    Value = 
new System.Int16[4]
{
4876,
5092,
25966,
10731,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 7,
    Value = 
new System.Int16[3]
{
28487,
15119,
14565,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 12,
    Value = 
new System.Int16[4]
{
26399,
18588,
27220,
19533,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
17999,
12360,
20157,
},
},
            new Int16smallintArray1M
{
    Id = 19,
    Value = 
new System.Int16[4]
{
15107,
13832,
27018,
10312,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 9,
    Value = 
new System.Int16[3]
{
16604,
26841,
28601,
},
    NullableValue = 
new System.Int16[3]
{
6669,
24590,
8001,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 22,
    Value = 
new System.Int16[3]
{
15680,
24361,
24077,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 27,
    Value = 
new System.Int16[3]
{
2432,
23970,
31627,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 15,
    Value = 
new System.Int16[4]
{
4796,
10259,
12445,
4368,
},
    NullableValue = 
new System.Int16[4]
{
10665,
3845,
6126,
17580,
},
},
    NullableValue = 
new System.Int16[3]
{
3242,
5579,
2493,
},
},
            new Int16smallintArray1M
{
    Id = 34,
    Value = 
new System.Int16[3]
{
27769,
26035,
8864,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
11018,
22312,
31701,
10427,
},
},
            new Int16smallintArray1M
{
    Id = 37,
    Value = 
new System.Int16[4]
{
6032,
30765,
863,
22156,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 16,
    Value = 
new System.Int16[4]
{
20254,
3513,
31049,
30270,
},
    NullableValue = 
new System.Int16[3]
{
12607,
26503,
6994,
},
},
    NullableValue = 
new System.Int16[4]
{
21837,
28638,
18353,
25195,
},
},
            new Int16smallintArray1M
{
    Id = 41,
    Value = 
new System.Int16[3]
{
15736,
4455,
8210,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
14972,
3315,
31699,
},
},
            new Int16smallintArray1M
{
    Id = 44,
    Value = 
new System.Int16[4]
{
16013,
22853,
32682,
22031,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 25,
    Value = 
new System.Int16[3]
{
6506,
23966,
14168,
},
    NullableValue = 
new System.Int16[3]
{
27497,
17557,
16539,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 52,
    Value = 
new System.Int16[4]
{
6961,
19121,
23842,
2427,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
6626,
3792,
22172,
32650,
},
},
            new Int16smallintArray1M
{
    Id = 61,
    Value = 
new System.Int16[4]
{
25809,
20712,
1111,
30196,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 32,
    Value = 
new System.Int16[4]
{
24867,
16011,
18226,
15333,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
28722,
31578,
27531,
},
},
            new Int16smallintArray1M
{
    Id = 64,
    Value = 
new System.Int16[4]
{
28557,
8923,
30377,
16124,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
21004,
29841,
2548,
},
},
            new Int16smallintArray1M
{
    Id = 68,
    Value = 
new System.Int16[4]
{
28172,
15866,
19038,
32500,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 35,
    Value = 
new System.Int16[4]
{
22789,
549,
3840,
26178,
},
    NullableValue = 
new System.Int16[3]
{
111,
174,
2097,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 72,
    Value = 
new System.Int16[4]
{
12351,
28187,
26739,
24526,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 74,
    Value = 
new System.Int16[3]
{
4967,
944,
19661,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 43,
    Value = 
new System.Int16[4]
{
26789,
29005,
22868,
18993,
},
    NullableValue = 
new System.Int16[4]
{
19683,
21791,
379,
29058,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 78,
    Value = 
new System.Int16[4]
{
28463,
16406,
29945,
28752,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 84,
    Value = 
new System.Int16[4]
{
28340,
5810,
25756,
31240,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 48,
    Value = 
new System.Int16[4]
{
32175,
30275,
28221,
15342,
},
    NullableValue = 
new System.Int16[4]
{
24720,
18814,
16749,
24597,
},
},
    NullableValue = 
new System.Int16[4]
{
16647,
32635,
21405,
27517,
},
},
            new Int16smallintArray1M
{
    Id = 88,
    Value = 
new System.Int16[3]
{
9843,
13991,
1898,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
1125,
949,
1698,
26516,
},
},
            new Int16smallintArray1M
{
    Id = 96,
    Value = 
new System.Int16[3]
{
22651,
18866,
15418,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 49,
    Value = 
new System.Int16[3]
{
580,
4253,
6393,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 100,
    Value = 
new System.Int16[4]
{
15062,
5985,
6278,
4785,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 105,
    Value = 
new System.Int16[4]
{
26034,
27710,
31680,
32546,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 58,
    Value = 
new System.Int16[4]
{
14157,
28409,
20836,
18961,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 107,
    Value = 
new System.Int16[3]
{
29801,
32273,
27504,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 110,
    Value = 
new System.Int16[4]
{
13867,
15968,
22835,
10220,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 60,
    Value = 
new System.Int16[4]
{
10542,
25880,
23980,
18910,
},
    NullableValue = 
new System.Int16[3]
{
12696,
11348,
25560,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 116,
    Value = 
new System.Int16[3]
{
2030,
16489,
29867,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 125,
    Value = 
new System.Int16[4]
{
18085,
26482,
31058,
6724,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 62,
    Value = 
new System.Int16[3]
{
2729,
18652,
17466,
},
    NullableValue = 
new System.Int16[4]
{
16820,
368,
5390,
29747,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 129,
    Value = 
new System.Int16[3]
{
10505,
31625,
13814,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
28084,
22413,
1270,
15553,
},
},
            new Int16smallintArray1M
{
    Id = 132,
    Value = 
new System.Int16[3]
{
14540,
18738,
7155,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 64,
    Value = 
new System.Int16[4]
{
6458,
14513,
11263,
22851,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 136,
    Value = 
new System.Int16[4]
{
7103,
25667,
13319,
656,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 141,
    Value = 
new System.Int16[3]
{
7424,
30561,
12320,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 65,
    Value = 
new System.Int16[3]
{
13156,
9489,
15870,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
5008,
9126,
25139,
32020,
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[3]
{
3242,
5579,
2493,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
11018,
22312,
31701,
10427,
}));
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
21837,
28638,
18353,
25195,
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
new System.Int16[3]
{
14972,
3315,
31699,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
6626,
3792,
22172,
32650,
}));
                nullable = await ((IInt16ArraysmallintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[3]
{
28722,
31578,
27531,
}));
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[8], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[21],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[3], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[4], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[5], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[6], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[7], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[8], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[21],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[22],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[23],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[24],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[25],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
Int16smallintArray1M.AssertModel(models[0],_testData[15], false);Int16smallintArray1M.AssertModel(models[1],_testData[16], false);Int16smallintArray1M.AssertModel(models[2],_testData[17], false);Int16smallintArray1M.AssertModel(models[3],_testData[18], false);Int16smallintArray1M.AssertModel(models[4],_testData[19], false);Int16smallintArray1M.AssertModel(models[5],_testData[20], false);Int16smallintArray1M.AssertModel(models[6],_testData[21], false);Int16smallintArray1M.AssertModel(models[7],_testData[22], false);Int16smallintArray1M.AssertModel(models[8],_testData[23], false);Int16smallintArray1M.AssertModel(models[9],_testData[24], false);Int16smallintArray1M.AssertModel(models[10],_testData[25], false);Int16smallintArray1M.AssertModel(models[11],_testData[26], false);Int16smallintArray1M.AssertModel(models[12],_testData[27], false);Int16smallintArray1M.AssertModel(models[13],_testData[28], false);Int16smallintArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Int16smallintArray1M.AssertModel(models[0],_testData[4], false);Int16smallintArray1M.AssertModel(models[1],_testData[5], false);Int16smallintArray1M.AssertModel(models[2],_testData[6], false);Int16smallintArray1M.AssertModel(models[3],_testData[7], false);Int16smallintArray1M.AssertModel(models[4],_testData[8], false);Int16smallintArray1M.AssertModel(models[5],_testData[9], false);Int16smallintArray1M.AssertModel(models[6],_testData[10], false);Int16smallintArray1M.AssertModel(models[7],_testData[11], false);Int16smallintArray1M.AssertModel(models[8],_testData[12], false);Int16smallintArray1M.AssertModel(models[9],_testData[13], false);Int16smallintArray1M.AssertModel(models[10],_testData[14], false);Int16smallintArray1M.AssertModel(models[11],_testData[15], false);Int16smallintArray1M.AssertModel(models[12],_testData[16], false);Int16smallintArray1M.AssertModel(models[13],_testData[17], false);Int16smallintArray1M.AssertModel(models[14],_testData[18], false);Int16smallintArray1M.AssertModel(models[15],_testData[19], false);Int16smallintArray1M.AssertModel(models[16],_testData[20], false);Int16smallintArray1M.AssertModel(models[17],_testData[21], false);Int16smallintArray1M.AssertModel(models[18],_testData[22], false);Int16smallintArray1M.AssertModel(models[19],_testData[23], false);Int16smallintArray1M.AssertModel(models[20],_testData[24], false);Int16smallintArray1M.AssertModel(models[21],_testData[25], false);Int16smallintArray1M.AssertModel(models[22],_testData[26], false);Int16smallintArray1M.AssertModel(models[23],_testData[27], false);Int16smallintArray1M.AssertModel(models[24],_testData[28], false);Int16smallintArray1M.AssertModel(models[25],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
Int16smallintArray1M.AssertModel(models[0],_testData[13], false);Int16smallintArray1M.AssertModel(models[1],_testData[14], false);Int16smallintArray1M.AssertModel(models[2],_testData[15], false);Int16smallintArray1M.AssertModel(models[3],_testData[16], false);Int16smallintArray1M.AssertModel(models[4],_testData[17], false);Int16smallintArray1M.AssertModel(models[5],_testData[18], false);Int16smallintArray1M.AssertModel(models[6],_testData[19], false);Int16smallintArray1M.AssertModel(models[7],_testData[20], false);Int16smallintArray1M.AssertModel(models[8],_testData[21], false);Int16smallintArray1M.AssertModel(models[9],_testData[22], false);Int16smallintArray1M.AssertModel(models[10],_testData[23], false);Int16smallintArray1M.AssertModel(models[11],_testData[24], false);Int16smallintArray1M.AssertModel(models[12],_testData[25], false);Int16smallintArray1M.AssertModel(models[13],_testData[26], false);Int16smallintArray1M.AssertModel(models[14],_testData[27], false);Int16smallintArray1M.AssertModel(models[15],_testData[28], false);Int16smallintArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Int16smallintArray1M.AssertModel(models[0],_testData[16], false);Int16smallintArray1M.AssertModel(models[1],_testData[17], false);Int16smallintArray1M.AssertModel(models[2],_testData[18], false);Int16smallintArray1M.AssertModel(models[3],_testData[19], false);Int16smallintArray1M.AssertModel(models[4],_testData[20], false);Int16smallintArray1M.AssertModel(models[5],_testData[21], false);Int16smallintArray1M.AssertModel(models[6],_testData[22], false);Int16smallintArray1M.AssertModel(models[7],_testData[23], false);Int16smallintArray1M.AssertModel(models[8],_testData[24], false);Int16smallintArray1M.AssertModel(models[9],_testData[25], false);Int16smallintArray1M.AssertModel(models[10],_testData[26], false);Int16smallintArray1M.AssertModel(models[11],_testData[27], false);Int16smallintArray1M.AssertModel(models[12],_testData[28], false);Int16smallintArray1M.AssertModel(models[13],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[29], false);
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 61, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
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
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 68, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Int16smallintArray1M.AssertModel(models[0],_testData[14], false);Int16smallintArray1M.AssertModel(models[1],_testData[15], false);Int16smallintArray1M.AssertModel(models[2],_testData[16], false);Int16smallintArray1M.AssertModel(models[3],_testData[17], false);Int16smallintArray1M.AssertModel(models[4],_testData[18], false);Int16smallintArray1M.AssertModel(models[5],_testData[19], false);Int16smallintArray1M.AssertModel(models[6],_testData[20], false);Int16smallintArray1M.AssertModel(models[7],_testData[21], false);Int16smallintArray1M.AssertModel(models[8],_testData[22], false);Int16smallintArray1M.AssertModel(models[9],_testData[23], false);Int16smallintArray1M.AssertModel(models[10],_testData[24], false);Int16smallintArray1M.AssertModel(models[11],_testData[25], false);Int16smallintArray1M.AssertModel(models[12],_testData[26], false);Int16smallintArray1M.AssertModel(models[13],_testData[27], false);Int16smallintArray1M.AssertModel(models[14],_testData[28], false);Int16smallintArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Int16smallintArray1M.AssertModel(models[0],_testData[6], false);Int16smallintArray1M.AssertModel(models[1],_testData[7], false);Int16smallintArray1M.AssertModel(models[2],_testData[8], false);Int16smallintArray1M.AssertModel(models[3],_testData[9], false);Int16smallintArray1M.AssertModel(models[4],_testData[10], false);Int16smallintArray1M.AssertModel(models[5],_testData[11], false);Int16smallintArray1M.AssertModel(models[6],_testData[12], false);Int16smallintArray1M.AssertModel(models[7],_testData[13], false);Int16smallintArray1M.AssertModel(models[8],_testData[14], false);Int16smallintArray1M.AssertModel(models[9],_testData[15], false);Int16smallintArray1M.AssertModel(models[10],_testData[16], false);Int16smallintArray1M.AssertModel(models[11],_testData[17], false);Int16smallintArray1M.AssertModel(models[12],_testData[18], false);Int16smallintArray1M.AssertModel(models[13],_testData[19], false);Int16smallintArray1M.AssertModel(models[14],_testData[20], false);Int16smallintArray1M.AssertModel(models[15],_testData[21], false);Int16smallintArray1M.AssertModel(models[16],_testData[22], false);Int16smallintArray1M.AssertModel(models[17],_testData[23], false);Int16smallintArray1M.AssertModel(models[18],_testData[24], false);Int16smallintArray1M.AssertModel(models[19],_testData[25], false);Int16smallintArray1M.AssertModel(models[20],_testData[26], false);Int16smallintArray1M.AssertModel(models[21],_testData[27], false);Int16smallintArray1M.AssertModel(models[22],_testData[28], false);Int16smallintArray1M.AssertModel(models[23],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSelectModelBatch(connection, 61, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
Int16smallintArray1M.AssertModel(models[0],_testData[12], false);Int16smallintArray1M.AssertModel(models[1],_testData[13], false);Int16smallintArray1M.AssertModel(models[2],_testData[14], false);Int16smallintArray1M.AssertModel(models[3],_testData[15], false);Int16smallintArray1M.AssertModel(models[4],_testData[16], false);Int16smallintArray1M.AssertModel(models[5],_testData[17], false);Int16smallintArray1M.AssertModel(models[6],_testData[18], false);Int16smallintArray1M.AssertModel(models[7],_testData[19], false);Int16smallintArray1M.AssertModel(models[8],_testData[20], false);Int16smallintArray1M.AssertModel(models[9],_testData[21], false);Int16smallintArray1M.AssertModel(models[10],_testData[22], false);Int16smallintArray1M.AssertModel(models[11],_testData[23], false);Int16smallintArray1M.AssertModel(models[12],_testData[24], false);Int16smallintArray1M.AssertModel(models[13],_testData[25], false);Int16smallintArray1M.AssertModel(models[14],_testData[26], false);Int16smallintArray1M.AssertModel(models[15],_testData[27], false);Int16smallintArray1M.AssertModel(models[16],_testData[28], false);Int16smallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Int16smallintArray1M.AssertModel(models[0],_testData[5], false);Int16smallintArray1M.AssertModel(models[1],_testData[6], false);Int16smallintArray1M.AssertModel(models[2],_testData[7], false);Int16smallintArray1M.AssertModel(models[3],_testData[8], false);Int16smallintArray1M.AssertModel(models[4],_testData[9], false);Int16smallintArray1M.AssertModel(models[5],_testData[10], false);Int16smallintArray1M.AssertModel(models[6],_testData[11], false);Int16smallintArray1M.AssertModel(models[7],_testData[12], false);Int16smallintArray1M.AssertModel(models[8],_testData[13], false);Int16smallintArray1M.AssertModel(models[9],_testData[14], false);Int16smallintArray1M.AssertModel(models[10],_testData[15], false);Int16smallintArray1M.AssertModel(models[11],_testData[16], false);Int16smallintArray1M.AssertModel(models[12],_testData[17], false);Int16smallintArray1M.AssertModel(models[13],_testData[18], false);Int16smallintArray1M.AssertModel(models[14],_testData[19], false);Int16smallintArray1M.AssertModel(models[15],_testData[20], false);Int16smallintArray1M.AssertModel(models[16],_testData[21], false);Int16smallintArray1M.AssertModel(models[17],_testData[22], false);Int16smallintArray1M.AssertModel(models[18],_testData[23], false);Int16smallintArray1M.AssertModel(models[19],_testData[24], false);Int16smallintArray1M.AssertModel(models[20],_testData[25], false);Int16smallintArray1M.AssertModel(models[21],_testData[26], false);Int16smallintArray1M.AssertModel(models[22],_testData[27], false);Int16smallintArray1M.AssertModel(models[23],_testData[28], false);Int16smallintArray1M.AssertModel(models[24],_testData[29], false);
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
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models = await ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Int16smallintArray1M.AssertModel(models[0],_testData[13], false);Int16smallintArray1M.AssertModel(models[1],_testData[14], false);Int16smallintArray1M.AssertModel(models[2],_testData[15], false);Int16smallintArray1M.AssertModel(models[3],_testData[16], false);Int16smallintArray1M.AssertModel(models[4],_testData[17], false);Int16smallintArray1M.AssertModel(models[5],_testData[18], false);Int16smallintArray1M.AssertModel(models[6],_testData[19], false);Int16smallintArray1M.AssertModel(models[7],_testData[20], false);Int16smallintArray1M.AssertModel(models[8],_testData[21], false);Int16smallintArray1M.AssertModel(models[9],_testData[22], false);Int16smallintArray1M.AssertModel(models[10],_testData[23], false);Int16smallintArray1M.AssertModel(models[11],_testData[24], false);Int16smallintArray1M.AssertModel(models[12],_testData[25], false);Int16smallintArray1M.AssertModel(models[13],_testData[26], false);Int16smallintArray1M.AssertModel(models[14],_testData[27], false);Int16smallintArray1M.AssertModel(models[15],_testData[28], false);Int16smallintArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Int16smallintArray1M.AssertModel(models[0],_testData[2], false);Int16smallintArray1M.AssertModel(models[1],_testData[3], false);Int16smallintArray1M.AssertModel(models[2],_testData[4], false);Int16smallintArray1M.AssertModel(models[3],_testData[5], false);Int16smallintArray1M.AssertModel(models[4],_testData[6], false);Int16smallintArray1M.AssertModel(models[5],_testData[7], false);Int16smallintArray1M.AssertModel(models[6],_testData[8], false);Int16smallintArray1M.AssertModel(models[7],_testData[9], false);Int16smallintArray1M.AssertModel(models[8],_testData[10], false);Int16smallintArray1M.AssertModel(models[9],_testData[11], false);Int16smallintArray1M.AssertModel(models[10],_testData[12], false);Int16smallintArray1M.AssertModel(models[11],_testData[13], false);Int16smallintArray1M.AssertModel(models[12],_testData[14], false);Int16smallintArray1M.AssertModel(models[13],_testData[15], false);Int16smallintArray1M.AssertModel(models[14],_testData[16], false);Int16smallintArray1M.AssertModel(models[15],_testData[17], false);Int16smallintArray1M.AssertModel(models[16],_testData[18], false);Int16smallintArray1M.AssertModel(models[17],_testData[19], false);Int16smallintArray1M.AssertModel(models[18],_testData[20], false);Int16smallintArray1M.AssertModel(models[19],_testData[21], false);Int16smallintArray1M.AssertModel(models[20],_testData[22], false);Int16smallintArray1M.AssertModel(models[21],_testData[23], false);Int16smallintArray1M.AssertModel(models[22],_testData[24], false);Int16smallintArray1M.AssertModel(models[23],_testData[25], false);Int16smallintArray1M.AssertModel(models[24],_testData[26], false);Int16smallintArray1M.AssertModel(models[25],_testData[27], false);Int16smallintArray1M.AssertModel(models[26],_testData[28], false);Int16smallintArray1M.AssertModel(models[27],_testData[29], false);
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


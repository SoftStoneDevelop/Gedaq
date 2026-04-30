

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
    Id = 8,
    Value = 
new System.Int16[4]
{
6397,
2660,
444,
15178,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
27142,
26251,
10968,
1262,
},
},
            new Int16smallintArray1M
{
    Id = 16,
    Value = 
new System.Int16[3]
{
8040,
18898,
26290,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 3,
    Value = 
new System.Int16[4]
{
13755,
30242,
19219,
6426,
},
    NullableValue = 
new System.Int16[3]
{
22039,
23947,
12032,
},
},
    NullableValue = 
new System.Int16[4]
{
8546,
6101,
13656,
12433,
},
},
            new Int16smallintArray1M
{
    Id = 18,
    Value = 
new System.Int16[4]
{
19099,
25276,
19343,
7387,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
12696,
32546,
9766,
4565,
},
},
            new Int16smallintArray1M
{
    Id = 24,
    Value = 
new System.Int16[3]
{
5635,
8738,
30613,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 7,
    Value = 
new System.Int16[4]
{
147,
19261,
29123,
9084,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 32,
    Value = 
new System.Int16[4]
{
14151,
31842,
19272,
32408,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
30196,
31677,
3020,
},
},
            new Int16smallintArray1M
{
    Id = 36,
    Value = 
new System.Int16[3]
{
11458,
21476,
14371,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 12,
    Value = 
new System.Int16[4]
{
12326,
18497,
26940,
4310,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 40,
    Value = 
new System.Int16[4]
{
1268,
24377,
27138,
10575,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
16280,
4728,
12088,
27408,
},
},
            new Int16smallintArray1M
{
    Id = 43,
    Value = 
new System.Int16[3]
{
14712,
19216,
12228,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 21,
    Value = 
new System.Int16[4]
{
12501,
27128,
30180,
10331,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
26496,
346,
7731,
19568,
},
},
            new Int16smallintArray1M
{
    Id = 49,
    Value = 
new System.Int16[4]
{
26407,
22693,
11708,
16528,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
31796,
30455,
15457,
24307,
},
},
            new Int16smallintArray1M
{
    Id = 58,
    Value = 
new System.Int16[4]
{
5119,
3702,
7943,
8270,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 27,
    Value = 
new System.Int16[3]
{
21781,
24739,
6471,
},
    NullableValue = 
new System.Int16[3]
{
10838,
17878,
32736,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 60,
    Value = 
new System.Int16[3]
{
29780,
256,
2707,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
10508,
20771,
21781,
},
},
            new Int16smallintArray1M
{
    Id = 65,
    Value = 
new System.Int16[3]
{
21849,
16173,
30169,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 36,
    Value = 
new System.Int16[3]
{
21004,
32342,
31401,
},
    NullableValue = 
new System.Int16[4]
{
32424,
25326,
6274,
28257,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 68,
    Value = 
new System.Int16[3]
{
5240,
25657,
7026,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
17264,
29841,
28454,
1465,
},
},
            new Int16smallintArray1M
{
    Id = 77,
    Value = 
new System.Int16[4]
{
14578,
20824,
27629,
31612,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 38,
    Value = 
new System.Int16[4]
{
1491,
27821,
28148,
8716,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 86,
    Value = 
new System.Int16[4]
{
20311,
32036,
17357,
6958,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 88,
    Value = 
new System.Int16[3]
{
5500,
9258,
5111,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 44,
    Value = 
new System.Int16[4]
{
32146,
17069,
24360,
7481,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
4235,
19641,
32052,
22935,
},
},
            new Int16smallintArray1M
{
    Id = 89,
    Value = 
new System.Int16[3]
{
21157,
28253,
3677,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
11608,
9459,
13998,
},
},
            new Int16smallintArray1M
{
    Id = 94,
    Value = 
new System.Int16[4]
{
27154,
23264,
10446,
22425,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 49,
    Value = 
new System.Int16[4]
{
6670,
22888,
3994,
4022,
},
    NullableValue = 
new System.Int16[4]
{
22609,
5686,
15972,
3086,
},
},
    NullableValue = 
new System.Int16[4]
{
12422,
30789,
4924,
6347,
},
},
            new Int16smallintArray1M
{
    Id = 103,
    Value = 
new System.Int16[3]
{
2569,
22287,
6494,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
10149,
26406,
19201,
},
},
            new Int16smallintArray1M
{
    Id = 111,
    Value = 
new System.Int16[3]
{
10026,
30495,
12339,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 58,
    Value = 
new System.Int16[4]
{
17435,
29298,
9355,
29809,
},
    NullableValue = 
new System.Int16[4]
{
4062,
16758,
20601,
30001,
},
},
    NullableValue = 
new System.Int16[3]
{
19595,
17764,
10077,
},
},
            new Int16smallintArray1M
{
    Id = 117,
    Value = 
new System.Int16[4]
{
21232,
9083,
14414,
27950,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
21546,
10835,
13594,
},
},
            new Int16smallintArray1M
{
    Id = 118,
    Value = 
new System.Int16[3]
{
28928,
9890,
12024,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 60,
    Value = 
new System.Int16[4]
{
29845,
6791,
15784,
23704,
},
    NullableValue = 
new System.Int16[4]
{
9850,
4738,
11229,
16156,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 126,
    Value = 
new System.Int16[4]
{
23384,
10215,
22925,
14792,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
23692,
28016,
30197,
31323,
},
},
            new Int16smallintArray1M
{
    Id = 130,
    Value = 
new System.Int16[4]
{
8381,
2580,
17548,
12710,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 63,
    Value = 
new System.Int16[4]
{
17814,
23504,
16558,
2988,
},
    NullableValue = 
new System.Int16[4]
{
15658,
25810,
17246,
28103,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 131,
    Value = 
new System.Int16[4]
{
8571,
3856,
11442,
16944,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
20912,
21931,
5196,
},
},
            new Int16smallintArray1M
{
    Id = 133,
    Value = 
new System.Int16[3]
{
11397,
22031,
17885,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 72,
    Value = 
new System.Int16[4]
{
4451,
10282,
26440,
9511,
},
    NullableValue = 
new System.Int16[3]
{
28868,
21099,
21998,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 136,
    Value = 
new System.Int16[3]
{
17625,
12794,
13764,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
3031,
543,
8626,
13815,
},
},
            new Int16smallintArray1M
{
    Id = 143,
    Value = 
new System.Int16[3]
{
20883,
24464,
18226,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 79,
    Value = 
new System.Int16[3]
{
18384,
2338,
4144,
},
    NullableValue = 
new System.Int16[3]
{
5493,
8028,
16918,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 145,
    Value = 
new System.Int16[3]
{
26150,
16091,
12398,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
23819,
8768,
16060,
},
},
            new Int16smallintArray1M
{
    Id = 146,
    Value = 
new System.Int16[4]
{
4768,
16699,
3797,
19643,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 80,
    Value = 
new System.Int16[3]
{
699,
18885,
30271,
},
    NullableValue = 
new System.Int16[4]
{
14150,
8864,
11547,
19639,
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[3]
{
30196,
31677,
3020,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
16280,
4728,
12088,
27408,
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
26496,
346,
7731,
19568,
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
31796,
30455,
15457,
24307,
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
new System.Int16[3]
{
10508,
20771,
21781,
}));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintArray1M.AssertModel(models[0],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int16smallintArray1M.AssertModel(models[0],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int16smallintArray1M.AssertModel(models[0],_testData[1], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[2], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[3], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[4], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[5], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[6], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[7], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[8], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[9], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[10], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[11], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[19],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[20],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[21],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[22],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[23],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[24],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[25],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[26],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[27],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[28],_testData[29], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 60, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 68, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 58, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 68, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[26],_testData[29], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 18, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 77, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[29], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 77, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int16smallintArray1M.AssertModel(models[0],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int16smallintArray1M.AssertModel(models[0],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 40, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int16smallintArray1M.AssertModel(models[0],_testData[7], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[8], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[9], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[10], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[11], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[19],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[20],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[21],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models = await ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Int16smallintArray1M.AssertModel(models[0],_testData[15], false);Int16smallintArray1M.AssertModel(models[1],_testData[16], false);Int16smallintArray1M.AssertModel(models[2],_testData[17], false);Int16smallintArray1M.AssertModel(models[3],_testData[18], false);Int16smallintArray1M.AssertModel(models[4],_testData[19], false);Int16smallintArray1M.AssertModel(models[5],_testData[20], false);Int16smallintArray1M.AssertModel(models[6],_testData[21], false);Int16smallintArray1M.AssertModel(models[7],_testData[22], false);Int16smallintArray1M.AssertModel(models[8],_testData[23], false);Int16smallintArray1M.AssertModel(models[9],_testData[24], false);Int16smallintArray1M.AssertModel(models[10],_testData[25], false);Int16smallintArray1M.AssertModel(models[11],_testData[26], false);Int16smallintArray1M.AssertModel(models[12],_testData[27], false);Int16smallintArray1M.AssertModel(models[13],_testData[28], false);Int16smallintArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
Int16smallintArray1M.AssertModel(models[0],_testData[20], false);Int16smallintArray1M.AssertModel(models[1],_testData[21], false);Int16smallintArray1M.AssertModel(models[2],_testData[22], false);Int16smallintArray1M.AssertModel(models[3],_testData[23], false);Int16smallintArray1M.AssertModel(models[4],_testData[24], false);Int16smallintArray1M.AssertModel(models[5],_testData[25], false);Int16smallintArray1M.AssertModel(models[6],_testData[26], false);Int16smallintArray1M.AssertModel(models[7],_testData[27], false);Int16smallintArray1M.AssertModel(models[8],_testData[28], false);Int16smallintArray1M.AssertModel(models[9],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintArray1MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((IInt16ArraysmallintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((IInt16ArraysmallintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(Int16smallintArray1MI),
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
            queryMapType: typeof(Int16smallintArray1M),
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


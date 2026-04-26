

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
    Id = 1,
    Value = 
new System.Int16[3]
{
6201,
18886,
21497,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 8,
    Value = 
new System.Int16[3]
{
107,
7072,
23620,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 3,
    Value = 
new System.Int16[3]
{
2116,
14400,
22469,
},
    NullableValue = 
new System.Int16[4]
{
1103,
18761,
12612,
11064,
},
},
    NullableValue = 
new System.Int16[4]
{
2526,
3310,
16740,
8673,
},
},
            new Int16smallintArray1M
{
    Id = 17,
    Value = 
new System.Int16[4]
{
27864,
3451,
8800,
6596,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 24,
    Value = 
new System.Int16[3]
{
19161,
19849,
27876,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 10,
    Value = 
new System.Int16[3]
{
27621,
12764,
7103,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
1796,
8168,
2047,
},
},
            new Int16smallintArray1M
{
    Id = 27,
    Value = 
new System.Int16[3]
{
20090,
10013,
19183,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 35,
    Value = 
new System.Int16[4]
{
17753,
32701,
622,
24966,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 15,
    Value = 
new System.Int16[4]
{
22702,
5254,
26972,
31571,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
26584,
12943,
2808,
16054,
},
},
            new Int16smallintArray1M
{
    Id = 44,
    Value = 
new System.Int16[3]
{
15211,
8633,
25225,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 47,
    Value = 
new System.Int16[4]
{
10336,
28621,
24058,
4344,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 24,
    Value = 
new System.Int16[3]
{
5222,
19700,
32621,
},
    NullableValue = 
new System.Int16[3]
{
17415,
10185,
19921,
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
7353,
5246,
4974,
17558,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
8022,
29991,
7780,
13048,
},
},
            new Int16smallintArray1M
{
    Id = 54,
    Value = 
new System.Int16[3]
{
11516,
3594,
23358,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 26,
    Value = 
new System.Int16[3]
{
15312,
1158,
29120,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 57,
    Value = 
new System.Int16[4]
{
10790,
10615,
27851,
28225,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 59,
    Value = 
new System.Int16[3]
{
1102,
32082,
28691,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 32,
    Value = 
new System.Int16[4]
{
7986,
18594,
28620,
3232,
},
    NullableValue = 
new System.Int16[3]
{
5378,
29826,
10476,
},
},
    NullableValue = 
new System.Int16[3]
{
10097,
15629,
14517,
},
},
            new Int16smallintArray1M
{
    Id = 68,
    Value = 
new System.Int16[4]
{
31812,
11544,
9387,
15715,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
3013,
10329,
2622,
20677,
},
},
            new Int16smallintArray1M
{
    Id = 73,
    Value = 
new System.Int16[3]
{
30504,
10685,
15716,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 41,
    Value = 
new System.Int16[3]
{
28083,
16065,
23858,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
21976,
24049,
13169,
},
},
            new Int16smallintArray1M
{
    Id = 78,
    Value = 
new System.Int16[4]
{
11540,
19221,
10957,
23271,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 85,
    Value = 
new System.Int16[3]
{
8888,
26294,
29573,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 47,
    Value = 
new System.Int16[4]
{
31304,
6052,
27981,
14155,
},
    NullableValue = 
new System.Int16[4]
{
9995,
16175,
26066,
19937,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 90,
    Value = 
new System.Int16[4]
{
2694,
18149,
19063,
25247,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
27141,
31450,
13361,
4874,
},
},
            new Int16smallintArray1M
{
    Id = 98,
    Value = 
new System.Int16[3]
{
4423,
13554,
240,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 56,
    Value = 
new System.Int16[3]
{
21973,
9329,
12812,
},
    NullableValue = 
new System.Int16[4]
{
14202,
1378,
6895,
9892,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 99,
    Value = 
new System.Int16[4]
{
18107,
12730,
16321,
29317,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 102,
    Value = 
new System.Int16[4]
{
13687,
28881,
17422,
30916,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 62,
    Value = 
new System.Int16[3]
{
6431,
6382,
21483,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
13121,
26486,
10030,
},
},
            new Int16smallintArray1M
{
    Id = 105,
    Value = 
new System.Int16[4]
{
12163,
6853,
28542,
15732,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 108,
    Value = 
new System.Int16[3]
{
13624,
15015,
9236,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 71,
    Value = 
new System.Int16[4]
{
29949,
6031,
760,
29726,
},
    NullableValue = 
new System.Int16[4]
{
13354,
9732,
6159,
16935,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 109,
    Value = 
new System.Int16[3]
{
8242,
31490,
22101,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 112,
    Value = 
new System.Int16[4]
{
15079,
10539,
20320,
11416,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 77,
    Value = 
new System.Int16[4]
{
5165,
19122,
14877,
19124,
},
    NullableValue = 
new System.Int16[3]
{
11351,
15002,
6414,
},
},
    NullableValue = 
new System.Int16[3]
{
24604,
5847,
13170,
},
},
            new Int16smallintArray1M
{
    Id = 120,
    Value = 
new System.Int16[3]
{
16592,
3382,
9660,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
32442,
15145,
16612,
},
},
            new Int16smallintArray1M
{
    Id = 129,
    Value = 
new System.Int16[3]
{
5145,
12169,
30555,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 83,
    Value = 
new System.Int16[4]
{
8835,
581,
3068,
1800,
},
    NullableValue = 
new System.Int16[4]
{
23047,
25869,
7133,
24314,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 133,
    Value = 
new System.Int16[4]
{
3445,
7595,
23180,
31772,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
21298,
29900,
28702,
6027,
},
},
            new Int16smallintArray1M
{
    Id = 141,
    Value = 
new System.Int16[3]
{
28481,
7622,
32597,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 90,
    Value = 
new System.Int16[4]
{
7080,
12169,
30420,
32280,
},
    NullableValue = 
new System.Int16[3]
{
28667,
4241,
27041,
},
},
    NullableValue = 
new System.Int16[4]
{
13531,
11742,
16831,
22289,
},
},
            new Int16smallintArray1M
{
    Id = 146,
    Value = 
new System.Int16[3]
{
29816,
7474,
2956,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
13312,
22745,
2121,
15782,
},
},
            new Int16smallintArray1M
{
    Id = 153,
    Value = 
new System.Int16[3]
{
30390,
23715,
19896,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 95,
    Value = 
new System.Int16[4]
{
28952,
1130,
1329,
9995,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
26584,
12943,
2808,
16054,
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
                Assert.That(nullable, Is.Null);
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
8022,
29991,
7780,
13048,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[3]
{
10097,
15629,
14517,
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
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
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int16smallintArray1M.AssertModel(models[0],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int16smallintArray1M.AssertModel(models[0],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int16smallintArray1M.AssertModel(models[0],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int16smallintArray1M.AssertModel(models[0],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[29], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[29], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[29], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[29], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 73, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int16smallintArray1M.AssertModel(models[0],_testData[10], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[11], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int16smallintArray1M.AssertModel(models[0],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 68, 141))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
Int16smallintArray1M.AssertModel(models[0],_testData[24], false);Int16smallintArray1M.AssertModel(models[1],_testData[25], false);Int16smallintArray1M.AssertModel(models[2],_testData[26], false);Int16smallintArray1M.AssertModel(models[3],_testData[27], false);Int16smallintArray1M.AssertModel(models[4],_testData[28], false);Int16smallintArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Int16smallintArray1M.AssertModel(models[0],_testData[21], false);Int16smallintArray1M.AssertModel(models[1],_testData[22], false);Int16smallintArray1M.AssertModel(models[2],_testData[23], false);Int16smallintArray1M.AssertModel(models[3],_testData[24], false);Int16smallintArray1M.AssertModel(models[4],_testData[25], false);Int16smallintArray1M.AssertModel(models[5],_testData[26], false);Int16smallintArray1M.AssertModel(models[6],_testData[27], false);Int16smallintArray1M.AssertModel(models[7],_testData[28], false);Int16smallintArray1M.AssertModel(models[8],_testData[29], false);
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


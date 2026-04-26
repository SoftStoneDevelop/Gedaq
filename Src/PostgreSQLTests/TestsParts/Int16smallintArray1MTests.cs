

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
    Id = 9,
    Value = 
new System.Int16[3]
{
31881,
21270,
32229,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 17,
    Value = 
new System.Int16[3]
{
27330,
31384,
26947,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 8,
    Value = 
new System.Int16[4]
{
6288,
30523,
30534,
29517,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
7480,
8140,
17640,
},
},
            new Int16smallintArray1M
{
    Id = 26,
    Value = 
new System.Int16[4]
{
28948,
8090,
19549,
30577,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
22676,
28002,
11349,
},
},
            new Int16smallintArray1M
{
    Id = 35,
    Value = 
new System.Int16[3]
{
4524,
12997,
15037,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 13,
    Value = 
new System.Int16[3]
{
24873,
3151,
6996,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 39,
    Value = 
new System.Int16[4]
{
21742,
7082,
19650,
29193,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 46,
    Value = 
new System.Int16[3]
{
20523,
18402,
3700,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 15,
    Value = 
new System.Int16[4]
{
21277,
3613,
5803,
25214,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 49,
    Value = 
new System.Int16[4]
{
6999,
8888,
29092,
4379,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
2661,
6516,
13551,
},
},
            new Int16smallintArray1M
{
    Id = 52,
    Value = 
new System.Int16[3]
{
15649,
26063,
13008,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 18,
    Value = 
new System.Int16[3]
{
16583,
24057,
13942,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
10892,
22028,
14714,
6048,
},
},
            new Int16smallintArray1M
{
    Id = 59,
    Value = 
new System.Int16[3]
{
13849,
27446,
28664,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 68,
    Value = 
new System.Int16[3]
{
26808,
12939,
21100,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 21,
    Value = 
new System.Int16[4]
{
23483,
30875,
4163,
3669,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
4223,
27928,
19757,
20237,
},
},
            new Int16smallintArray1M
{
    Id = 74,
    Value = 
new System.Int16[4]
{
30205,
30657,
23994,
22026,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 79,
    Value = 
new System.Int16[3]
{
28856,
29055,
20226,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 22,
    Value = 
new System.Int16[4]
{
12007,
27341,
29356,
30441,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 85,
    Value = 
new System.Int16[4]
{
10907,
11466,
6167,
25565,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 94,
    Value = 
new System.Int16[4]
{
10539,
26379,
2769,
29762,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 28,
    Value = 
new System.Int16[3]
{
1483,
10067,
7579,
},
    NullableValue = 
new System.Int16[3]
{
19307,
1690,
25082,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 99,
    Value = 
new System.Int16[3]
{
24462,
24347,
2847,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 106,
    Value = 
new System.Int16[4]
{
1833,
25671,
9781,
8096,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 30,
    Value = 
new System.Int16[4]
{
7195,
28041,
9344,
29502,
},
    NullableValue = 
new System.Int16[4]
{
23059,
15982,
30432,
2866,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 114,
    Value = 
new System.Int16[3]
{
1362,
2956,
11846,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 117,
    Value = 
new System.Int16[3]
{
4729,
17612,
21651,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 36,
    Value = 
new System.Int16[3]
{
3615,
15238,
32501,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 125,
    Value = 
new System.Int16[3]
{
3632,
2549,
14919,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 133,
    Value = 
new System.Int16[4]
{
6372,
25710,
5445,
28860,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 42,
    Value = 
new System.Int16[4]
{
10040,
28861,
21988,
31959,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
24380,
9042,
14389,
8716,
},
},
            new Int16smallintArray1M
{
    Id = 137,
    Value = 
new System.Int16[4]
{
750,
32615,
31438,
21435,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
31641,
20802,
32476,
20523,
},
},
            new Int16smallintArray1M
{
    Id = 142,
    Value = 
new System.Int16[4]
{
13133,
32061,
1758,
262,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 50,
    Value = 
new System.Int16[4]
{
2343,
27938,
19182,
16737,
},
    NullableValue = 
new System.Int16[4]
{
25690,
17213,
11122,
18878,
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
30768,
21972,
14830,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
19915,
2512,
6567,
2625,
},
},
            new Int16smallintArray1M
{
    Id = 152,
    Value = 
new System.Int16[3]
{
25969,
31484,
28835,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 51,
    Value = 
new System.Int16[4]
{
14384,
8056,
3092,
12983,
},
    NullableValue = 
new System.Int16[3]
{
20578,
26533,
16797,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 161,
    Value = 
new System.Int16[4]
{
1940,
23030,
18063,
18856,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
14267,
10659,
4287,
},
},
            new Int16smallintArray1M
{
    Id = 167,
    Value = 
new System.Int16[4]
{
21314,
5252,
24015,
17175,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 56,
    Value = 
new System.Int16[3]
{
29385,
30758,
314,
},
    NullableValue = 
new System.Int16[3]
{
3138,
5076,
3015,
},
},
    NullableValue = 
new System.Int16[4]
{
5457,
31115,
30796,
14306,
},
},
            new Int16smallintArray1M
{
    Id = 173,
    Value = 
new System.Int16[4]
{
23582,
10473,
1596,
5806,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 177,
    Value = 
new System.Int16[3]
{
31163,
7297,
12922,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 63,
    Value = 
new System.Int16[4]
{
160,
1635,
13421,
23429,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 184,
    Value = 
new System.Int16[4]
{
9739,
10071,
8835,
18525,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 188,
    Value = 
new System.Int16[3]
{
6072,
12484,
16612,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 67,
    Value = 
new System.Int16[3]
{
30559,
1156,
20818,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[3]
{
2661,
6516,
13551,
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
10892,
22028,
14714,
6048,
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt16ArraysmallintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[4]
{
4223,
27928,
19757,
20237,
}));
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt16ArraysmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IInt16ArraysmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt16ArraysmallintArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IInt16ArraysmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallintArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray1m m
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(23));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[7], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[8], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[21],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[29], false);
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 173;
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(3));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[29], false);
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

                var models = await ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
Int16smallintArray1M.AssertModel(models[0],_testData[24], false);Int16smallintArray1M.AssertModel(models[1],_testData[25], false);Int16smallintArray1M.AssertModel(models[2],_testData[26], false);Int16smallintArray1M.AssertModel(models[3],_testData[27], false);Int16smallintArray1M.AssertModel(models[4],_testData[28], false);Int16smallintArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
Int16smallintArray1M.AssertModel(models[0],_testData[13], false);Int16smallintArray1M.AssertModel(models[1],_testData[14], false);Int16smallintArray1M.AssertModel(models[2],_testData[15], false);Int16smallintArray1M.AssertModel(models[3],_testData[16], false);Int16smallintArray1M.AssertModel(models[4],_testData[17], false);Int16smallintArray1M.AssertModel(models[5],_testData[18], false);Int16smallintArray1M.AssertModel(models[6],_testData[19], false);Int16smallintArray1M.AssertModel(models[7],_testData[20], false);Int16smallintArray1M.AssertModel(models[8],_testData[21], false);Int16smallintArray1M.AssertModel(models[9],_testData[22], false);Int16smallintArray1M.AssertModel(models[10],_testData[23], false);Int16smallintArray1M.AssertModel(models[11],_testData[24], false);Int16smallintArray1M.AssertModel(models[12],_testData[25], false);Int16smallintArray1M.AssertModel(models[13],_testData[26], false);Int16smallintArray1M.AssertModel(models[14],_testData[27], false);Int16smallintArray1M.AssertModel(models[15],_testData[28], false);Int16smallintArray1M.AssertModel(models[16],_testData[29], false);
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

                var models =  ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(26));
Int16smallintArray1M.AssertModel(models[0],_testData[4], false);Int16smallintArray1M.AssertModel(models[1],_testData[5], false);Int16smallintArray1M.AssertModel(models[2],_testData[6], false);Int16smallintArray1M.AssertModel(models[3],_testData[7], false);Int16smallintArray1M.AssertModel(models[4],_testData[8], false);Int16smallintArray1M.AssertModel(models[5],_testData[9], false);Int16smallintArray1M.AssertModel(models[6],_testData[10], false);Int16smallintArray1M.AssertModel(models[7],_testData[11], false);Int16smallintArray1M.AssertModel(models[8],_testData[12], false);Int16smallintArray1M.AssertModel(models[9],_testData[13], false);Int16smallintArray1M.AssertModel(models[10],_testData[14], false);Int16smallintArray1M.AssertModel(models[11],_testData[15], false);Int16smallintArray1M.AssertModel(models[12],_testData[16], false);Int16smallintArray1M.AssertModel(models[13],_testData[17], false);Int16smallintArray1M.AssertModel(models[14],_testData[18], false);Int16smallintArray1M.AssertModel(models[15],_testData[19], false);Int16smallintArray1M.AssertModel(models[16],_testData[20], false);Int16smallintArray1M.AssertModel(models[17],_testData[21], false);Int16smallintArray1M.AssertModel(models[18],_testData[22], false);Int16smallintArray1M.AssertModel(models[19],_testData[23], false);Int16smallintArray1M.AssertModel(models[20],_testData[24], false);Int16smallintArray1M.AssertModel(models[21],_testData[25], false);Int16smallintArray1M.AssertModel(models[22],_testData[26], false);Int16smallintArray1M.AssertModel(models[23],_testData[27], false);Int16smallintArray1M.AssertModel(models[24],_testData[28], false);Int16smallintArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[5], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[6], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[7], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[8], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[21],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[22],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[23],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[29], false);
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
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
LEFT JOIN public.int16smallintarray1mi mi ON mi.id = m.int16smallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 39, query1, 177, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[5], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[6], false);FlatInt16smallintArray1M.AssertModel(models[2],_testData[7], false);FlatInt16smallintArray1M.AssertModel(models[3],_testData[8], false);FlatInt16smallintArray1M.AssertModel(models[4],_testData[9], false);FlatInt16smallintArray1M.AssertModel(models[5],_testData[10], false);FlatInt16smallintArray1M.AssertModel(models[6],_testData[11], false);FlatInt16smallintArray1M.AssertModel(models[7],_testData[12], false);FlatInt16smallintArray1M.AssertModel(models[8],_testData[13], false);FlatInt16smallintArray1M.AssertModel(models[9],_testData[14], false);FlatInt16smallintArray1M.AssertModel(models[10],_testData[15], false);FlatInt16smallintArray1M.AssertModel(models[11],_testData[16], false);FlatInt16smallintArray1M.AssertModel(models[12],_testData[17], false);FlatInt16smallintArray1M.AssertModel(models[13],_testData[18], false);FlatInt16smallintArray1M.AssertModel(models[14],_testData[19], false);FlatInt16smallintArray1M.AssertModel(models[15],_testData[20], false);FlatInt16smallintArray1M.AssertModel(models[16],_testData[21], false);FlatInt16smallintArray1M.AssertModel(models[17],_testData[22], false);FlatInt16smallintArray1M.AssertModel(models[18],_testData[23], false);FlatInt16smallintArray1M.AssertModel(models[19],_testData[24], false);FlatInt16smallintArray1M.AssertModel(models[20],_testData[25], false);FlatInt16smallintArray1M.AssertModel(models[21],_testData[26], false);FlatInt16smallintArray1M.AssertModel(models[22],_testData[27], false);FlatInt16smallintArray1M.AssertModel(models[23],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatInt16smallintArray1M.AssertModel(models[0],_testData[28], false);FlatInt16smallintArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = await ((IInt16ArraysmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 17, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int16smallintArray1M.AssertModel(models[0],_testData[2], false);Int16smallintArray1M.AssertModel(models[1],_testData[3], false);Int16smallintArray1M.AssertModel(models[2],_testData[4], false);Int16smallintArray1M.AssertModel(models[3],_testData[5], false);Int16smallintArray1M.AssertModel(models[4],_testData[6], false);Int16smallintArray1M.AssertModel(models[5],_testData[7], false);Int16smallintArray1M.AssertModel(models[6],_testData[8], false);Int16smallintArray1M.AssertModel(models[7],_testData[9], false);Int16smallintArray1M.AssertModel(models[8],_testData[10], false);Int16smallintArray1M.AssertModel(models[9],_testData[11], false);Int16smallintArray1M.AssertModel(models[10],_testData[12], false);Int16smallintArray1M.AssertModel(models[11],_testData[13], false);Int16smallintArray1M.AssertModel(models[12],_testData[14], false);Int16smallintArray1M.AssertModel(models[13],_testData[15], false);Int16smallintArray1M.AssertModel(models[14],_testData[16], false);Int16smallintArray1M.AssertModel(models[15],_testData[17], false);Int16smallintArray1M.AssertModel(models[16],_testData[18], false);Int16smallintArray1M.AssertModel(models[17],_testData[19], false);Int16smallintArray1M.AssertModel(models[18],_testData[20], false);Int16smallintArray1M.AssertModel(models[19],_testData[21], false);Int16smallintArray1M.AssertModel(models[20],_testData[22], false);Int16smallintArray1M.AssertModel(models[21],_testData[23], false);Int16smallintArray1M.AssertModel(models[22],_testData[24], false);Int16smallintArray1M.AssertModel(models[23],_testData[25], false);Int16smallintArray1M.AssertModel(models[24],_testData[26], false);Int16smallintArray1M.AssertModel(models[25],_testData[27], false);Int16smallintArray1M.AssertModel(models[26],_testData[28], false);Int16smallintArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
Int16smallintArray1M.AssertModel(models[0],_testData[11], false);Int16smallintArray1M.AssertModel(models[1],_testData[12], false);Int16smallintArray1M.AssertModel(models[2],_testData[13], false);Int16smallintArray1M.AssertModel(models[3],_testData[14], false);Int16smallintArray1M.AssertModel(models[4],_testData[15], false);Int16smallintArray1M.AssertModel(models[5],_testData[16], false);Int16smallintArray1M.AssertModel(models[6],_testData[17], false);Int16smallintArray1M.AssertModel(models[7],_testData[18], false);Int16smallintArray1M.AssertModel(models[8],_testData[19], false);Int16smallintArray1M.AssertModel(models[9],_testData[20], false);Int16smallintArray1M.AssertModel(models[10],_testData[21], false);Int16smallintArray1M.AssertModel(models[11],_testData[22], false);Int16smallintArray1M.AssertModel(models[12],_testData[23], false);Int16smallintArray1M.AssertModel(models[13],_testData[24], false);Int16smallintArray1M.AssertModel(models[14],_testData[25], false);Int16smallintArray1M.AssertModel(models[15],_testData[26], false);Int16smallintArray1M.AssertModel(models[16],_testData[27], false);Int16smallintArray1M.AssertModel(models[17],_testData[28], false);Int16smallintArray1M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IInt16ArraysmallintArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSelectModelBatch(connection, 49, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Int16smallintArray1M.AssertModel(models[0],_testData[7], false);Int16smallintArray1M.AssertModel(models[1],_testData[8], false);Int16smallintArray1M.AssertModel(models[2],_testData[9], false);Int16smallintArray1M.AssertModel(models[3],_testData[10], false);Int16smallintArray1M.AssertModel(models[4],_testData[11], false);Int16smallintArray1M.AssertModel(models[5],_testData[12], false);Int16smallintArray1M.AssertModel(models[6],_testData[13], false);Int16smallintArray1M.AssertModel(models[7],_testData[14], false);Int16smallintArray1M.AssertModel(models[8],_testData[15], false);Int16smallintArray1M.AssertModel(models[9],_testData[16], false);Int16smallintArray1M.AssertModel(models[10],_testData[17], false);Int16smallintArray1M.AssertModel(models[11],_testData[18], false);Int16smallintArray1M.AssertModel(models[12],_testData[19], false);Int16smallintArray1M.AssertModel(models[13],_testData[20], false);Int16smallintArray1M.AssertModel(models[14],_testData[21], false);Int16smallintArray1M.AssertModel(models[15],_testData[22], false);Int16smallintArray1M.AssertModel(models[16],_testData[23], false);Int16smallintArray1M.AssertModel(models[17],_testData[24], false);Int16smallintArray1M.AssertModel(models[18],_testData[25], false);Int16smallintArray1M.AssertModel(models[19],_testData[26], false);Int16smallintArray1M.AssertModel(models[20],_testData[27], false);Int16smallintArray1M.AssertModel(models[21],_testData[28], false);Int16smallintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Int16smallintArray1M.AssertModel(models[0],_testData[8], false);Int16smallintArray1M.AssertModel(models[1],_testData[9], false);Int16smallintArray1M.AssertModel(models[2],_testData[10], false);Int16smallintArray1M.AssertModel(models[3],_testData[11], false);Int16smallintArray1M.AssertModel(models[4],_testData[12], false);Int16smallintArray1M.AssertModel(models[5],_testData[13], false);Int16smallintArray1M.AssertModel(models[6],_testData[14], false);Int16smallintArray1M.AssertModel(models[7],_testData[15], false);Int16smallintArray1M.AssertModel(models[8],_testData[16], false);Int16smallintArray1M.AssertModel(models[9],_testData[17], false);Int16smallintArray1M.AssertModel(models[10],_testData[18], false);Int16smallintArray1M.AssertModel(models[11],_testData[19], false);Int16smallintArray1M.AssertModel(models[12],_testData[20], false);Int16smallintArray1M.AssertModel(models[13],_testData[21], false);Int16smallintArray1M.AssertModel(models[14],_testData[22], false);Int16smallintArray1M.AssertModel(models[15],_testData[23], false);Int16smallintArray1M.AssertModel(models[16],_testData[24], false);Int16smallintArray1M.AssertModel(models[17],_testData[25], false);Int16smallintArray1M.AssertModel(models[18],_testData[26], false);Int16smallintArray1M.AssertModel(models[19],_testData[27], false);Int16smallintArray1M.AssertModel(models[20],_testData[28], false);Int16smallintArray1M.AssertModel(models[21],_testData[29], false);
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
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 167);
                var models = await ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Int16smallintArray1M.AssertModel(models[0],_testData[26], false);Int16smallintArray1M.AssertModel(models[1],_testData[27], false);Int16smallintArray1M.AssertModel(models[2],_testData[28], false);Int16smallintArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models =  ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Int16smallintArray1M.AssertModel(models[0],_testData[25], false);Int16smallintArray1M.AssertModel(models[1],_testData[26], false);Int16smallintArray1M.AssertModel(models[2],_testData[27], false);Int16smallintArray1M.AssertModel(models[3],_testData[28], false);Int16smallintArray1M.AssertModel(models[4],_testData[29], false);
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


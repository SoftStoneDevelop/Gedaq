

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
    internal partial interface ISByteArraysmallintArray
    {
    }
    
    internal partial class SByteArraysmallintArray : ISByteArraysmallintArray
    {


#region TestData

        private readonly SBytesmallintArray1M[] _testData = new SBytesmallintArray1M[]
        {
            new SBytesmallintArray1M
{
    Id = 3,
    Value = 
new System.SByte[3]
{
51,
-42,
101,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 6,
    Value = 
new System.SByte[4]
{
42,
97,
117,
-79,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 3,
    Value = 
new System.SByte[4]
{
-11,
101,
74,
38,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
47,
-94,
119,
},
},
            new SBytesmallintArray1M
{
    Id = 14,
    Value = 
new System.SByte[3]
{
-49,
-48,
102,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
53,
17,
-68,
54,
},
},
            new SBytesmallintArray1M
{
    Id = 19,
    Value = 
new System.SByte[3]
{
-57,
-20,
11,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 6,
    Value = 
new System.SByte[3]
{
-126,
-109,
27,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
63,
10,
86,
49,
},
},
            new SBytesmallintArray1M
{
    Id = 27,
    Value = 
new System.SByte[3]
{
2,
-89,
85,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-104,
-12,
72,
-29,
},
},
            new SBytesmallintArray1M
{
    Id = 28,
    Value = 
new System.SByte[4]
{
126,
-49,
22,
85,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 7,
    Value = 
new System.SByte[4]
{
14,
112,
75,
-82,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 34,
    Value = 
new System.SByte[4]
{
-114,
-66,
121,
-80,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 37,
    Value = 
new System.SByte[3]
{
28,
66,
96,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 8,
    Value = 
new System.SByte[4]
{
48,
34,
66,
108,
},
    NullableValue = 
new System.SByte[4]
{
-121,
53,
-54,
-93,
},
},
    NullableValue = 
new System.SByte[3]
{
87,
75,
-18,
},
},
            new SBytesmallintArray1M
{
    Id = 43,
    Value = 
new System.SByte[3]
{
102,
-4,
-14,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 49,
    Value = 
new System.SByte[3]
{
48,
123,
76,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 12,
    Value = 
new System.SByte[3]
{
-68,
73,
17,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
72,
30,
78,
-62,
},
},
            new SBytesmallintArray1M
{
    Id = 52,
    Value = 
new System.SByte[4]
{
15,
-10,
7,
-107,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 59,
    Value = 
new System.SByte[4]
{
-11,
115,
58,
-71,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 16,
    Value = 
new System.SByte[3]
{
14,
-16,
-32,
},
    NullableValue = 
new System.SByte[3]
{
-10,
-57,
-59,
},
},
    NullableValue = 
new System.SByte[4]
{
-83,
-48,
116,
-119,
},
},
            new SBytesmallintArray1M
{
    Id = 63,
    Value = 
new System.SByte[3]
{
118,
40,
42,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-33,
100,
-45,
-54,
},
},
            new SBytesmallintArray1M
{
    Id = 65,
    Value = 
new System.SByte[4]
{
77,
-120,
32,
-120,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 23,
    Value = 
new System.SByte[3]
{
-96,
64,
-48,
},
    NullableValue = 
new System.SByte[4]
{
-33,
-81,
-74,
90,
},
},
    NullableValue = 
new System.SByte[3]
{
-5,
-27,
-109,
},
},
            new SBytesmallintArray1M
{
    Id = 67,
    Value = 
new System.SByte[4]
{
82,
114,
-125,
-100,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
109,
5,
-113,
-111,
},
},
            new SBytesmallintArray1M
{
    Id = 71,
    Value = 
new System.SByte[3]
{
37,
-107,
-8,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 29,
    Value = 
new System.SByte[3]
{
-31,
88,
32,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-35,
-102,
86,
},
},
            new SBytesmallintArray1M
{
    Id = 75,
    Value = 
new System.SByte[4]
{
50,
87,
-1,
54,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 79,
    Value = 
new System.SByte[4]
{
60,
18,
-49,
-116,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 31,
    Value = 
new System.SByte[3]
{
32,
109,
-120,
},
    NullableValue = 
new System.SByte[4]
{
-112,
89,
-3,
-90,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 87,
    Value = 
new System.SByte[3]
{
-96,
44,
21,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-62,
-39,
-90,
},
},
            new SBytesmallintArray1M
{
    Id = 90,
    Value = 
new System.SByte[3]
{
117,
27,
35,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 38,
    Value = 
new System.SByte[3]
{
25,
-10,
-13,
},
    NullableValue = 
new System.SByte[3]
{
-118,
-126,
-111,
},
},
    NullableValue = 
new System.SByte[4]
{
38,
-118,
-45,
-115,
},
},
            new SBytesmallintArray1M
{
    Id = 95,
    Value = 
new System.SByte[4]
{
-119,
-17,
-44,
111,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
4,
-126,
-82,
-26,
},
},
            new SBytesmallintArray1M
{
    Id = 101,
    Value = 
new System.SByte[4]
{
-108,
-89,
125,
-103,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 41,
    Value = 
new System.SByte[3]
{
-82,
79,
-92,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 105,
    Value = 
new System.SByte[4]
{
102,
84,
-19,
100,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-55,
100,
-12,
-73,
},
},
            new SBytesmallintArray1M
{
    Id = 111,
    Value = 
new System.SByte[4]
{
-35,
66,
20,
29,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 46,
    Value = 
new System.SByte[3]
{
78,
3,
37,
},
    NullableValue = 
new System.SByte[4]
{
56,
110,
-45,
-46,
},
},
    NullableValue = 
new System.SByte[4]
{
24,
116,
3,
-6,
},
},
            new SBytesmallintArray1M
{
    Id = 120,
    Value = 
new System.SByte[3]
{
94,
64,
-47,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-10,
56,
-19,
},
},
            new SBytesmallintArray1M
{
    Id = 125,
    Value = 
new System.SByte[4]
{
46,
-37,
-124,
-3,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 47,
    Value = 
new System.SByte[3]
{
124,
-1,
-21,
},
    NullableValue = 
new System.SByte[4]
{
92,
35,
110,
-46,
},
},
    NullableValue = 
new System.SByte[4]
{
49,
112,
-42,
119,
},
},
            new SBytesmallintArray1M
{
    Id = 130,
    Value = 
new System.SByte[4]
{
41,
-59,
-47,
80,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
0,
27,
73,
},
},
            new SBytesmallintArray1M
{
    Id = 138,
    Value = 
new System.SByte[3]
{
74,
-116,
-77,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 56,
    Value = 
new System.SByte[3]
{
-108,
-4,
14,
},
    NullableValue = 
new System.SByte[4]
{
126,
-91,
-71,
-58,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 144,
    Value = 
new System.SByte[3]
{
33,
53,
0,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 152,
    Value = 
new System.SByte[4]
{
49,
94,
120,
2,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 60,
    Value = 
new System.SByte[3]
{
-79,
-100,
-14,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-115,
-104,
92,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray1mi(
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
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray1mi(
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
            queryMapTypes: [typeof(SBytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]), 
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

                changedRows =  ((ISByteArraysmallintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteArraysmallintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISByteArraysmallintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteArraysmallintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISByteArraysmallintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISByteArraysmallintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray1m(
	id,
    value,
    nullablevalue,
    sbytesmallintarray1mi_id
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
            asPartInterface: typeof(ISByteArraysmallintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallintarray1mi_id", 
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
                changedRows =  ((ISByteArraysmallintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISByteArraysmallintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISByteArraysmallintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISByteArraysmallintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray1m(
	id,
    value,
    nullablevalue,
    sbytesmallintarray1mi_id
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
    sbytesmallintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintarray1m(
	id,
    value,
    nullablevalue,
    sbytesmallintarray1mi_id
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
    sbytesmallintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallintarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallintArray1M> models = null;

                models =  ((ISByteArraysmallintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((ISByteArraysmallintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((ISByteArraysmallintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((ISByteArraysmallintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallintArray1M> models = null;

                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M), typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                ((ISByteArraysmallintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISByteArraysmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISByteArraysmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
                var models = await ((ISByteArraysmallintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISByteArraysmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M), typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                ((ISByteArraysmallintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteArraysmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISByteArraysmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
                var models = await ((ISByteArraysmallintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteArraysmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M), typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                await((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[8], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[4], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[5], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[6], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[7], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[8], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[21],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[22],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[23],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[24],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[1], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[2], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[3], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[4], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[5], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[6], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[7], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[8], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[21],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[22],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[23],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[24],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[25],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[26],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[27],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
                var models = await((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
SBytesmallintArray1M.AssertModel(models[0],_testData[24], false);SBytesmallintArray1M.AssertModel(models[1],_testData[25], false);SBytesmallintArray1M.AssertModel(models[2],_testData[26], false);SBytesmallintArray1M.AssertModel(models[3],_testData[27], false);SBytesmallintArray1M.AssertModel(models[4],_testData[28], false);SBytesmallintArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
SBytesmallintArray1M.AssertModel(models[0],_testData[11], false);SBytesmallintArray1M.AssertModel(models[1],_testData[12], false);SBytesmallintArray1M.AssertModel(models[2],_testData[13], false);SBytesmallintArray1M.AssertModel(models[3],_testData[14], false);SBytesmallintArray1M.AssertModel(models[4],_testData[15], false);SBytesmallintArray1M.AssertModel(models[5],_testData[16], false);SBytesmallintArray1M.AssertModel(models[6],_testData[17], false);SBytesmallintArray1M.AssertModel(models[7],_testData[18], false);SBytesmallintArray1M.AssertModel(models[8],_testData[19], false);SBytesmallintArray1M.AssertModel(models[9],_testData[20], false);SBytesmallintArray1M.AssertModel(models[10],_testData[21], false);SBytesmallintArray1M.AssertModel(models[11],_testData[22], false);SBytesmallintArray1M.AssertModel(models[12],_testData[23], false);SBytesmallintArray1M.AssertModel(models[13],_testData[24], false);SBytesmallintArray1M.AssertModel(models[14],_testData[25], false);SBytesmallintArray1M.AssertModel(models[15],_testData[26], false);SBytesmallintArray1M.AssertModel(models[16],_testData[27], false);SBytesmallintArray1M.AssertModel(models[17],_testData[28], false);SBytesmallintArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
SBytesmallintArray1M.AssertModel(models[0],_testData[22], false);SBytesmallintArray1M.AssertModel(models[1],_testData[23], false);SBytesmallintArray1M.AssertModel(models[2],_testData[24], false);SBytesmallintArray1M.AssertModel(models[3],_testData[25], false);SBytesmallintArray1M.AssertModel(models[4],_testData[26], false);SBytesmallintArray1M.AssertModel(models[5],_testData[27], false);SBytesmallintArray1M.AssertModel(models[6],_testData[28], false);SBytesmallintArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
SBytesmallintArray1M.AssertModel(models[0],_testData[5], false);SBytesmallintArray1M.AssertModel(models[1],_testData[6], false);SBytesmallintArray1M.AssertModel(models[2],_testData[7], false);SBytesmallintArray1M.AssertModel(models[3],_testData[8], false);SBytesmallintArray1M.AssertModel(models[4],_testData[9], false);SBytesmallintArray1M.AssertModel(models[5],_testData[10], false);SBytesmallintArray1M.AssertModel(models[6],_testData[11], false);SBytesmallintArray1M.AssertModel(models[7],_testData[12], false);SBytesmallintArray1M.AssertModel(models[8],_testData[13], false);SBytesmallintArray1M.AssertModel(models[9],_testData[14], false);SBytesmallintArray1M.AssertModel(models[10],_testData[15], false);SBytesmallintArray1M.AssertModel(models[11],_testData[16], false);SBytesmallintArray1M.AssertModel(models[12],_testData[17], false);SBytesmallintArray1M.AssertModel(models[13],_testData[18], false);SBytesmallintArray1M.AssertModel(models[14],_testData[19], false);SBytesmallintArray1M.AssertModel(models[15],_testData[20], false);SBytesmallintArray1M.AssertModel(models[16],_testData[21], false);SBytesmallintArray1M.AssertModel(models[17],_testData[22], false);SBytesmallintArray1M.AssertModel(models[18],_testData[23], false);SBytesmallintArray1M.AssertModel(models[19],_testData[24], false);SBytesmallintArray1M.AssertModel(models[20],_testData[25], false);SBytesmallintArray1M.AssertModel(models[21],_testData[26], false);SBytesmallintArray1M.AssertModel(models[22],_testData[27], false);SBytesmallintArray1M.AssertModel(models[23],_testData[28], false);SBytesmallintArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M), typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                await((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintArray1M>();
                var models2 = new List<FlatSBytesmallintArray1M>();
                ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[7], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[8], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[21],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[7], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[8], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[21],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[22],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
                var models = await((ISByteArraysmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 138, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
SBytesmallintArray1M.AssertModel(models[0],_testData[28], false);SBytesmallintArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
SBytesmallintArray1M.AssertModel(models[0],_testData[24], false);SBytesmallintArray1M.AssertModel(models[1],_testData[25], false);SBytesmallintArray1M.AssertModel(models[2],_testData[26], false);SBytesmallintArray1M.AssertModel(models[3],_testData[27], false);SBytesmallintArray1M.AssertModel(models[4],_testData[28], false);SBytesmallintArray1M.AssertModel(models[5],_testData[29], false);
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
                var models = ((ISByteArraysmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSelectModelBatch(connection, 27, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
SBytesmallintArray1M.AssertModel(models[0],_testData[5], false);SBytesmallintArray1M.AssertModel(models[1],_testData[6], false);SBytesmallintArray1M.AssertModel(models[2],_testData[7], false);SBytesmallintArray1M.AssertModel(models[3],_testData[8], false);SBytesmallintArray1M.AssertModel(models[4],_testData[9], false);SBytesmallintArray1M.AssertModel(models[5],_testData[10], false);SBytesmallintArray1M.AssertModel(models[6],_testData[11], false);SBytesmallintArray1M.AssertModel(models[7],_testData[12], false);SBytesmallintArray1M.AssertModel(models[8],_testData[13], false);SBytesmallintArray1M.AssertModel(models[9],_testData[14], false);SBytesmallintArray1M.AssertModel(models[10],_testData[15], false);SBytesmallintArray1M.AssertModel(models[11],_testData[16], false);SBytesmallintArray1M.AssertModel(models[12],_testData[17], false);SBytesmallintArray1M.AssertModel(models[13],_testData[18], false);SBytesmallintArray1M.AssertModel(models[14],_testData[19], false);SBytesmallintArray1M.AssertModel(models[15],_testData[20], false);SBytesmallintArray1M.AssertModel(models[16],_testData[21], false);SBytesmallintArray1M.AssertModel(models[17],_testData[22], false);SBytesmallintArray1M.AssertModel(models[18],_testData[23], false);SBytesmallintArray1M.AssertModel(models[19],_testData[24], false);SBytesmallintArray1M.AssertModel(models[20],_testData[25], false);SBytesmallintArray1M.AssertModel(models[21],_testData[26], false);SBytesmallintArray1M.AssertModel(models[22],_testData[27], false);SBytesmallintArray1M.AssertModel(models[23],_testData[28], false);SBytesmallintArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
SBytesmallintArray1M.AssertModel(models[0],_testData[23], false);SBytesmallintArray1M.AssertModel(models[1],_testData[24], false);SBytesmallintArray1M.AssertModel(models[2],_testData[25], false);SBytesmallintArray1M.AssertModel(models[3],_testData[26], false);SBytesmallintArray1M.AssertModel(models[4],_testData[27], false);SBytesmallintArray1M.AssertModel(models[5],_testData[28], false);SBytesmallintArray1M.AssertModel(models[6],_testData[29], false);
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
                await using var cmd = await ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models = await ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
SBytesmallintArray1M.AssertModel(models[0],_testData[10], false);SBytesmallintArray1M.AssertModel(models[1],_testData[11], false);SBytesmallintArray1M.AssertModel(models[2],_testData[12], false);SBytesmallintArray1M.AssertModel(models[3],_testData[13], false);SBytesmallintArray1M.AssertModel(models[4],_testData[14], false);SBytesmallintArray1M.AssertModel(models[5],_testData[15], false);SBytesmallintArray1M.AssertModel(models[6],_testData[16], false);SBytesmallintArray1M.AssertModel(models[7],_testData[17], false);SBytesmallintArray1M.AssertModel(models[8],_testData[18], false);SBytesmallintArray1M.AssertModel(models[9],_testData[19], false);SBytesmallintArray1M.AssertModel(models[10],_testData[20], false);SBytesmallintArray1M.AssertModel(models[11],_testData[21], false);SBytesmallintArray1M.AssertModel(models[12],_testData[22], false);SBytesmallintArray1M.AssertModel(models[13],_testData[23], false);SBytesmallintArray1M.AssertModel(models[14],_testData[24], false);SBytesmallintArray1M.AssertModel(models[15],_testData[25], false);SBytesmallintArray1M.AssertModel(models[16],_testData[26], false);SBytesmallintArray1M.AssertModel(models[17],_testData[27], false);SBytesmallintArray1M.AssertModel(models[18],_testData[28], false);SBytesmallintArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
SBytesmallintArray1M.AssertModel(models[0],_testData[13], false);SBytesmallintArray1M.AssertModel(models[1],_testData[14], false);SBytesmallintArray1M.AssertModel(models[2],_testData[15], false);SBytesmallintArray1M.AssertModel(models[3],_testData[16], false);SBytesmallintArray1M.AssertModel(models[4],_testData[17], false);SBytesmallintArray1M.AssertModel(models[5],_testData[18], false);SBytesmallintArray1M.AssertModel(models[6],_testData[19], false);SBytesmallintArray1M.AssertModel(models[7],_testData[20], false);SBytesmallintArray1M.AssertModel(models[8],_testData[21], false);SBytesmallintArray1M.AssertModel(models[9],_testData[22], false);SBytesmallintArray1M.AssertModel(models[10],_testData[23], false);SBytesmallintArray1M.AssertModel(models[11],_testData[24], false);SBytesmallintArray1M.AssertModel(models[12],_testData[25], false);SBytesmallintArray1M.AssertModel(models[13],_testData[26], false);SBytesmallintArray1M.AssertModel(models[14],_testData[27], false);SBytesmallintArray1M.AssertModel(models[15],_testData[28], false);SBytesmallintArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MI)],
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
            asPartInterface: typeof(ISByteArraysmallintArray))]
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
FROM public.binary_sbytesmallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SBytesmallintArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISByteArraysmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteArraysmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(actual, expect, false);
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
                await ((ISByteArraysmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISByteArraysmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
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
            asPartInterface: typeof(ISByteArraysmallintArray))]
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
FROM public.binary_sbytesmallintarray1m m
LEFT JOIN public.binary_sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SBytesmallintArray1M>(15);

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
                ((ISByteArraysmallintArray)this).ImportModel(connection, importCollection);
                var models = ((ISByteArraysmallintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SBytesmallintArray1M.AssertModel(models[0],_testData[0], false);
                SBytesmallintArray1M.AssertModel(models[1],_testData[1], false);
                SBytesmallintArray1M.AssertModel(models[2],_testData[2], false);
                SBytesmallintArray1M.AssertModel(models[3],_testData[3], false);
                SBytesmallintArray1M.AssertModel(models[4],_testData[4], false);
                SBytesmallintArray1M.AssertModel(models[5],_testData[5], false);
                SBytesmallintArray1M.AssertModel(models[6],_testData[6], false);
                SBytesmallintArray1M.AssertModel(models[7],_testData[7], false);
                SBytesmallintArray1M.AssertModel(models[8],_testData[8], false);
                SBytesmallintArray1M.AssertModel(models[9],_testData[9], false);
                SBytesmallintArray1M.AssertModel(models[10],_testData[10], false);
                SBytesmallintArray1M.AssertModel(models[11],_testData[11], false);
                SBytesmallintArray1M.AssertModel(models[12],_testData[12], false);
                SBytesmallintArray1M.AssertModel(models[13],_testData[13], false);
                SBytesmallintArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ISByteArraysmallintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISByteArraysmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SBytesmallintArray1M.AssertModel(models[0],_testData[0], false);
                SBytesmallintArray1M.AssertModel(models[1],_testData[1], false);
                SBytesmallintArray1M.AssertModel(models[2],_testData[2], false);
                SBytesmallintArray1M.AssertModel(models[3],_testData[3], false);
                SBytesmallintArray1M.AssertModel(models[4],_testData[4], false);
                SBytesmallintArray1M.AssertModel(models[5],_testData[5], false);
                SBytesmallintArray1M.AssertModel(models[6],_testData[6], false);
                SBytesmallintArray1M.AssertModel(models[7],_testData[7], false);
                SBytesmallintArray1M.AssertModel(models[8],_testData[8], false);
                SBytesmallintArray1M.AssertModel(models[9],_testData[9], false);
                SBytesmallintArray1M.AssertModel(models[10],_testData[10], false);
                SBytesmallintArray1M.AssertModel(models[11],_testData[11], false);
                SBytesmallintArray1M.AssertModel(models[12],_testData[12], false);
                SBytesmallintArray1M.AssertModel(models[13],_testData[13], false);
                SBytesmallintArray1M.AssertModel(models[14],_testData[14], false);
                SBytesmallintArray1M.AssertModel(models[15],_testData[15], false);
                SBytesmallintArray1M.AssertModel(models[16],_testData[16], false);
                SBytesmallintArray1M.AssertModel(models[17],_testData[17], false);
                SBytesmallintArray1M.AssertModel(models[18],_testData[18], false);
                SBytesmallintArray1M.AssertModel(models[19],_testData[19], false);
                SBytesmallintArray1M.AssertModel(models[20],_testData[20], false);
                SBytesmallintArray1M.AssertModel(models[21],_testData[21], false);
                SBytesmallintArray1M.AssertModel(models[22],_testData[22], false);
                SBytesmallintArray1M.AssertModel(models[23],_testData[23], false);
                SBytesmallintArray1M.AssertModel(models[24],_testData[24], false);
                SBytesmallintArray1M.AssertModel(models[25],_testData[25], false);
                SBytesmallintArray1M.AssertModel(models[26],_testData[26], false);
                SBytesmallintArray1M.AssertModel(models[27],_testData[27], false);
                SBytesmallintArray1M.AssertModel(models[28],_testData[28], false);
                SBytesmallintArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SBytesmallintArray1M)],
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
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteArraysmallintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteArraysmallintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MI)],
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
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteArraysmallintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteArraysmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


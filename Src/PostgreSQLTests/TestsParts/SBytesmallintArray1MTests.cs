

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
    Id = 1,
    Value = 
new System.SByte[4]
{
48,
125,
-4,
27,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
90,
-1,
1,
},
},
            new SBytesmallintArray1M
{
    Id = 7,
    Value = 
new System.SByte[4]
{
28,
84,
-78,
86,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 9,
    Value = 
new System.SByte[4]
{
15,
80,
-72,
3,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
43,
-68,
90,
-78,
},
},
            new SBytesmallintArray1M
{
    Id = 10,
    Value = 
new System.SByte[4]
{
-118,
-42,
48,
22,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 14,
    Value = 
new System.SByte[4]
{
-44,
87,
119,
6,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 10,
    Value = 
new System.SByte[3]
{
-73,
71,
-58,
},
    NullableValue = 
new System.SByte[4]
{
83,
95,
63,
111,
},
},
    NullableValue = 
new System.SByte[4]
{
16,
-123,
-37,
118,
},
},
            new SBytesmallintArray1M
{
    Id = 22,
    Value = 
new System.SByte[3]
{
69,
-60,
-53,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-117,
99,
32,
-28,
},
},
            new SBytesmallintArray1M
{
    Id = 31,
    Value = 
new System.SByte[4]
{
45,
-3,
-59,
121,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 13,
    Value = 
new System.SByte[4]
{
-115,
-69,
-55,
10,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 37,
    Value = 
new System.SByte[3]
{
-49,
-63,
-28,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 43,
    Value = 
new System.SByte[3]
{
-95,
78,
118,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 20,
    Value = 
new System.SByte[3]
{
66,
-111,
-109,
},
    NullableValue = 
new System.SByte[3]
{
-14,
116,
-122,
},
},
    NullableValue = 
new System.SByte[3]
{
82,
63,
-71,
},
},
            new SBytesmallintArray1M
{
    Id = 47,
    Value = 
new System.SByte[4]
{
52,
101,
-20,
-70,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 50,
    Value = 
new System.SByte[4]
{
-114,
93,
-3,
7,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 24,
    Value = 
new System.SByte[4]
{
40,
-55,
80,
1,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-112,
-125,
124,
},
},
            new SBytesmallintArray1M
{
    Id = 52,
    Value = 
new System.SByte[3]
{
47,
51,
-10,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 55,
    Value = 
new System.SByte[3]
{
-52,
122,
87,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 29,
    Value = 
new System.SByte[4]
{
-33,
67,
-7,
61,
},
    NullableValue = 
new System.SByte[4]
{
59,
56,
43,
78,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 61,
    Value = 
new System.SByte[4]
{
-7,
40,
-95,
-80,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 62,
    Value = 
new System.SByte[4]
{
-71,
-59,
63,
-53,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 32,
    Value = 
new System.SByte[3]
{
34,
-74,
118,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-103,
-29,
32,
},
},
            new SBytesmallintArray1M
{
    Id = 67,
    Value = 
new System.SByte[3]
{
-103,
51,
-55,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-25,
-20,
110,
},
},
            new SBytesmallintArray1M
{
    Id = 74,
    Value = 
new System.SByte[3]
{
114,
114,
-90,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 37,
    Value = 
new System.SByte[4]
{
95,
116,
-24,
-44,
},
    NullableValue = 
new System.SByte[3]
{
31,
-126,
-15,
},
},
    NullableValue = 
new System.SByte[4]
{
-30,
-124,
-48,
115,
},
},
            new SBytesmallintArray1M
{
    Id = 81,
    Value = 
new System.SByte[3]
{
-111,
26,
124,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
51,
113,
-14,
},
},
            new SBytesmallintArray1M
{
    Id = 89,
    Value = 
new System.SByte[4]
{
-114,
87,
-10,
-48,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 44,
    Value = 
new System.SByte[4]
{
19,
103,
122,
-59,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 92,
    Value = 
new System.SByte[3]
{
22,
124,
-66,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
6,
89,
5,
99,
},
},
            new SBytesmallintArray1M
{
    Id = 100,
    Value = 
new System.SByte[4]
{
37,
93,
121,
-123,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 53,
    Value = 
new System.SByte[3]
{
-102,
66,
-109,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
36,
116,
-59,
},
},
            new SBytesmallintArray1M
{
    Id = 102,
    Value = 
new System.SByte[3]
{
-83,
74,
21,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-124,
36,
-124,
},
},
            new SBytesmallintArray1M
{
    Id = 109,
    Value = 
new System.SByte[4]
{
87,
37,
-8,
51,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 61,
    Value = 
new System.SByte[3]
{
-80,
7,
80,
},
    NullableValue = 
new System.SByte[4]
{
-106,
18,
89,
-128,
},
},
    NullableValue = 
new System.SByte[3]
{
111,
-64,
-124,
},
},
            new SBytesmallintArray1M
{
    Id = 118,
    Value = 
new System.SByte[3]
{
-112,
-51,
51,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 122,
    Value = 
new System.SByte[3]
{
78,
26,
60,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 63,
    Value = 
new System.SByte[4]
{
-96,
-105,
-121,
30,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-68,
-85,
77,
-126,
},
},
            new SBytesmallintArray1M
{
    Id = 130,
    Value = 
new System.SByte[3]
{
68,
-104,
-121,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-43,
81,
9,
},
},
            new SBytesmallintArray1M
{
    Id = 131,
    Value = 
new System.SByte[4]
{
-14,
-13,
-66,
110,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 66,
    Value = 
new System.SByte[4]
{
100,
77,
-31,
-9,
},
    NullableValue = 
new System.SByte[3]
{
-43,
-69,
102,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 139,
    Value = 
new System.SByte[4]
{
27,
-105,
73,
68,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
122,
101,
-40,
},
},
            new SBytesmallintArray1M
{
    Id = 144,
    Value = 
new System.SByte[3]
{
-65,
-115,
7,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-76,
-74,
118,
65,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-32,
-51,
-54,
-73,
},
},
            new SBytesmallintArray1M
{
    Id = 147,
    Value = 
new System.SByte[4]
{
73,
-66,
-41,
46,
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
11,
35,
93,
-44,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 83,
    Value = 
new System.SByte[4]
{
108,
-87,
-93,
-6,
},
    NullableValue = 
new System.SByte[4]
{
-31,
-84,
48,
62,
},
},
    NullableValue = null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
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
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                 ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
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
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                 ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[23],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 118;
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[23],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[24],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[25],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[26],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                 ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[29], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
            asPartInterface: typeof(ISByteArraysmallintArray)),
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 62, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 31, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                 ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 74, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var firstItems2 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                 ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 1, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[23],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.sbytesmallintarray1m m
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
FROM public.sbytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems1 = new List<FlatSBytesmallintArray1M>();
                var secondItems2 = new List<FlatSBytesmallintArray1M>();
                 ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 109, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 67, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[29], false);
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
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models = await ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
SBytesmallintArray1M.AssertModel(models[0],_testData[15], false);SBytesmallintArray1M.AssertModel(models[1],_testData[16], false);SBytesmallintArray1M.AssertModel(models[2],_testData[17], false);SBytesmallintArray1M.AssertModel(models[3],_testData[18], false);SBytesmallintArray1M.AssertModel(models[4],_testData[19], false);SBytesmallintArray1M.AssertModel(models[5],_testData[20], false);SBytesmallintArray1M.AssertModel(models[6],_testData[21], false);SBytesmallintArray1M.AssertModel(models[7],_testData[22], false);SBytesmallintArray1M.AssertModel(models[8],_testData[23], false);SBytesmallintArray1M.AssertModel(models[9],_testData[24], false);SBytesmallintArray1M.AssertModel(models[10],_testData[25], false);SBytesmallintArray1M.AssertModel(models[11],_testData[26], false);SBytesmallintArray1M.AssertModel(models[12],_testData[27], false);SBytesmallintArray1M.AssertModel(models[13],_testData[28], false);SBytesmallintArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
SBytesmallintArray1M.AssertModel(models[0],_testData[9], false);SBytesmallintArray1M.AssertModel(models[1],_testData[10], false);SBytesmallintArray1M.AssertModel(models[2],_testData[11], false);SBytesmallintArray1M.AssertModel(models[3],_testData[12], false);SBytesmallintArray1M.AssertModel(models[4],_testData[13], false);SBytesmallintArray1M.AssertModel(models[5],_testData[14], false);SBytesmallintArray1M.AssertModel(models[6],_testData[15], false);SBytesmallintArray1M.AssertModel(models[7],_testData[16], false);SBytesmallintArray1M.AssertModel(models[8],_testData[17], false);SBytesmallintArray1M.AssertModel(models[9],_testData[18], false);SBytesmallintArray1M.AssertModel(models[10],_testData[19], false);SBytesmallintArray1M.AssertModel(models[11],_testData[20], false);SBytesmallintArray1M.AssertModel(models[12],_testData[21], false);SBytesmallintArray1M.AssertModel(models[13],_testData[22], false);SBytesmallintArray1M.AssertModel(models[14],_testData[23], false);SBytesmallintArray1M.AssertModel(models[15],_testData[24], false);SBytesmallintArray1M.AssertModel(models[16],_testData[25], false);SBytesmallintArray1M.AssertModel(models[17],_testData[26], false);SBytesmallintArray1M.AssertModel(models[18],_testData[27], false);SBytesmallintArray1M.AssertModel(models[19],_testData[28], false);SBytesmallintArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.binary_sbytesmallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SBytesmallintArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteArraysmallintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteArraysmallintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteArraysmallintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteArraysmallintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
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
            queryMapType: typeof(SBytesmallintArray1MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteArraysmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteArraysmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallintArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteArraysmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteArraysmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(SBytesmallintArray1M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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


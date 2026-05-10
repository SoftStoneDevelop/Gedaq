

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
    Id = 2,
    Value = 
new System.SByte[3]
{
-20,
46,
-114,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 3,
    Value = 
new System.SByte[3]
{
-126,
-8,
-23,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 4,
    Value = 
new System.SByte[4]
{
61,
-7,
-57,
67,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-86,
-43,
-16,
3,
},
},
            new SBytesmallintArray1M
{
    Id = 4,
    Value = 
new System.SByte[3]
{
43,
85,
-80,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
95,
-56,
11,
-27,
},
},
            new SBytesmallintArray1M
{
    Id = 13,
    Value = 
new System.SByte[3]
{
-58,
75,
76,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 12,
    Value = 
new System.SByte[4]
{
26,
71,
10,
24,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
27,
-47,
22,
},
},
            new SBytesmallintArray1M
{
    Id = 21,
    Value = 
new System.SByte[3]
{
-25,
43,
-69,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-57,
-81,
-57,
},
},
            new SBytesmallintArray1M
{
    Id = 30,
    Value = 
new System.SByte[4]
{
32,
-57,
-115,
-72,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 17,
    Value = 
new System.SByte[3]
{
-68,
100,
5,
},
    NullableValue = 
new System.SByte[4]
{
121,
-96,
46,
-92,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 35,
    Value = 
new System.SByte[3]
{
36,
63,
110,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-56,
-119,
22,
70,
},
},
            new SBytesmallintArray1M
{
    Id = 42,
    Value = 
new System.SByte[4]
{
-84,
-6,
-16,
120,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 24,
    Value = 
new System.SByte[3]
{
-37,
68,
-47,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
35,
-33,
20,
},
},
            new SBytesmallintArray1M
{
    Id = 46,
    Value = 
new System.SByte[3]
{
-49,
-78,
-5,
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
53,
64,
43,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 28,
    Value = 
new System.SByte[3]
{
34,
-60,
38,
},
    NullableValue = 
new System.SByte[3]
{
-105,
-79,
-88,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 56,
    Value = 
new System.SByte[4]
{
39,
109,
11,
-11,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
12,
40,
51,
-104,
},
},
            new SBytesmallintArray1M
{
    Id = 65,
    Value = 
new System.SByte[4]
{
16,
25,
73,
-65,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 34,
    Value = 
new System.SByte[3]
{
48,
16,
18,
},
    NullableValue = 
new System.SByte[4]
{
-108,
6,
55,
47,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 69,
    Value = 
new System.SByte[3]
{
-122,
1,
101,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-15,
39,
46,
},
},
            new SBytesmallintArray1M
{
    Id = 71,
    Value = 
new System.SByte[3]
{
119,
44,
-91,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 43,
    Value = 
new System.SByte[4]
{
-70,
117,
47,
-12,
},
    NullableValue = 
new System.SByte[4]
{
-48,
65,
114,
-100,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 77,
    Value = 
new System.SByte[4]
{
-105,
74,
-75,
66,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 78,
    Value = 
new System.SByte[4]
{
-49,
50,
14,
74,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 44,
    Value = 
new System.SByte[4]
{
96,
80,
95,
117,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-39,
-53,
-24,
},
},
            new SBytesmallintArray1M
{
    Id = 86,
    Value = 
new System.SByte[3]
{
21,
-37,
-119,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 88,
    Value = 
new System.SByte[4]
{
84,
-124,
-50,
-67,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 51,
    Value = 
new System.SByte[3]
{
-51,
-57,
-15,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
17,
106,
75,
26,
},
},
            new SBytesmallintArray1M
{
    Id = 92,
    Value = 
new System.SByte[4]
{
-98,
120,
8,
-10,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 97,
    Value = 
new System.SByte[3]
{
68,
47,
16,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 59,
    Value = 
new System.SByte[3]
{
24,
-45,
-23,
},
    NullableValue = 
new System.SByte[3]
{
-33,
92,
-33,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 106,
    Value = 
new System.SByte[3]
{
115,
-88,
71,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 109,
    Value = 
new System.SByte[3]
{
-41,
-39,
28,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 61,
    Value = 
new System.SByte[3]
{
-30,
-6,
-26,
},
    NullableValue = 
new System.SByte[4]
{
86,
-61,
44,
53,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 112,
    Value = 
new System.SByte[3]
{
-56,
-108,
-82,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-95,
-56,
56,
-54,
},
},
            new SBytesmallintArray1M
{
    Id = 114,
    Value = 
new System.SByte[3]
{
-121,
117,
-5,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 69,
    Value = 
new System.SByte[4]
{
-128,
-3,
-82,
40,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 118,
    Value = 
new System.SByte[3]
{
-46,
5,
-126,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-11,
-99,
96,
90,
},
},
            new SBytesmallintArray1M
{
    Id = 126,
    Value = 
new System.SByte[3]
{
-125,
36,
122,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 72,
    Value = 
new System.SByte[4]
{
-73,
-69,
-20,
-46,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 135,
    Value = 
new System.SByte[4]
{
-118,
-98,
26,
-107,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 139,
    Value = 
new System.SByte[3]
{
35,
16,
-110,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 80,
    Value = 
new System.SByte[4]
{
108,
46,
-29,
39,
},
    NullableValue = 
new System.SByte[4]
{
-32,
-78,
86,
20,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 143,
    Value = 
new System.SByte[3]
{
-78,
88,
120,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 145,
    Value = 
new System.SByte[3]
{
-103,
-50,
-95,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 84,
    Value = 
new System.SByte[3]
{
116,
-2,
-13,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 149,
    Value = 
new System.SByte[4]
{
-85,
-13,
-64,
58,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 154,
    Value = 
new System.SByte[4]
{
-66,
-83,
-27,
-113,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 89,
    Value = 
new System.SByte[3]
{
-34,
-89,
-49,
},
    NullableValue = 
new System.SByte[4]
{
12,
-110,
-57,
94,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 162,
    Value = 
new System.SByte[3]
{
23,
-26,
-96,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-94,
-7,
42,
},
},
            new SBytesmallintArray1M
{
    Id = 167,
    Value = 
new System.SByte[4]
{
-38,
102,
-104,
-57,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 94,
    Value = 
new System.SByte[4]
{
126,
-6,
-23,
123,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-6,
1,
-37,
},
},
            new SBytesmallintArray1M
{
    Id = 170,
    Value = 
new System.SByte[3]
{
-128,
109,
-109,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-89,
8,
2,
99,
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

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
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
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 118;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        FlatSBytesmallintArray1M.AssertModel(models[28],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(models[29],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[30],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[31],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 55;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[23],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[34], false);
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
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[11], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[29], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[4], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[5], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[6], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[7], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[8], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[9], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[10], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[11], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[23],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[24],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[25],_testData[29], false);
                        SBytesmallintArray1M.AssertModel(models[26],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[27],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[28],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[29],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        SBytesmallintArray1M.AssertModel(models[15],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[1], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[2], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[3], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[4], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[5], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[6], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[7], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[8], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[9], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[10], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[11], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[23],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[24],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[25],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[26],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[27],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[28],_testData[29], false);
                        SBytesmallintArray1M.AssertModel(models[29],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[30],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[31],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[32],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[33],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 46, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 162, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 149, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[34], false);
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
                await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 106, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 154, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[34], false);
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
                 ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 154, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        SBytesmallintArray1M.AssertModel(models[16],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[29], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 112, 2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[29], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[1], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[2], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[3], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[4], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[5], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[6], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[7], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[8], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[9], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[10], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[11], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[23],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[24],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[25],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[26],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[27],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[28],_testData[29], false);
                        SBytesmallintArray1M.AssertModel(models[29],_testData[30], false);
                        SBytesmallintArray1M.AssertModel(models[30],_testData[31], false);
                        SBytesmallintArray1M.AssertModel(models[31],_testData[32], false);
                        SBytesmallintArray1M.AssertModel(models[32],_testData[33], false);
                        SBytesmallintArray1M.AssertModel(models[33],_testData[34], false);
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
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models = await ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                SBytesmallintArray1M.AssertModel(models[0],_testData[20], false);
                SBytesmallintArray1M.AssertModel(models[1],_testData[21], false);
                SBytesmallintArray1M.AssertModel(models[2],_testData[22], false);
                SBytesmallintArray1M.AssertModel(models[3],_testData[23], false);
                SBytesmallintArray1M.AssertModel(models[4],_testData[24], false);
                SBytesmallintArray1M.AssertModel(models[5],_testData[25], false);
                SBytesmallintArray1M.AssertModel(models[6],_testData[26], false);
                SBytesmallintArray1M.AssertModel(models[7],_testData[27], false);
                SBytesmallintArray1M.AssertModel(models[8],_testData[28], false);
                SBytesmallintArray1M.AssertModel(models[9],_testData[29], false);
                SBytesmallintArray1M.AssertModel(models[10],_testData[30], false);
                SBytesmallintArray1M.AssertModel(models[11],_testData[31], false);
                SBytesmallintArray1M.AssertModel(models[12],_testData[32], false);
                SBytesmallintArray1M.AssertModel(models[13],_testData[33], false);
                SBytesmallintArray1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                SBytesmallintArray1M.AssertModel(models[0],_testData[9], false);
                SBytesmallintArray1M.AssertModel(models[1],_testData[10], false);
                SBytesmallintArray1M.AssertModel(models[2],_testData[11], false);
                SBytesmallintArray1M.AssertModel(models[3],_testData[12], false);
                SBytesmallintArray1M.AssertModel(models[4],_testData[13], false);
                SBytesmallintArray1M.AssertModel(models[5],_testData[14], false);
                SBytesmallintArray1M.AssertModel(models[6],_testData[15], false);
                SBytesmallintArray1M.AssertModel(models[7],_testData[16], false);
                SBytesmallintArray1M.AssertModel(models[8],_testData[17], false);
                SBytesmallintArray1M.AssertModel(models[9],_testData[18], false);
                SBytesmallintArray1M.AssertModel(models[10],_testData[19], false);
                SBytesmallintArray1M.AssertModel(models[11],_testData[20], false);
                SBytesmallintArray1M.AssertModel(models[12],_testData[21], false);
                SBytesmallintArray1M.AssertModel(models[13],_testData[22], false);
                SBytesmallintArray1M.AssertModel(models[14],_testData[23], false);
                SBytesmallintArray1M.AssertModel(models[15],_testData[24], false);
                SBytesmallintArray1M.AssertModel(models[16],_testData[25], false);
                SBytesmallintArray1M.AssertModel(models[17],_testData[26], false);
                SBytesmallintArray1M.AssertModel(models[18],_testData[27], false);
                SBytesmallintArray1M.AssertModel(models[19],_testData[28], false);
                SBytesmallintArray1M.AssertModel(models[20],_testData[29], false);
                SBytesmallintArray1M.AssertModel(models[21],_testData[30], false);
                SBytesmallintArray1M.AssertModel(models[22],_testData[31], false);
                SBytesmallintArray1M.AssertModel(models[23],_testData[32], false);
                SBytesmallintArray1M.AssertModel(models[24],_testData[33], false);
                SBytesmallintArray1M.AssertModel(models[25],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((ISByteArraysmallintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteArraysmallintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((ISByteArraysmallintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteArraysmallintArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteArraysmallintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteArraysmallintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteArraysmallintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISByteArraysmallintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(SBytesmallintArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((ISByteArraysmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteArraysmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((ISByteArraysmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteArraysmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISByteArraysmallintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISByteArraysmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISByteArraysmallintArray)this).ImportModel(connection, importCollection);
                var models = ((ISByteArraysmallintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA), typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MIWA>();
                var models2 = new List<SBytesmallintArray1MIWA>();
                await ((ISByteArraysmallintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MIWA>();
                var models2 = new List<SBytesmallintArray1MIWA>();
                ((ISByteArraysmallintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISByteArraysmallintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISByteArraysmallintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA), typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MIWA>();
                var models2 = new List<SBytesmallintArray1MIWA>();
                await ((ISByteArraysmallintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MIWA>();
                var models2 = new List<SBytesmallintArray1MIWA>();
                ((ISByteArraysmallintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISByteArraysmallintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISByteArraysmallintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MI), typeof(SBytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MI>();
                var models2 = new List<SBytesmallintArray1MI>();
                await ((ISByteArraysmallintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MI>();
                var models2 = new List<SBytesmallintArray1MI>();
                ((ISByteArraysmallintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630),
                (NpgsqlTypes.NpgsqlDbType)(-2147483630)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISByteArraysmallintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISByteArraysmallintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA), typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MIWA>();
                var models2 = new List<SBytesmallintArray1MIWA>();
                await ((ISByteArraysmallintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<SBytesmallintArray1MIWA>();
                var models2 = new List<SBytesmallintArray1MIWA>();
                ((ISByteArraysmallintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteArraysmallintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISByteArraysmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISByteArraysmallintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


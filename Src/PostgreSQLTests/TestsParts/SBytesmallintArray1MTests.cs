

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
new System.SByte[3]
{
71,
21,
9,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 7,
    Value = 
new System.SByte[4]
{
79,
-94,
9,
-44,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 1,
    Value = 
new System.SByte[4]
{
53,
109,
-76,
120,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 12,
    Value = 
new System.SByte[3]
{
-89,
105,
40,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 15,
    Value = 
new System.SByte[4]
{
-6,
-21,
58,
121,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 5,
    Value = 
new System.SByte[4]
{
-61,
23,
3,
32,
},
    NullableValue = 
new System.SByte[3]
{
75,
-40,
-111,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 20,
    Value = 
new System.SByte[4]
{
-109,
62,
-76,
40,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
64,
-4,
-10,
},
},
            new SBytesmallintArray1M
{
    Id = 27,
    Value = 
new System.SByte[4]
{
-2,
-81,
65,
22,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 7,
    Value = 
new System.SByte[4]
{
-16,
2,
101,
25,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 30,
    Value = 
new System.SByte[4]
{
119,
-5,
101,
-110,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-5,
-55,
-119,
-102,
},
},
            new SBytesmallintArray1M
{
    Id = 37,
    Value = 
new System.SByte[3]
{
-75,
-122,
102,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 16,
    Value = 
new System.SByte[4]
{
-18,
-64,
25,
-118,
},
    NullableValue = 
new System.SByte[3]
{
-36,
115,
-127,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 40,
    Value = 
new System.SByte[3]
{
-94,
41,
-50,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 45,
    Value = 
new System.SByte[3]
{
117,
83,
-89,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 23,
    Value = 
new System.SByte[4]
{
80,
101,
77,
12,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-67,
61,
-68,
},
},
            new SBytesmallintArray1M
{
    Id = 47,
    Value = 
new System.SByte[3]
{
-123,
-3,
-35,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
41,
86,
112,
},
},
            new SBytesmallintArray1M
{
    Id = 52,
    Value = 
new System.SByte[3]
{
101,
-12,
-72,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 32,
    Value = 
new System.SByte[4]
{
91,
52,
126,
-100,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 59,
    Value = 
new System.SByte[3]
{
-83,
-6,
14,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 62,
    Value = 
new System.SByte[3]
{
34,
38,
123,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 37,
    Value = 
new System.SByte[3]
{
-19,
46,
-84,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-69,
-33,
-76,
},
},
            new SBytesmallintArray1M
{
    Id = 71,
    Value = 
new System.SByte[3]
{
-59,
-95,
-39,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
10,
14,
-43,
29,
},
},
            new SBytesmallintArray1M
{
    Id = 74,
    Value = 
new System.SByte[4]
{
-74,
84,
-17,
1,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 38,
    Value = 
new System.SByte[4]
{
35,
45,
41,
-20,
},
    NullableValue = 
new System.SByte[4]
{
-88,
123,
80,
-17,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 80,
    Value = 
new System.SByte[4]
{
100,
-29,
120,
-98,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-47,
30,
45,
56,
},
},
            new SBytesmallintArray1M
{
    Id = 82,
    Value = 
new System.SByte[3]
{
124,
11,
93,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 42,
    Value = 
new System.SByte[3]
{
5,
-97,
-66,
},
    NullableValue = 
new System.SByte[3]
{
-106,
81,
-37,
},
},
    NullableValue = 
new System.SByte[4]
{
-38,
-31,
16,
115,
},
},
            new SBytesmallintArray1M
{
    Id = 90,
    Value = 
new System.SByte[4]
{
7,
92,
-10,
-72,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 96,
    Value = 
new System.SByte[3]
{
101,
70,
1,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 44,
    Value = 
new System.SByte[3]
{
10,
-95,
73,
},
    NullableValue = 
new System.SByte[4]
{
-42,
100,
-2,
-40,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 100,
    Value = 
new System.SByte[3]
{
116,
-7,
74,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 102,
    Value = 
new System.SByte[3]
{
7,
-2,
-91,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 47,
    Value = 
new System.SByte[4]
{
75,
-128,
79,
-98,
},
    NullableValue = 
new System.SByte[4]
{
12,
-63,
28,
-100,
},
},
    NullableValue = 
new System.SByte[3]
{
126,
102,
-62,
},
},
            new SBytesmallintArray1M
{
    Id = 106,
    Value = 
new System.SByte[4]
{
-118,
-125,
-22,
105,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-14,
-76,
-116,
},
},
            new SBytesmallintArray1M
{
    Id = 115,
    Value = 
new System.SByte[3]
{
96,
103,
-71,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 50,
    Value = 
new System.SByte[4]
{
-53,
38,
55,
-7,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 123,
    Value = 
new System.SByte[4]
{
32,
54,
8,
-110,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 125,
    Value = 
new System.SByte[3]
{
-21,
117,
-66,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 56,
    Value = 
new System.SByte[3]
{
-72,
96,
97,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
-61,
79,
94,
-83,
},
},
            new SBytesmallintArray1M
{
    Id = 130,
    Value = 
new System.SByte[4]
{
39,
17,
-61,
93,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 131,
    Value = 
new System.SByte[3]
{
-54,
47,
58,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 62,
    Value = 
new System.SByte[4]
{
111,
81,
-59,
-91,
},
    NullableValue = 
new System.SByte[3]
{
67,
-14,
-66,
},
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 136,
    Value = 
new System.SByte[4]
{
-105,
-128,
-57,
-6,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 137,
    Value = 
new System.SByte[4]
{
93,
-49,
8,
68,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 66,
    Value = 
new System.SByte[3]
{
-67,
-75,
54,
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                parametr2.Value = 102;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[7], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[8], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[9], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[10], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[11], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[29], false);
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
                await ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                await ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems2[6],_testData[29], false);
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
                 ((ISByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
                 ((ISByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[29], false);
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
                await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 74, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSBytesmallintArray1M.AssertModel(models[0],_testData[3], false);
                        FlatSBytesmallintArray1M.AssertModel(models[1],_testData[4], false);
                        FlatSBytesmallintArray1M.AssertModel(models[2],_testData[5], false);
                        FlatSBytesmallintArray1M.AssertModel(models[3],_testData[6], false);
                        FlatSBytesmallintArray1M.AssertModel(models[4],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(models[5],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(models[6],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(models[7],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(models[8],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(models[9],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(models[10],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(models[11],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(models[12],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(models[13],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(models[14],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(models[15],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(models[16],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(models[17],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(models[18],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(models[19],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(models[20],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(models[21],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(models[22],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(models[23],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(models[24],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(models[25],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(models[26],_testData[29], false);
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
                 ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSBytesmallintArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[6], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[7], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[8], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[9], false);
                        SBytesmallintArray1M.AssertModel(models[4],_testData[10], false);
                        SBytesmallintArray1M.AssertModel(models[5],_testData[11], false);
                        SBytesmallintArray1M.AssertModel(models[6],_testData[12], false);
                        SBytesmallintArray1M.AssertModel(models[7],_testData[13], false);
                        SBytesmallintArray1M.AssertModel(models[8],_testData[14], false);
                        SBytesmallintArray1M.AssertModel(models[9],_testData[15], false);
                        SBytesmallintArray1M.AssertModel(models[10],_testData[16], false);
                        SBytesmallintArray1M.AssertModel(models[11],_testData[17], false);
                        SBytesmallintArray1M.AssertModel(models[12],_testData[18], false);
                        SBytesmallintArray1M.AssertModel(models[13],_testData[19], false);
                        SBytesmallintArray1M.AssertModel(models[14],_testData[20], false);
                        SBytesmallintArray1M.AssertModel(models[15],_testData[21], false);
                        SBytesmallintArray1M.AssertModel(models[16],_testData[22], false);
                        SBytesmallintArray1M.AssertModel(models[17],_testData[23], false);
                        SBytesmallintArray1M.AssertModel(models[18],_testData[24], false);
                        SBytesmallintArray1M.AssertModel(models[19],_testData[25], false);
                        SBytesmallintArray1M.AssertModel(models[20],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[21],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[22],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SBytesmallintArray1M.AssertModel(models[0],_testData[26], false);
                        SBytesmallintArray1M.AssertModel(models[1],_testData[27], false);
                        SBytesmallintArray1M.AssertModel(models[2],_testData[28], false);
                        SBytesmallintArray1M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 71, 131))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
SBytesmallintArray1M.AssertModel(models[0],_testData[9], false);SBytesmallintArray1M.AssertModel(models[1],_testData[10], false);SBytesmallintArray1M.AssertModel(models[2],_testData[11], false);SBytesmallintArray1M.AssertModel(models[3],_testData[12], false);SBytesmallintArray1M.AssertModel(models[4],_testData[13], false);SBytesmallintArray1M.AssertModel(models[5],_testData[14], false);SBytesmallintArray1M.AssertModel(models[6],_testData[15], false);SBytesmallintArray1M.AssertModel(models[7],_testData[16], false);SBytesmallintArray1M.AssertModel(models[8],_testData[17], false);SBytesmallintArray1M.AssertModel(models[9],_testData[18], false);SBytesmallintArray1M.AssertModel(models[10],_testData[19], false);SBytesmallintArray1M.AssertModel(models[11],_testData[20], false);SBytesmallintArray1M.AssertModel(models[12],_testData[21], false);SBytesmallintArray1M.AssertModel(models[13],_testData[22], false);SBytesmallintArray1M.AssertModel(models[14],_testData[23], false);SBytesmallintArray1M.AssertModel(models[15],_testData[24], false);SBytesmallintArray1M.AssertModel(models[16],_testData[25], false);SBytesmallintArray1M.AssertModel(models[17],_testData[26], false);SBytesmallintArray1M.AssertModel(models[18],_testData[27], false);SBytesmallintArray1M.AssertModel(models[19],_testData[28], false);SBytesmallintArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
SBytesmallintArray1M.AssertModel(models[0],_testData[14], false);SBytesmallintArray1M.AssertModel(models[1],_testData[15], false);SBytesmallintArray1M.AssertModel(models[2],_testData[16], false);SBytesmallintArray1M.AssertModel(models[3],_testData[17], false);SBytesmallintArray1M.AssertModel(models[4],_testData[18], false);SBytesmallintArray1M.AssertModel(models[5],_testData[19], false);SBytesmallintArray1M.AssertModel(models[6],_testData[20], false);SBytesmallintArray1M.AssertModel(models[7],_testData[21], false);SBytesmallintArray1M.AssertModel(models[8],_testData[22], false);SBytesmallintArray1M.AssertModel(models[9],_testData[23], false);SBytesmallintArray1M.AssertModel(models[10],_testData[24], false);SBytesmallintArray1M.AssertModel(models[11],_testData[25], false);SBytesmallintArray1M.AssertModel(models[12],_testData[26], false);SBytesmallintArray1M.AssertModel(models[13],_testData[27], false);SBytesmallintArray1M.AssertModel(models[14],_testData[28], false);SBytesmallintArray1M.AssertModel(models[15],_testData[29], false);
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


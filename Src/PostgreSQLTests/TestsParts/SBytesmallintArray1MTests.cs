

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
-68,
38,
-12,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
74,
93,
-87,
},
},
            new SBytesmallintArray1M
{
    Id = 12,
    Value = 
new System.SByte[4]
{
-96,
114,
120,
-27,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 8,
    Value = 
new System.SByte[3]
{
31,
-103,
123,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 18,
    Value = 
new System.SByte[4]
{
-97,
-81,
-122,
114,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 22,
    Value = 
new System.SByte[4]
{
63,
-6,
-43,
54,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 16,
    Value = 
new System.SByte[3]
{
-43,
104,
65,
},
    NullableValue = 
new System.SByte[4]
{
-73,
108,
-102,
-44,
},
},
    NullableValue = 
new System.SByte[4]
{
124,
-120,
-57,
101,
},
},
            new SBytesmallintArray1M
{
    Id = 24,
    Value = 
new System.SByte[3]
{
60,
88,
-12,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 30,
    Value = 
new System.SByte[3]
{
66,
26,
-7,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 18,
    Value = 
new System.SByte[3]
{
42,
-39,
98,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
103,
28,
-17,
},
},
            new SBytesmallintArray1M
{
    Id = 36,
    Value = 
new System.SByte[4]
{
92,
15,
-9,
-80,
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
84,
105,
71,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 20,
    Value = 
new System.SByte[4]
{
92,
86,
-32,
107,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 52,
    Value = 
new System.SByte[3]
{
-71,
-120,
36,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 55,
    Value = 
new System.SByte[4]
{
-58,
66,
85,
21,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 21,
    Value = 
new System.SByte[4]
{
71,
-123,
43,
36,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 64,
    Value = 
new System.SByte[4]
{
41,
6,
-92,
39,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 71,
    Value = 
new System.SByte[4]
{
40,
-6,
61,
47,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 24,
    Value = 
new System.SByte[3]
{
75,
68,
-60,
},
    NullableValue = 
new System.SByte[3]
{
103,
21,
39,
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
-68,
89,
-12,
-16,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 83,
    Value = 
new System.SByte[3]
{
-127,
-14,
-10,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 27,
    Value = 
new System.SByte[3]
{
-85,
-89,
-93,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-111,
123,
50,
},
},
            new SBytesmallintArray1M
{
    Id = 89,
    Value = 
new System.SByte[4]
{
71,
63,
-118,
7,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-41,
-24,
-97,
12,
},
},
            new SBytesmallintArray1M
{
    Id = 97,
    Value = 
new System.SByte[4]
{
53,
113,
94,
55,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 31,
    Value = 
new System.SByte[4]
{
-64,
81,
-29,
114,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 101,
    Value = 
new System.SByte[4]
{
-66,
100,
51,
89,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
33,
33,
104,
},
},
            new SBytesmallintArray1M
{
    Id = 110,
    Value = 
new System.SByte[3]
{
-17,
-90,
-22,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 38,
    Value = 
new System.SByte[3]
{
24,
84,
110,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 116,
    Value = 
new System.SByte[4]
{
40,
-123,
120,
-4,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 120,
    Value = 
new System.SByte[4]
{
110,
-126,
31,
62,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 43,
    Value = 
new System.SByte[4]
{
-96,
7,
42,
-1,
},
    NullableValue = 
new System.SByte[3]
{
-111,
-34,
41,
},
},
    NullableValue = 
new System.SByte[4]
{
84,
36,
-59,
39,
},
},
            new SBytesmallintArray1M
{
    Id = 122,
    Value = 
new System.SByte[4]
{
-47,
121,
9,
112,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 124,
    Value = 
new System.SByte[3]
{
78,
107,
126,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 48,
    Value = 
new System.SByte[4]
{
-121,
35,
-62,
82,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 125,
    Value = 
new System.SByte[4]
{
-122,
-119,
-126,
-80,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 127,
    Value = 
new System.SByte[3]
{
93,
25,
-53,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 50,
    Value = 
new System.SByte[3]
{
-67,
107,
65,
},
    NullableValue = 
new System.SByte[4]
{
26,
-17,
98,
108,
},
},
    NullableValue = 
new System.SByte[4]
{
-81,
88,
-67,
35,
},
},
            new SBytesmallintArray1M
{
    Id = 131,
    Value = 
new System.SByte[4]
{
-27,
-84,
42,
-32,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 134,
    Value = 
new System.SByte[3]
{
95,
-70,
-6,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 53,
    Value = 
new System.SByte[3]
{
15,
44,
67,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 140,
    Value = 
new System.SByte[3]
{
-66,
-91,
-32,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
2,
-8,
114,
},
},
            new SBytesmallintArray1M
{
    Id = 147,
    Value = 
new System.SByte[3]
{
91,
-94,
-18,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 60,
    Value = 
new System.SByte[3]
{
-122,
55,
108,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 155,
    Value = 
new System.SByte[3]
{
18,
-72,
-34,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintArray1M
{
    Id = 160,
    Value = 
new System.SByte[3]
{
120,
46,
65,
},
    ModelInner = new SBytesmallintArray1MI
{
    Id = 61,
    Value = 
new System.SByte[4]
{
46,
34,
41,
-62,
},
    NullableValue = 
new System.SByte[4]
{
110,
-26,
-99,
-117,
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ISByteArraysmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((ISByteArraysmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ISByteArraysmallintArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((ISByteArraysmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintarray1m m
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(18));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[29], false);
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 131;
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(5));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[29], false);
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

                var models = await ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
SBytesmallintArray1M.AssertModel(models[0],_testData[15], false);SBytesmallintArray1M.AssertModel(models[1],_testData[16], false);SBytesmallintArray1M.AssertModel(models[2],_testData[17], false);SBytesmallintArray1M.AssertModel(models[3],_testData[18], false);SBytesmallintArray1M.AssertModel(models[4],_testData[19], false);SBytesmallintArray1M.AssertModel(models[5],_testData[20], false);SBytesmallintArray1M.AssertModel(models[6],_testData[21], false);SBytesmallintArray1M.AssertModel(models[7],_testData[22], false);SBytesmallintArray1M.AssertModel(models[8],_testData[23], false);SBytesmallintArray1M.AssertModel(models[9],_testData[24], false);SBytesmallintArray1M.AssertModel(models[10],_testData[25], false);SBytesmallintArray1M.AssertModel(models[11],_testData[26], false);SBytesmallintArray1M.AssertModel(models[12],_testData[27], false);SBytesmallintArray1M.AssertModel(models[13],_testData[28], false);SBytesmallintArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
SBytesmallintArray1M.AssertModel(models[0],_testData[13], false);SBytesmallintArray1M.AssertModel(models[1],_testData[14], false);SBytesmallintArray1M.AssertModel(models[2],_testData[15], false);SBytesmallintArray1M.AssertModel(models[3],_testData[16], false);SBytesmallintArray1M.AssertModel(models[4],_testData[17], false);SBytesmallintArray1M.AssertModel(models[5],_testData[18], false);SBytesmallintArray1M.AssertModel(models[6],_testData[19], false);SBytesmallintArray1M.AssertModel(models[7],_testData[20], false);SBytesmallintArray1M.AssertModel(models[8],_testData[21], false);SBytesmallintArray1M.AssertModel(models[9],_testData[22], false);SBytesmallintArray1M.AssertModel(models[10],_testData[23], false);SBytesmallintArray1M.AssertModel(models[11],_testData[24], false);SBytesmallintArray1M.AssertModel(models[12],_testData[25], false);SBytesmallintArray1M.AssertModel(models[13],_testData[26], false);SBytesmallintArray1M.AssertModel(models[14],_testData[27], false);SBytesmallintArray1M.AssertModel(models[15],_testData[28], false);SBytesmallintArray1M.AssertModel(models[16],_testData[29], false);
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

                var models =  ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
SBytesmallintArray1M.AssertModel(models[0],_testData[13], false);SBytesmallintArray1M.AssertModel(models[1],_testData[14], false);SBytesmallintArray1M.AssertModel(models[2],_testData[15], false);SBytesmallintArray1M.AssertModel(models[3],_testData[16], false);SBytesmallintArray1M.AssertModel(models[4],_testData[17], false);SBytesmallintArray1M.AssertModel(models[5],_testData[18], false);SBytesmallintArray1M.AssertModel(models[6],_testData[19], false);SBytesmallintArray1M.AssertModel(models[7],_testData[20], false);SBytesmallintArray1M.AssertModel(models[8],_testData[21], false);SBytesmallintArray1M.AssertModel(models[9],_testData[22], false);SBytesmallintArray1M.AssertModel(models[10],_testData[23], false);SBytesmallintArray1M.AssertModel(models[11],_testData[24], false);SBytesmallintArray1M.AssertModel(models[12],_testData[25], false);SBytesmallintArray1M.AssertModel(models[13],_testData[26], false);SBytesmallintArray1M.AssertModel(models[14],_testData[27], false);SBytesmallintArray1M.AssertModel(models[15],_testData[28], false);SBytesmallintArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
SBytesmallintArray1M.AssertModel(models[0],_testData[16], false);SBytesmallintArray1M.AssertModel(models[1],_testData[17], false);SBytesmallintArray1M.AssertModel(models[2],_testData[18], false);SBytesmallintArray1M.AssertModel(models[3],_testData[19], false);SBytesmallintArray1M.AssertModel(models[4],_testData[20], false);SBytesmallintArray1M.AssertModel(models[5],_testData[21], false);SBytesmallintArray1M.AssertModel(models[6],_testData[22], false);SBytesmallintArray1M.AssertModel(models[7],_testData[23], false);SBytesmallintArray1M.AssertModel(models[8],_testData[24], false);SBytesmallintArray1M.AssertModel(models[9],_testData[25], false);SBytesmallintArray1M.AssertModel(models[10],_testData[26], false);SBytesmallintArray1M.AssertModel(models[11],_testData[27], false);SBytesmallintArray1M.AssertModel(models[12],_testData[28], false);SBytesmallintArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 134, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[29], false);
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
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
LEFT JOIN public.sbytesmallintarray1mi mi ON mi.id = m.sbytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 140, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatSBytesmallintArray1M.AssertModel(models[0],_testData[6], false);FlatSBytesmallintArray1M.AssertModel(models[1],_testData[7], false);FlatSBytesmallintArray1M.AssertModel(models[2],_testData[8], false);FlatSBytesmallintArray1M.AssertModel(models[3],_testData[9], false);FlatSBytesmallintArray1M.AssertModel(models[4],_testData[10], false);FlatSBytesmallintArray1M.AssertModel(models[5],_testData[11], false);FlatSBytesmallintArray1M.AssertModel(models[6],_testData[12], false);FlatSBytesmallintArray1M.AssertModel(models[7],_testData[13], false);FlatSBytesmallintArray1M.AssertModel(models[8],_testData[14], false);FlatSBytesmallintArray1M.AssertModel(models[9],_testData[15], false);FlatSBytesmallintArray1M.AssertModel(models[10],_testData[16], false);FlatSBytesmallintArray1M.AssertModel(models[11],_testData[17], false);FlatSBytesmallintArray1M.AssertModel(models[12],_testData[18], false);FlatSBytesmallintArray1M.AssertModel(models[13],_testData[19], false);FlatSBytesmallintArray1M.AssertModel(models[14],_testData[20], false);FlatSBytesmallintArray1M.AssertModel(models[15],_testData[21], false);FlatSBytesmallintArray1M.AssertModel(models[16],_testData[22], false);FlatSBytesmallintArray1M.AssertModel(models[17],_testData[23], false);FlatSBytesmallintArray1M.AssertModel(models[18],_testData[24], false);FlatSBytesmallintArray1M.AssertModel(models[19],_testData[25], false);FlatSBytesmallintArray1M.AssertModel(models[20],_testData[26], false);FlatSBytesmallintArray1M.AssertModel(models[21],_testData[27], false);FlatSBytesmallintArray1M.AssertModel(models[22],_testData[28], false);FlatSBytesmallintArray1M.AssertModel(models[23],_testData[29], false);
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
                var models = await ((ISByteArraysmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((ISByteArraysmallintArray)this).DbConnectionSelectModelBatchAsync(connection, 71, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
SBytesmallintArray1M.AssertModel(models[0],_testData[12], false);SBytesmallintArray1M.AssertModel(models[1],_testData[13], false);SBytesmallintArray1M.AssertModel(models[2],_testData[14], false);SBytesmallintArray1M.AssertModel(models[3],_testData[15], false);SBytesmallintArray1M.AssertModel(models[4],_testData[16], false);SBytesmallintArray1M.AssertModel(models[5],_testData[17], false);SBytesmallintArray1M.AssertModel(models[6],_testData[18], false);SBytesmallintArray1M.AssertModel(models[7],_testData[19], false);SBytesmallintArray1M.AssertModel(models[8],_testData[20], false);SBytesmallintArray1M.AssertModel(models[9],_testData[21], false);SBytesmallintArray1M.AssertModel(models[10],_testData[22], false);SBytesmallintArray1M.AssertModel(models[11],_testData[23], false);SBytesmallintArray1M.AssertModel(models[12],_testData[24], false);SBytesmallintArray1M.AssertModel(models[13],_testData[25], false);SBytesmallintArray1M.AssertModel(models[14],_testData[26], false);SBytesmallintArray1M.AssertModel(models[15],_testData[27], false);SBytesmallintArray1M.AssertModel(models[16],_testData[28], false);SBytesmallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
SBytesmallintArray1M.AssertModel(models[0],_testData[13], false);SBytesmallintArray1M.AssertModel(models[1],_testData[14], false);SBytesmallintArray1M.AssertModel(models[2],_testData[15], false);SBytesmallintArray1M.AssertModel(models[3],_testData[16], false);SBytesmallintArray1M.AssertModel(models[4],_testData[17], false);SBytesmallintArray1M.AssertModel(models[5],_testData[18], false);SBytesmallintArray1M.AssertModel(models[6],_testData[19], false);SBytesmallintArray1M.AssertModel(models[7],_testData[20], false);SBytesmallintArray1M.AssertModel(models[8],_testData[21], false);SBytesmallintArray1M.AssertModel(models[9],_testData[22], false);SBytesmallintArray1M.AssertModel(models[10],_testData[23], false);SBytesmallintArray1M.AssertModel(models[11],_testData[24], false);SBytesmallintArray1M.AssertModel(models[12],_testData[25], false);SBytesmallintArray1M.AssertModel(models[13],_testData[26], false);SBytesmallintArray1M.AssertModel(models[14],_testData[27], false);SBytesmallintArray1M.AssertModel(models[15],_testData[28], false);SBytesmallintArray1M.AssertModel(models[16],_testData[29], false);
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
                var models =  ((ISByteArraysmallintArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((ISByteArraysmallintArray)this).DbConnectionSelectModelBatch(connection, 89, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
SBytesmallintArray1M.AssertModel(models[0],_testData[15], false);SBytesmallintArray1M.AssertModel(models[1],_testData[16], false);SBytesmallintArray1M.AssertModel(models[2],_testData[17], false);SBytesmallintArray1M.AssertModel(models[3],_testData[18], false);SBytesmallintArray1M.AssertModel(models[4],_testData[19], false);SBytesmallintArray1M.AssertModel(models[5],_testData[20], false);SBytesmallintArray1M.AssertModel(models[6],_testData[21], false);SBytesmallintArray1M.AssertModel(models[7],_testData[22], false);SBytesmallintArray1M.AssertModel(models[8],_testData[23], false);SBytesmallintArray1M.AssertModel(models[9],_testData[24], false);SBytesmallintArray1M.AssertModel(models[10],_testData[25], false);SBytesmallintArray1M.AssertModel(models[11],_testData[26], false);SBytesmallintArray1M.AssertModel(models[12],_testData[27], false);SBytesmallintArray1M.AssertModel(models[13],_testData[28], false);SBytesmallintArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
SBytesmallintArray1M.AssertModel(models[0],_testData[26], false);SBytesmallintArray1M.AssertModel(models[1],_testData[27], false);SBytesmallintArray1M.AssertModel(models[2],_testData[28], false);SBytesmallintArray1M.AssertModel(models[3],_testData[29], false);
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
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
SBytesmallintArray1M.AssertModel(models[0],_testData[7], false);SBytesmallintArray1M.AssertModel(models[1],_testData[8], false);SBytesmallintArray1M.AssertModel(models[2],_testData[9], false);SBytesmallintArray1M.AssertModel(models[3],_testData[10], false);SBytesmallintArray1M.AssertModel(models[4],_testData[11], false);SBytesmallintArray1M.AssertModel(models[5],_testData[12], false);SBytesmallintArray1M.AssertModel(models[6],_testData[13], false);SBytesmallintArray1M.AssertModel(models[7],_testData[14], false);SBytesmallintArray1M.AssertModel(models[8],_testData[15], false);SBytesmallintArray1M.AssertModel(models[9],_testData[16], false);SBytesmallintArray1M.AssertModel(models[10],_testData[17], false);SBytesmallintArray1M.AssertModel(models[11],_testData[18], false);SBytesmallintArray1M.AssertModel(models[12],_testData[19], false);SBytesmallintArray1M.AssertModel(models[13],_testData[20], false);SBytesmallintArray1M.AssertModel(models[14],_testData[21], false);SBytesmallintArray1M.AssertModel(models[15],_testData[22], false);SBytesmallintArray1M.AssertModel(models[16],_testData[23], false);SBytesmallintArray1M.AssertModel(models[17],_testData[24], false);SBytesmallintArray1M.AssertModel(models[18],_testData[25], false);SBytesmallintArray1M.AssertModel(models[19],_testData[26], false);SBytesmallintArray1M.AssertModel(models[20],_testData[27], false);SBytesmallintArray1M.AssertModel(models[21],_testData[28], false);SBytesmallintArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((ISByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
SBytesmallintArray1M.AssertModel(models[0],_testData[9], false);SBytesmallintArray1M.AssertModel(models[1],_testData[10], false);SBytesmallintArray1M.AssertModel(models[2],_testData[11], false);SBytesmallintArray1M.AssertModel(models[3],_testData[12], false);SBytesmallintArray1M.AssertModel(models[4],_testData[13], false);SBytesmallintArray1M.AssertModel(models[5],_testData[14], false);SBytesmallintArray1M.AssertModel(models[6],_testData[15], false);SBytesmallintArray1M.AssertModel(models[7],_testData[16], false);SBytesmallintArray1M.AssertModel(models[8],_testData[17], false);SBytesmallintArray1M.AssertModel(models[9],_testData[18], false);SBytesmallintArray1M.AssertModel(models[10],_testData[19], false);SBytesmallintArray1M.AssertModel(models[11],_testData[20], false);SBytesmallintArray1M.AssertModel(models[12],_testData[21], false);SBytesmallintArray1M.AssertModel(models[13],_testData[22], false);SBytesmallintArray1M.AssertModel(models[14],_testData[23], false);SBytesmallintArray1M.AssertModel(models[15],_testData[24], false);SBytesmallintArray1M.AssertModel(models[16],_testData[25], false);SBytesmallintArray1M.AssertModel(models[17],_testData[26], false);SBytesmallintArray1M.AssertModel(models[18],_testData[27], false);SBytesmallintArray1M.AssertModel(models[19],_testData[28], false);SBytesmallintArray1M.AssertModel(models[20],_testData[29], false);
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


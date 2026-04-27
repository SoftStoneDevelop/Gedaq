

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
    internal partial interface IByteArraysmallintArray
    {
    }
    
    internal partial class ByteArraysmallintArray : IByteArraysmallintArray
    {


#region TestData

        private readonly BytesmallintArray1M[] _testData = new BytesmallintArray1M[]
        {
            new BytesmallintArray1M
{
    Id = 4,
    Value = 
new System.Byte[3]
{
184,
221,
138,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 9,
    Value = 
new System.Byte[3]
{
129,
234,
170,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 4,
    Value = 
new System.Byte[3]
{
187,
245,
207,
},
    NullableValue = 
new System.Byte[4]
{
152,
165,
137,
8,
},
},
    NullableValue = 
new System.Byte[3]
{
40,
12,
157,
},
},
            new BytesmallintArray1M
{
    Id = 16,
    Value = 
new System.Byte[4]
{
9,
50,
6,
118,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 19,
    Value = 
new System.Byte[3]
{
235,
120,
5,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 5,
    Value = 
new System.Byte[4]
{
204,
46,
25,
226,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
208,
111,
13,
86,
},
},
            new BytesmallintArray1M
{
    Id = 26,
    Value = 
new System.Byte[3]
{
40,
158,
189,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 28,
    Value = 
new System.Byte[4]
{
49,
208,
233,
67,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 8,
    Value = 
new System.Byte[3]
{
160,
240,
52,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 30,
    Value = 
new System.Byte[4]
{
208,
242,
251,
91,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 37,
    Value = 
new System.Byte[4]
{
131,
242,
191,
19,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 14,
    Value = 
new System.Byte[4]
{
55,
81,
106,
44,
},
    NullableValue = 
new System.Byte[4]
{
224,
127,
71,
136,
},
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 39,
    Value = 
new System.Byte[3]
{
57,
5,
214,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[4]
{
28,
86,
73,
140,
},
},
            new BytesmallintArray1M
{
    Id = 47,
    Value = 
new System.Byte[4]
{
170,
24,
36,
133,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 17,
    Value = 
new System.Byte[4]
{
32,
187,
147,
44,
},
    NullableValue = 
new System.Byte[4]
{
16,
247,
119,
0,
},
},
    NullableValue = 
new System.Byte[3]
{
228,
163,
95,
},
},
            new BytesmallintArray1M
{
    Id = 54,
    Value = 
new System.Byte[4]
{
115,
30,
143,
69,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 55,
    Value = 
new System.Byte[4]
{
252,
161,
237,
157,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 19,
    Value = 
new System.Byte[3]
{
163,
56,
48,
},
    NullableValue = 
new System.Byte[4]
{
140,
121,
160,
6,
},
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 64,
    Value = 
new System.Byte[3]
{
183,
40,
103,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 70,
    Value = 
new System.Byte[4]
{
190,
29,
203,
51,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 20,
    Value = 
new System.Byte[4]
{
247,
13,
244,
252,
},
    NullableValue = 
new System.Byte[3]
{
181,
245,
23,
},
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 78,
    Value = 
new System.Byte[4]
{
71,
92,
0,
202,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
174,
135,
191,
},
},
            new BytesmallintArray1M
{
    Id = 80,
    Value = 
new System.Byte[4]
{
40,
156,
58,
160,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 29,
    Value = 
new System.Byte[3]
{
48,
62,
30,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 84,
    Value = 
new System.Byte[3]
{
186,
110,
100,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 90,
    Value = 
new System.Byte[3]
{
25,
183,
216,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 36,
    Value = 
new System.Byte[3]
{
93,
40,
155,
},
    NullableValue = 
new System.Byte[4]
{
28,
95,
37,
19,
},
},
    NullableValue = 
new System.Byte[3]
{
22,
119,
192,
},
},
            new BytesmallintArray1M
{
    Id = 94,
    Value = 
new System.Byte[3]
{
40,
180,
137,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
120,
79,
117,
},
},
            new BytesmallintArray1M
{
    Id = 98,
    Value = 
new System.Byte[3]
{
115,
102,
253,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 42,
    Value = 
new System.Byte[3]
{
115,
33,
23,
},
    NullableValue = 
new System.Byte[3]
{
181,
44,
68,
},
},
    NullableValue = 
new System.Byte[4]
{
29,
26,
72,
221,
},
},
            new BytesmallintArray1M
{
    Id = 104,
    Value = 
new System.Byte[3]
{
18,
12,
16,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 108,
    Value = 
new System.Byte[3]
{
246,
57,
173,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 45,
    Value = 
new System.Byte[4]
{
222,
163,
85,
126,
},
    NullableValue = 
new System.Byte[4]
{
16,
252,
150,
77,
},
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 113,
    Value = 
new System.Byte[4]
{
84,
21,
5,
15,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[4]
{
8,
149,
113,
33,
},
},
            new BytesmallintArray1M
{
    Id = 116,
    Value = 
new System.Byte[3]
{
181,
225,
146,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 53,
    Value = 
new System.Byte[3]
{
102,
222,
190,
},
    NullableValue = 
new System.Byte[4]
{
142,
194,
67,
60,
},
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 118,
    Value = 
new System.Byte[4]
{
250,
44,
7,
233,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 126,
    Value = 
new System.Byte[3]
{
120,
125,
160,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 62,
    Value = 
new System.Byte[4]
{
189,
102,
86,
240,
},
    NullableValue = 
new System.Byte[4]
{
97,
153,
63,
142,
},
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 128,
    Value = 
new System.Byte[4]
{
90,
236,
179,
58,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 130,
    Value = 
new System.Byte[4]
{
140,
17,
20,
78,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 66,
    Value = 
new System.Byte[3]
{
155,
40,
232,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 136,
    Value = 
new System.Byte[3]
{
167,
59,
22,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintArray1M
{
    Id = 137,
    Value = 
new System.Byte[4]
{
194,
7,
253,
113,
},
    ModelInner = new BytesmallintArray1MI
{
    Id = 74,
    Value = 
new System.Byte[3]
{
147,
227,
217,
},
    NullableValue = 
new System.Byte[3]
{
45,
82,
25,
},
},
    NullableValue = 
new System.Byte[4]
{
121,
79,
184,
191,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray1mi(
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
            asPartInterface: typeof(IByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray1mi(
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
            queryMapTypes: [typeof(BytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]), 
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

                changedRows =  ((IByteArraysmallintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteArraysmallintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteArraysmallintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteArraysmallintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IByteArraysmallintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IByteArraysmallintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IByteArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray1m(
	id,
    value,
    nullablevalue,
    bytesmallintarray1mi_id
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
            asPartInterface: typeof(IByteArraysmallintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallintarray1mi_id", 
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
                changedRows =  ((IByteArraysmallintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IByteArraysmallintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IByteArraysmallintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IByteArraysmallintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintarray1m(
	id,
    value,
    nullablevalue,
    bytesmallintarray1mi_id
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
    bytesmallintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
INSERT INTO public.bytesmallintarray1m(
	id,
    value,
    nullablevalue,
    bytesmallintarray1mi_id
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
    bytesmallintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallintarray1mi_id", 
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
                List<BytesmallintArray1M> models = null;

                models =  ((IByteArraysmallintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IByteArraysmallintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IByteArraysmallintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IByteArraysmallintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BytesmallintArray1M> models = null;

                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IByteArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray1M), typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                ((IByteArraysmallintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IByteArraysmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IByteArraysmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
LEFT JOIN public.bytesmallintarray1mi mi ON mi.id = m.bytesmallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
                var models = await ((IByteArraysmallintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteArraysmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray1M), typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                ((IByteArraysmallintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IByteArraysmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IByteArraysmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
LEFT JOIN public.bytesmallintarray1mi mi ON mi.id = m.bytesmallintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
                var models = await ((IByteArraysmallintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteArraysmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray1M), typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                await((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 19;
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                ((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                 ((IByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                 ((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[9],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[10],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                 ((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.bytesmallintarray1m m
LEFT JOIN public.bytesmallintarray1mi mi ON mi.id = m.bytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
                var models = await((IByteArraysmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BytesmallintArray1M.AssertModel(models[0],_testData[12], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[13], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[14], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[15], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[16], false);
                        BytesmallintArray1M.AssertModel(models[5],_testData[17], false);
                        BytesmallintArray1M.AssertModel(models[6],_testData[18], false);
                        BytesmallintArray1M.AssertModel(models[7],_testData[19], false);
                        BytesmallintArray1M.AssertModel(models[8],_testData[20], false);
                        BytesmallintArray1M.AssertModel(models[9],_testData[21], false);
                        BytesmallintArray1M.AssertModel(models[10],_testData[22], false);
                        BytesmallintArray1M.AssertModel(models[11],_testData[23], false);
                        BytesmallintArray1M.AssertModel(models[12],_testData[24], false);
                        BytesmallintArray1M.AssertModel(models[13],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[14],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[15],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[16],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BytesmallintArray1M.AssertModel(models[0],_testData[2], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[3], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[4], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[5], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[6], false);
                        BytesmallintArray1M.AssertModel(models[5],_testData[7], false);
                        BytesmallintArray1M.AssertModel(models[6],_testData[8], false);
                        BytesmallintArray1M.AssertModel(models[7],_testData[9], false);
                        BytesmallintArray1M.AssertModel(models[8],_testData[10], false);
                        BytesmallintArray1M.AssertModel(models[9],_testData[11], false);
                        BytesmallintArray1M.AssertModel(models[10],_testData[12], false);
                        BytesmallintArray1M.AssertModel(models[11],_testData[13], false);
                        BytesmallintArray1M.AssertModel(models[12],_testData[14], false);
                        BytesmallintArray1M.AssertModel(models[13],_testData[15], false);
                        BytesmallintArray1M.AssertModel(models[14],_testData[16], false);
                        BytesmallintArray1M.AssertModel(models[15],_testData[17], false);
                        BytesmallintArray1M.AssertModel(models[16],_testData[18], false);
                        BytesmallintArray1M.AssertModel(models[17],_testData[19], false);
                        BytesmallintArray1M.AssertModel(models[18],_testData[20], false);
                        BytesmallintArray1M.AssertModel(models[19],_testData[21], false);
                        BytesmallintArray1M.AssertModel(models[20],_testData[22], false);
                        BytesmallintArray1M.AssertModel(models[21],_testData[23], false);
                        BytesmallintArray1M.AssertModel(models[22],_testData[24], false);
                        BytesmallintArray1M.AssertModel(models[23],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[24],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[25],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[26],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((IByteArraysmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BytesmallintArray1M.AssertModel(models[0],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BytesmallintArray1M.AssertModel(models[0],_testData[19], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[20], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[21], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[22], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[23], false);
                        BytesmallintArray1M.AssertModel(models[5],_testData[24], false);
                        BytesmallintArray1M.AssertModel(models[6],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[7],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[8],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[9],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray1M), typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                await((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 104, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 47, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintArray1M>();
                var models2 = new List<FlatBytesmallintArray1M>();
                ((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                 ((IByteArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var firstItems2 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                 ((IByteArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[9],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[10],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[11],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[12],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                await ((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 37, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(models[9],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(models[10],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[11],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[12],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[13],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[14],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[15],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[16],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[17],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBytesmallintArray1M.AssertModel(models[0],_testData[4], false);
                        FlatBytesmallintArray1M.AssertModel(models[1],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(models[2],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(models[3],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(models[4],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(models[5],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(models[6],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(models[7],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(models[8],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(models[9],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(models[10],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(models[11],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(models[12],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(models[13],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(models[14],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(models[15],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(models[16],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(models[17],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(models[18],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(models[19],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(models[20],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(models[21],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(models[22],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(models[23],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(models[24],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.bytesmallintarray1m m
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
FROM public.bytesmallintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems1 = new List<FlatBytesmallintArray1M>();
                var secondItems2 = new List<FlatBytesmallintArray1M>();
                 ((IByteArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBytesmallintArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBytesmallintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBytesmallintArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.bytesmallintarray1m m
LEFT JOIN public.bytesmallintarray1mi mi ON mi.id = m.bytesmallintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray)),
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
            asPartInterface: typeof(IByteArraysmallintArray)),
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
                var models = await((IByteArraysmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BytesmallintArray1M.AssertModel(models[0],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BytesmallintArray1M.AssertModel(models[0],_testData[1], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[2], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[3], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[4], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[5], false);
                        BytesmallintArray1M.AssertModel(models[5],_testData[6], false);
                        BytesmallintArray1M.AssertModel(models[6],_testData[7], false);
                        BytesmallintArray1M.AssertModel(models[7],_testData[8], false);
                        BytesmallintArray1M.AssertModel(models[8],_testData[9], false);
                        BytesmallintArray1M.AssertModel(models[9],_testData[10], false);
                        BytesmallintArray1M.AssertModel(models[10],_testData[11], false);
                        BytesmallintArray1M.AssertModel(models[11],_testData[12], false);
                        BytesmallintArray1M.AssertModel(models[12],_testData[13], false);
                        BytesmallintArray1M.AssertModel(models[13],_testData[14], false);
                        BytesmallintArray1M.AssertModel(models[14],_testData[15], false);
                        BytesmallintArray1M.AssertModel(models[15],_testData[16], false);
                        BytesmallintArray1M.AssertModel(models[16],_testData[17], false);
                        BytesmallintArray1M.AssertModel(models[17],_testData[18], false);
                        BytesmallintArray1M.AssertModel(models[18],_testData[19], false);
                        BytesmallintArray1M.AssertModel(models[19],_testData[20], false);
                        BytesmallintArray1M.AssertModel(models[20],_testData[21], false);
                        BytesmallintArray1M.AssertModel(models[21],_testData[22], false);
                        BytesmallintArray1M.AssertModel(models[22],_testData[23], false);
                        BytesmallintArray1M.AssertModel(models[23],_testData[24], false);
                        BytesmallintArray1M.AssertModel(models[24],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[25],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[26],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[27],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IByteArraysmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BytesmallintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 90, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BytesmallintArray1M.AssertModel(models[0],_testData[18], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[19], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[20], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[21], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[22], false);
                        BytesmallintArray1M.AssertModel(models[5],_testData[23], false);
                        BytesmallintArray1M.AssertModel(models[6],_testData[24], false);
                        BytesmallintArray1M.AssertModel(models[7],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[8],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[9],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[10],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BytesmallintArray1M.AssertModel(models[0],_testData[9], false);
                        BytesmallintArray1M.AssertModel(models[1],_testData[10], false);
                        BytesmallintArray1M.AssertModel(models[2],_testData[11], false);
                        BytesmallintArray1M.AssertModel(models[3],_testData[12], false);
                        BytesmallintArray1M.AssertModel(models[4],_testData[13], false);
                        BytesmallintArray1M.AssertModel(models[5],_testData[14], false);
                        BytesmallintArray1M.AssertModel(models[6],_testData[15], false);
                        BytesmallintArray1M.AssertModel(models[7],_testData[16], false);
                        BytesmallintArray1M.AssertModel(models[8],_testData[17], false);
                        BytesmallintArray1M.AssertModel(models[9],_testData[18], false);
                        BytesmallintArray1M.AssertModel(models[10],_testData[19], false);
                        BytesmallintArray1M.AssertModel(models[11],_testData[20], false);
                        BytesmallintArray1M.AssertModel(models[12],_testData[21], false);
                        BytesmallintArray1M.AssertModel(models[13],_testData[22], false);
                        BytesmallintArray1M.AssertModel(models[14],_testData[23], false);
                        BytesmallintArray1M.AssertModel(models[15],_testData[24], false);
                        BytesmallintArray1M.AssertModel(models[16],_testData[25], false);
                        BytesmallintArray1M.AssertModel(models[17],_testData[26], false);
                        BytesmallintArray1M.AssertModel(models[18],_testData[27], false);
                        BytesmallintArray1M.AssertModel(models[19],_testData[28], false);
                        BytesmallintArray1M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((IByteArraysmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models = await ((IByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
BytesmallintArray1M.AssertModel(models[0],_testData[21], false);BytesmallintArray1M.AssertModel(models[1],_testData[22], false);BytesmallintArray1M.AssertModel(models[2],_testData[23], false);BytesmallintArray1M.AssertModel(models[3],_testData[24], false);BytesmallintArray1M.AssertModel(models[4],_testData[25], false);BytesmallintArray1M.AssertModel(models[5],_testData[26], false);BytesmallintArray1M.AssertModel(models[6],_testData[27], false);BytesmallintArray1M.AssertModel(models[7],_testData[28], false);BytesmallintArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((IByteArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
BytesmallintArray1M.AssertModel(models[0],_testData[8], false);BytesmallintArray1M.AssertModel(models[1],_testData[9], false);BytesmallintArray1M.AssertModel(models[2],_testData[10], false);BytesmallintArray1M.AssertModel(models[3],_testData[11], false);BytesmallintArray1M.AssertModel(models[4],_testData[12], false);BytesmallintArray1M.AssertModel(models[5],_testData[13], false);BytesmallintArray1M.AssertModel(models[6],_testData[14], false);BytesmallintArray1M.AssertModel(models[7],_testData[15], false);BytesmallintArray1M.AssertModel(models[8],_testData[16], false);BytesmallintArray1M.AssertModel(models[9],_testData[17], false);BytesmallintArray1M.AssertModel(models[10],_testData[18], false);BytesmallintArray1M.AssertModel(models[11],_testData[19], false);BytesmallintArray1M.AssertModel(models[12],_testData[20], false);BytesmallintArray1M.AssertModel(models[13],_testData[21], false);BytesmallintArray1M.AssertModel(models[14],_testData[22], false);BytesmallintArray1M.AssertModel(models[15],_testData[23], false);BytesmallintArray1M.AssertModel(models[16],_testData[24], false);BytesmallintArray1M.AssertModel(models[17],_testData[25], false);BytesmallintArray1M.AssertModel(models[18],_testData[26], false);BytesmallintArray1M.AssertModel(models[19],_testData[27], false);BytesmallintArray1M.AssertModel(models[20],_testData[28], false);BytesmallintArray1M.AssertModel(models[21],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BytesmallintArray1MI),
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
            asPartInterface: typeof(IByteArraysmallintArray))]
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
FROM public.binary_bytesmallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BytesmallintArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IByteArraysmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IByteArraysmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray1MI.AssertModel(actual, expect, false);
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
                await ((IByteArraysmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IByteArraysmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BytesmallintArray1M),
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
            asPartInterface: typeof(IByteArraysmallintArray))]
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
FROM public.binary_bytesmallintarray1m m
LEFT JOIN public.binary_bytesmallintarray1mi mi ON mi.id = m.bytesmallintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BytesmallintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteArraysmallintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BytesmallintArray1M>(15);

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
                ((IByteArraysmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IByteArraysmallintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BytesmallintArray1M.AssertModel(models[0],_testData[0], false);
                BytesmallintArray1M.AssertModel(models[1],_testData[1], false);
                BytesmallintArray1M.AssertModel(models[2],_testData[2], false);
                BytesmallintArray1M.AssertModel(models[3],_testData[3], false);
                BytesmallintArray1M.AssertModel(models[4],_testData[4], false);
                BytesmallintArray1M.AssertModel(models[5],_testData[5], false);
                BytesmallintArray1M.AssertModel(models[6],_testData[6], false);
                BytesmallintArray1M.AssertModel(models[7],_testData[7], false);
                BytesmallintArray1M.AssertModel(models[8],_testData[8], false);
                BytesmallintArray1M.AssertModel(models[9],_testData[9], false);
                BytesmallintArray1M.AssertModel(models[10],_testData[10], false);
                BytesmallintArray1M.AssertModel(models[11],_testData[11], false);
                BytesmallintArray1M.AssertModel(models[12],_testData[12], false);
                BytesmallintArray1M.AssertModel(models[13],_testData[13], false);
                BytesmallintArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IByteArraysmallintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IByteArraysmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BytesmallintArray1M.AssertModel(models[0],_testData[0], false);
                BytesmallintArray1M.AssertModel(models[1],_testData[1], false);
                BytesmallintArray1M.AssertModel(models[2],_testData[2], false);
                BytesmallintArray1M.AssertModel(models[3],_testData[3], false);
                BytesmallintArray1M.AssertModel(models[4],_testData[4], false);
                BytesmallintArray1M.AssertModel(models[5],_testData[5], false);
                BytesmallintArray1M.AssertModel(models[6],_testData[6], false);
                BytesmallintArray1M.AssertModel(models[7],_testData[7], false);
                BytesmallintArray1M.AssertModel(models[8],_testData[8], false);
                BytesmallintArray1M.AssertModel(models[9],_testData[9], false);
                BytesmallintArray1M.AssertModel(models[10],_testData[10], false);
                BytesmallintArray1M.AssertModel(models[11],_testData[11], false);
                BytesmallintArray1M.AssertModel(models[12],_testData[12], false);
                BytesmallintArray1M.AssertModel(models[13],_testData[13], false);
                BytesmallintArray1M.AssertModel(models[14],_testData[14], false);
                BytesmallintArray1M.AssertModel(models[15],_testData[15], false);
                BytesmallintArray1M.AssertModel(models[16],_testData[16], false);
                BytesmallintArray1M.AssertModel(models[17],_testData[17], false);
                BytesmallintArray1M.AssertModel(models[18],_testData[18], false);
                BytesmallintArray1M.AssertModel(models[19],_testData[19], false);
                BytesmallintArray1M.AssertModel(models[20],_testData[20], false);
                BytesmallintArray1M.AssertModel(models[21],_testData[21], false);
                BytesmallintArray1M.AssertModel(models[22],_testData[22], false);
                BytesmallintArray1M.AssertModel(models[23],_testData[23], false);
                BytesmallintArray1M.AssertModel(models[24],_testData[24], false);
                BytesmallintArray1M.AssertModel(models[25],_testData[25], false);
                BytesmallintArray1M.AssertModel(models[26],_testData[26], false);
                BytesmallintArray1M.AssertModel(models[27],_testData[27], false);
                BytesmallintArray1M.AssertModel(models[28],_testData[28], false);
                BytesmallintArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BytesmallintArray1M)],
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
            asPartInterface: typeof(IByteArraysmallintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteArraysmallintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteArraysmallintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BytesmallintArray1MI)],
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
            asPartInterface: typeof(IByteArraysmallintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteArraysmallintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteArraysmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}




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
    internal partial interface IByteMArraysmallintMArrayD1
    {
    }
    
    internal partial class ByteMArraysmallintMArrayD1 : IByteMArraysmallintMArrayD1
    {


#region TestData

        private readonly BytesmallintMArrayD1E1M[] _testData = new BytesmallintMArrayD1E1M[]
        {
            new BytesmallintMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Byte[4]
{
251,
14,
186,
20,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Byte[3]
{
85,
103,
245,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 7,
    Value = 
new System.Byte[3]
{
14,
134,
171,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
31,
245,
204,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Byte[4]
{
228,
100,
216,
178,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
96,
73,
254,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Byte[4]
{
99,
163,
67,
174,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 12,
    Value = 
new System.Byte[3]
{
124,
218,
141,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Byte[3]
{
237,
95,
14,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
250,
90,
22,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Byte[3]
{
7,
201,
142,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 15,
    Value = 
new System.Byte[4]
{
252,
132,
157,
9,
},
    NullableValue = 
new System.Byte[4]
{
156,
205,
154,
72,
},
},
    NullableValue = 
new System.Byte[4]
{
33,
248,
115,
76,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Byte[4]
{
35,
250,
214,
207,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
142,
109,
159,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Byte[4]
{
3,
177,
126,
145,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 19,
    Value = 
new System.Byte[4]
{
46,
142,
246,
146,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
52,
18,
49,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Byte[4]
{
148,
150,
75,
33,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Byte[3]
{
170,
212,
200,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 23,
    Value = 
new System.Byte[4]
{
202,
61,
233,
181,
},
    NullableValue = 
new System.Byte[4]
{
225,
143,
218,
22,
},
},
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Byte[4]
{
9,
34,
15,
91,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
132,
116,
183,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Byte[4]
{
144,
7,
174,
58,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 30,
    Value = 
new System.Byte[4]
{
225,
129,
15,
226,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
3,
201,
77,
159,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Byte[3]
{
132,
94,
42,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Byte[4]
{
121,
74,
11,
10,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 32,
    Value = 
new System.Byte[4]
{
165,
124,
204,
171,
},
    NullableValue = 
new System.Byte[4]
{
35,
242,
131,
105,
},
},
    NullableValue = 
new System.Byte[3]
{
62,
24,
208,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Byte[3]
{
99,
14,
224,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[4]
{
150,
159,
128,
165,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Byte[4]
{
225,
74,
148,
67,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 41,
    Value = 
new System.Byte[4]
{
127,
156,
230,
14,
},
    NullableValue = 
new System.Byte[4]
{
123,
15,
66,
89,
},
},
    NullableValue = 
new System.Byte[3]
{
139,
126,
228,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Byte[3]
{
226,
212,
83,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[4]
{
110,
140,
85,
157,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Byte[3]
{
133,
75,
74,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 49,
    Value = 
new System.Byte[3]
{
238,
8,
164,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[4]
{
235,
168,
98,
117,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Byte[4]
{
12,
159,
246,
134,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Byte[3]
{
201,
241,
139,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 52,
    Value = 
new System.Byte[3]
{
47,
105,
11,
},
    NullableValue = 
new System.Byte[4]
{
131,
147,
6,
137,
},
},
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Byte[3]
{
183,
163,
179,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
181,
173,
31,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Byte[4]
{
168,
210,
84,
176,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 56,
    Value = 
new System.Byte[3]
{
187,
124,
94,
},
    NullableValue = 
new System.Byte[3]
{
150,
98,
162,
},
},
    NullableValue = 
new System.Byte[4]
{
15,
108,
119,
147,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Byte[3]
{
252,
223,
188,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[4]
{
23,
215,
251,
110,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Byte[4]
{
226,
129,
82,
227,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 62,
    Value = 
new System.Byte[4]
{
145,
92,
132,
240,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
75,
56,
162,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Byte[4]
{
84,
130,
85,
164,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[3]
{
214,
225,
178,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 125,
    Value = 
new System.Byte[4]
{
1,
244,
77,
243,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 69,
    Value = 
new System.Byte[3]
{
98,
224,
235,
},
    NullableValue = null,
},
    NullableValue = 
new System.Byte[3]
{
152,
160,
140,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Byte[3]
{
241,
218,
250,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Byte[4]
{
174,
146,
155,
38,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 76,
    Value = 
new System.Byte[3]
{
203,
102,
3,
},
    NullableValue = 
new System.Byte[4]
{
150,
102,
97,
138,
},
},
    NullableValue = 
new System.Byte[4]
{
208,
86,
215,
112,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Byte[4]
{
213,
207,
211,
208,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Byte[3]
{
210,
36,
22,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 83,
    Value = 
new System.Byte[3]
{
25,
204,
25,
},
    NullableValue = 
new System.Byte[4]
{
18,
10,
141,
210,
},
},
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Byte[3]
{
20,
142,
222,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Byte[4]
{
198,
187,
12,
188,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 87,
    Value = 
new System.Byte[4]
{
95,
253,
151,
12,
},
    NullableValue = 
new System.Byte[4]
{
241,
234,
143,
123,
},
},
    NullableValue = 
new System.Byte[4]
{
21,
203,
18,
203,
},
},
            new BytesmallintMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Byte[4]
{
133,
145,
223,
29,
},
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Byte[4]
{
122,
62,
68,
156,
},
    ModelInner = new BytesmallintMArrayD11MI
{
    Id = 94,
    Value = 
new System.Byte[4]
{
219,
33,
143,
228,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintMArrayD1E1M
{
    Id = 175,
    Value = 
new System.Byte[3]
{
25,
168,
59,
},
    ModelInner = null,
    NullableValue = 
new System.Byte[4]
{
79,
33,
199,
73,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmarrayd11mi(
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
INSERT INTO public.bytesmallintmarrayd11mi(
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
            queryMapTypes: [typeof(BytesmallintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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

                changedRows =  ((IByteMArraysmallintMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteMArraysmallintMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IByteMArraysmallintMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bytesmallintmarrayd11mi_id
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)), 
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
                methodParametrName: "bytesmallintmarrayd11mi_id", 
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
                changedRows =  ((IByteMArraysmallintMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IByteMArraysmallintMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IByteMArraysmallintMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IByteMArraysmallintMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallintmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bytesmallintmarrayd11mi_id
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
    bytesmallintmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
INSERT INTO public.bytesmallintmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bytesmallintmarrayd11mi_id
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
    bytesmallintmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                methodParametrName: "bytesmallintmarrayd11mi_id", 
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
                List<BytesmallintMArrayD1E1M> models = null;

                models =  ((IByteMArraysmallintMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IByteMArraysmallintMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IByteMArraysmallintMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IByteMArraysmallintMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BytesmallintMArrayD1E1M> models = null;

                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IByteMArraysmallintMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M), typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                ((IByteMArraysmallintMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IByteMArraysmallintMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IByteMArraysmallintMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
LEFT JOIN public.bytesmallintmarrayd11mi mi ON mi.id = m.bytesmallintmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models = await ((IByteMArraysmallintMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M), typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                ((IByteMArraysmallintMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IByteMArraysmallintMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IByteMArraysmallintMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
LEFT JOIN public.bytesmallintmarrayd11mi mi ON mi.id = m.bytesmallintmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models = await ((IByteMArraysmallintMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteMArraysmallintMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M), typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                await((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                ((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                 ((IByteMArraysmallintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                 ((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteMArraysmallintMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteMArraysmallintMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                 ((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
LEFT JOIN public.bytesmallintmarrayd11mi mi ON mi.id = m.bytesmallintmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models = await((IByteMArraysmallintMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteMArraysmallintMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteMArraysmallintMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M), typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                await((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 170, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintMArrayD1E1M>();
                var models2 = new List<FlatBytesmallintMArrayD1E1M>();
                ((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                 ((IByteMArraysmallintMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 6, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var firstItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                 ((IByteMArraysmallintMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 113, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteMArraysmallintMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 137, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                await ((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 49, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteMArraysmallintMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 36, query1, 165, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBytesmallintMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
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
FROM public.bytesmallintmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems1 = new List<FlatBytesmallintMArrayD1E1M>();
                var secondItems2 = new List<FlatBytesmallintMArrayD1E1M>();
                 ((IByteMArraysmallintMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 21, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBytesmallintMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.bytesmallintmarrayd1e1m m
LEFT JOIN public.bytesmallintmarrayd11mi mi ON mi.id = m.bytesmallintmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models = await((IByteMArraysmallintMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteMArraysmallintMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteMArraysmallintMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 144, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        BytesmallintMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IByteMArraysmallintMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteMArraysmallintMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 156);
                var models = await ((IByteMArraysmallintMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteMArraysmallintMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteMArraysmallintMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((IByteMArraysmallintMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                BytesmallintMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                BytesmallintMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                BytesmallintMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                BytesmallintMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                BytesmallintMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                BytesmallintMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                BytesmallintMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                BytesmallintMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                BytesmallintMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                BytesmallintMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                BytesmallintMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                BytesmallintMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_bytesmallintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BytesmallintMArrayD11MIWA),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteMArraysmallintMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteMArraysmallintMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteMArraysmallintMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteMArraysmallintMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BytesmallintMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteMArraysmallintMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteMArraysmallintMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteMArraysmallintMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteMArraysmallintMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BytesmallintMArrayD11MI),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IByteMArraysmallintMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteMArraysmallintMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IByteMArraysmallintMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IByteMArraysmallintMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallintmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BytesmallintMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteMArraysmallintMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteMArraysmallintMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteMArraysmallintMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IByteMArraysmallintMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallintmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallintmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BytesmallintMArrayD1E1M),
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
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
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
FROM public.binary_bytesmallintmarrayd1e1m m
LEFT JOIN public.binary_bytesmallintmarrayd11mi mi ON mi.id = m.bytesmallintmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IByteMArraysmallintMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IByteMArraysmallintMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IByteMArraysmallintMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IByteMArraysmallintMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallintmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BytesmallintMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models =  ((IByteMArraysmallintMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteMArraysmallintMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA), typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models1 = new List<BytesmallintMArrayD11MIWA>();
                var models2 = new List<BytesmallintMArrayD11MIWA>();
                await ((IByteMArraysmallintMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMArrayD11MIWA>();
                var models2 = new List<BytesmallintMArrayD11MIWA>();
                ((IByteMArraysmallintMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models = await ((IByteMArraysmallintMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallintmarrayd11mi
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
                    BytesmallintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bytesmallintmarrayd11mi
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
                    BytesmallintMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA), typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
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
                var models1 = new List<BytesmallintMArrayD11MIWA>();
                var models2 = new List<BytesmallintMArrayD11MIWA>();
                await ((IByteMArraysmallintMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMArrayD11MIWA>();
                var models2 = new List<BytesmallintMArrayD11MIWA>();
                ((IByteMArraysmallintMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
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
                var models = await ((IByteMArraysmallintMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallintmarrayd11mi
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
                    BytesmallintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bytesmallintmarrayd11mi
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
                    BytesmallintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bytesmallintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MI), typeof(BytesmallintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models1 = new List<BytesmallintMArrayD11MI>();
                var models2 = new List<BytesmallintMArrayD11MI>();
                await ((IByteMArraysmallintMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMArrayD11MI>();
                var models2 = new List<BytesmallintMArrayD11MI>();
                ((IByteMArraysmallintMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1)),
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
                var models = await ((IByteMArraysmallintMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bytesmallintmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA), typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
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
                var models1 = new List<BytesmallintMArrayD11MIWA>();
                var models2 = new List<BytesmallintMArrayD11MIWA>();
                await ((IByteMArraysmallintMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintMArrayD11MIWA>();
                var models2 = new List<BytesmallintMArrayD11MIWA>();
                ((IByteMArraysmallintMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallintmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BytesmallintMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArraysmallintMArrayD1))]
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
                var models = await ((IByteMArraysmallintMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteMArraysmallintMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


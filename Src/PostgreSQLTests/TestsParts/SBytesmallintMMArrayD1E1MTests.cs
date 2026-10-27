

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
    internal partial interface ISByteMArraysmallintMMArrayD1
    {
    }
    
    internal partial class SByteMArraysmallintMMArrayD1 : ISByteMArraysmallintMMArrayD1
    {


#region TestData

        private readonly SBytesmallintMMArrayD1E1M[] _testData = new SBytesmallintMMArrayD1E1M[]
        {
            new SBytesmallintMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.SByte[3]
{
33,
96,
-60,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.SByte[3]
{
65,
-61,
-76,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.SByte[4]
{
-119,
-82,
106,
76,
},
    NullableValue = 
new System.SByte[3]
{
77,
14,
-54,
},
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.SByte[4]
{
50,
-17,
69,
-15,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-22,
33,
-16,
-36,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.SByte[4]
{
118,
-19,
-27,
-68,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.SByte[4]
{
-121,
112,
40,
25,
},
    NullableValue = 
new System.SByte[4]
{
74,
126,
-2,
-96,
},
},
    NullableValue = 
new System.SByte[4]
{
-126,
103,
-72,
125,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.SByte[3]
{
-31,
28,
11,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
-124,
-14,
74,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.SByte[3]
{
-21,
-53,
26,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.SByte[3]
{
112,
79,
77,
},
    NullableValue = 
new System.SByte[3]
{
-23,
-96,
56,
},
},
    NullableValue = 
new System.SByte[3]
{
67,
7,
-121,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.SByte[4]
{
52,
-43,
-106,
-41,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
82,
-19,
34,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.SByte[3]
{
93,
-123,
116,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.SByte[3]
{
-33,
-109,
30,
},
    NullableValue = 
new System.SByte[3]
{
39,
92,
5,
},
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.SByte[3]
{
20,
4,
28,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-20,
83,
68,
-123,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.SByte[4]
{
-75,
-70,
33,
34,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.SByte[3]
{
-115,
48,
85,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.SByte[3]
{
-26,
104,
30,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.SByte[3]
{
-23,
125,
72,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.SByte[4]
{
-66,
-76,
40,
-8,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-9,
56,
-111,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.SByte[3]
{
-13,
94,
-16,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.SByte[4]
{
88,
48,
20,
-51,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.SByte[4]
{
123,
-54,
125,
-63,
},
    NullableValue = 
new System.SByte[3]
{
-7,
120,
-89,
},
},
    NullableValue = 
new System.SByte[4]
{
-71,
82,
-50,
71,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.SByte[3]
{
-73,
45,
61,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[3]
{
91,
-79,
117,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.SByte[4]
{
10,
-100,
125,
-9,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.SByte[4]
{
-21,
5,
100,
-63,
},
    NullableValue = 
new System.SByte[3]
{
-116,
-86,
82,
},
},
    NullableValue = 
new System.SByte[4]
{
110,
43,
-69,
-104,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.SByte[3]
{
32,
45,
38,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-14,
-67,
25,
-125,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.SByte[3]
{
-34,
-108,
78,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.SByte[4]
{
5,
98,
114,
-121,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[4]
{
108,
49,
-95,
-109,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.SByte[4]
{
-2,
-53,
-3,
-118,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
-37,
-117,
52,
5,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.SByte[4]
{
-11,
108,
-26,
78,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.SByte[3]
{
-120,
50,
-11,
},
    NullableValue = 
new System.SByte[3]
{
82,
-42,
7,
},
},
    NullableValue = 
new System.SByte[3]
{
2,
25,
-38,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.SByte[3]
{
-71,
-36,
1,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.SByte[3]
{
83,
33,
25,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.SByte[4]
{
-96,
69,
31,
35,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.SByte[4]
{
-38,
92,
-49,
-15,
},
    ModelInner = null,
    NullableValue = 
new System.SByte[4]
{
21,
112,
-105,
-105,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.SByte[3]
{
-88,
-120,
120,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.SByte[4]
{
-123,
-29,
-60,
-102,
},
    NullableValue = 
new System.SByte[4]
{
22,
-46,
3,
120,
},
},
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 125,
    Value = 
new System.SByte[3]
{
46,
62,
105,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.SByte[4]
{
60,
12,
116,
-103,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.SByte[4]
{
73,
53,
-17,
102,
},
    NullableValue = 
new System.SByte[4]
{
-60,
82,
14,
101,
},
},
    NullableValue = 
new System.SByte[3]
{
-106,
-110,
-101,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.SByte[4]
{
98,
91,
93,
34,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.SByte[3]
{
118,
118,
7,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.SByte[4]
{
-60,
57,
115,
42,
},
    NullableValue = 
new System.SByte[3]
{
-28,
-105,
117,
},
},
    NullableValue = 
new System.SByte[4]
{
-10,
24,
59,
95,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.SByte[4]
{
59,
-62,
-48,
-15,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 151,
    Value = 
new System.SByte[3]
{
119,
-75,
96,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.SByte[3]
{
22,
108,
-108,
},
    NullableValue = 
new System.SByte[3]
{
77,
78,
-12,
},
},
    NullableValue = 
new System.SByte[4]
{
-37,
8,
-17,
57,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.SByte[4]
{
56,
-13,
69,
33,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.SByte[3]
{
-35,
-12,
90,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.SByte[4]
{
-85,
-88,
41,
-60,
},
    NullableValue = null,
},
    NullableValue = 
new System.SByte[3]
{
-39,
-92,
99,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.SByte[3]
{
123,
27,
-80,
},
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.SByte[4]
{
-3,
-91,
45,
93,
},
    ModelInner = new SBytesmallintMMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.SByte[4]
{
73,
47,
46,
104,
},
    NullableValue = 
new System.SByte[3]
{
73,
89,
-41,
},
},
    NullableValue = 
new System.SByte[4]
{
-42,
-41,
-98,
97,
},
},
            new SBytesmallintMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.SByte[4]
{
60,
-69,
119,
90,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd1e1mi(
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
INSERT INTO public.sbytesmallintmmarrayd1e1mi(
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
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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

                changedRows =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    sbytesmallintmmarrayd1e1mi_id
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)), 
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
                methodParametrName: "sbytesmallintmmarrayd1e1mi_id", 
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
                changedRows =  ((ISByteMArraysmallintMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISByteMArraysmallintMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    sbytesmallintmmarrayd1e1mi_id
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
    sbytesmallintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
INSERT INTO public.sbytesmallintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    sbytesmallintmmarrayd1e1mi_id
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
    sbytesmallintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                methodParametrName: "sbytesmallintmmarrayd1e1mi_id", 
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
                List<SBytesmallintMMArrayD1E1M> models = null;

                models =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallintMMArrayD1E1M> models = null;

                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISByteMArraysmallintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M), typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                ((ISByteMArraysmallintMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISByteMArraysmallintMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISByteMArraysmallintMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
LEFT JOIN public.sbytesmallintmmarrayd1e1mi mi ON mi.id = m.sbytesmallintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models = await ((ISByteMArraysmallintMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M), typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                ((ISByteMArraysmallintMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteMArraysmallintMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISByteMArraysmallintMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
LEFT JOIN public.sbytesmallintmmarrayd1e1mi mi ON mi.id = m.sbytesmallintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models = await ((ISByteMArraysmallintMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteMArraysmallintMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M), typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                ((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                 ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                 ((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                 ((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
LEFT JOIN public.sbytesmallintmmarrayd1e1mi mi ON mi.id = m.sbytesmallintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models = await((ISByteMArraysmallintMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M), typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 107, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 165, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var models2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                ((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                 ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var firstItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                 ((ISByteMArraysmallintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
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
FROM public.sbytesmallintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems1 = new List<FlatSBytesmallintMMArrayD1E1M>();
                var secondItems2 = new List<FlatSBytesmallintMMArrayD1E1M>();
                 ((ISByteMArraysmallintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSBytesmallintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.sbytesmallintmmarrayd1e1m m
LEFT JOIN public.sbytesmallintmmarrayd1e1mi mi ON mi.id = m.sbytesmallintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models = await((ISByteMArraysmallintMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 9, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SBytesmallintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteMArraysmallintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 151, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((ISByteMArraysmallintMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteMArraysmallintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models = await ((ISByteMArraysmallintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteMArraysmallintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteMArraysmallintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((ISByteMArraysmallintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                SBytesmallintMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                SBytesmallintMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_sbytesmallintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD1E1MIWA),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteMArraysmallintMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteMArraysmallintMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteMArraysmallintMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteMArraysmallintMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteMArraysmallintMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteMArraysmallintMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteMArraysmallintMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteMArraysmallintMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD1E1MI),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteMArraysmallintMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteMArraysmallintMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteMArraysmallintMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ISByteMArraysmallintMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteMArraysmallintMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteMArraysmallintMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteMArraysmallintMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteMArraysmallintMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallintmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SBytesmallintMMArrayD1E1M),
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
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
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
FROM public.binary_sbytesmallintmmarrayd1e1m m
LEFT JOIN public.binary_sbytesmallintmmarrayd1e1mi mi ON mi.id = m.sbytesmallintmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallintMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISByteMArraysmallintMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISByteMArraysmallintMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SBytesmallintMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISByteMArraysmallintMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((ISByteMArraysmallintMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SBytesmallintMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models =  ((ISByteMArraysmallintMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteMArraysmallintMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA), typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models1 = new List<SBytesmallintMMArrayD1E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD1E1MIWA>();
                await ((ISByteMArraysmallintMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD1E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD1E1MIWA>();
                ((ISByteMArraysmallintMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models = await ((ISByteMArraysmallintMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
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
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
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
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA), typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
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
                var models1 = new List<SBytesmallintMMArrayD1E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD1E1MIWA>();
                await ((ISByteMArraysmallintMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD1E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD1E1MIWA>();
                ((ISByteMArraysmallintMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_sbytesmallintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
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
                var models = await ((ISByteMArraysmallintMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
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
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
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
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MI), typeof(SBytesmallintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models1 = new List<SBytesmallintMMArrayD1E1MI>();
                var models2 = new List<SBytesmallintMMArrayD1E1MI>();
                await ((ISByteMArraysmallintMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD1E1MI>();
                var models2 = new List<SBytesmallintMMArrayD1E1MI>();
                ((ISByteMArraysmallintMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1)),
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
                var models = await ((ISByteMArraysmallintMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_sbytesmallintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA), typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
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
                var models1 = new List<SBytesmallintMMArrayD1E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD1E1MIWA>();
                await ((ISByteMArraysmallintMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SBytesmallintMMArrayD1E1MIWA>();
                var models2 = new List<SBytesmallintMMArrayD1E1MIWA>();
                ((ISByteMArraysmallintMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallintmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArraysmallintMMArrayD1))]
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
                var models = await ((ISByteMArraysmallintMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISByteMArraysmallintMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


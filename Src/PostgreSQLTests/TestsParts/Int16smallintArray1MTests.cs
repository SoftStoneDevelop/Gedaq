

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
    Id = 7,
    Value = 
new System.Int16[3]
{
19426,
4411,
4770,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
28158,
1056,
27020,
22807,
},
},
            new Int16smallintArray1M
{
    Id = 14,
    Value = 
new System.Int16[4]
{
28317,
31106,
18941,
15139,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 4,
    Value = 
new System.Int16[3]
{
24344,
23374,
26648,
},
    NullableValue = 
new System.Int16[3]
{
31042,
39,
26974,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 17,
    Value = 
new System.Int16[4]
{
11951,
15836,
20231,
20173,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
539,
1042,
16589,
},
},
            new Int16smallintArray1M
{
    Id = 23,
    Value = 
new System.Int16[3]
{
12597,
1819,
7866,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 8,
    Value = 
new System.Int16[4]
{
14793,
9517,
15190,
29828,
},
    NullableValue = 
new System.Int16[3]
{
19019,
30061,
27823,
},
},
    NullableValue = 
new System.Int16[3]
{
13168,
32713,
32340,
},
},
            new Int16smallintArray1M
{
    Id = 29,
    Value = 
new System.Int16[3]
{
3500,
31172,
4633,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
7763,
8884,
32554,
},
},
            new Int16smallintArray1M
{
    Id = 37,
    Value = 
new System.Int16[3]
{
3774,
25394,
7903,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 15,
    Value = 
new System.Int16[3]
{
30067,
25000,
13414,
},
    NullableValue = 
new System.Int16[4]
{
21930,
336,
19701,
1173,
},
},
    NullableValue = 
new System.Int16[4]
{
19892,
15652,
29374,
23420,
},
},
            new Int16smallintArray1M
{
    Id = 45,
    Value = 
new System.Int16[3]
{
18032,
21504,
30840,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 51,
    Value = 
new System.Int16[4]
{
12933,
31149,
4820,
27984,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 23,
    Value = 
new System.Int16[3]
{
9158,
27146,
27515,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 59,
    Value = 
new System.Int16[3]
{
21361,
819,
8052,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
29626,
31391,
16379,
},
},
            new Int16smallintArray1M
{
    Id = 62,
    Value = 
new System.Int16[3]
{
18722,
9585,
573,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 24,
    Value = 
new System.Int16[3]
{
177,
29378,
23474,
},
    NullableValue = 
new System.Int16[4]
{
18686,
15754,
28063,
7058,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 66,
    Value = 
new System.Int16[3]
{
12043,
24333,
17428,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 71,
    Value = 
new System.Int16[3]
{
982,
19649,
28323,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 33,
    Value = 
new System.Int16[4]
{
26984,
19317,
15313,
3116,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 73,
    Value = 
new System.Int16[4]
{
11465,
20028,
8214,
9761,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
29010,
18793,
28016,
},
},
            new Int16smallintArray1M
{
    Id = 76,
    Value = 
new System.Int16[3]
{
5868,
22827,
6557,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 42,
    Value = 
new System.Int16[3]
{
14157,
9421,
29871,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 79,
    Value = 
new System.Int16[3]
{
9655,
23486,
27613,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 83,
    Value = 
new System.Int16[3]
{
1819,
840,
24587,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 51,
    Value = 
new System.Int16[3]
{
12166,
17132,
14361,
},
    NullableValue = 
new System.Int16[3]
{
6252,
1576,
21989,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 84,
    Value = 
new System.Int16[4]
{
1150,
25517,
3209,
5687,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 93,
    Value = 
new System.Int16[3]
{
5405,
16901,
652,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 55,
    Value = 
new System.Int16[4]
{
32262,
3298,
9814,
20765,
},
    NullableValue = 
new System.Int16[4]
{
28491,
6496,
30651,
4061,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 101,
    Value = 
new System.Int16[4]
{
30788,
16252,
15754,
3028,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 108,
    Value = 
new System.Int16[4]
{
21125,
6095,
24061,
30956,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 63,
    Value = 
new System.Int16[3]
{
25046,
30106,
5369,
},
    NullableValue = 
new System.Int16[3]
{
23590,
3269,
26231,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 115,
    Value = 
new System.Int16[3]
{
12414,
7494,
4242,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
19877,
4331,
29633,
3381,
},
},
            new Int16smallintArray1M
{
    Id = 121,
    Value = 
new System.Int16[4]
{
8278,
22341,
13071,
1120,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 70,
    Value = 
new System.Int16[3]
{
27709,
13865,
10259,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 127,
    Value = 
new System.Int16[3]
{
24546,
19297,
19034,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
19246,
14466,
12977,
},
},
            new Int16smallintArray1M
{
    Id = 131,
    Value = 
new System.Int16[4]
{
17389,
26533,
2235,
14954,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 78,
    Value = 
new System.Int16[4]
{
22846,
21225,
24689,
11690,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
4557,
3235,
5476,
24890,
},
},
            new Int16smallintArray1M
{
    Id = 136,
    Value = 
new System.Int16[3]
{
26244,
19309,
32618,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[3]
{
25209,
19420,
8767,
},
},
            new Int16smallintArray1M
{
    Id = 145,
    Value = 
new System.Int16[3]
{
3433,
8012,
9639,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 81,
    Value = 
new System.Int16[4]
{
29092,
22088,
27879,
27221,
},
    NullableValue = 
new System.Int16[4]
{
15477,
18836,
6657,
19170,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 148,
    Value = 
new System.Int16[3]
{
3688,
10206,
20016,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 151,
    Value = 
new System.Int16[3]
{
25020,
14776,
1474,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 87,
    Value = 
new System.Int16[4]
{
7737,
32003,
193,
10023,
},
    NullableValue = 
new System.Int16[4]
{
30621,
144,
3271,
14169,
},
},
    NullableValue = 
new System.Int16[4]
{
14866,
21284,
8135,
14365,
},
},
            new Int16smallintArray1M
{
    Id = 153,
    Value = 
new System.Int16[3]
{
20375,
26499,
4234,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 155,
    Value = 
new System.Int16[3]
{
21914,
1701,
31417,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 90,
    Value = 
new System.Int16[4]
{
10437,
15329,
18740,
32682,
},
    NullableValue = 
new System.Int16[4]
{
29788,
10720,
27945,
19403,
},
},
    NullableValue = 
new System.Int16[3]
{
28408,
24706,
21832,
},
},
            new Int16smallintArray1M
{
    Id = 164,
    Value = 
new System.Int16[3]
{
8090,
10729,
19455,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
7181,
12241,
3610,
20686,
},
},
            new Int16smallintArray1M
{
    Id = 167,
    Value = 
new System.Int16[3]
{
5155,
5129,
28224,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 97,
    Value = 
new System.Int16[4]
{
29057,
19588,
1259,
2690,
},
    NullableValue = 
new System.Int16[3]
{
31848,
16315,
19758,
},
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 171,
    Value = 
new System.Int16[3]
{
14586,
14278,
24835,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 172,
    Value = 
new System.Int16[4]
{
26349,
27031,
21518,
7520,
},
    ModelInner = new Int16smallintArray1MI
{
    Id = 102,
    Value = 
new System.Int16[4]
{
14397,
29011,
12822,
20534,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray1M
{
    Id = 175,
    Value = 
new System.Int16[4]
{
8342,
25489,
5899,
25184,
},
    ModelInner = null,
    NullableValue = 
new System.Int16[4]
{
3881,
27800,
32690,
25358,
},
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

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt16ArraysmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int16[3]
{
7763,
8884,
32554,
}));
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
19892,
15652,
29374,
23420,
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
new System.Int16[3]
{
29626,
31391,
16379,
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
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt16ArraysmallintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[25],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(models[26],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[27],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[28],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[29],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int16smallintArray1M.AssertModel(models[0],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[29], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        Int16smallintArray1M.AssertModel(models[10],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallintArray1M.AssertModel(models[0],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[29], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int16smallintArray1M.AssertModel(models[0],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[29], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 108, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        FlatInt16smallintArray1M.AssertModel(models[29],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[30],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[31],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[32],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[33],_testData[34], false);
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
                await ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatInt16smallintArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 164, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt16smallintArray1M.AssertModel(models[0],_testData[7], false);
                        FlatInt16smallintArray1M.AssertModel(models[1],_testData[8], false);
                        FlatInt16smallintArray1M.AssertModel(models[2],_testData[9], false);
                        FlatInt16smallintArray1M.AssertModel(models[3],_testData[10], false);
                        FlatInt16smallintArray1M.AssertModel(models[4],_testData[11], false);
                        FlatInt16smallintArray1M.AssertModel(models[5],_testData[12], false);
                        FlatInt16smallintArray1M.AssertModel(models[6],_testData[13], false);
                        FlatInt16smallintArray1M.AssertModel(models[7],_testData[14], false);
                        FlatInt16smallintArray1M.AssertModel(models[8],_testData[15], false);
                        FlatInt16smallintArray1M.AssertModel(models[9],_testData[16], false);
                        FlatInt16smallintArray1M.AssertModel(models[10],_testData[17], false);
                        FlatInt16smallintArray1M.AssertModel(models[11],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(models[12],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(models[13],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(models[14],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(models[15],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(models[16],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(models[17],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(models[18],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(models[19],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(models[20],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(models[21],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(models[22],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(models[23],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(models[24],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(models[25],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(models[26],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(models[27],_testData[34], false);
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
                 ((IInt16ArraysmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 164, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt16smallintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt16smallintArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallintArray1M.AssertModel(models[0],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[29], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintArray1M.AssertModel(models[0],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[29], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IInt16ArraysmallintArray)this).DbConnectionSTSelectModelBatch(connection, 37, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int16smallintArray1M.AssertModel(models[0],_testData[6], false);
                        Int16smallintArray1M.AssertModel(models[1],_testData[7], false);
                        Int16smallintArray1M.AssertModel(models[2],_testData[8], false);
                        Int16smallintArray1M.AssertModel(models[3],_testData[9], false);
                        Int16smallintArray1M.AssertModel(models[4],_testData[10], false);
                        Int16smallintArray1M.AssertModel(models[5],_testData[11], false);
                        Int16smallintArray1M.AssertModel(models[6],_testData[12], false);
                        Int16smallintArray1M.AssertModel(models[7],_testData[13], false);
                        Int16smallintArray1M.AssertModel(models[8],_testData[14], false);
                        Int16smallintArray1M.AssertModel(models[9],_testData[15], false);
                        Int16smallintArray1M.AssertModel(models[10],_testData[16], false);
                        Int16smallintArray1M.AssertModel(models[11],_testData[17], false);
                        Int16smallintArray1M.AssertModel(models[12],_testData[18], false);
                        Int16smallintArray1M.AssertModel(models[13],_testData[19], false);
                        Int16smallintArray1M.AssertModel(models[14],_testData[20], false);
                        Int16smallintArray1M.AssertModel(models[15],_testData[21], false);
                        Int16smallintArray1M.AssertModel(models[16],_testData[22], false);
                        Int16smallintArray1M.AssertModel(models[17],_testData[23], false);
                        Int16smallintArray1M.AssertModel(models[18],_testData[24], false);
                        Int16smallintArray1M.AssertModel(models[19],_testData[25], false);
                        Int16smallintArray1M.AssertModel(models[20],_testData[26], false);
                        Int16smallintArray1M.AssertModel(models[21],_testData[27], false);
                        Int16smallintArray1M.AssertModel(models[22],_testData[28], false);
                        Int16smallintArray1M.AssertModel(models[23],_testData[29], false);
                        Int16smallintArray1M.AssertModel(models[24],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[25],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[26],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[27],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        Int16smallintArray1M.AssertModel(models[20],_testData[30], false);
                        Int16smallintArray1M.AssertModel(models[21],_testData[31], false);
                        Int16smallintArray1M.AssertModel(models[22],_testData[32], false);
                        Int16smallintArray1M.AssertModel(models[23],_testData[33], false);
                        Int16smallintArray1M.AssertModel(models[24],_testData[34], false);
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
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 164);
                var models = await ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Int16smallintArray1M.AssertModel(models[0],_testData[31], false);
                Int16smallintArray1M.AssertModel(models[1],_testData[32], false);
                Int16smallintArray1M.AssertModel(models[2],_testData[33], false);
                Int16smallintArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ArraysmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ArraysmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((IInt16ArraysmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Int16smallintArray1M.AssertModel(models[0],_testData[11], false);
                Int16smallintArray1M.AssertModel(models[1],_testData[12], false);
                Int16smallintArray1M.AssertModel(models[2],_testData[13], false);
                Int16smallintArray1M.AssertModel(models[3],_testData[14], false);
                Int16smallintArray1M.AssertModel(models[4],_testData[15], false);
                Int16smallintArray1M.AssertModel(models[5],_testData[16], false);
                Int16smallintArray1M.AssertModel(models[6],_testData[17], false);
                Int16smallintArray1M.AssertModel(models[7],_testData[18], false);
                Int16smallintArray1M.AssertModel(models[8],_testData[19], false);
                Int16smallintArray1M.AssertModel(models[9],_testData[20], false);
                Int16smallintArray1M.AssertModel(models[10],_testData[21], false);
                Int16smallintArray1M.AssertModel(models[11],_testData[22], false);
                Int16smallintArray1M.AssertModel(models[12],_testData[23], false);
                Int16smallintArray1M.AssertModel(models[13],_testData[24], false);
                Int16smallintArray1M.AssertModel(models[14],_testData[25], false);
                Int16smallintArray1M.AssertModel(models[15],_testData[26], false);
                Int16smallintArray1M.AssertModel(models[16],_testData[27], false);
                Int16smallintArray1M.AssertModel(models[17],_testData[28], false);
                Int16smallintArray1M.AssertModel(models[18],_testData[29], false);
                Int16smallintArray1M.AssertModel(models[19],_testData[30], false);
                Int16smallintArray1M.AssertModel(models[20],_testData[31], false);
                Int16smallintArray1M.AssertModel(models[21],_testData[32], false);
                Int16smallintArray1M.AssertModel(models[22],_testData[33], false);
                Int16smallintArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_int16smallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int16smallintArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ArraysmallintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16ArraysmallintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ArraysmallintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16ArraysmallintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ArraysmallintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16ArraysmallintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ArraysmallintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16ArraysmallintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int16smallintArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16ArraysmallintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ArraysmallintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16ArraysmallintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt16ArraysmallintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ArraysmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ArraysmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ArraysmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16ArraysmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(Int16smallintArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt16ArraysmallintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt16ArraysmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt16ArraysmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt16ArraysmallintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA), typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models1 = new List<Int16smallintArray1MIWA>();
                var models2 = new List<Int16smallintArray1MIWA>();
                await ((IInt16ArraysmallintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray1MIWA>();
                var models2 = new List<Int16smallintArray1MIWA>();
                ((IInt16ArraysmallintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models = await ((IInt16ArraysmallintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintarray1mi
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
                    Int16smallintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ArraysmallintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int16smallintarray1mi
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
                    Int16smallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA), typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
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
                var models1 = new List<Int16smallintArray1MIWA>();
                var models2 = new List<Int16smallintArray1MIWA>();
                await ((IInt16ArraysmallintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray1MIWA>();
                var models2 = new List<Int16smallintArray1MIWA>();
                ((IInt16ArraysmallintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
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
                var models = await ((IInt16ArraysmallintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintarray1mi
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
                    Int16smallintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ArraysmallintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int16smallintarray1mi
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
                    Int16smallintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MI), typeof(Int16smallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models1 = new List<Int16smallintArray1MI>();
                var models2 = new List<Int16smallintArray1MI>();
                await ((IInt16ArraysmallintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray1MI>();
                var models2 = new List<Int16smallintArray1MI>();
                ((IInt16ArraysmallintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray)),
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
                var models = await ((IInt16ArraysmallintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ArraysmallintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA), typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
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
                var models1 = new List<Int16smallintArray1MIWA>();
                var models2 = new List<Int16smallintArray1MIWA>();
                await ((IInt16ArraysmallintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray1MIWA>();
                var models2 = new List<Int16smallintArray1MIWA>();
                ((IInt16ArraysmallintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArraysmallintArray))]
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
                var models = await ((IInt16ArraysmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ArraysmallintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


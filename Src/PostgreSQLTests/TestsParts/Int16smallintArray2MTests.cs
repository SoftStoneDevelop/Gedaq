

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
    internal partial interface IInt16ListsmallintArray
    {
    }
    
    internal partial class Int16ListsmallintArray : IInt16ListsmallintArray
    {


#region TestData

        private readonly Int16smallintArray2M[] _testData = new Int16smallintArray2M[]
        {
            new Int16smallintArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
22724,

16068,

13094,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
24521,

14674,

14475,

23287,

},
},
            new Int16smallintArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17243,

12277,

7853,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
345,

23313,

1550,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
10178,

12393,

6658,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
27909,

25040,

10529,

27352,

},
},
            new Int16smallintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
26234,

27949,

30402,

22174,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
11730,

25346,

6191,

2696,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
2570,

177,

12901,

16693,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
27240,

18326,

30476,

20568,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
11347,

28535,

7569,

15159,

},
},
            new Int16smallintArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
23342,

4697,

18764,

28998,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
16097,

19287,

20739,

},
},
            new Int16smallintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
7206,

2780,

20031,

11022,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
12602,

23753,

258,

23886,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
25023,

16039,

2386,

1579,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
1021,

12131,

22984,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
20830,

4934,

19733,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
6112,

29643,

1637,

6366,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
20774,

21180,

17385,

17682,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
1080,

13215,

28944,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
3642,

18701,

3641,

10449,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31968,

18775,

27717,

16307,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
15923,

11323,

20842,

},
},
            new Int16smallintArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
30477,

18048,

10376,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
5434,

14648,

14802,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16048,

18368,

25241,

9200,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
28632,

29443,

31248,

21314,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24508,

6963,

20434,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
10694,

16115,

22643,

24052,

},
},
            new Int16smallintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17520,

10771,

11304,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22920,

12348,

15545,

16998,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
30955,

28202,

3939,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
3428,

24044,

17849,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9389,

5671,

21190,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
29319,

9872,

9218,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
29210,

27272,

17953,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
2893,

28929,

16376,

3561,

},
},
            new Int16smallintArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
13483,

10570,

5349,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
2398,

17268,

26634,

19488,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
6262,

7127,

18196,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
28292,

18570,

8115,

17800,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
2805,

24915,

24587,

171,

},
},
            new Int16smallintArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18810,

12718,

14084,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
27052,

29518,

18691,

},
},
            new Int16smallintArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
13717,

32268,

8891,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
31117,

19365,

12533,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
29474,

31560,

29005,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
20859,

28566,

6162,

307,

},
},
            new Int16smallintArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
31498,

20358,

20387,

7694,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
29978,

4182,

13276,

27174,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15727,

18710,

20301,

4911,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
28126,

5952,

19502,

22447,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
8767,

11800,

3947,

},
},
            new Int16smallintArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
26155,

27473,

13478,

32483,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18315,

13794,

30765,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
26601,

1796,

3029,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
22792,

889,

14246,

14124,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
32347,

12866,

26697,

},
},
            new Int16smallintArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
17904,

23045,

12928,

30515,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
10531,

20290,

30287,

},
},
            new Int16smallintArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
5109,

26038,

24892,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15668,

9192,

1203,

26113,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
15094,

9406,

22620,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
1533,

5223,

25065,

},
},
            new Int16smallintArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17953,

5417,

16236,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
5224,

781,

13313,

15548,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
17282,

28048,

26175,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
11616,

11610,

28622,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
12030,

28653,

28645,

2672,

},
},
            new Int16smallintArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
27008,

21045,

16030,

17484,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
12823,

6128,

15273,

5640,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
30021,

30728,

6107,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
12573,

11565,

15293,

936,

},
},
            new Int16smallintArray2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
4624,

28955,

22912,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
32542,

30604,

15129,

13538,

},
},
            new Int16smallintArray2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
13246,

23244,

37,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
13405,

30096,

23319,

8565,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 205,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
17973,

29687,

16515,

26935,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
18799,

21669,

22577,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray2mi(
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray2mi(
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
            queryMapTypes: [typeof(Int16smallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>), 
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

                changedRows =  ((IInt16ListsmallintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16ListsmallintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16ListsmallintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16ListsmallintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16ListsmallintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16ListsmallintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt16ListsmallintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray2m(
	id,
    value,
    nullablevalue,
    int16smallintarray2mi_id
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
            asPartInterface: typeof(IInt16ListsmallintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintarray2mi_id", 
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
                changedRows =  ((IInt16ListsmallintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16ListsmallintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16ListsmallintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16ListsmallintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray2m(
	id,
    value,
    nullablevalue,
    int16smallintarray2mi_id
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
    int16smallintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallintarray2m(
	id,
    value,
    nullablevalue,
    int16smallintarray2mi_id
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
    int16smallintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int16>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483630)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallintarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintArray2M> models = null;

                models =  ((IInt16ListsmallintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt16ListsmallintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt16ListsmallintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt16ListsmallintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintArray2M> models = null;

                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt16ListsmallintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray2M), typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                ((IInt16ListsmallintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt16ListsmallintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16ListsmallintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models = await ((IInt16ListsmallintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16ListsmallintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray2M), typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                ((IInt16ListsmallintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16ListsmallintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16ListsmallintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models = await ((IInt16ListsmallintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16ListsmallintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray2M), typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                await((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 189;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                 ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                 ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[26],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[27],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[28],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[1], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[26],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[27],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[28],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[29],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[30],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[31],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[32],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                 ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models = await((IInt16ListsmallintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int16smallintArray2M.AssertModel(models[0],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int16smallintArray2M.AssertModel(models[0],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IInt16ListsmallintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int16smallintArray2M.AssertModel(models[0],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int16smallintArray2M.AssertModel(models[0],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray2M), typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                await((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 147, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintArray2M>();
                var models2 = new List<FlatInt16smallintArray2M>();
                ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                 ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 13, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var firstItems2 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                 ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 174, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[34], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 161, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[5], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[26],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[27],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[28],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.int16smallintarray2m m
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
FROM public.int16smallintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems1 = new List<FlatInt16smallintArray2M>();
                var secondItems2 = new List<FlatInt16smallintArray2M>();
                 ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.int16smallintarray2m m
LEFT JOIN public.int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models = await((IInt16ListsmallintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 110, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int16smallintArray2M.AssertModel(models[0],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int16smallintArray2M.AssertModel(models[0],_testData[10], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[23],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((IInt16ListsmallintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 162, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintArray2M.AssertModel(models[0],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int16smallintArray2M.AssertModel(models[0],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models = await ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Int16smallintArray2M.AssertModel(models[0],_testData[22], false);
                Int16smallintArray2M.AssertModel(models[1],_testData[23], false);
                Int16smallintArray2M.AssertModel(models[2],_testData[24], false);
                Int16smallintArray2M.AssertModel(models[3],_testData[25], false);
                Int16smallintArray2M.AssertModel(models[4],_testData[26], false);
                Int16smallintArray2M.AssertModel(models[5],_testData[27], false);
                Int16smallintArray2M.AssertModel(models[6],_testData[28], false);
                Int16smallintArray2M.AssertModel(models[7],_testData[29], false);
                Int16smallintArray2M.AssertModel(models[8],_testData[30], false);
                Int16smallintArray2M.AssertModel(models[9],_testData[31], false);
                Int16smallintArray2M.AssertModel(models[10],_testData[32], false);
                Int16smallintArray2M.AssertModel(models[11],_testData[33], false);
                Int16smallintArray2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Int16smallintArray2M.AssertModel(models[0],_testData[10], false);
                Int16smallintArray2M.AssertModel(models[1],_testData[11], false);
                Int16smallintArray2M.AssertModel(models[2],_testData[12], false);
                Int16smallintArray2M.AssertModel(models[3],_testData[13], false);
                Int16smallintArray2M.AssertModel(models[4],_testData[14], false);
                Int16smallintArray2M.AssertModel(models[5],_testData[15], false);
                Int16smallintArray2M.AssertModel(models[6],_testData[16], false);
                Int16smallintArray2M.AssertModel(models[7],_testData[17], false);
                Int16smallintArray2M.AssertModel(models[8],_testData[18], false);
                Int16smallintArray2M.AssertModel(models[9],_testData[19], false);
                Int16smallintArray2M.AssertModel(models[10],_testData[20], false);
                Int16smallintArray2M.AssertModel(models[11],_testData[21], false);
                Int16smallintArray2M.AssertModel(models[12],_testData[22], false);
                Int16smallintArray2M.AssertModel(models[13],_testData[23], false);
                Int16smallintArray2M.AssertModel(models[14],_testData[24], false);
                Int16smallintArray2M.AssertModel(models[15],_testData[25], false);
                Int16smallintArray2M.AssertModel(models[16],_testData[26], false);
                Int16smallintArray2M.AssertModel(models[17],_testData[27], false);
                Int16smallintArray2M.AssertModel(models[18],_testData[28], false);
                Int16smallintArray2M.AssertModel(models[19],_testData[29], false);
                Int16smallintArray2M.AssertModel(models[20],_testData[30], false);
                Int16smallintArray2M.AssertModel(models[21],_testData[31], false);
                Int16smallintArray2M.AssertModel(models[22],_testData[32], false);
                Int16smallintArray2M.AssertModel(models[23],_testData[33], false);
                Int16smallintArray2M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_int16smallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int16smallintArray2MIWA),
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
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ListsmallintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16ListsmallintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ListsmallintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16ListsmallintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ListsmallintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16ListsmallintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ListsmallintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16ListsmallintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int16smallintArray2MI),
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
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16ListsmallintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16ListsmallintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt16ListsmallintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16ListsmallintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16ListsmallintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16ListsmallintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int16smallintArray2M),
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
            asPartInterface: typeof(IInt16ListsmallintArray))]
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
FROM public.binary_int16smallintarray2m m
LEFT JOIN public.binary_int16smallintarray2mi mi ON mi.id = m.int16smallintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt16ListsmallintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt16ListsmallintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt16ListsmallintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt16ListsmallintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models =  ((IInt16ListsmallintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16ListsmallintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA), typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models1 = new List<Int16smallintArray2MIWA>();
                var models2 = new List<Int16smallintArray2MIWA>();
                await ((IInt16ListsmallintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray2MIWA>();
                var models2 = new List<Int16smallintArray2MIWA>();
                ((IInt16ListsmallintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models = await ((IInt16ListsmallintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintarray2mi
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
                    Int16smallintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int16smallintarray2mi
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
                    Int16smallintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA), typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
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
                var models1 = new List<Int16smallintArray2MIWA>();
                var models2 = new List<Int16smallintArray2MIWA>();
                await ((IInt16ListsmallintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray2MIWA>();
                var models2 = new List<Int16smallintArray2MIWA>();
                ((IInt16ListsmallintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
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
                var models = await ((IInt16ListsmallintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int16smallintarray2mi
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
                    Int16smallintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int16smallintarray2mi
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
                    Int16smallintArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MI), typeof(Int16smallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models1 = new List<Int16smallintArray2MI>();
                var models2 = new List<Int16smallintArray2MI>();
                await ((IInt16ListsmallintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray2MI>();
                var models2 = new List<Int16smallintArray2MI>();
                ((IInt16ListsmallintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray)),
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
                var models = await ((IInt16ListsmallintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA), typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
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
                var models1 = new List<Int16smallintArray2MIWA>();
                var models2 = new List<Int16smallintArray2MIWA>();
                await ((IInt16ListsmallintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintArray2MIWA>();
                var models2 = new List<Int16smallintArray2MIWA>();
                ((IInt16ListsmallintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ListsmallintArray))]
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
                var models = await ((IInt16ListsmallintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16ListsmallintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


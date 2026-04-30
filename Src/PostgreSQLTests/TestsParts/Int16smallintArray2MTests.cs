

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
25065,

22088,

17713,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
26791,

27199,

13411,

},
},
            new Int16smallintArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
18742,

2919,

22142,

28436,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
26471,

1658,

23636,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
1439,

11394,

423,

5963,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
7919,

27874,

24882,

},
},
            new Int16smallintArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
521,

31618,

24555,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
30066,

19629,

26669,

7398,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
19205,

18810,

30725,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
30837,

9319,

12551,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
29963,

26401,

16436,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
13825,

32621,

15963,

19009,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
16713,

21745,

12643,

20187,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
15187,

12543,

6860,

3596,

},
},
            new Int16smallintArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
28281,

10157,

6845,

6951,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
12492,

7585,

17176,

30176,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
14895,

1445,

11200,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
30194,

11895,

4367,

},
},
            new Int16smallintArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
22219,

30134,

18477,

28623,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
1690,

2157,

1427,

},
},
            new Int16smallintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
5224,

22986,

3497,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
16039,

17213,

8891,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
13503,

10548,

20382,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
27215,

15100,

26165,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
399,

27665,

27269,

11416,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
9057,

2180,

4624,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
4811,

787,

27730,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
11881,

32519,

18882,

3577,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
11768,

25584,

6965,

13701,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
5027,

26112,

14647,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
20551,

11684,

11689,

25515,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
29293,

28310,

28291,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
25601,

9306,

9039,

31014,

},
},
            new Int16smallintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
20189,

31241,

10743,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
15395,

4498,

5273,

31653,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
5137,

20751,

20963,

4350,

},
},
            new Int16smallintArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18040,

18739,

13485,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
28783,

23708,

7167,

1379,

},
},
            new Int16smallintArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9329,

25280,

29339,

8038,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
27144,

12067,

18327,

25769,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
15877,

30026,

6529,

29803,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
30721,

2552,

27538,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
24660,

5831,

9335,

9456,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
25698,

10519,

7957,

8730,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
8858,

1998,

16627,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
12774,

3533,

11421,

},
},
            new Int16smallintArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
19598,

18224,

31903,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
272,

28461,

27474,

},
},
            new Int16smallintArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
3666,

5629,

29435,

12060,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
10114,

5602,

15056,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
12265,

21842,

7729,

12431,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
9735,

14294,

11070,

},
},
            new Int16smallintArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
14694,

15540,

7166,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
26385,

11984,

29281,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2737,

11390,

15343,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
5717,

27434,

24189,

},
},
            new Int16smallintArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
13870,

11,

16118,

37,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
11968,

6067,

24519,

24433,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
15796,

14229,

31559,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
4737,

11374,

5867,

18032,

},
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
24299,

25986,

20334,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
886,

7767,

29905,

32257,

},
},
            new Int16smallintArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
27259,

16986,

17565,

11749,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9806,

3159,

7136,

8196,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
19921,

22160,

22577,

19078,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
4457,

18597,

28817,

29882,

},
},
            new Int16smallintArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
2199,

3880,

16799,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
9734,

26211,

20611,

23115,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
23984,

11768,

2138,

12597,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
30967,

13271,

23995,

2946,

},
},
            new Int16smallintArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
7028,

6634,

3516,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(4)
{
29881,

25046,

853,

16043,

},
},
            new Int16smallintArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
29851,

26012,

26320,

11105,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
25397,

510,

10839,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
22576,

3736,

7102,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
18613,

469,

7231,

},
    ModelInner = new Int16smallintArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int16>(3)
{
31635,

3756,

8486,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int16>(3)
{
20222,

7922,

17,

},
},
            new Int16smallintArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Int16>(4)
{
19298,

3256,

7625,

19788,

},
    ModelInner = null,
    NullableValue = null,
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[6], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[26],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[27],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintArray2M.AssertModel(models[0],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int16smallintArray2M.AssertModel(models[0],_testData[4], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[5], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[6], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[7], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[8], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[9], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[10], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[23],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[24],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[25],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[26],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[27],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[28],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[29],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintArray2M.AssertModel(models[0],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IInt16ListsmallintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((IInt16ListsmallintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 116, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[34], false);
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
                await ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 92, query1, 177, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[9], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[10], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[11], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[12], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[13], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[14], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[15], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[18],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[19],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[20],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[21],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[22],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[23],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[24],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt16smallintArray2M.AssertModel(models[0],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(models[1],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(models[2],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(models[3],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(models[4],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(models[5],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(models[6],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(models[7],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(models[8],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(models[9],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(models[10],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(models[11],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(models[12],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(models[13],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(models[14],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(models[15],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(models[16],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(models[17],_testData[34], false);
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
                 ((IInt16ListsmallintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt16smallintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt16smallintArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in await ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 142, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int16smallintArray2M.AssertModel(models[0],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int16smallintArray2M.AssertModel(models[0],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[34], false);
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
                foreach(var batchResult in  ((IInt16ListsmallintArray)this).DbConnectionSTSelectModelBatch(connection, 4, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int16smallintArray2M.AssertModel(models[0],_testData[1], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[2], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[3], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[4], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[5], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[6], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[7], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[8], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[9], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[10], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[23],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[24],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[25],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[26],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[27],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[28],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[29],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[30],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[31],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[32],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int16smallintArray2M.AssertModel(models[0],_testData[2], false);
                        Int16smallintArray2M.AssertModel(models[1],_testData[3], false);
                        Int16smallintArray2M.AssertModel(models[2],_testData[4], false);
                        Int16smallintArray2M.AssertModel(models[3],_testData[5], false);
                        Int16smallintArray2M.AssertModel(models[4],_testData[6], false);
                        Int16smallintArray2M.AssertModel(models[5],_testData[7], false);
                        Int16smallintArray2M.AssertModel(models[6],_testData[8], false);
                        Int16smallintArray2M.AssertModel(models[7],_testData[9], false);
                        Int16smallintArray2M.AssertModel(models[8],_testData[10], false);
                        Int16smallintArray2M.AssertModel(models[9],_testData[11], false);
                        Int16smallintArray2M.AssertModel(models[10],_testData[12], false);
                        Int16smallintArray2M.AssertModel(models[11],_testData[13], false);
                        Int16smallintArray2M.AssertModel(models[12],_testData[14], false);
                        Int16smallintArray2M.AssertModel(models[13],_testData[15], false);
                        Int16smallintArray2M.AssertModel(models[14],_testData[16], false);
                        Int16smallintArray2M.AssertModel(models[15],_testData[17], false);
                        Int16smallintArray2M.AssertModel(models[16],_testData[18], false);
                        Int16smallintArray2M.AssertModel(models[17],_testData[19], false);
                        Int16smallintArray2M.AssertModel(models[18],_testData[20], false);
                        Int16smallintArray2M.AssertModel(models[19],_testData[21], false);
                        Int16smallintArray2M.AssertModel(models[20],_testData[22], false);
                        Int16smallintArray2M.AssertModel(models[21],_testData[23], false);
                        Int16smallintArray2M.AssertModel(models[22],_testData[24], false);
                        Int16smallintArray2M.AssertModel(models[23],_testData[25], false);
                        Int16smallintArray2M.AssertModel(models[24],_testData[26], false);
                        Int16smallintArray2M.AssertModel(models[25],_testData[27], false);
                        Int16smallintArray2M.AssertModel(models[26],_testData[28], false);
                        Int16smallintArray2M.AssertModel(models[27],_testData[29], false);
                        Int16smallintArray2M.AssertModel(models[28],_testData[30], false);
                        Int16smallintArray2M.AssertModel(models[29],_testData[31], false);
                        Int16smallintArray2M.AssertModel(models[30],_testData[32], false);
                        Int16smallintArray2M.AssertModel(models[31],_testData[33], false);
                        Int16smallintArray2M.AssertModel(models[32],_testData[34], false);
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
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Int16smallintArray2M.AssertModel(models[0],_testData[18], false);Int16smallintArray2M.AssertModel(models[1],_testData[19], false);Int16smallintArray2M.AssertModel(models[2],_testData[20], false);Int16smallintArray2M.AssertModel(models[3],_testData[21], false);Int16smallintArray2M.AssertModel(models[4],_testData[22], false);Int16smallintArray2M.AssertModel(models[5],_testData[23], false);Int16smallintArray2M.AssertModel(models[6],_testData[24], false);Int16smallintArray2M.AssertModel(models[7],_testData[25], false);Int16smallintArray2M.AssertModel(models[8],_testData[26], false);Int16smallintArray2M.AssertModel(models[9],_testData[27], false);Int16smallintArray2M.AssertModel(models[10],_testData[28], false);Int16smallintArray2M.AssertModel(models[11],_testData[29], false);Int16smallintArray2M.AssertModel(models[12],_testData[30], false);Int16smallintArray2M.AssertModel(models[13],_testData[31], false);Int16smallintArray2M.AssertModel(models[14],_testData[32], false);Int16smallintArray2M.AssertModel(models[15],_testData[33], false);Int16smallintArray2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16ListsmallintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16ListsmallintArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((IInt16ListsmallintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
Int16smallintArray2M.AssertModel(models[0],_testData[24], false);Int16smallintArray2M.AssertModel(models[1],_testData[25], false);Int16smallintArray2M.AssertModel(models[2],_testData[26], false);Int16smallintArray2M.AssertModel(models[3],_testData[27], false);Int16smallintArray2M.AssertModel(models[4],_testData[28], false);Int16smallintArray2M.AssertModel(models[5],_testData[29], false);Int16smallintArray2M.AssertModel(models[6],_testData[30], false);Int16smallintArray2M.AssertModel(models[7],_testData[31], false);Int16smallintArray2M.AssertModel(models[8],_testData[32], false);Int16smallintArray2M.AssertModel(models[9],_testData[33], false);Int16smallintArray2M.AssertModel(models[10],_testData[34], false);
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

